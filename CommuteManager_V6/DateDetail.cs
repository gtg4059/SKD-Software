using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using xc = Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Globalization;


namespace CommuteManager_V6
{
    public partial class DateDetail : Form
    {
        CommuteManager formMain = new CommuteManager();
        SQLServer server = new SQLServer();
        DateTime it, ft;
        /*xc.Application xcApp = null;
        xc.Workbook wb = null;
        xc.Worksheet ws = null;*/
        public bool flag;
        List<worker> listW = new List<worker>();

        public DateDetail()
        {
            InitializeComponent();
        }

        public class worker
        {
            public string name, job, date, status, tag, gate;
            public int cnt, sumTime;


            public worker()
            {
                this.name = null;
                this.job = null;
                this.date = null;
                this.status = null;
                this.cnt = 0;
            }

            public worker(string sname, string sjob, string sdate, string sStatus, string _tag, string _gate)
            {
                this.name = sname;
                this.job = sjob;
                this.date = sdate;
                this.status = sStatus;
                this.tag = _tag;
                this.gate = _gate;
            }
            public worker(string sname, string sjob, string sdate)
            {
                this.name = sname;
                this.job = sjob;
                this.date = sdate;

            }
        }

        public class dWorker
        {
            public string tag, job, name;
            public int cnt, time;

            public dWorker()
            {

            }

            public dWorker(string name, string tag, string job, int cnt, int time)
            {
                this.name = name;
                this.tag = tag;
                this.job = job;
                this.cnt = cnt;
                this.time = time;
            }
        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!flag)
            {
                lblInit.Text = monthCalendar1.SelectionStart.ToShortDateString();
                flag = !flag;
            }
            else
            {
                lblFinal.Text = monthCalendar1.SelectionStart.ToShortDateString();
                flag = !flag;
            }

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            List<dWorker> ldWorker = new List<dWorker>();
            ldWorker.Clear();
            List<worker> listWorker = new List<worker>();
            listWorker.Clear();
            try
            {
                string strqry = "select count(*) from Logs";
                server.GetDBTable(strqry);
                server.sdr.Read();
                Int32 nInLastRow = server.sdr.GetInt32(0);
                server.sdr.Close();

                DateTime ot = new DateTime();
                strqry = "select * from Logs ORDER BY row";
                server.GetDBTable(strqry);

                int row = 0, rowf = 0;
                string status = null, tag = null, gate = null;
                string date = null, pdate = null, pname = null, name = null, job = null;
                bool isFound = false, isInit = false;
                lvDate.Items.Clear();

                it = Convert.ToDateTime(lblInit.Text);
                ft = Convert.ToDateTime(lblFinal.Text);

                if (it.CompareTo(ft) > 0)
                {
                    it = Convert.ToDateTime(lblFinal.Text);
                    ft = Convert.ToDateTime(lblInit.Text);
                }

                for (int i = 0; i < nInLastRow; i++)
                {
                    server.sdr.Read();
                    date = server.sdr.GetString(1);
                    ot = DateTime.ParseExact(date, "yyyy-MM-dd-HH:mm:ss", CultureInfo.InvariantCulture);
                    if (ot.CompareTo(it) >= 0)
                    {
                        row = i;
                        break;
                    }
                }

                isInit = true;

                for (int i = row + 1; i < nInLastRow; i++)
                {
                    server.sdr.Read();
                    date = server.sdr.GetString(1);
                    ot = DateTime.ParseExact(date, "yyyy-MM-dd-HH:mm:ss", CultureInfo.InvariantCulture);

                    if (isInit)
                    {
                        System.TimeSpan span = new System.TimeSpan(1, 0, 0, 0);
                        ft = ft + span;
                        isInit = false;
                    }

                    if (ot.CompareTo(ft) != -1)
                    {
                        rowf = i;
                        isFound = true;
                        break;
                    }
                }

                server.sdr.Close();
                if (!isFound) rowf = nInLastRow;
                strqry = "SELECT* FROM Logs where row > " + row + " AND row<" + (rowf) + "order by row";
                server.GetDBTable(strqry);

                for (int i = row; i < rowf; i++)
                {

                    server.sdr.Read();
                    date = server.sdr.GetString(1);
                    name = server.sdr.GetString(3);
                    tag = server.sdr.GetString(4);
                    gate = server.sdr.GetString(5);
                    status = server.sdr.GetString(2); //IN/OUT
                    job = server.sdr.GetString(6); //공종

                    worker wk = new worker(name, job, date, status, tag, gate);
                    listWorker.Add(wk);
                    dWorker dw = new dWorker(name, tag, job, 0, 0);
                    ldWorker.Add(dw);

                }
            }
            catch
            {

            }
            for (int i = ldWorker.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (ldWorker[i].tag == ldWorker[j].tag)
                    {
                        ldWorker.RemoveAt(j);
                        i--;
                    }
                }
            }
            server.sdr.Close();
            string[] pday = new string[ldWorker.Count];
            
