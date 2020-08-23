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
using CommuteManager_V6;
//using xc = Microsoft.Office.Interop.Excel;

namespace CommuteManager_V6
{
    public partial class Detail : Form
    {

        CommuteManager formMain = new CommuteManager();
        SQLServer server = new SQLServer();
        public int i;
        public string strI, strF;
        public int cntIn, cntOut, index,
            cntMgIn, cntMgOut, cntMgIn1, cntMgIn2, cntMgIn3, cntMgIn4, cntMgOut1, cntMgOut2, cntMgOut3, cntMgOut4,
            cntSg1In, cntSg1Out, cntSg1In1, cntSg1In2, cntSg1In3, cntSg1In4, cntSg1Out1, cntSg1Out2, cntSg1Out3, cntSg1Out4,
            cntSg2In, cntSg2Out, cntSg2In1, cntSg2In2, cntSg2In3, cntSg2In4, cntSg2Out1, cntSg2Out2, cntSg2Out3, cntSg2Out4,
            cnt101In, cnt101Out, cntWorkIn, cntWorkOut,
            cntDuIn, cntDuOut, cntChIn, cntChOut, cntToIn, cntToOut, cntGiIn, cntGiOut;

        private void dgvJob_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvJob.CurrentCell.RowIndex;
            int col = dgvJob.CurrentCell.ColumnIndex;
            // MessageBox.Show("Row is " + row.ToString() + "  Col is " + col.ToString());
            lvEvent.Items.Clear();
            //MessageBox.Show(row.ToString() + "//" + col.ToString());

