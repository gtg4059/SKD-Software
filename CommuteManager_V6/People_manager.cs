using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using xc = Microsoft.Office.Interop.Excel;



namespace CommuteManager_V6
{
    public partial class People_manager : Form
    {
        CommuteManager Main;
        People PersonalData;
        OpenFileDialog pFileDlg = new OpenFileDialog();
        SQLServer server = new SQLServer();
        ListView lvPeople;
        private int PersonIndex = 0, PersonIndexStatic = 0;
        private bool DoubleFlag = false, DoubleFlagStatic = false;
        xc.Application xcApp = null;
        xc.Workbook wb = null;
        xc.Worksheet ws = null;
        string[] names, PK;
        public People_manager()
        {
            InitializeComponent();
        }

        //string name, tag, blood, job, comp, PK, phone, emer, add, year, insu, edu;
        

        public People_manager(string t0, string t1, string t2, string t3, string t4,
            string t5, string t6, string t7, string t8, 
            string t9, string t10, string t11,CommuteManager _Main)
        {
            InitializeComponent();
            chkModify.Checked = true;
            Main = _Main;
            txtName.Text = t0;
            txtTagID.Text = t1;
            txtBlood.Text = t2;
            txtJob.Text = t3;
            txtCompany.Text = t4;
            txtPerNum.Text = t5;
            txtPhone.Text = t6;
            txtEmer.Text = t7;
            txtAddress.Text = t8;
            txtYear.Text = t9;
            txtInsu.Text = t10;
            if (t11 == "Y") radEduY.Checked = true;
            else radEduN.Checked = true;
            PersonalData = new People();
            string strqry = "SELECT COUNT(*) FROM PersonalData";
            server.GetDBTable(strqry);
            server.sdr.Read();
            PersonIndex = server.sdr.GetInt32(0);
            PersonIndexStatic = PersonIndex;
            server.sdr.Close();

            strqry = "SELECT Names,PK FROM PersonalData";
            server.GetDBTable(strqry);
            names = new string[PersonIndex];
            PK = new string[PersonIndex];
            int i = 0;
            while (server.sdr.Read())
            {
                names[i] = server.sdr.GetString(0);
                PK[i] = server.sdr.GetString(1);
                //if (names[i] == txtName.Text && PK[i] == txtPerNum.Text) DoubleFlag = true;
                i++;
            }
            server.sdr.Close();

        }
        public People_manager(People _input, CommuteManager _Main)
        {
            InitializeComponent();
            Main = _Main;
            PersonalData = _input;
            txtName.Text = PersonalData.Name;
            txtPhoto.Text = PersonalData.Photo;
            txtTagID.Text = PersonalData.TagID;
            txtBlood.Text = PersonalData.Blood;
            txtJob.Text = PersonalData.Job;
            txtCompany.Text = PersonalData.Company;
            txtPerNum.Text = PersonalData.PK;
            txtPhone.Text = PersonalData.Phone;
            txtAddress.Text = PersonalData.Address;
            txtYear.Text = PersonalData.Year;
            //	txtInsure.Text = PersonalData.Insure;
            picPhoto.ImageLocation = PersonalData.Photo;
            if (_input.Edu == "Y") radEduY.Checked = true;
            else radEduN.Checked = true;
        }

        public People_manager(CommuteManager _Main)
        {
            InitializeComponent();
            Main = _Main;
            PersonalData = new People();
            string strqry = "SELECT COUNT(*) FROM PersonalData";
            server.GetDBTable(strqry);
            server.sdr.Read();
            PersonIndex = server.sdr.GetInt32(0);
            PersonIndexStatic = PersonIndex;
            server.sdr.Close();

            strqry = "SELECT Names,PK FROM PersonalData";
            server.GetDBTable(strqry);
            names = new string[PersonIndex];
            PK = new string[PersonIndex];
            int i = 0;
            while (server.sdr.Read())
            {
                names[i] = server.sdr.GetString(0);
                PK[i] = server.sdr.GetString(1);
                //if (names[i] == txtName.Text && PK[i] == txtPerNum.Text) DoubleFlag = true;
                i++;
            }
            server.sdr.Close();
        }

