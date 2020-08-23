using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO.Ports;
using nsAlienRFID2;
using System.IO;
//using xc = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Security;
using System.Security.Cryptography;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;


//------------------------------------------------------------------------------------------------
// MG1 / SG2
// MG in - 현장내 / SG in - 101동
// PK  활용 방안 협의
// 전체 현황 page
//------------------------------------------------------------------------------------------------    
namespace CommuteManager_V6
{
    public partial class CommuteManager : Form
    {
        public int ni, nf, Cnt_reader = 0, ServerContainerCnt = 0;
        public List<clsReader> RFID_Reader;
        public List<Panel> pnllist = new List<Panel>();
        public List<Label> lbllist = new List<Label>();
        public List<PictureBox> piclist1 = new List<PictureBox>();
        public List<PictureBox> piclist2 = new List<PictureBox>();
        public List<PictureBox> piclist3 = new List<PictureBox>();
        public List<PictureBox> piclist4 = new List<PictureBox>();
        public List<PictureBox> piclist5 = new List<PictureBox>();
        public List<List<PictureBox>> picList = new List<List<PictureBox>>();
        public List<CAlienServer> RFID_Server;
        public static bool Server_Setting = false, AdminFlag = false;
        private bool[] active = new bool[5];
        public string ServerIP;
        public List<int> ServerPort = new List<int>();
        private delegate void showMsg();
        private Protocol_data Protocol;
        public Taglist_Manager TagList;
        private bool Server_toggle = false;
        private bool sw_timer = false;
        public string Mode = "Stop", Gate1, Gate2;
        public string startPath = Application.StartupPath;//Directory path of starting this.
        /*xc.Application xcApp = null;
        xc.Workbook wb = null;
        xc.Worksheet ws = null;*/
        private int sortColumn = -1;
        public bool ExcelAdd = false;
        bool isLogin = false;
        public bool isAddPeople = false;
        //서버 업로드 부분
        SQLServer server = new SQLServer();
        public int LogIndex = 0;
        public int PersonIndex = 0;
        public int SupIndex = 0;
        public int index = 0;
        public List<int> indexes = new List<int>();
        public List<string> listJob = new List<string>();
        public List<string> listCompany = new List<string>();
        public ComInterface mReaderInterface = ComInterface.enumTCPIP;
        private int _count = 0;
        public int telnet = 24;
        public bool a = false;
        public TreeNode tree = new TreeNode();
        //public Trees trs = new Trees();
        //public MobileServiceClient Client = new MobileServiceClient("https://commutemanager.azurewebsites.net");
        //IMobileServiceTable<Log> LogTable;
        public static List<Trees> listtrs = new List<Trees>();
        public Log log;
        //AzureMobileService AMS = new AzureMobileService();
        public CommuteManager()
        {
            InitializeComponent();
            InitializedModule();
            InitializeListView();
            //LoadPeople();

            LoadPeopleExcel();
            ServerIP = null;
            ServerPort = null;
            UserSetup(); //Setting DataProcess

            disableBtn();
            btnSupervisor.Visible = false;
            label12.Visible = false;
            lblStatus.Text = "로그인이 필요합니다.";

            loadSupervisor();

            string strqry = "SELECT COUNT(*) FROM PersonalData";
            server.GetDBTable(strqry);
            server.sdr.Read();
            PersonIndex = server.sdr.GetInt32(0);
            server.sdr.Close();
            strqry = "SELECT COUNT(*) FROM Logs";
            server.GetDBTable(strqry);
            server.sdr.Read();
            LogIndex = server.sdr.GetInt32(0);
            server.sdr.Close();

            foreach (supervisor sv in listSuper)
            {
                ListViewItem item = new ListViewItem(sv.id);
                item.SubItems.Add(sv.pw);
                item.SubItems.Add(sv.au);
                lvSup.Items.Add(item);
            }
            //LogTable = Client.GetTable<Log>();
        }

        private void tsComboxInout_TextChanged_1(object sender, EventArgs e)
        {
            saveLog();

            while (listView_Main.Items.Count > 1)
            {
                listView_Main.Items.RemoveAt(10);
            }

            switch (tsComboxInout.Text)
            {
                case ("출입 현황"):
                    break;
                case ("전체 현황"):
                    Detail d1 = new Detail("전체 현황", ni);
                    d1.Show();
                    break;
                case ("공종별 현황"):
                    Detail d2 = new Detail("공종별 현황", ni);
                    d2.Show();
                    break;
            }
        }

        #region Initialize
        private void InitializedModule()
        {
            RFID_Reader = new List<clsReader>();
            RFID_Server = new List<CAlienServer>();
            Protocol = new Protocol_data();
            TagList = new Taglist_Manager();
            lbllist.Add(lblGate1); lbllist.Add(lblGate2); lbllist.Add(lblGate3); lbllist.Add(lblGate4); lbllist.Add(lblGate5);
            pnllist.Add(panel4); pnllist.Add(panel5); pnllist.Add(panel6); pnllist.Add(panel7); pnllist.Add(panel8);
            piclist1.Add(Led1_1); piclist1.Add(Led1_2); //piclist1.Add(Led1_3); piclist1.Add(Led1_4);
            piclist2.Add(Led2_1); piclist2.Add(Led2_2); //piclist2.Add(Led2_3); piclist2.Add(Led2_4);
            piclist3.Add(Led3_1); piclist3.Add(Led3_2); //piclist3.Add(Led3_3); piclist3.Add(Led3_4);
            piclist4.Add(Led4_1); piclist4.Add(Led4_2); //piclist4.Add(Led4_3); piclist4.Add(Led4_4);
            piclist5.Add(Led5_1); piclist5.Add(Led5_2); //piclist5.Add(Led5_3); piclist5.Add(Led5_4);
            picList.Add(piclist1); picList.Add(piclist2); //picList.Add(piclist3); picList.Add(piclist4); 
            picList.Add(piclist5);
        }

        private void InitializeListView()
        {//Initialize ListView control.
         //Set double buffer for ListView controls to prevent blinking problem...
            listView_Main.DoubleBuffered(true);
            listView_People.DoubleBuffered(true);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect_Setting Gate_Connect = new Connect_Setting(serialPort_RFID, RFID_Reader);
            Gate_Connect.Show();

            if (RFID_Reader[0].IsConnected)
                btnConnect.Image = Properties.Resources.Image_Select;

            if (Server_Setting)
                btnConnect.Image = Properties.Resources.Image_Select;
        }

        #region Server_data
        string removePrefix(string msg) // 데이터 가공
        {
            if (msg == null)
            {
                return null;
            }
            int idx = msg.IndexOf(" ");
            if ((idx == -1) || (idx == msg.Length))
                return msg;
            else
                return msg.Substring(idx + 1);
        }

