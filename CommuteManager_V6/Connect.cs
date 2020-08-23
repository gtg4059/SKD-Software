using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using nsAlienRFID2;
//using System.Linq;

namespace CommuteManager_V6
{
    public partial class Connect_Setting : Form
    {
        
        private SerialPort comPort;
        private bool ReaderFlag = false;
        //private CAlienServer mServer;
        private int lv_chkbox_index;
        public static List<clsReader> mReader = new List<clsReader>();
        public static string ServerIP;
        public static List<int> ServerPort = new List<int>();
        public static List<string> ReaderPort = new List<string>();
        public static bool rebootflag = false;
        private delegate void showMsg();
        List<IPContainer> listGate = new List<IPContainer>();
        SQLServer Server = new SQLServer();
        public static int Count;
        public ComInterface mReaderInterface = ComInterface.enumTCPIP;
        
        public class IPContainer
        {
            public string ip;
            public int port, gate;


            public IPContainer()
            {
                
            }

            public IPContainer(string ip, int port, int gate)
            {
                this.ip = ip;
                this.port = port;
                this.gate = gate;
            }
        }

        public Connect_Setting()
        {
            InitializeComponent();
            comPort = null;
            
            //mServer = null;
            //mReader = null;
        }

        public Connect_Setting(SerialPort _comPort, List<clsReader> _mReader)
        {
            InitializeComponent();
            //mReader = new List<clsReader>();

            comPort = _comPort;
            //mReader = _mReader;
            
        }

        public Connect_Setting(SerialPort _comPort, List<clsReader> _mreader, int _Count, List<string> _ip, List<string> _port, List<string> _gate, List<string> _ant, List<string> _Main)
        {
            
            InitializeComponent();
            if (CommuteManager.AdminFlag == true) panel1.Visible = true;
            foreach (clsReader C in _mreader)
                mReader.Add(C);

            comPort = _comPort;
            Count = _Count;

            //TreeNode FirstNode = new TreeNode("게이트");

            for (int i = 0; i < Count; i++)
            {
                string unit = _ip[i] + ',' + _port[i] + ',' + _gate[i] + ',' + _ant[i] + ',' + _Main[i];
                comb_Reader.Items.Add(unit);
                ListViewItem _Item1 = new ListViewItem(_Main[i]);
                _Item1.SubItems.Add(_port[i]);
                _Item1.SubItems.Add(_gate[i]);
                _Item1.SubItems.Add(_Main[i]);
                lv_Port.Items.Add(_Item1);
                lv_Port.Items[lv_Port.Items.Count - 1].EnsureVisible();
            }
            //var result = from lv_Port in lv_Port.Items[0].Text orderby lv_Port.Items[0].Text.length select 

            tv_Gate.Nodes.Clear();
            for (int i = 0; i < Count; i++)
            {

                string[] GateTree = lv_Port.Items[i].SubItems[0].Text.Split('-');
                try
                {
                    switch (GateTree.Length)
                    {
                        case 1: //1-1
                            tv_Gate.Nodes.Add(GateTree[0], GateTree[0]);
                            break;
                        case 2: //1-1
                            tv_Gate.Nodes[GateTree[0]].Nodes.Add(GateTree[1], GateTree[1]);
                            break;
                        case 3: //1-1-1
                            tv_Gate.Nodes[GateTree[0]].Nodes[GateTree[1]].Nodes.Add(GateTree[2], GateTree[2]);
                            break;
                    }
                }
                catch
                {

                }


            }
            tv_Gate.ExpandAll();
            lv_Port.Items[0].Checked = true;

            //TreeView 구현
            //tv_Gate.Nodes.Clear();



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
        private void Connect_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();

        }
        #region Serial_Connect
        /*private void cboPort_DropDown(object sender, EventArgs e)
		{
			cboPort.Items.Clear();
			SerialConnect(comPort);
		}

		

		private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (mReader != null && mServer == null)
			{
				mReader.SerialPort = cboPort.Text;
			}
		}

		private void SerialConnect(clsReader _mReader)
		{
			if (_mReader.IsConnected) _mReader.Disconnect();
			if (comPort.IsOpen) comPort.Close();
			_mReader.InitOnCom(Convert.ToInt32(comPort.PortName.Substring(3)));
		}

		public void SerialConnect(SerialPort Port)
		{
			comPort = Port;
			if (comPort != null && comPort.IsOpen) comPort.Close();

			foreach (string name in System.IO.Ports.SerialPort.GetPortNames())
			{
				cboPort.Items.Add(name);
			}
			if (cboPort.Items.Count > 0)
			{
				cboPort.SelectedIndex = 0;
			}
		}
		private void btnPort_Connect_Click(object sender, EventArgs e)
		{
			comPort.PortName = cboPort.Text;
			SerialConnect(mReader);
			InitModule(mReader);
			this.Dispose();
		}*/
        #endregion