            bool[] dayflag = new bool[ldWorker.Count];
            string ppname = null;
            string pptag = null;
            int cnt = ldWorker.Count;
            for (int i = 0; i < listWorker.Count; i++)
            {
                bool foundEnd = false;
                string Dname = null; string day = null, time = null, day2 = null, time2 = null;
                string[] gateSplit = listWorker[i].gate.Split('-');
                int dt = 0;
                
                if (listWorker[i].status.Substring(0, 1) == "입" && gateSplit.Length == 1) //MG  들어오는거 발견
                {
                    //Dname = listWorker[i].name;
                    //if (listWorker[i].name != Dname) pday = null;

                    day = listWorker[i].date.Substring(0, 10);
                    time = listWorker[i].date.Substring(11, 5); //출근했으면


                    
                    for (int j = i + 1; j < listWorker.Count; j++)
                    {
                        string[] gateSplit2 = listWorker[j].gate.Split('-'); //메인게이트
                        if (listWorker[i].date.Substring(0, 10) == listWorker[j].date.Substring(0, 10))
                        {
                            if (listWorker[i].name == listWorker[j].name && listWorker[j].status.Substring(0, 1) == "출"
                                && gateSplit2.Length == 1)
                            {
                                time2 = listWorker[j].date.Substring(11, 5);

                                foreach (dWorker dw in ldWorker)
                                {
                                    if (dw.tag == listWorker[i].tag && cnt>=1) //&& listWorker[i].date.Substring(0, 10) == listWorker[j].date.Substring(0, 10))
                                    {
                                        if (day != pday[cnt-1])
                                        {
                                            dw.cnt++;
                                            cnt--;
                                            break;
                                        }

                                    }

                                }
                                break;
                            }
                        }
                        else
                        {
                            time2 = "18:00";
                            foreach (dWorker dw in ldWorker)
                            {
                                if (dw.tag == listWorker[i].tag)
                                {
                                    dw.cnt++;
                                    break;
                                }
                            }
                            break;
                        }

                    }
                    if(cnt>=0 && cnt<ldWorker.Count) pday[cnt] = day;

                }

                if (time != null && time2 != null)
                {
                    DateTime itime = Convert.ToDateTime(time);
                    DateTime ftime = Convert.ToDateTime(time2);
                    if (itime == ftime)
                    {
                        dt = 0;
                    }
                    else
                    {
                        TimeSpan dtime = ftime - itime;
                        dt = dtime.Hours * 60 + dtime.Minutes;
                    }
                    foundEnd = false;
                }
                foreach (dWorker dw in ldWorker)
                {
                    if (dw.tag == listWorker[i].tag)
                    {
                        dw.time += dt;
                        break;
                    }
                }

            }


            foreach (dWorker dw in ldWorker)
            {
                ListViewItem item = new ListViewItem(dw.name);
                item.SubItems.Add(dw.job);
                item.SubItems.Add(dw.cnt.ToString());
                item.SubItems.Add((dw.time / 60).ToString());
                lvDate.Items.Add(item);
            }