        public People_manager(ListView lv, int index)
        {
            int idx = index;
            this.lvPeople = lv;

            string name = "";
            ListView.SelectedListViewItemCollection _Selected = lv.SelectedItems;

            foreach (ListViewItem item in _Selected)
            {
                name = item.SubItems[0].Text;
            }

            MessageBox.Show(name);

            index = lv.SelectedIndices[0] + 1;
            string strqry = "SELECT * FROM PersonalData WHERE names='" + name + "' ORDER BY row";
            server.GetDBTable(strqry);
            server.sdr.Read();
            MessageBox.Show("이름=" + server.sdr.GetString(0) + "\n" + "태그ID=" + server.sdr.GetString(1) + "\n" + "혈액형=" + server.sdr.GetString(2) + "\n" + "공종=" + server.sdr.GetString(3) + "\n" +
                "회사=" + server.sdr.GetString(4) + "\n" + "PK=" + server.sdr.GetString(5) + "\n" + "전화번호=" + server.sdr.GetString(6) + "\n" + "비상번호=" + server.sdr.GetString(7) + "\n" +
                "주소=" + server.sdr.GetString(8) + "\n" + "경력=" + server.sdr.GetString(9) + "\n" + "보험=" + server.sdr.GetString(10) + "\n" + "교육=" + server.sdr.GetString(11));
            server.sdr.Close();
        }

        private void btnPhotoSearch_Click(object sender, EventArgs e)
        {
            pFileDlg.ShowDialog();
            txtPhoto.Text = pFileDlg.FileName;
            picPhoto.ImageLocation = txtPhoto.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PersonalData.Name = txtName.Text;
            PersonalData.Photo = txtPhoto.Text;
            PersonalData.TagID = txtTagID.Text;
            PersonalData.Blood = txtBlood.Text;
            PersonalData.Job = txtJob.Text;
            PersonalData.Company = txtCompany.Text;
            PersonalData.PK = txtPerNum.Text;
            PersonalData.Phone = txtPhoto.Text;
            //	PersonalData.Emer = txtEmer.Text;
            PersonalData.Address = txtAddress.Text;
            PersonalData.Year = txtYear.Text;
            //	PersonalData.Insure = txtInsure.Text;           
            PersonalData.Edu = (radEduY.Checked) ? "Y" : "N";

            if (Main.FindMatchData(PersonalData.TagID) != null)
                Main.DeletePerson(PersonalData.TagID);

            //PersonalData.SaveIni(Main.startPath);
            Main.LoadPeople();
            this.Close();
        }