            for (int i = 0; i < formMain.listJob.Count; i++)
            {
                if (row == i && col == 1)
                {
                    foreach (worker wk in listWorker)
                    {
                        if (wk.job == formMain.listJob[i] && wk.status == "입")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }

                else if (row == i && col == 2)
                {
                    foreach (worker wk in listWorker)

                    {
                        if (wk.job == formMain.listJob[i] && wk.status == "출")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }
            }
        }

        public class Gate
        {
            public string server, port, gate, antenna, main;


            public Gate()
            {

            }

            public Gate(string _server, string _port, string _gate, string _antenna, string _main)
            {
                this.server = _server;
                this.port = _port;
                this.gate = _gate; // 현장내
                this.antenna = _antenna;
                this.main = _main; //1-1
            }
        }

        private void dgvCompnay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvCompnay.CurrentCell.RowIndex;
            int col = dgvCompnay.CurrentCell.ColumnIndex;
            // MessageBox.Show("Row is " + row.ToString() + "  Col is " + col.ToString());
            lvEvent.Items.Clear();
            //MessageBox.Show(row.ToString() + "//" + col.ToString());

            for (int i = 0; i < formMain.listCompany.Count; i++)
            {
                if (row == i && col == 1)
                {
                    foreach (worker wk in listWorker)
                    {
                        if (wk.company == formMain.listCompany[i] && wk.status == "입")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }

                else if (row == i && col == 2)
                {
                    foreach (worker wk in listWorker)
                    {
                        if (wk.company == formMain.listCompany[i] && wk.status == "출")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void dgvJob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvEvent_DoubleClick(object sender, EventArgs e)
        {
            string name = "";
            ListView.SelectedListViewItemCollection _Selected = lvEvent.SelectedItems;

            foreach (ListViewItem item in _Selected)
            {
                name = item.SubItems[0].Text;
            }



            index = lvEvent.SelectedIndices[0] + 1;
            string strqry = "SELECT * FROM PersonalData WHERE names='" + name + "' ORDER BY row";
            server.GetDBTable(strqry);
            server.sdr.Read();
            MessageBox.Show("이름=" + server.sdr.GetString(0) + "\n" + "태그ID=" + server.sdr.GetString(1) + "\n" + "혈액형=" + server.sdr.GetString(2) + "\n" + "공종=" + server.sdr.GetString(3) + "\n" +
                "회사=" + server.sdr.GetString(4) + "\n" + "PK=" + server.sdr.GetString(5) + "\n" + "전화번호=" + server.sdr.GetString(6) + "\n" + "비상번호=" + server.sdr.GetString(7) + "\n" +
                "주소=" + server.sdr.GetString(8) + "\n" + "경력=" + server.sdr.GetString(9) + "\n" + "보험=" + server.sdr.GetString(10) + "\n" + "교육=" + server.sdr.GetString(11));
            server.sdr.Close();

        }

        private void dgvJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvJob.CurrentCell.RowIndex;
            int col = dgvJob.CurrentCell.ColumnIndex;
            lvEvent.Items.Clear();
            //MessageBox.Show(row.ToString() + "//" + col.ToString());

            if (row == 0 && col == 1) //철근 입
            {
                foreach (worker wk in listWorker)
                {
                    if (wk.status == "입" && wk.job == "철근")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 0 && col == 2) //철근 출
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "출" && wk.job == "철근")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 1 && col == 1) //덕트 입
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "입" && wk.job == "덕트")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 1 && col == 2) //덕트 출
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "출" && wk.job == "덕트")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 2 && col == 1) //토목 입
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "입" && wk.job == "토목")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 2 && col == 2) //토목 출
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "출" && wk.job == "토목")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }

            else if (row == 3 && col == 1) //기계 입
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "입" && wk.job == "기계")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }


            else if (row == 3 && col == 2) //기계 출
            {
                foreach (worker wk in listWorker)
                {

                    if (wk.status == "출" && wk.job == "기계")
                    {

                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.gate);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.tag);
                        lvEvent.Items.Add(item);
                    }
                }
            }
        }

        private void dgvLoca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvLoca.CurrentCell.RowIndex;
            int col = dgvLoca.CurrentCell.ColumnIndex;
            // MessageBox.Show(row.ToString() + "," + col.ToString());
            // MessageBox.Show("Row is " + row.ToString() + "  Col is " + col.ToString());
            lvEvent.Items.Clear();
            //MessageBox.Show(row.ToString() + "//" + col.ToString());

            for (int i = 0; i < lstGate.Count; i++)
            {
                if (row == i && col == 1)
                {
                    foreach (worker wk in listWorker)
                    {

                        if (wk.loca == lstGate[i].main && wk.status == "입")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }

                else if (row == i && col == 2)
                {
                    foreach (worker wk in listWorker)
                    {                        
                        if (wk.loca == lstGate[i].main && wk.status == "출")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void dgvTotal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTotal.CurrentCell.RowIndex;
            int col = dgvTotal.CurrentCell.ColumnIndex;
            // MessageBox.Show("Row is " + row.ToString() + "  Col is " + col.ToString());
            lvEvent.Items.Clear();
            //MessageBox.Show(row.ToString() + "//" + col.ToString());

            for (int i = 0; i < lstGate.Count; i++)
            {
                if (row == i && col == 1)
                {
                    foreach (worker wk in listWorker)
                    {
                        if (wk.gate == lstGate[i].main && wk.status == "입")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }

                else if (row == i && col == 2)
                {
                    foreach (worker wk in listWorker)
                    {                      
                        if (wk.gate == lstGate[i].main && wk.status == "출")
                        {
                            ListViewItem item = new ListViewItem(wk.name);
                            item.SubItems.Add(wk.gate);
                            item.SubItems.Add(wk.job);
                            item.SubItems.Add(wk.tag);
                            lvEvent.Items.Add(item);
                        }
                    }
                }
            }
        }
            



        //덕트, 철근, 토목, 기계





            //1. 철근   2. 토목   3. 토목
            //Gate 1번이 Main
            //Gate 2번이 Sub Gate

            //detail 생성자에서 listview 끌고감
            /*xc.Application xcApp = null;
            xc.Workbook wb = null;
            xc.Worksheet ws = null;*/
        public ListView lv;
        public List<worker> listWorker = new List<worker>();
        public List<worker> listEvent = new List<worker>();
        public Detail()
        {
            InitializeComponent();
        }

        public class worker
        {
            public string time, status, name, tag, gate, job, loca, company;
            public worker()
            {
                this.time = null;
                this.status = null;
                this.name = null;
                this.tag = null;
                this.gate = null;
                this.job = null;
                this.loca = null;
                this.company = null;
            }
        }

        /// <summary>
        /// 공종별 현황
        /// </summary>
        /// <param name="listview"></param>
        /// <param name="Job"></param>

        public Detail(ListView listview, string Job)    
        {
            int sumIn = 0, sumOut = 0;
            int ii = 0;
            listWorker.Clear();
            InitializeComponent();
            this.lv = listview;
            dgvTotal.Visible = false;
            lblDgvTotal.Visible = false;
            dgvLoca.Visible = false;
            lblDgvLoca.Visible = false;
            dgvCompnay.Visible = false;
            lblCompnay.Visible = false;
            dgvJob.Visible = true;

            foreach (ListViewItem item in lv.Items)
            {
                worker wk = new worker();
                wk.time = item.SubItems[0].Text;
                wk.status = item.SubItems[1].Text;
                wk.name = item.SubItems[2].Text;
                wk.tag = item.SubItems[3].Text;
                wk.gate = item.SubItems[4].Text;
                wk.job = item.SubItems[5].Text;
                wk.loca = item.SubItems[6].Text;
                wk.company = item.SubItems[7].Text;
                listWorker.Add(wk);
            }

            for (int i = 0; i < formMain.listJob.Count; i++)
            {
                string zob = formMain.listJob[i];
                int cntIn = 0, cntOut = 0;
                foreach (worker wk in listWorker)
                {
                    if (wk.job == zob && wk.status == "입") cntIn++;
                    else if (wk.job == zob && wk.status == "출") cntOut++;
                }
                string[] row = { zob, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                dgvJob.Rows.Add(row);
                ii++;
                sumIn += cntIn;
                sumOut += cntOut;
            }
            string[] row3 = { "총계", sumIn.ToString(), sumOut.ToString(), (sumIn - sumOut).ToString() };
            dgvJob.Rows.Add(row3);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(dgvJob.Font, FontStyle.Bold);
            dgvJob.Rows[ii].DefaultCellStyle = style;
        }
        public List<Gate> lstGate;

        public Detail(ListView lvitemLoad, List<Gate> list)
        {
            if (lstGate != null) lstGate.Clear();
            listWorker.Clear();
            InitializeComponent();
            lstGate = list;
            dgvTotal.Visible = true;
            lblDgvTotal.Visible = true;
            dgvLoca.Visible = true;
            lblDgvLoca.Visible = true;
            dgvCompnay.Visible = true;
            lblCompnay.Visible = true;
            dgvJob.Visible = false;

            this.lv = lvitemLoad;

            foreach (ListViewItem item in lv.Items)
            {
                worker wk = new worker();
                wk.time = item.SubItems[0].Text;
                wk.status = item.SubItems[1].Text;
                wk.name = item.SubItems[2].Text;
                wk.tag = item.SubItems[3].Text;
                wk.gate = item.SubItems[4].Text;
                wk.job = item.SubItems[5].Text;
                wk.loca = item.SubItems[6].Text;
                wk.company = item.SubItems[7].Text;
                listWorker.Add(wk);
            }


            for (int i = 0; i < lstGate.Count; i++)
            {
                //  string comp = formMain.listCompany[i];
                int cntIn = 0, cntOut = 0;
                foreach (worker wk in listWorker)
                {
                    if (wk.gate == list[i].main && wk.status == "입") cntIn++;
                    else if (wk.gate == list[i].main && wk.status == "출") cntOut++;
                }
                string[] row = { list[i].main, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                dgvTotal.Rows.Add(row);
            }
          
            int cntHIn = 0, cntHOut = 0;
            //
            for (int i = 0; i < lstGate.Count; i++)
            {
                int cntIn = 0, cntOut = 0;
                string[] GateTree = lstGate[i].main.Split('-');
                foreach (worker wk in listWorker)
                {
                    
                    if (GateTree.Length > 1) 
                    {
                        if (wk.loca == lstGate[i].main && wk.status == "입") cntIn++;
                        else if (wk.loca == lstGate[i].main && wk.status == "출") cntOut++;
                        else if (wk.loca == "현장내" && wk.status == "출") cntHIn++;                        
                    }
                    else
                    {
                        if (wk.loca == "현장내" && wk.status == "입") cntHIn++;
                        else if (wk.loca == "현장외") cntHOut++;
                    }                                        
                }
                if (GateTree.Length > 1)
                {
                    string[] row = { lstGate[i].main, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                    dgvLoca.Rows.Add(row);
                }
                
            }
            string[] rowH = { "현장내", cntHIn.ToString(), cntHOut.ToString(), (cntHIn - cntHOut).ToString() };
            dgvLoca.Rows.Add(rowH);
            for (int i = 0; i < formMain.listCompany.Count; i++)
            {
                string comp = formMain.listCompany[i];
                int cntIn = 0, cntOut = 0;
                foreach (worker wk in listWorker)
                {
                    if (wk.company == comp && wk.status == "입") cntIn++;
                    else if (wk.company == comp && wk.status == "출") cntOut++;
                }
                string[] row = { comp, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                dgvCompnay.Rows.Add(row);

            }

        }

        //전체현황        
        public Detail(ListView lvitemLoad)
        {

            listWorker.Clear();
            InitializeComponent();

            dgvTotal.Visible = true;
            lblDgvTotal.Visible = true;
            dgvLoca.Visible = true;
            lblDgvLoca.Visible = true;
            dgvCompnay.Visible = true;
            lblCompnay.Visible = true;
            dgvJob.Visible = false;

            this.lv = lvitemLoad;

            foreach (ListViewItem item in lv.Items)
            {
                worker wk = new worker();
                wk.time = item.SubItems[1].Text;
                wk.status = item.SubItems[2].Text;
                wk.name = item.SubItems[3].Text;
                wk.tag = item.SubItems[4].Text;
                wk.gate = item.SubItems[5].Text;
                wk.job = item.SubItems[6].Text;
                wk.loca = item.SubItems[7].Text;
                wk.company = item.SubItems[8].Text;
                listWorker.Add(wk);
            }

            foreach (worker wk in listWorker)
            {
                foreach (Gate gt in formMain.listGate)
                {
                    cntIn = 0; cntOut = 0;
                    if (wk.gate == gt.main && wk.status == "입") cntIn++;
                    else if (wk.gate == gt.main && wk.status == "출") cntOut++;
                    string[] row = { gt.main, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                    dgvTotal.Rows.Add(row);
                }
            }        

            for (int i = 0; i < formMain.listCompany.Count; i++)
            {
                string comp = formMain.listCompany[i];
                int cntIn = 0, cntOut = 0;
                foreach (worker wk in listWorker)
                {
                    if (wk.company == comp && wk.status == "입") cntIn++;
                    else if (wk.company == comp && wk.status == "출") cntOut++;
                }
                string[] row = { comp, cntIn.ToString(), cntOut.ToString(), (cntIn - cntOut).ToString() };
                dgvCompnay.Rows.Add(row);

            }
        }

        public Detail(string name, int n)
        {
            InitializeComponent();
            this.Text = name;
            //i = n;
            i = 2;
            if (name == "전체 현황") initDgvTotal();
            else if (name == "공종별 현황") initDgvJob();

            cntTotal();

        }


        private void cntTotal()
        {
            string strqry = "SELECT * FROM Logs ORDER BY row";
            server.GetDBTable(strqry);



            /*xcApp = new xc.Application();
            wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets.Item["Log"];

            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                  System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                  xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                  System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            strI = Convert.ToString(ws.Cells[i, 1].value);
            strF = Convert.ToString(ws.Cells[nInLastRow, 1].value);*/
            while (server.sdr.Read())
            {
                if (server.sdr.GetString(1) == "출근" && server.sdr.GetString(5)
                    == "철근" && server.sdr.GetString(4) == "2") cntMgIn1++;
                else if (server.sdr.GetString(1) == "출근" && server.sdr.GetString(5)
                    == "토목" && server.sdr.GetString(4) == "2") cntMgIn2++;
                else if (server.sdr.GetString(1) == "출근" && server.sdr.GetString(5)
                    == "덕트" && server.sdr.GetString(4) == "2") cntMgIn3++;

                else if (server.sdr.GetString(1) == "퇴근" && server.sdr.GetString(5)
                    == "철근" && server.sdr.GetString(4) == "2") cntMgOut1++;
                else if (server.sdr.GetString(1) == "퇴근" && server.sdr.GetString(5)
                    == "토목" && server.sdr.GetString(4) == "2") cntMgOut2++;
                else if (server.sdr.GetString(1) == "퇴근" && server.sdr.GetString(5)
                    == "덕트" && server.sdr.GetString(4) == "2") cntMgOut3++;
            }
            server.sdr.Close();
            /*tslblRef.Text = strI + "~" + strF;
            wb.Save();
            wb.Close();
            if (xcApp != null) xcApp.Quit();*/
        }

        private void cntJob()
        {
            /*xcApp = new xc.Application();
            wb = xcApp.Workbooks.Open(Application.StartupPath + @"/personalData.xlsx");
            ws = wb.Worksheets.Item["Log"];

            int nInLastRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                  System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                  xc.XlSearchOrder.xlByRows, xc.XlSearchDirection.xlPrevious, false,
                  System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            strI = ws.Cells[i, 1];
            strF = ws.Cells[nInLastRow, 1];

            for (int j = 1; j <= nInLastRow; j++)
            {
              //  if (ws.Cells[j, 2].value == "출근" && ws.Cells[j, 6] == "철근") 
            }
            tslblRef.Text = strI + "~" + strF;*/
        }

        private void initDgvTotal()
        {
            dgvTotal.Visible = true;
            lblDgvTotal.Visible = true;
            dgvLoca.Visible = true;
            lblDgvLoca.Visible = true;
            //  dgvJob.Visible = false;

            dgvTotal.Rows.Add();
            dgvTotal["dgvTotalCol0", 0].Value = "Main Gate";
            dgvTotal.Rows.Add();
            dgvTotal["dgvTotalCol0", 1].Value = "Sub Gate";
            dgvTotal["dgvTotalCol0", 2].Value = "출퇴근 현황 계";

            dgvLoca.Rows.Add();
            dgvLoca["dgvLocaCol0", 0].Value = "101동";
            dgvLoca.Rows.Add();
            dgvLoca["dgvLocaCol0", 1].Value = "현장내";
            dgvLoca["dgvLocaCol0", 2].Value = "총 출입현황";
        }

        private void initDgvJob()
        {
            /*
            dgvTotal.Visible = false;
            lblDgvTotal.Visible = false;
            dgvLoca.Visible = false;
            lblDgvLoca.Visible = false;
            dgvJob.Visible = true;

            dgvJob.Rows.Add();
            dgvJob["dgvJobCol0", 0].Value = "철근";
            dgvJob.Rows.Add();
            dgvJob["dgvJobCol0", 1].Value = "토목";            
            dgvJob["dgvJobCol0", 2].Value = "덕트";
            */
        }

        private void Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.connection.Close();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