        void mServer_ServerMessageReceived(string msg)
        {
            if (msg == null)
            {
                return;
            }
            lock (this)
            {
                showMsg method = delegate
                {
                    string s = removePrefix(msg);
                    Protocol.AddBuffer(s);//Receive tag data.
                    while (Protocol.CheckBlock())
                    {//if there is data block in buffer...
                        Protocol.ProcessBlock();//Translate first block in buffer and remove it.

                        if (Protocol.HasProtocol("No Tags") == false)
                        {//If there is tag data income...
                         //Get each seperated data.
                            string _ID = Protocol.GetString("EPC");
                            string _Ant = Protocol.GetString("Ant");
                            double _RSSI = Protocol.GetDouble("RSSI");
                            string _GATE = Protocol.GetString("GATE");

                            //Update TagList with new tag data.
                            if (_ID != "") TagList.Update(_ID, _Ant, _RSSI, _GATE);
                        }
                    }
                };
                //TagList.RemoveOld(10);
                TagList.RemoveOld(1);
                try
                {
                    this.BeginInvoke(method);
                }
                catch
                {

                }

            }
        }

        private void UserSetup()
        {//Function which will run once on starting.
         //Initialize protocol manager class.
            Protocol.Protocol();
            Protocol.Design("(", ")", ",", "=");
            Protocol.AddString("EPC");
            Protocol.AddString("Ant");
            Protocol.AddDouble("RSSI");
            Protocol.AddString("GATE");
        }
        #endregion