        private void btnTagSearch_Click(object sender, EventArgs e)
        {
            TagMonitor _TagMonitor = new TagMonitor(Main.TagList);
            _TagMonitor.Owner = this;
            if (_TagMonitor.ShowDialog() == DialogResult.OK)
            {//If one of tag selected...
                txtTagID.Text = Clipboard.GetText();//Get text from clip board - selected EPC ID was saved on clip board.
            }
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            

            if (txtPerNum.Text == "")
            {
                MessageBox.Show("PK를 입력하셔야 합니다");
            }
            else
            {
                int i = 0;
                
                
                PersonIndex++;
                PersonalData.Name = txtName.Text;
                PersonalData.Photo = txtPhoto.Text;
                PersonalData.TagID = txtTagID.Text;
                PersonalData.Blood = txtBlood.Text;

                if (txtJob.Text == "") PersonalData.Job = "기타";
                else PersonalData.Job = txtJob.Text;

                if (txtCompany.Text == "") PersonalData.Company = "기타";
                else PersonalData.Company = txtCompany.Text;

                Main.listJob.Add(PersonalData.Job);
                Main.listCompany.Add(PersonalData.Company);
                PersonalData.PK = txtPerNum.Text;
                PersonalData.Phone = txtPhoto.Text;
                // PersonalData.Emer = txtEmer.Text;
                PersonalData.Address = txtAddress.Text;
                PersonalData.Year = txtYear.Text;
                Main.listJob.Add(PersonalData.Job);
                Main.listCompany.Add(PersonalData.Company);
                Main.listJob = Main.listJob.Distinct().ToList();
                Main.listCompany = Main.listCompany.Distinct().ToList();
                // PersonalData.Insure = txtInsure.Text;
                PersonalData.Edu = (radEduY.Checked) ? "Y" : "N";
                if (Main.FindMatchData(PersonalData.TagID) != null)
                    Main.DeletePerson(PersonalData.TagID);

                /*string strqry = "SELECT Names,PK FROM PersonalData";
                server.GetDBTable(strqry);
                string[] names = new string[PersonIndex];
                string[] PK = new string[PersonIndex];*/

                for (i = 0; i < PersonIndex-1; i++)
                {
                    //if (names[i] == null || PK[i] ==null) break;
                    if (names[i] == txtName.Text && PK[i] == txtPerNum.Text) DoubleFlag = true;
                    //i++;                    
                }
                server.sdr.Close();


                //Main.index;
                if (chkModify.Checked)
                {
                    if (Main.index != 0)//더블클릭 후 수정
                    {
                        /*UPDATE PersonalData
                            SET names     ='',
                                tag       ='',
                                blood     ='',
                                types     ='',
                                 Company   ='',
                                 PK        ='',
                                 tel       ='',
                                 emerg     ='',
                                 location  ='',
                                 career    ='',
                                insurance ='',
                                edu       =''
                            WHERE row = 1*/

                        string strqry = "UPDATE PersonalData SET names = '" + PersonalData.Name + "', tag='" + PersonalData.TagID + "', blood = '" + PersonalData.Blood + "',types = '"
                     + PersonalData.Job + "',Company = '" + PersonalData.Company + "',PK = '" + PersonalData.PK + "', tel = '" + PersonalData.Phone + "', emerg = '" + PersonalData.Emer + "', location = '"
                      + PersonalData.Address + "', career = '" + PersonalData.Year + "',insurance = '" + PersonalData.Insure + "', edu = '" + PersonalData.Edu + "'WHERE row = " + Main.index;

                        Main.index = 0;

                        server.SQLUpload(strqry);
                        Main.isAddPeople = true;
                        server.connection.Close();
                        Main.LoadPeopleExcel();
                        this.Close();
                    }
                }

                else if (DoubleFlag)
                {
                    MessageBox.Show("중복되는 이름과 PK입니다");
                    DoubleFlag = false;
                }

                else
                {
                    string strqry = "INSERT INTO PersonalData VALUES('" + PersonalData.Name + "','" + PersonalData.TagID + "','" + PersonalData.Blood + "','"
                 + PersonalData.Job + "','" + PersonalData.Company + "','" + PersonalData.PK + "','" + PersonalData.Phone + "','" + PersonalData.Emer + "','"
                  + PersonalData.Address + "','" + PersonalData.Year + "','" + PersonalData.Insure + "','" + PersonalData.Edu + "'," + PersonIndex + ")";

                    server.SQLUpload(strqry);
                    Main.isAddPeople = true;
                    server.connection.Close();
                    Main.LoadPeopleExcel();
                    this.Close();
                }
                
            }
        }

        
        private void People_manager_Load(object sender, EventArgs e)
        {

        }

        private void btnExcelAdd_Click(object sender, EventArgs e)
        {
            
            if (!Main.ExcelAdd)
            {
                string paraName, paraTag, paraBlood, paraJob, paraComp, paraPernum, paraPhone,
                          paraEmer, paraAddr, paraYear, paraInsu, paraEdu;
                //listView_People.Items.Clear();
                xcApp = new xc.Application();
                wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
                ws = wb.Worksheets["Personal Data"];
                
                int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                                System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                                System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                for (int i = 2; i < nInLastRow + 1; i++)
                {
                    DoubleFlag = false;
                    PersonIndex++;
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
                    if (paraPernum == null) paraPernum = "";
                    People _Person = new People(paraName, paraTag, paraBlood, paraJob, paraComp,
                            paraPernum, paraPhone, paraEmer, paraAddr, paraYear, paraInsu, paraEdu);
                    

                    for (int k = 0; k < PersonIndexStatic; k++) if (names[k] == paraName && PK[k] == paraPernum) { DoubleFlag = true; DoubleFlagStatic = true; }

                    if (!DoubleFlag)
                    {
                        Main.isAddPeople = true;
                        Main.AddPerson(_Person);
                        string strqry = "INSERT INTO PersonalData VALUES('" + paraName + "','" + paraTag + "','" + paraBlood + "','"
                         + paraJob + "','" + paraComp + "','" + paraPernum + "','" + paraPhone + "','" + paraEmer + "','"
                          + paraAddr + "','" + paraYear + "','" + paraInsu + "','" + paraEdu + "'," + PersonIndex + ")";

                        server.SQLUpload(strqry);
                    }
                    //AddPerson(_Person);
                }
                //wb.Save();
                wb.Close();
                if (xcApp != null) xcApp.Quit();
                if (DoubleFlagStatic) MessageBox.Show("중복된 이름과 PK는 필터링하였습니다");

                btnExcelAdd.Enabled = false;
                btnExcelAdd.Visible = false;
                server.connection.Close();
                Main.ExcelAdd = true;
            }
            else { MessageBox.Show("추가할 수 없는 엑셀 파일입니다"); }
            

        }
    }
}