            /* for (int k = lvDate.Items.Count - 1; k >= 0; k--)
             {
                 string na = lvDate.Items[k].SubItems[0].Text;
                 string ti = lvDate.Items[k].SubItems[2].Text;
                 for (int l = k - 1; l >= 0; l--)
                 {
                     if (na == lvDate.Items[l].SubItems[0].Text && ti == lvDate.Items[l].SubItems[2].Text)
                     {
                         lvDate.Items.RemoveAt(l);
                         k--;
                     }
                 }
             }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string gate = "", status = "";
            string wDay = "", wTime = "";
            try
            {
                List<worker> listWorker = new List<worker>();
                listWorker.Clear();
                if (txtName.Text != "")
                {
                    string name = txtName.Text;
                    for (int j = lvDate.Items.Count - 1; j >= 0; j--)
                        if (name != lvDate.Items[j].SubItems[0].Text) lvDate.Items.RemoveAt(j);
                }

                else
                {
                    string strqry = "select count(*) from Logs";
                    server.GetDBTable(strqry);
                    server.sdr.Read();
                    Int32 nInLastRow = server.sdr.GetInt32(0) - 1;
                    server.sdr.Close();
                    listW.Clear();

                    bool isFound = false;

                    DateTime ot = new DateTime();

                    strqry = "select * from Logs ORDER BY row";
                    server.GetDBTable(strqry);

                    int row = 0, col = 0;
                    int rowf = 0, colf = 0;
                    string date = null;
                    string pdate = null;
                    string pname = null;
                    string name, job;
                    lvDate.Items.Clear();

                    it = Convert.ToDateTime(lblInit.Text);
                    ft = Convert.ToDateTime(lblFinal.Text);

                    if (it.CompareTo(ft) > 0)
                    {
                        it = Convert.ToDateTime(lblFinal.Text);
                        ft = Convert.ToDateTime(lblInit.Text);
                    }

                    for (int i = 0; i < nInLastRow; i++)
                    {
                        server.sdr.Read();
                        date = server.sdr.GetString(1);
                        date = date.Substring(0, 10);
                        ot = Convert.ToDateTime(date);
                        if (ot.CompareTo(it) >= 0)
                        {
                            row = i;
                            break;
                        }
                    }

                    bool a = true;
                    for (int i = row; i < nInLastRow; i++)
                    {
                        server.sdr.Read();
                        date = server.sdr.GetString(1);
                        date = date.Substring(0, 10);
                        ot = Convert.ToDateTime(date);
                        if (a)
                        {
                            System.TimeSpan span = new System.TimeSpan(1, 0, 0, 0);
                            ft = ft + span;
                            a = false;
                        }
                        //MessageBox.Show(ot.ToString());
                        //                    MessageBox.Show(ot.CompareTo(ft).ToString());
                        if (ot.CompareTo(ft) != -1)
                        {
                            rowf = i + 1;
                            isFound = true;
                            break;
                        }
                    }

                    server.sdr.Close();
                    if (!isFound) rowf = nInLastRow;
                    strqry = "SELECT* FROM Logs where row > " + row + " AND row<" + rowf + "order by row";
                    server.GetDBTable(strqry);

                    try
                    {
                        for (int i = row; i < rowf; i++)
                        {
                            server.sdr.Read();
                            date = server.sdr.GetString(1);
                            status = server.sdr.GetString(2);
                            date = date.Substring(0, 16);
                            name = server.sdr.GetString(3);
                            gate = server.sdr.GetString(5);
                            //if (date.Substring(18) == ":") date = date.Substring(0, 16);

                            if (date == pdate && pname == name) continue;

                            job = server.sdr.GetString(6);
                            worker wk = new worker(name, job, date);
                            listWorker.Add(wk);
                            pdate = date;
                            pname = name;
                        }
                        server.sdr.Close();
                    }
                    catch { server.sdr.Close(); }

                    foreach (worker wk in listWorker)
                    {
                        ListViewItem item = new ListViewItem(wk.name);
                        item.SubItems.Add(wk.job);
                        item.SubItems.Add(wk.date);
                        lvDate.Items.Add(item);
                    }

                    for (int k = lvDate.Items.Count - 1; k >= 0; k--)
                    {
                        string na = lvDate.Items[k].SubItems[0].Text;
                        string ti = lvDate.Items[k].SubItems[2].Text;
                        for (int l = k - 1; l >= 0; l--)
                        {
                            if (na == lvDate.Items[l].SubItems[0].Text && ti == lvDate.Items[l].SubItems[2].Text)
                            {
                                lvDate.Items.RemoveAt(l);
                                k--;
                            }
                        }
                    }

                }

                try
                {
                    if (comboJob.SelectedItem.ToString() != "")
                    {
                        string name = comboJob.SelectedItem.ToString();
                        for (int j = lvDate.Items.Count - 1; j >= 0; j--)
                            if (name != lvDate.Items[j].SubItems[1].Text) lvDate.Items.RemoveAt(j);
                    }
                }
                catch { }

                if (txtName.Text != "")
                {
                    string name = txtName.Text;
                    for (int j = lvDate.Items.Count - 1; j >= 0; j--)
                        if (name != lvDate.Items[j].SubItems[0].Text) lvDate.Items.RemoveAt(j);
                }
            }
            catch
            {

            }


        }



        private void lvDate_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            int sortColumn = -1;
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                lvDate.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (lvDate.Sorting == SortOrder.Ascending) lvDate.Sorting = SortOrder.Descending;
                else lvDate.Sorting = SortOrder.Ascending;
            }

            lvDate.Sort();
            this.lvDate.ListViewItemSorter = new MyListViewComparer(e.Column, lvDate.Sorting);
        }

        private void DateDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.SQLClose();
        }

        private void DateDetail_Load(object sender, EventArgs e)
        {


        }

        private void comboJob_MouseDown(object sender, MouseEventArgs e)
        {
            comboJob.Items.Clear();
            for (int i = 0; i < formMain.listJob.Count; i++) comboJob.Items.Add(formMain.listJob[i]);
        }

        private void lvDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        class MyListViewComparer : IComparer
        {
            private int col; private SortOrder order; public MyListViewComparer() { col = 0; order = SortOrder.Ascending; }
            public MyListViewComparer(int column, SortOrder order) { col = column; this.order = order; }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending. 
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1; return returnVal;
            }
        }

    }
}