        private void toolStripButton_ServerStart_Click(object sender, EventArgs e)
        {
            int _count = Connect_Setting.Count;
            if (!Server_toggle)
            {
                List<int> ConServerPort = new List<int>();

                // 단순히 포트 1개씩 추가
                for (int i = 0; i < _count; i++)
                {
                    ConServerPort[i] = Connect_Setting.ServerPort[i];
                }
                string ConServerIP = Connect_Setting.ServerIP;//192.168.1.130 고정

                if (ConServerIP == null || ConServerPort == null)
                    MessageBox.Show("Server 설정이 잘못되었습니다.", "알림");

                if (ConServerIP != null && ConServerPort != null)
                {
                    toolStripButton_ServerStart.Image = Properties.Resources.Image_Select;
                    for (int i = 0; i < _count; i++)
                    {
                        if ((RFID_Server != null) && (RFID_Server[i].IsListening))
                        {
                            this.Cursor = Cursors.WaitCursor;

                            RFID_Server[i].StopListening();
                            RFID_Server[i].ServerMessageReceived -= new CAlienServer.ServerMessageReceivedEventHandler(mServer_ServerMessageReceived);
                            System.Threading.Thread.Sleep(10);
                            return;
                        }
                        lblStatus.Text = "Start Listening";
                        RFID_Server[i] = new CAlienServer(ConServerPort[i], ConServerIP, true);
                        RFID_Server[i].ServerMessageReceived += new CAlienServer.ServerMessageReceivedEventHandler(mServer_ServerMessageReceived);

                    }
                    try
                    {
                        for (int i = 0; i < _count; i++)
                        {
                            RFID_Server[i].StopListening();
                            RFID_Server[i].StartListening();
                        }
                        lblStatus.Text = "Stop Listening";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                for (int i = 0; i < _count; i++)
                {
                    if ((RFID_Server[i] != null) && (RFID_Server[i].IsListening))
                    {
                        try
                        {
                            RFID_Server[i].StopListening();
                            toolStripButton_ServerStart.Image = Properties.Resources.Image_Close;
                        }
                        catch
                        {

                        }
                    }
                }
            }
            Server_toggle = !Server_toggle;
        }

        private void toolStripButton_TagMonitor_Click(object sender, EventArgs e)
        {
            TagMonitor Tag_Monitor = new TagMonitor(TagList);
            Tag_Monitor.Show();
        }
        #region listview_manage

        private void CommuteIn(ListViewItem _Person, Taglist_Manager.List_Tag _Tag)
        {
            _Person.ImageIndex = 0;//change icon.
            string inout = "";
            string gateSt = "";
            string loca = "";
            //listGate[0]
            //split -> MG/ SG/ SSG 판별, MG 조건문에만 person.subitem의 상태 (출퇴근)
            //나머지에는 모두 위치 넣기. 상태는 MG 조건문에만 있으면됨./
            //판별한대로 따로 로직..1-1-1

            foreach (Detail.Gate lg in listGate)
            {
                if (_Tag.GATE == lg.main)
                {
                    gateSt = lg.main;
                    string[] GateSplit = lg.main.Split('-');
                    switch (GateSplit.Length)
                    {
                        case 1: //1
                                //_Person.SubItems[0].Text = "출근";
                            if (_Tag.GATE == lg.main)
                            {
                                _Person.SubItems[0].Text = "출근";
                                loca = "현장내";
                                //   _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Text;
                                inout = "입";
                            }
                            break;
                        case 2: //1-1
                            if (_Tag.GATE == lg.main)
                            {
                                loca = lg.main;
                                _Person.SubItems[0].Text = "출근";
                                //      _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Nodes[GateSplit[1]].Text;
                                inout = "입";
                            }
                            break;
                        case 3: //1-1-1
                            if (_Tag.GATE == lg.main)
                            {
                                loca = lg.main;
                                _Person.SubItems[0].Text = "출근";
                                //    _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Nodes[GateSplit[1]].Nodes[GateSplit[2]].Text;
                                inout = "입";
                            }
                            break;
                    }
                }
            }

            //Add a new Item to ListView_Main, by information of _Person.
            //            int _cnt = listView_Main.Items.Count + 1;
            ListViewItem _Item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss"));
            //번호

            _Item.SubItems.Add(inout);
            _Item.SubItems.Add(_Person.SubItems[1].Text);
            _Item.SubItems.Add(_Person.SubItems[2].Text);
            _Item.SubItems.Add(gateSt);
            _Item.SubItems.Add(_Person.SubItems[3].Text);
            _Item.SubItems.Add(loca);
            _Item.SubItems.Add(_Person.SubItems[4].Text);
            listView_Main.Items.Add(_Item);
            listView_Main.Items[listView_Main.Items.Count - 1].EnsureVisible();

            log = new Log();
            log.Id = Guid.NewGuid().ToString();
            log.dates = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
            log.inout = "입";
            log.names = _Item.SubItems[2].Text;
            log.tag = _Item.SubItems[3].Text;
            log.gates = _Tag.GATE;
            log.works = _Item.SubItems[5].Text;
            log.location = _Item.SubItems[6].Text;
            log.row = LogIndex;
            string strqry = $"INSERT INTO Logs (Id, dates,inout,names,tags,gates,works,location,row,Deleted) VALUES" +
            $"('{log.Id}','{log.dates}','{log.inout}',' {log.names} ','{log.tag} ','{log.gates}','{log.works}','{log.location}','{log.row}','0')";
            //await LogTable.InsertAsync(log);
            server.SQLUpload(strqry);
        }

        private void CommuteOut(ListViewItem _Person, Taglist_Manager.List_Tag _Tag)
        {//Commute assignment process - "Out"
         //Set ListView_People Item to attendance.
            _Person.ImageIndex = 1;//change icon.
            string inout = "";
            string gateSt = "";
            string loca = "";
            foreach (Detail.Gate lg in listGate)
            {
                if (_Tag.GATE == lg.main)
                {
                    gateSt = lg.main;
                    string[] GateSplit = lg.main.Split('-');
                    switch (GateSplit.Length)
                    {
                        case 1: //1
                                //_Person.SubItems[0].Text = "출근";
                            if (_Tag.GATE == lg.main)
                            {
                                _Person.SubItems[0].Text = "퇴근";
                                loca = "현장외";
                                //   _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Text;
                                inout = "출";
                            }
                            break;
                        case 2: //1-1
                            if (_Tag.GATE == lg.main)
                            {
                                //   _Person.SubItems[0].Text = "출근";
                                //      _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Nodes[GateSplit[1]].Text;
                                loca = "현장내";
                                inout = "출";
                            }
                            break;
                        case 3: //1-1-1
                            if (_Tag.GATE == lg.main)
                            {
                                //     _Person.SubItems[0].Text = "출근";
                                //    _Person.SubItems[0].Text = tree.Nodes[GateSplit[0]].Nodes[GateSplit[1]].Nodes[GateSplit[2]].Text;
                                inout = "출";
                                loca = lg.main.Substring(0, 3);
                            }
                            break;
                    }
                }
            }
            //if (_Tag.GATE == "1") Gate1=_Person.SubItems[0].Text = "퇴근";//chage status text.
            //else if (_Tag.GATE == "1-1") Gate2=_Person.SubItems[0].Text = "현장내";//chage status text.



            //Add a new Item to ListView_Main, by information of _Person.
            // int _cnt = listView_Main.Items.Count + 1;
            ListViewItem _Item = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss"));
            _Item.SubItems.Add(inout); //commute
            _Item.SubItems.Add(_Person.SubItems[1].Text); //name
            _Item.SubItems.Add(_Person.SubItems[2].Text); //EPC ID
            _Item.SubItems.Add(_Tag.GATE);
            _Item.SubItems.Add(_Person.SubItems[3].Text);
            _Item.SubItems.Add(loca);//위치
            _Item.SubItems.Add(_Person.SubItems[4].Text);
            listView_Main.Items.Add(_Item);
            listView_Main.Items[listView_Main.Items.Count - 1].EnsureVisible();

            log = new Log();
            log.Id = Guid.NewGuid().ToString();
            log.dates = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
            log.inout = "출";
            log.names = _Item.SubItems[2].Text;
            log.tag = _Item.SubItems[3].Text;
            log.gates = _Tag.GATE;
            log.works = _Item.SubItems[5].Text;
            log.location = _Item.SubItems[6].Text;
            log.row = LogIndex;
            //await LogTable.InsertAsync(log);
            string strqry = $"INSERT INTO Logs (Id, dates,inout,names,tags,gates,works,location,row,Deleted) VALUES" +
            $"('{log.Id}','{log.dates}','{log.inout}',' {log.names} ','{log.tag} ','{log.gates}','{log.works}','{log.location}','{log.row}','0')";
            //"INSERT INTO PLAYER (PLAYER_ID, PLAYER_NAME, TEAM_ID, POSITION, HEIGHT, WEIGHT, BACK_NO) VALUES('2002007', ' 박지성', 'K07', 'MF', 178, 73, 7)";
            server.SQLUpload(strqry);
        }
        #endregion

        private void toolStripButton_MainRefresh_Click(object sender, EventArgs e)
        {
            listView_Main.Items.Clear();
            lblStatus.Text = "출퇴근 이력이 초기화 되었습니다.";
        }

        private void toolStripButton_AddPeople_Click(object sender, EventArgs e)
        {
            /*People_manager _People = new People_manager(this);
            _People.ShowDialog();
            //LoadPeople();
            LoadPeopleExcel();
            _People.Dispose();*/
        }

        private void toolStripButton_DeletePeople_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection _selected = listView_People.SelectedItems;
            //Check data directory existence.
            string sDirPath;
            sDirPath = startPath + "\\PersonalData";
            DirectoryInfo di = new DirectoryInfo(sDirPath);
            if (di.Exists == false)
            {//if there is not, create new one.
                di.Create();
                return;//finish the process.
            }

            foreach (ListViewItem _item in _selected)
            {
                //construct target file name.
                string _name = _item.SubItems[1].Text;
                string _tagID = _item.SubItems[2].Text;
                string _fileName = sDirPath + "\\" + _name + "_" + _tagID + ".ini";

                //delete file.
                FileInfo _file = new FileInfo(_fileName);
                if (_file.Exists) _file.Delete();
            }
            LoadPeople();//refresh listview_people.
        }

        private void listView_People_DoubleClick(object sender, EventArgs e)
        {
            if (server.connection.State == ConnectionState.Closed) server.connection.Open();
            //SQLServer serverP = new SQLServer();
            string na, ta, bl, jo, co, pk, ph, em, ad, ye, insu, ed;
            ListView.SelectedListViewItemCollection _Selected = listView_People.SelectedItems;
            index = listView_People.SelectedIndices[0] + 1;
            string name = "";

            foreach (ListViewItem item in _Selected)
            {
                name = item.SubItems[1].Text;
            }

            string strqry = "SELECT * FROM PersonalData WHERE row='" + index + "' ORDER BY row";
            server.GetDBTable(strqry);
            server.sdr.Read();
            na = server.sdr.GetString(0);
            ta = server.sdr.GetString(1);
            bl = server.sdr.GetString(2);
            jo = server.sdr.GetString(3);
            co = server.sdr.GetString(4);
            pk = server.sdr.GetString(5);
            ph = server.sdr.GetString(6);
            em = server.sdr.GetString(7);
            ad = server.sdr.GetString(8);
            ye = server.sdr.GetString(9);
            insu = server.sdr.GetString(10);
            ed = server.sdr.GetString(11);

            server.sdr.Close();
            //index = listView_People.SelectedIndices[0] + 1;
            //MessageBox.Show(index.ToString());
            People_manager _People = new People_manager(na, ta, bl, jo, co, pk, ph, em, ad, ye, insu, ed, this);

            _People.ShowDialog();
        }

        #region method

        private FileInfo[] GetFileInfo(string _path, string _ext)
        {//Do test of directory existence and get file info of _ext(extentsion).
         //Directory existence test.
            DirectoryInfo _dir = new DirectoryInfo(_path);
            if (_dir.Exists)
            {//if directory is exists...
             //Do nothing.
            }
            else
            {//directory is not exists...
                _dir.Create();//create new one.
            }
            FileInfo[] _files = _dir.GetFiles(_ext);
            return _files;
        }

        public void AddPerson(People _Person)
        {//Add personal data to listview.
            ListViewItem _Item;//create a instance of listview item.

            //set icon by personal status.
            if (_Person.Status == true)
                _Item = new ListViewItem("재중", 0);

            else
                _Item = new ListViewItem("부재", 1);

            //Add personal data.
            _Item.SubItems.Add(_Person.Name);
            _Item.SubItems.Add(_Person.TagID);
            _Item.SubItems.Add(_Person.Job);
            _Item.SubItems.Add(_Person.Company);
            listView_People.Items.Add(_Item);
        }

        public void LoadPeopleExcel() // Test
        {
            if (isAddPeople)
            {
                server = new SQLServer();
                isAddPeople = false;
            }
            listView_People.Items.Clear();
            string strqry = "SELECT * FROM PersonalData ORDER BY row";
            server.GetDBTable(strqry);
            string paraName, paraTag, paraBlood, paraJob, paraComp, paraPK, paraPhone,
                    paraEmer, paraAddr, paraYear, paraInsu, paraEdu;

            while (server.sdr.Read())
            {
                paraName = server.sdr.GetString(0);
                paraTag = server.sdr.GetString(1);
                paraBlood = server.sdr.GetString(2);
                paraJob = server.sdr.GetString(3);
                paraComp = server.sdr.GetString(4);
                paraPK = server.sdr.GetString(5);
                paraPhone = server.sdr.GetString(6);
                paraEmer = server.sdr.GetString(7);
                paraAddr = server.sdr.GetString(8);
                paraYear = server.sdr.GetString(9);
                paraInsu = server.sdr.GetString(10);
                paraEdu = server.sdr.GetString(11);
                listJob.Add(paraJob);
                listCompany.Add(paraComp);
                listJob = listJob.Distinct().ToList();
                listCompany = listCompany.Distinct().ToList();
                //    paraPK = server.sdr.GetString(12);  //190410 SS-09 수정요망
                //People _Person = new People(paraName, paraTag, paraBlood, paraJob, paraComp,
                //    paraPernum, paraPhone, paraEmer, paraAddr, paraYear, paraInsu, paraEdu, paraPK);
                People _Person = new People(paraName, paraTag, paraBlood, paraJob, paraComp,
                    paraPK, paraPhone, paraEmer, paraAddr, paraYear, paraInsu, paraEdu);
                AddPerson(_Person);
            }
            server.sdr.Close();
            /*xcApp = new xc.Application();
            wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets["Personal Data"];

            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                            xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                            System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            for (int i = 2; i < nInLastRow + 1; i++)
            {
                paraName = ws.Cells[i, 1].Value;
                paraTag = Convert.ToString(ws.Cells[i, 2].Value);
                paraBlood = Convert.ToString(ws.Cells[i, 3].Value);
                paraJob = Convert.ToString(ws.Cells[i, 4].Value);
                paraComp = Convert.ToString(ws.Cells[i, 5].Value);
                paraPernum = Convert.ToString(ws.Cells[i, 6].Value);
                paraPhone = Convert.ToString(ws.Cells[i, 7].Value);
                paraEmer = Convert.ToString(ws.Cells[i, 8].Value);
                paraAddr = Convert.ToString(ws.Cells[i, 9].Value);
                paraYear = Convert.ToString(ws.Cells[i, 10].Value);
                paraInsu = Convert.ToString(ws.Cells[i, 11].Value);
                paraEdu = Convert.ToString(ws.Cells[i, 12].Value);
                People _Person = new People(paraName, paraTag, paraBlood, paraJob, paraComp,
                    paraPernum, paraPhone, paraEmer, paraAddr, paraYear, paraInsu, paraEdu);
                AddPerson(_Person);
            }
            wb.Save();
            wb.Close();
            if (xcApp != null) xcApp.Quit();*/
        }

        public void LoadPeople()
        {//Load personal data list on listview_people.
            listView_People.Items.Clear();//first, clear items on listview.
            string _dirpath = startPath + "\\PersonalData";//Set path of personal data folder.

            //load file information which directory contains.
            FileInfo[] _files = GetFileInfo(_dirpath, "*.ini");

            foreach (FileInfo _file in _files)
            {//for every ini file in directory...
                string _fullname = _file.FullName;//remember current file path.
                People _Person = new People(_file.FullName);//load personal data.
                AddPerson(_Person);//add personal data to listview.
            }
        }

        public People FindMatchData(string _ID)
        {//Find personal data file in data directory which has same EPC ID with _ID.
            string _dirpath = startPath + "\\PersonalData";
            FileInfo[] _files = GetFileInfo(_dirpath, "*.ini");

            foreach (FileInfo _file in _files)
            {//for every ini file in directory...
                string _name = _file.Name;//remember current file path.
                string[] SEP1 = _name.Split('_');//seperate filename by '_'.
                string _EPC = SEP1[1];//secondary text is EPC ID.

                if (_EPC == _ID + ".ini")
                {//if current file's EPC ID is same with _ID...
                    People _Person = new People(_file.FullName);//load personal data.
                    return _Person;//return personal data.
                }
            }
            return null;//If has no matched data, return null.
        }

        public void DeletePerson(string _ID)
        {//Delete personal data from directory by EPC ID.

            //Define directory and target file name.
            string sDirPath;
            sDirPath = startPath + "\\PersonalData";
            People _Person = FindMatchData(_ID);
            string _fileName = sDirPath + "\\" + _Person.Name + "_" + _Person.TagID + ".ini";

            //Delete target file if it is existing.
            FileInfo _file = new FileInfo(_fileName);
            if (_file.Exists) _file.Delete();
        }

        private ListViewItem FindList(string _ID)
        {//Find ListViewItem in ListView_People which has same EPC ID with _ID.
            foreach (ListViewItem _Item in listView_People.Items)
            {//Searching for every items in listview...
                if (_Item.SubItems[2].Text == _ID)
                {//if current item has _ID...
                    return _Item;//return current item.
                }
            }
            return null;//If there is no matched item, return null.
        }
        #endregion

        private void 활성화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = "Run";
            toolStripSplitBtn_Mode.Image = Properties.Resources.Image_ComeIn;
        }