        #region Reader_Connect

        /*private void btnLAN_Connect_Click(object sender, EventArgs e)
        {

            if (!ReaderFlag)
            {
                for (int j = 0; j < lv_Port.Items.Count; j++)
                {
                    ReaderPort.Add(lv_Reader.Items[j].SubItems[1].Text);
                    LANConnect(mReader[j], ReaderPort[j]);

                }
                for (int k = 0; k < lv_Port.Items.Count; k++)
                {
                    if (mReader[k].IsConnected)
                    {
                        InitModule(mReader[k], Convert.ToInt32(lv_Reader.Items[k].SubItems[2].Text));
                        //MessageBox.Show("LAN 통신 설정되었습니다.", "알림");
                    }
                    else
                    {
                        //MessageBox.Show("문제발생.", "알림");
                    }

                }
            }
            ReaderFlag = true;
            //this.Dispose();
        }*/
        #endregion


        #region Server
        
        private void btnServer_Connect_Click(object sender, EventArgs e)
        {
            
                List<Trees> tr = new List<Trees>();

                for (int i = 0; i < Count; i++)
                {
                    Trees tree = new Trees(lv_Port.Items[i].SubItems[0].Text, lv_Port.Items[i].SubItems[2].Text);
                    tr.Add(tree);
                    CommuteManager.listtrs.Add(tree);
                }

                var result = from n in tr orderby n.main select n;
                tr = result.ToList();


                bool a = true;
                tv_Gate.Nodes.Clear();
                for (int i = 0; i < Count; i++)
                {

                    string[] GateTree = tr[i].main.Split('-');//lv_Port.Items[i].SubItems[0].Text.Split('-');//

                    try
                    {
                        switch (GateTree.Length)
                        {
                            case 1: //1
                                tv_Gate.Nodes.Add(GateTree[0], tr[i].gate);
                                break;
                            case 2: //1-1
                                tv_Gate.Nodes[GateTree[0]].Nodes.Add(GateTree[1], tr[i].gate);
                                break;
                            case 3: //1-1-1
                                tv_Gate.Nodes[GateTree[0]].Nodes[GateTree[1]].Nodes.Add(GateTree[2], tr[i].gate);
                                break;
                        }
                                        
                    if (rebootflag)
                    {
                        MessageBox.Show("프로그램을 재부팅해주십시오");

                        this.Close();
                    }
                }
                    catch
                    {
                        a = false;
                        tv_Gate.Nodes.Clear();
                        MessageBox.Show("잘못된 게이트설정");
                        //string strqry = "Update ServerContainer set Gate = '" + txtGateName.Text + "'where port =" + ST[1];
                        //Server.SQLUpload(strqry);
                        break;
                    }


                }
                tv_Gate.ExpandAll();
                if (a)
                {
                    // 동일IP 다른 포트 - 박스형 게이트 2번 노출형 1번
                    if (Count != lv_Port.Items.Count)
                    {
                        MessageBox.Show("게이트 정보와 등록 수는 동일해야 합니다");
                    }
                    else
                    {
                        ServerIP = "192.168.1.130";
                        int index = lv_Port.CheckedIndices[0];
                        for (int j = 0; j < lv_Port.Items.Count; j++)
                        {
                            ServerPort.Add(Convert.ToInt32(lv_Port.Items[j].SubItems[1].Text));
                        }

                        for (int i = 0; i < Count; i++)
                        {
                            //if (lv_Port.Items[i].Checked) MessageBox.Show("Gate " + lv_Port.Items[i].SubItems[2].Text + "번이 메인게이트");
                        }

                        CommuteManager.Server_Setting = true;
                        this.Dispose();
                    }
                }
           


        }