        private void 대기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = "Stop";
            toolStripSplitBtn_Mode.Image = Properties.Resources.Image_ComeStop;
        }

        private void tsComboxInout_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_CommuteCheck_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("yyyy/MM/dd/HH:mm");            

            if (!sw_timer)
            {

                if (Mode == "Run")
                {
                    try
                    {
                        foreach (Taglist_Manager.List_Tag _Tag in TagList.TagList)
                        {
                            string strqry = "";
                            if (_Tag.Event != "")
                            {
                                ListViewItem _Item = FindList(_Tag.ID);

                                if (_Item != null)
                                {
                                    LogIndex++;
                                    if (_Tag.Event == "in")
                                    {
                                        CommuteIn(_Item, _Tag);
                                        /*strqry = "INSERT INTO Log VALUES('" + DateTime.Now.ToString("yyyy/MM/dd/HH:mm:ss") + "','"
                                            + "IN" + "','" + _Item.SubItems[1].Text + "','" + _Item.SubItems[2].Text + "','" + _Tag.GATE 
                                            + "','" + _Item.SubItems[3].Text + "','" + _Item.SubItems[0].Text + "'," + LogIndex + ")";*/
                                    }

                                    else if (_Tag.Event == "Out")
                                    {
                                        CommuteOut(_Item, _Tag);
                                        /*strqry = "INSERT INTO Log VALUES('" + DateTime.Now.ToString("yyyy/MM/dd/HH:mm:ss") + "','" 
                                            + "OUT" + "','" + _Item.SubItems[1].Text + "','" + _Item.SubItems[2].Text + "','" + _Tag.GATE 
                                            + "','" + _Item.SubItems[3].Text + "','" + _Item.SubItems[0].Text + "'," + LogIndex + ")";*/
                                    }
                                }
                                _Tag.Event = "";
                                server.SQLUpload(strqry);
                            }
                        }
                    }
                    catch
                    {

                    }

                }
                sw_timer = false;
            }
        }

        private void saveLog()
        {
            /*try
            {
                xcApp = new xc.Application();
                wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
                ws = wb.Worksheets.Item["Log"];

                int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                    xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                    System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                if (!isChecked) ni = nInLastRow + 1;

                foreach (ListViewItem item in listView_Main.Items)
                {
                    ws.Cells[nInLastRow + 1, 1] = item.SubItems[1].Text;
                    ws.Cells[nInLastRow + 1, 2] = item.SubItems[2].Text;
                    ws.Cells[nInLastRow + 1, 3] = item.SubItems[3].Text;
                    ws.Cells[nInLastRow + 1, 4] = item.SubItems[4].Text;
                    ws.Cells[nInLastRow + 1, 5] = item.SubItems[5].Text;
                    ws.Cells[nInLastRow + 1, 6] = item.SubItems[6].Text;
                    ws.Cells[nInLastRow + 1, 7] = item.SubItems[7].Text;
                    nInLastRow++;
                }

                wb.Save();
                wb.Close();
                xcApp.Quit();
                isChecked = true;
            }

            catch
            {
                MessageBox.Show("eob0x13");
                this.Close();
            }*/

        }
        private void CommuteManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            string strqry =
                "Update logs set row = a.row FROM(SELECT dates, names, location, inout, ROW_NUMBER() OVER(ORDER BY dates ASC) AS row FROM log) as a where log.dates = a.dates AND log.names = a.names AND log.inout = a.inout AND log.location = a.location";
            server.SQLUpload(strqry);
            //saveLog();
            saveSupervisor();
            server.SQLClose();
            if(Connect_Setting.rebootflag)this.Dispose();
        }

        private void listView_Main_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                listView_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                if (listView_Main.Sorting == System.Windows.Forms.SortOrder.Ascending) listView_Main.Sorting = System.Windows.Forms.SortOrder.Descending;
                else listView_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }

            listView_Main.Sort();
            this.listView_Main.ListViewItemSorter = new MyListViewComparer(e.Column, listView_Main.Sorting);
        }

        class MyListViewComparer : IComparer
        {
            private int col; private System.Windows.Forms.SortOrder order; public MyListViewComparer() { col = 0; order = System.Windows.Forms.SortOrder.Ascending; }
            public MyListViewComparer(int column, System.Windows.Forms.SortOrder order) { col = column; this.order = order; }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending. 
                if (order == System.Windows.Forms.SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1; return returnVal;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //암호화 개체 생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();


            // 개인키 생성
            RSAParameters privateKey = RSA.Create().ExportParameters(true);
            rsa.ImportParameters(privateKey);
            string privateKeyText = rsa.ToXmlString(true);


            // 공개키 생성            
            RSAParameters publicKey = new RSAParameters();
            publicKey.Modulus = privateKey.Modulus;
            publicKey.Exponent = privateKey.Exponent;
            rsa.ImportParameters(publicKey);
            string publicKeyText = rsa.ToXmlString(false);

            string pw = RSAEncrypt(txtPassword.Text, publicKeyText);
            //lblTest.Text = pw;
            string id = txtId.Text;


        }

        //RSA 암호화
        public string RSAEncrypt(string getValue, string pubKey)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa =
                new RSACryptoServiceProvider(); //암호화
            rsa.FromXmlString(pubKey);
            //암호화할 문자열을 UFT8인코딩
            byte[] inbuf = (new UTF8Encoding()).GetBytes(getValue);
            //암호화
            byte[] encbuf = rsa.Encrypt(inbuf, false);
            //암호화된 문자열 Base64인코딩
            return Convert.ToBase64String(encbuf);
        }

        //RSA 복호화
        public static string RSADecrypt(string getValue, string priKey)
        {
            //RSA객체생성
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); //복호화
            rsa.FromXmlString(priKey);
            //sValue문자열을 바이트배열로 변환
            byte[] srcbuf = Convert.FromBase64String(getValue);
            //바이트배열 복호화
            byte[] decbuf = rsa.Decrypt(srcbuf, false);
            //복호화 바이트배열을 문자열로 변환
            string sDec = (new UTF8Encoding()).GetString(decbuf, 0, decbuf.Length);
            return sDec;
        }



        private void btnSetting2_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConnect2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnConnect2, "연결");
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            List<string> IPAd = new List<string>();
            List<string> port = new List<string>();
            List<string> gate = new List<string>();
            List<string> Ant = new List<string>();
            List<string> Main = new List<string>();
            string strqry = "SELECT COUNT(*) FROM ServerContainer";
            server.GetDBTable(strqry);
            server.sdr.Read();
            ServerContainerCnt = server.sdr.GetInt32(0);
            server.sdr.Close();

            for (int i = 0; i < ServerContainerCnt; i++)
            {
                RFID_Reader.Add(new clsReader(true));
                RFID_Server.Add(new CAlienServer());
            };

            strqry = "SELECT * FROM ServerContainer ORDER BY main";
            server.GetDBTable(strqry);
            while (server.sdr.Read())
            {
                IPAd.Add(server.sdr.GetString(0));
                port.Add(server.sdr.GetString(1));
                gate.Add(server.sdr.GetString(2));
                Ant.Add(server.sdr.GetString(3));
                Main.Add(server.sdr.GetString(4));
            }
            server.sdr.Close();

            Connect_Setting Gate_Connect = new Connect_Setting(serialPort_RFID, RFID_Reader, ServerContainerCnt, IPAd, port, gate, Ant, Main);

            Gate_Connect.FormClosing += new FormClosingEventHandler(this.CommuteManager_FormClosing);
            Gate_Connect.Show();
            

            if (RFID_Reader[0].IsConnected)
                btnConnect2.BackgroundImage = Properties.Resources.icons8_wi_fi_connected_96;

            if (Server_Setting)
                btnConnect2.BackgroundImage = Properties.Resources.icons8_wi_fi_connected_96;





            //활성화 btn 내용 
            Mode = "Run";
            //toolStripSplitBtn_Mode.Image = Properties.Resources.Image_ComeIn;
            btn활성화.Enabled = false;
            btn대기.Enabled = true;
        }

        private void btn활성화_Click(object sender, EventArgs e)
        {
            Mode = "Run";
            //toolStripSplitBtn_Mode.Image = Properties.Resources.Image_ComeIn;
            btn활성화.Enabled = false;
            btn대기.Enabled = true;
        }

        private void btn활성화_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btn활성화, "활성화");
        }

        private void btn대기_Click(object sender, EventArgs e)
        {
            Mode = "Stop";
            btn대기.Enabled = false;
            btn활성화.Enabled = true;
        }

        private void btn대기_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btn대기, "대기");
        }

        private void btnTagMonitor_Click(object sender, EventArgs e)
        {
            TagMonitor Tag_Monitor = new TagMonitor(TagList);
            Tag_Monitor.Show();
        }

        private void btnTagMonitor_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnTagMonitor, "태그 모니터");
        }

        private void btnMainRefresh_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(this.btnMainRefresh, "로그 초기화");
        }

        /*private void btnMainRefresh_Click(object sender, EventArgs e)
        {
            listView_Main.Items.Clear();
            lblStatus.Text = "출퇴근 이력이 초기화 되었습니다.";
        }*/

        private void btnServerStart_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnServerStart, "서버 접속");
        }

        private void set1CommLamp(bool isOn)
        {
            Led1_1.Image = (isOn) ? Properties.Resources.LED_GREEN : Properties.Resources.LED_OFF;
        }

        private void set2CommLamp(bool isOn)
        {
            Led2_1.Image = (isOn) ? Properties.Resources.LED_GREEN : Properties.Resources.LED_OFF;
        }



        private async void btnServerStart_Click(object sender, EventArgs e)
        {
            _count = Connect_Setting.Count;

            if (!Server_toggle)
            {

                string strqry = "SELECT * FROM ServerContainer ORDER BY row";
                server.GetDBTable(strqry);
                string ssv, spt, sgt, sat, smain;

                while (server.sdr.Read())
                {
                    ssv = server.sdr.GetString(0);
                    spt = server.sdr.GetString(1);
                    sgt = server.sdr.GetString(2);
                    sat = server.sdr.GetString(3);
                    smain = server.sdr.GetString(4);
                    Detail.Gate gt = new Detail.Gate(ssv, spt, sgt, sat, smain);
                    listGate.Add(gt);
                }
                server.sdr.Close();

                tree.Nodes.Clear();

                List<Trees> trees = new List<Trees>();
                for (int i = 0; i < _count; i++)
                {
                    Trees trs = new Trees(listGate[i].main, listGate[i].gate);
                    trees.Add(trs);
                }

                var result = from n in trees orderby n.main select n;
                trees = result.ToList();

                for (int i = 0; i < _count; i++)
                {

                    string[] GateTree = trees[i].main.Split('-');
                    try
                    {
                        switch (GateTree.Length)
                        {
                            case 1: //1
                                tree.Nodes.Add(GateTree[0], trees[i].gate);
                                break;
                            case 2: //1-1
                                tree.Nodes[GateTree[0]].Nodes.Add(GateTree[1], trees[i].gate);
                                break;
                            case 3: //1-1-1
                                tree.Nodes[GateTree[0]].Nodes[GateTree[1]].Nodes.Add(GateTree[2], trees[i].gate);
                                break;
                        }
                    }
                    catch
                    {
                        tree.Nodes.Clear();
                        MessageBox.Show("잘못된 게이트설정");
                        break;
                    }

                    //tree.Nodes[GateTree[0]].Text;
                }
                //tree.ExpandAll();

                List<int> ConServerPort = new List<int>();

                // 단순히 포트 1개씩 추가
                for (int i = 0; i < _count; i++)
                {
                    ConServerPort.Add(Connect_Setting.ServerPort[i]);
                }
                string ConServerIP = Connect_Setting.ServerIP;//192.168.1.130 고정

                if (ConServerIP == null || ConServerPort == null)
                    MessageBox.Show("Server 설정이 잘못되었습니다.", "알림");

                if (ConServerIP != null && ConServerPort != null)
                {
                    btnServerStart.BackgroundImage = Properties.Resources._3;
                    for (int i = 0; i < _count; i++)
                    {
                        if ((RFID_Server != null) && (RFID_Server[i].IsListening))
                        {
                            this.Cursor = Cursors.WaitCursor;

                            RFID_Server[i].StopListening();
                            RFID_Server[i].ServerMessageReceived -= new CAlienServer.ServerMessageReceivedEventHandler(mServer_ServerMessageReceived);
                            System.Threading.Thread.Sleep(10);
                            return;
                        }
                        lblStatus.Text = "Start Listening";
                        RFID_Server[i] = new CAlienServer(ConServerPort[i], ConServerIP, true);
                        RFID_Server[i].ServerMessageReceived += new CAlienServer.ServerMessageReceivedEventHandler(mServer_ServerMessageReceived);

                    }
                    try
                    {
                        for (int i = 0; i < _count; i++)
                        {
                            RFID_Server[i].StopListening();
                            RFID_Server[i].StartListening();
                        }
                        lblStatus.Text = "Stop Listening";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                for (int k = 0; k < _count; k++)
                {
                    timer1.Enabled = true;
                    if (RFID_Reader[k].IsConnected)
                    {
                        pnllist[k].Visible = true;
                    }
                }

                if (RFID_Reader != null && Connect_Setting.ReaderPort != null)
                {
                    List<string> ConReaderPort = new List<string>();
                    for (int i = 0; i < _count; i++)
                    {

                        ConReaderPort.Add(listGate[i].server);
                    }

                    for (int i = 0; i < _count; i++)
                    {

                        LANConnect(RFID_Reader[i], ConReaderPort[i]);
                        if (RFID_Reader[i].IsConnected)
                        {
                            InitModule(RFID_Reader[i], listGate[i].main);
                            lbllist[i].Text = "GATE" + listGate[i].main;
                            //MessageBox.Show("LAN 통신 설정되었습니다.", "알림");
                            for (int k = 0; k < 4; k++) RFID_Reader[i].SetAntennaPower(k.ToString(), Convert.ToInt32(listGate[i].antenna));
                            //Cnt_reader++;
                        }
                        else
                        {
                            //MessageBox.Show("문제발생.", "알림");
                        }


                    }
                    Cnt_reader = 0;
                }
                else
                {
                    MessageBox.Show("Reader 설정이 잘못되었습니다.", "알림");
                }


            }
            else
            {
                for (int i = 0; i < _count; i++)
                {
                    if ((RFID_Server[i] != null) && (RFID_Server[i].IsListening))
                    {
                        try
                        {
                            RFID_Server[i].StopListening();

                        }
                        catch
                        {

                        }
                    }
                    if (RFID_Reader[i] != null)
                    {
                        try
                        {
                            RFID_Reader[i].Disconnect();
                            // btnServerStart.BackgroundImage = Properties.Resources._0;
                            pnllist[i].Visible = false;
                        }
                        catch
                        {

                        }
                    }
                    telnet = 24;
                    btnServerStart.BackgroundImage = Properties.Resources._0;
                }
            }
            Server_toggle = !Server_toggle;
            //List<Log> lg = await LogTable.ToListAsync();
            
        }

        private void btnTotal_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnTotal, "전체 현황");
        }

        private void btnJob_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnJob, "공종별 현황");
        }

        private void btnDate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnDate, "일자별 현황");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //saveLog();
            /*
                        while (listView_Main.Items.Count > 1)
                        {
                            listView_Main.Items.RemoveAt(1);
                        }
                        */
            //Detail d1 = new Detail("전체 현황", ni);
            //Detail detTotal = new Detail(listView_Main);
            Detail detTotal = new Detail(listView_Main, listGate);
            detTotal.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            Detail detJob = new Detail(listView_Main, "job");
            detJob.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DateDetail detDate = new DateDetail();
            detDate.Show();
        }

        private void btnAddPeople_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnAddPeople, "사용자 등록");
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            if (!panSupervisor.Visible)
                panSupervisor.Visible = true;

            else panSupervisor.Visible = false;
        }

        private void btnSupervisor_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.btnSupervisor, "관리자 메뉴");
        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            People_manager _People = new People_manager(this);
            _People.ShowDialog();
            //LoadPeople();
            LoadPeopleExcel();
            server.SQLClose();
            _People.Dispose();
        }

        private void disableBtn()
        {
            btnConnect2.Enabled = false;
            btn활성화.Enabled = false;
            btnTagMonitor.Enabled = false;
            //btnMainRefresh.Enabled = false;
            btnServerStart.Enabled = false;
            btnTotal.Enabled = false;
            btnJob.Enabled = false;
            btnDate.Enabled = false;
            btnAddPeople.Enabled = false;
            btnSupervisor.Enabled = false;
        }

        private void enableBtn()
        {
            btnConnect2.Enabled = true;
            btn활성화.Enabled = true;
            btnTagMonitor.Enabled = true;
            //btnMainRefresh.Enabled = true;
            btnServerStart.Enabled = true;
            btnTotal.Enabled = true;
            btnJob.Enabled = true;
            btnDate.Enabled = true;
            btnAddPeople.Enabled = true;
            btnSupervisor.Enabled = true;
        }

        private void CommuteManager_Load(object sender, EventArgs e)
        {
            btnDate.TabStop = false;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.FlatAppearance.BorderSize = 0;

            btnConnect2.TabStop = false;
            btnConnect2.FlatStyle = FlatStyle.Flat;
            btnConnect2.FlatAppearance.BorderSize = 0;

            btnServerStart.TabStop = false;
            btnServerStart.FlatStyle = FlatStyle.Flat;
            btnServerStart.FlatAppearance.BorderSize = 0;

            btnTagMonitor.TabStop = false;
            btnTagMonitor.FlatStyle = FlatStyle.Flat;
            btnTagMonitor.FlatAppearance.BorderSize = 0;

            //btnMainRefresh.TabStop = false;
            //btnMainRefresh.FlatStyle = FlatStyle.Flat;
            //btnMainRefresh.FlatAppearance.BorderSize = 0;

            btnTotal.TabStop = false;
            btnTotal.FlatStyle = FlatStyle.Flat;
            btnTotal.FlatAppearance.BorderSize = 0;

            btnJob.TabStop = false;
            btnJob.FlatStyle = FlatStyle.Flat;
            btnJob.FlatAppearance.BorderSize = 0;

            btnAddPeople.TabStop = false;
            btnAddPeople.FlatStyle = FlatStyle.Flat;
            btnAddPeople.FlatAppearance.BorderSize = 0;

            btnSupervisor.TabStop = false;
            btnSupervisor.FlatStyle = FlatStyle.Flat;
            btnSupervisor.FlatAppearance.BorderSize = 0;

            btnLogin.TabStop = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnRegisor.TabStop = false;
            btnRegisor.FlatStyle = FlatStyle.Flat;
            btnRegisor.FlatAppearance.BorderSize = 0;
        }





        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                if (txtId.Text == "skd" && txtPassword.Text == "1234")
                {
                    btnLogin.BackgroundImage = Properties.Resources.icons8_lock_outline_96;
                    enableBtn();
                    lblStatus.Text = "최고관리자가 로그인했습니다.";
                    btnSupervisor.Visible = true;
                    label12.Visible = true;
                    txtId.Visible = false;
                    txtPassword.Visible = false;
                    lblWho.Text = "최고관리자 SKD 산업님.";
                    lblWho.Visible = true;
                    isLogin = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panSupervisor.Visible = true;
                    btnAddPeople.Visible = true; lblAdd.Visible = true;
                    btnJob.Visible = true; lblJob.Visible = true;
                    btnDate.Visible = true; lblDate.Visible = true;
                    btnTotal.Visible = true; lblTotal.Visible = true;
                    AdminFlag = true;
                }

                foreach (supervisor sv in listSuper)
                {
                    if (txtId.Text == sv.id && txtPassword.Text == sv.pw)
                    {
                        btnLogin.BackgroundImage = Properties.Resources.icons8_lock_outline_96;
                        enableBtn();
                        lblStatus.Text = "일반관리자" + sv.id + " 로그인했습니다.";
                        txtId.Visible = false;
                        txtPassword.Visible = false;
                        panel2.Visible = true;
                        panel3.Visible = true;
                        if (sv.au.Substring(0, 1) == "o")
                        {
                            btnTotal.Visible = true; lblTotal.Visible = true;
                        }

                        if (sv.au.Substring(1, 1) == "o")
                        {
                            btnJob.Visible = true; lblJob.Visible = true;
                        }

                        if (sv.au.Substring(2, 1) == "o")
                        {
                            btnDate.Visible = true; lblDate.Visible = true;
                        }

                        if (sv.au.Substring(3, 1) == "o")
                        {
                            btnAddPeople.Visible = true; lblAdd.Visible = true;
                        }
                        isLogin = true;
                        break;
                    }
                }
                if (!isLogin) MessageBox.Show("잘못된 ID나 비밀번호입니다.");
            }
        }





        public class supervisor
        {
            public string id, pw, au;


            public supervisor()
            {

            }

            public supervisor(string tid, string tpw, string auu)
            {
                this.id = tid;
                this.pw = tpw;
                this.au = auu;
            }
        }



        public List<Detail.Gate> listGate = new List<Detail.Gate>();
        List<supervisor> listSuper = new List<supervisor>();

        private void btnRegisor_Click(object sender, EventArgs e)
        {
            //lvSup.Clear();      
            lvSup.Items.Clear();
            string a = (chkTotal.Checked) ? "o" : "x";
            string b = (chkJob.Checked) ? "o" : "x";
            string c = (chkDate.Checked) ? "o" : "x";
            string d = (chkAdd.Checked) ? "o" : "x";

            string Sid = txtSupId.Text;
            string Spw = txtSupPw.Text;
            string Sau = a + b + c + d;
            supervisor super = new supervisor(Sid, Spw, Sau);
            listSuper.Add(super);

            foreach (supervisor sv in listSuper)
            {
                ListViewItem item = new ListViewItem(sv.id);
                item.SubItems.Add(sv.pw);
                item.SubItems.Add(sv.au);
                lvSup.Items.Add(item);
            }
            //            lvSup.Update();

        }



        public void saveSupervisor()
        {
            server = new SQLServer();
            server.SQLUpload("DELETE FROM Sup");
            foreach (supervisor sv in listSuper)
            {
                SupIndex++;
                string strqry = "INSERT INTO Sup VALUES('" + sv.id + "','" + sv.pw + "','" + sv.au + "'," + SupIndex + ")";
                server.SQLUpload(strqry);

            }

            /*xcApp = new xc.Application();
            wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets.Item["Sup"];

            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                  System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                 xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                 System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            int i = 1;

            foreach (supervisor sv in listSuper)
            {
                ws.Cells[i, 50] = sv.id;
                ws.Cells[i, 51] = sv.pw;
                ws.Cells[i, 52] = sv.au;
                i++;
            }

            wb.Save();
            wb.Close();
            xcApp.Quit();*/
        }

        public void loadSupervisor() // Test
        {
            string strqry = "SELECT * FROM Sup ORDER BY row";
            server.GetDBTable(strqry);
            string sId, sPw, sAu;

            while (server.sdr.Read())
            {
                sId = server.sdr.GetString(0);
                sPw = server.sdr.GetString(1);
                sAu = server.sdr.GetString(2);
                supervisor sv = new supervisor(sId, sPw, sAu);
                listSuper.Add(sv);
            }
            server.sdr.Close();
            /*xcApp = new xc.Application();
            wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets["Sup"];

            string sId, sPw, sAu;
            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                            System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                            xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                            System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;


            for (int i = 1; i < nInLastRow + 1; i++)
            {
                sId = Convert.ToString(ws.Cells[i, 50].Value);
                sPw = Convert.ToString(ws.Cells[i, 51].Value);
                sAu = Convert.ToString(ws.Cells[i, 52].Value);
                supervisor sv = new supervisor(sId, sPw, sAu);
                listSuper.Add(sv);
            }

            wb.Save();
            wb.Close();
            if (xcApp != null) xcApp.Quit();*/

        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Text = "";            
        }

        private void txtPw_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {//Do process to all 4 antenna.

                if (active[i])
                {
                    try
                    {
                        bool[] Atn = RFID_Reader[i].GetAllAntennaStatus();
                        for (int k = 0; k < 2; k++)
                        {
                            picList[i][k].Image = (Atn[k]) ? Properties.Resources.LED_GREEN : Properties.Resources.LED_ORANGE;
                        }
                    }
                    catch
                    {

                    }
                }
            }

        }

        private void btnGate_Click(object sender, EventArgs e)
        {
            RFID_Reader[0].GetAllAntennaStatus();
            MessageBox.Show("a");
        }

        private void listView_People_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                try
                {
                    string strqry = "";
                    int delindex = 0;
                    //if (server.connection.State == ConnectionState.Closed) server.connection.Open();

                    ListView.SelectedListViewItemCollection _Selected = listView_People.SelectedItems;
                    List<string> job = new List<string>();
                    List<string> Comp = new List<string>();
                    int count = _Selected.Count;
                    strqry = "SELECT COUNT(*) FROM PersonalData";
                    server.GetDBTable(strqry);
                    server.sdr.Read();
                    delindex = server.sdr.GetInt32(0);
                    server.sdr.Close();

                    for (int i = 0; i < count; i++)
                    {
                        indexes.Add((listView_People.SelectedIndices[i]));
                        string s = listView_People.Items[indexes[i]].SubItems[2].Text;
                        strqry = "SELECT TYPES,COMPANY FROM PersonalData WHERE TAG='" + listView_People.Items[indexes[i]].SubItems[2].Text + "'";
                        server.GetDBTable(strqry);
                        server.sdr.Read();
                        job.Add(server.sdr.GetString(0));
                        Comp.Add(server.sdr.GetString(1));
                        server.sdr.Close();

                    }
                    for (int i = count - 1; i >= 0; i--)
                    {
                        strqry = "DELETE FROM PersonalData WHERE TAG='" + listView_People.Items[indexes[i]].SubItems[2].Text + "'";
                        server.SQLUpload(strqry);
                        listView_People.Items.RemoveAt(indexes[i]);
                    }

                    indexes.Clear();

                    strqry = "Update PersonalData set row = a.row FROM(SELECT names, ROW_NUMBER() OVER(ORDER BY row ASC) AS row FROM PersonalData) as a where PersonalData.names = a.names";
                    server.SQLUpload(strqry);
                    for (int i = 0; i < count; i++)
                    {
                        listJob.Remove(job[i]);
                        listCompany.Remove(Comp[i]);
                    }
                }
                catch
                {

                }

            }
        }

        private void tsbtnDetail_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Show();
        }

        private void LANConnect(clsReader RFID, string txtIP)
        {//Connect to LAN.
            if (RFID.IsConnected) RFID.Disconnect();
            try
            {
                if (mReaderInterface == ComInterface.enumTCPIP)
                {

                    RFID.InitOnNetwork(txtIP, telnet); //telnet 관리 23


                    
                }
                else
                    RFID.InitOnCom();
                telnet--;
                
                RFID.Connect();

                // MessageBox.Show(Convert.ToString(RFID.IsConnected), "알림");
                if (RFID.IsConnected)
                {
                    if (mReaderInterface == ComInterface.enumTCPIP)
                    {
                        //this.Cursor = Cursors.WaitCursor;
                        if (!RFID.Login("alien", "password"))        //returns result synchronously
                        {
                            RFID.Disconnect();
                            return;             //------------>
                        }
                        else
                        {
                            //RFID AutoMode
                            //RFID.AutoModeReset();
                            //RFID.AutoAction = "Acquire";
                            //RFID.AutoStartTrigger = "2 0";
                            //RFID.AutoStopTimer = "0";

                            RFID.AutoMode = "ON";

                            //활성 안테나 visible
                            active[Cnt_reader] = true;
                            pnllist[Cnt_reader].Visible = true;


                        }
                    }
                }
                else
                {
                    active[Cnt_reader] = false;
                    pnllist[Cnt_reader].Visible = false;
                }
                Cnt_reader++;
            }
            catch
            {
                MessageBox.Show("연결에 실패하였습니다.", "알림");
            }
        }
        private void InitModule(clsReader _mReader, string _count)
        {
            string _GateNum = _count;
            string TagListCustomFormat = "(EPC=%i,Ant=%a,RSSI=${RSSI},GATE=" + _GateNum + ")";
            _mReader.AntennaSequence = "0,1,2,3";
            _mReader.TagListFormat = "Custom";
            _mReader.TagStreamFormat = "Custom";
            _mReader.TagListCustomFormat = TagListCustomFormat;
            //_mReader.TagListCustomFormat = "(EPC=%i,Ant=%a,RSSI=${RSSI})";
            _mReader.TagStreamCustomFormat = "(EPC=%i,Ant=%a,RSSI=${RSSI},GATE=" + _GateNum + ")";
        }

    }


    public static class Extensions
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop.SetValue(control, enabled, null);
        }
    }
}