        #endregion

        private void btnAnt_Click(object sender, EventArgs e)
        {
            //string strqry = 
            string[] ST = comb_Reader.SelectedItem.ToString().Split(',');

            int index = comb_Reader.SelectedIndex;


            /*for (int i = 0; i < 4; i++)
            {//Do process to all 4 antenna.
                mReader[index].SetAntennaPower(i.ToString(), Convert.ToInt32(txtAnt.Text));
            }*/
            ST[3] = txtAnt.Text;
            string unit = ST[0] + ',' + ST[1] + ',' + ST[2] + ',' + ST[3];
            BeginInvoke(new Action(() => comb_Reader.Text = unit));
            string strqry = "update serverContainer set antenna = " + txtAnt.Text + "where row =" + (index + 1);
            Server.SQLUpload(strqry);

            MessageBox.Show("프로그램 연결시 " + txtAnt.Text + "로 조정됩니다.");//Print msg.


        }

        private void btnUIP_Click(object sender, EventArgs e)
        {
            Count++;
            string IP = txtHostIP.Text;
            string Port = txtPort.Text;
            string Gate = txtGATENumber.Text;
            string Ant = txtAnt.Text;

            ListViewItem _Item1 = new ListViewItem();
            _Item1.SubItems.Add(Port);
            _Item1.SubItems.Add(Gate);
            lv_Port.Items.Add(_Item1);
            lv_Port.Items[lv_Port.Items.Count - 1].EnsureVisible();

            mReader.Add(new clsReader());

            /*ListViewItem _Item2 = new ListViewItem();
            _Item2.SubItems.Add(IP);
            _Item2.SubItems.Add(Gate);
            lv_Reader.Items.Add(_Item2);
            lv_Reader.Items[lv_Reader.Items.Count - 1].EnsureVisible();*/
            string unit = IP + ',' + Port + ',' + Gate + ',' + Ant;
            comb_Reader.Items.Add(unit);

            string ServerContainer = "INSERT INTO ServerContainer VALUES('" + IP + "','" + Port + "','" + Gate + "','" + Ant + "','','" + Count + "')";
            Server.SQLUpload(ServerContainer);
            rebootflag = true;
            //Server.SQLClose();
        }



        private void lv_Port_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lv_chkbox_index = e.Index;
            for (int i = 0; i < Count; i++)
            {
                if (i != lv_chkbox_index) lv_Port.Items[i].Checked = false;
            }
        }
        /*private void LANConnect(clsReader RFID, string txtIP)
        {//Connect to LAN.
            if (RFID.IsConnected) RFID.Disconnect();
            try
            {
                if (mReaderInterface == ComInterface.enumTCPIP)
                    RFID.InitOnNetwork(txtIP, Convert.ToInt32(23)); //telnet 관리 23
                else
                    RFID.InitOnCom();

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


                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("연결에 실패하였습니다.", "알림");
            }
        }*/

        private void btnGate_set_Click(object sender, EventArgs e)
        {
            ListView.CheckedIndexCollection checkedIndex = lv_Port.CheckedIndices;
            int index = lv_Port.CheckedIndices[0];
            if (txtGate.Text == "") MessageBox.Show("번호를 기입하십시오");
            else if (index != -1)
            {
                lv_Port.Items[index].SubItems[0].Text = txtGate.Text;

                string[] ST = comb_Reader.Items[index].ToString().Split(',');

                string unit = ST[0] + ',' + ST[1] + ',' + ST[2] + ',' + ST[3] + ',' + txtGate.Text;

                comb_Reader.Items[index] = unit;

                string strqry = "Update ServerContainer set Main = '" + txtGate.Text + "'where port =" + ST[1];
                Server.SQLUpload(strqry);
                rebootflag = true;
            }

        }

        private void btnGateName_Click(object sender, EventArgs e)
        {
            ListView.CheckedIndexCollection checkedIndex = lv_Port.CheckedIndices;
            int index = lv_Port.CheckedIndices[0];
            if (txtGateName.Text == "") MessageBox.Show("이름을 기입하십시오");
            else if (index != -1)
            {
                lv_Port.Items[index].SubItems[2].Text = txtGateName.Text;

                string[] ST = comb_Reader.Items[index].ToString().Split(',');

                string unit = ST[0] + ',' + ST[1] + ',' + txtGateName.Text + ',' + ST[3] + ',' + ST[4];

                comb_Reader.Items[index] = unit;

                string strqry = "Update ServerContainer set Gate = '" + txtGateName.Text + "'where port =" + ST[1];
                Server.SQLUpload(strqry);
                rebootflag = true;
            }
        }

        private void btnDel_Gate_Click(object sender, EventArgs e)
        {
            string[] ST = comb_Reader.SelectedItem.ToString().Split(',');
            int cmbindex = comb_Reader.SelectedIndex;

            comb_Reader.Items.RemoveAt(cmbindex);
            lv_Port.Items.RemoveAt(cmbindex);

            string strqry = "";
            strqry = "DELETE FROM ServerContainer WHERE PORT=" + ST[1];
            Server.SQLUpload(strqry);
            strqry = "Update ServerContainer set row = a.row FROM(SELECT port, ROW_NUMBER() OVER(ORDER BY row ASC) AS row FROM ServerContainer) as a where ServerContainer.port = a.port";
            Server.SQLUpload(strqry);
            rebootflag = true;


        }

        private void btnFixIP_Click(object sender, EventArgs e)
        {
            string IP = txtHostIP.Text;
            string Port = txtPort.Text;
            string Gate = txtGATENumber.Text;
            string Ant = txtAnt.Text;
            int cmbindex = comb_Reader.SelectedIndex;
            string _main = lv_Port.Items[cmbindex].SubItems[0].Text;
            string unit = IP + ',' + Port + ',' + Gate + ',' + Ant;



            //lv_Port.Items[cmbindex].SubItems[0].Text = "1";
            ListViewItem _Item1 = new ListViewItem(_main);
            _Item1.SubItems.Add(Port);
            _Item1.SubItems.Add(Gate);
            lv_Port.Items[cmbindex] = _Item1;

            /*ListViewItem _Item1 = new ListViewItem();
            _Item1.SubItems.Add(Port);
            _Item1.SubItems.Add(Gate);
            lv_Port.Items.Add(_Item1);
            lv_Port.Items[lv_Port.Items.Count - 1].EnsureVisible();*/

            //mReader.Add(new clsReader());

            /*ListViewItem _Item2 = new ListViewItem();
            _Item2.SubItems.Add(IP);
            _Item2.SubItems.Add(Gate);
            lv_Reader.Items.Add(_Item2);
            lv_Reader.Items[lv_Reader.Items.Count - 1].EnsureVisible();*/

            comb_Reader.Items[cmbindex] = unit;

            string ServerContainer = "update serverContainer set server = '" + IP + "',port='" + Port + "',gate='" + Gate + "',antenna='" + Ant + "'where row =" + (cmbindex + 1);
            Server.SQLUpload(ServerContainer);
            //Server.SQLClose();
            rebootflag = true;
        }

        private void comb_Reader_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] ST = comb_Reader.SelectedItem.ToString().Split(',');


            this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
            {
                txtHostIP.Text = ST[0];
                txtPort.Text = ST[1];
                txtGATENumber.Text = ST[2];
                txtAnt.Text = ST[3];
            }));




        }
    }

}
