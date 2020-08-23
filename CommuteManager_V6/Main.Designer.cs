namespace CommuteManager_V6
{
	partial class CommuteManager
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommuteManager));
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitBtn_Mode = new System.Windows.Forms.ToolStripSplitButton();
            this.활성화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_TagMonitor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_MainRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_ServerStart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDetail = new System.Windows.Forms.ToolStripButton();
            this.tsComboxInout = new System.Windows.Forms.ToolStripComboBox();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.ListViewHeader_MainTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_MainCommute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_MainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_MainID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_MainGATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_MainJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListviewHeader_MainLoca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListviewHeader_MainCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip_People = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddPeople = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ModifyPeople = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DeletePeople = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox_Search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_Search = new System.Windows.Forms.ToolStripButton();
            this.listView_People = new System.Windows.Forms.ListView();
            this.ListViewHeader_PeopleStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_PeopleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_PeopleTagID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_PeopleJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewHeader_PeopleCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.lbltime = new System.Windows.Forms.ToolStripLabel();
            this.serialPort_RFID = new System.IO.Ports.SerialPort(this.components);
            this.timer_CommuteCheck = new System.Windows.Forms.Timer(this.components);
            this.panLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWho = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblGate5 = new System.Windows.Forms.Label();
            this.Led5_1 = new System.Windows.Forms.PictureBox();
            this.Led5_2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblGate4 = new System.Windows.Forms.Label();
            this.Led4_1 = new System.Windows.Forms.PictureBox();
            this.Led4_2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblGate3 = new System.Windows.Forms.Label();
            this.Led3_1 = new System.Windows.Forms.PictureBox();
            this.Led3_2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblGate2 = new System.Windows.Forms.Label();
            this.Led2_1 = new System.Windows.Forms.PictureBox();
            this.Led2_2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Led1_1 = new System.Windows.Forms.PictureBox();
            this.lblGate1 = new System.Windows.Forms.Label();
            this.Led1_2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.btn활성화 = new System.Windows.Forms.Button();
            this.btnTagMonitor = new System.Windows.Forms.Button();
            this.btn대기 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnSupervisor = new System.Windows.Forms.Button();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.panSupervisor = new System.Windows.Forms.Panel();
            this.lvSup = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkJob = new System.Windows.Forms.CheckBox();
            this.chkTotal = new System.Windows.Forms.CheckBox();
            this.btnRegisor = new System.Windows.Forms.Button();
            this.txtSupPw = new System.Windows.Forms.TextBox();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip_main.SuspendLayout();
            this.toolStrip_People.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led5_2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led4_2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led3_2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led2_2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led1_2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panSupervisor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip_main.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting,
            this.toolStripSeparator2,
            this.btnConnect,
            this.toolStripSeparator3,
            this.toolStripSplitBtn_Mode,
            this.toolStripSeparator4,
            this.toolStripButton_TagMonitor,
            this.toolStripSeparator5,
            this.toolStripButton_MainRefresh,
            this.toolStripSeparator6,
            this.toolStripButton_ServerStart,
            this.tsbtnDetail,
            this.tsComboxInout});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(1190, 39);
            this.toolStrip_main.TabIndex = 1;
            this.toolStrip_main.Text = "toolStrip1";
            this.toolStrip_main.Visible = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::CommuteManager_V6.Properties.Resources.Image_Setting;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(67, 36);
            this.btnSetting.Text = "설정";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::CommuteManager_V6.Properties.Resources.Image_X;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 36);
            this.btnConnect.Text = "연결";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSplitBtn_Mode
            // 
            this.toolStripSplitBtn_Mode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.활성화ToolStripMenuItem,
            this.대기ToolStripMenuItem});
            this.toolStripSplitBtn_Mode.Image = global::CommuteManager_V6.Properties.Resources.Image_ComeStop;
            this.toolStripSplitBtn_Mode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitBtn_Mode.Name = "toolStripSplitBtn_Mode";
            this.toolStripSplitBtn_Mode.Size = new System.Drawing.Size(79, 36);
            this.toolStripSplitBtn_Mode.Text = "모드";
            // 
            // 활성화ToolStripMenuItem
            // 
            this.활성화ToolStripMenuItem.Image = global::CommuteManager_V6.Properties.Resources.Image_ComeIn;
            this.활성화ToolStripMenuItem.Name = "활성화ToolStripMenuItem";
            this.활성화ToolStripMenuItem.Size = new System.Drawing.Size(126, 38);
            this.활성화ToolStripMenuItem.Text = "활성화";
            this.활성화ToolStripMenuItem.Click += new System.EventHandler(this.활성화ToolStripMenuItem_Click);
            // 
            // 대기ToolStripMenuItem
            // 
            this.대기ToolStripMenuItem.Image = global::CommuteManager_V6.Properties.Resources.Image_ComeStop1;
            this.대기ToolStripMenuItem.Name = "대기ToolStripMenuItem";
            this.대기ToolStripMenuItem.Size = new System.Drawing.Size(126, 38);
            this.대기ToolStripMenuItem.Text = "대기";
            this.대기ToolStripMenuItem.Click += new System.EventHandler(this.대기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton_TagMonitor
            // 
            this.toolStripButton_TagMonitor.Image = global::CommuteManager_V6.Properties.Resources.Image_Tag;
            this.toolStripButton_TagMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_TagMonitor.Name = "toolStripButton_TagMonitor";
            this.toolStripButton_TagMonitor.Size = new System.Drawing.Size(67, 36);
            this.toolStripButton_TagMonitor.Text = "태그";
            this.toolStripButton_TagMonitor.Click += new System.EventHandler(this.toolStripButton_TagMonitor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton_MainRefresh
            // 
            this.toolStripButton_MainRefresh.Image = global::CommuteManager_V6.Properties.Resources.Image_New;
            this.toolStripButton_MainRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MainRefresh.Name = "toolStripButton_MainRefresh";
            this.toolStripButton_MainRefresh.Size = new System.Drawing.Size(79, 36);
            this.toolStripButton_MainRefresh.Text = "초기화";
            this.toolStripButton_MainRefresh.Click += new System.EventHandler(this.toolStripButton_MainRefresh_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton_ServerStart
            // 
            this.toolStripButton_ServerStart.Image = global::CommuteManager_V6.Properties.Resources.Image_Close;
            this.toolStripButton_ServerStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ServerStart.Name = "toolStripButton_ServerStart";
            this.toolStripButton_ServerStart.Size = new System.Drawing.Size(99, 36);
            this.toolStripButton_ServerStart.Text = "시작(서버)";
            this.toolStripButton_ServerStart.Click += new System.EventHandler(this.toolStripButton_ServerStart_Click);
            // 
            // tsbtnDetail
            // 
            this.tsbtnDetail.Image = global::CommuteManager_V6.Properties.Resources.Image_ComeIn;
            this.tsbtnDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDetail.Name = "tsbtnDetail";
            this.tsbtnDetail.Size = new System.Drawing.Size(95, 36);
            this.tsbtnDetail.Text = "출입 현황";
            this.tsbtnDetail.Click += new System.EventHandler(this.tsbtnDetail_Click);
            // 
            // tsComboxInout
            // 
            this.tsComboxInout.Items.AddRange(new object[] {
            "전체 현황",
            "공종별 현황",
            "일자별 현황"});
            this.tsComboxInout.Name = "tsComboxInout";
            this.tsComboxInout.Size = new System.Drawing.Size(121, 39);
            this.tsComboxInout.Text = "출입 현황";
            this.tsComboxInout.ToolTipText = "출입현황을 선택하세요.";
            this.tsComboxInout.TextChanged += new System.EventHandler(this.tsComboxInout_TextChanged_1);
            // 
            // listView_Main
            // 
            this.listView_Main.BackColor = System.Drawing.Color.White;
            this.listView_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewHeader_MainTime,
            this.ListViewHeader_MainCommute,
            this.ListViewHeader_MainName,
            this.ListViewHeader_MainID,
            this.ListViewHeader_MainGATE,
            this.ListViewHeader_MainJob,
            this.ListviewHeader_MainLoca,
            this.ListviewHeader_MainCompany});
            this.listView_Main.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(20, 515);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(828, 498);
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Main_ColumnClick);
            // 
            // ListViewHeader_MainTime
            // 
            this.ListViewHeader_MainTime.Text = "시간";
            this.ListViewHeader_MainTime.Width = 157;
            // 
            // ListViewHeader_MainCommute
            // 
            this.ListViewHeader_MainCommute.Text = "출/입";
            this.ListViewHeader_MainCommute.Width = 53;
            // 
            // ListViewHeader_MainName
            // 
            this.ListViewHeader_MainName.Text = "이름";
            this.ListViewHeader_MainName.Width = 82;
            // 
            // ListViewHeader_MainID
            // 
            this.ListViewHeader_MainID.Text = "태그ID";
            this.ListViewHeader_MainID.Width = 267;
            // 
            // ListViewHeader_MainGATE
            // 
            this.ListViewHeader_MainGATE.Text = "GATE";
            this.ListViewHeader_MainGATE.Width = 73;
            // 
            // ListViewHeader_MainJob
            // 
            this.ListViewHeader_MainJob.Text = "공종";
            this.ListViewHeader_MainJob.Width = 49;
            // 
            // ListviewHeader_MainLoca
            // 
            this.ListviewHeader_MainLoca.Text = "위치";
            this.ListviewHeader_MainLoca.Width = 83;
            // 
            // ListviewHeader_MainCompany
            // 
            this.ListviewHeader_MainCompany.Text = "회사";
            this.ListviewHeader_MainCompany.Width = 65;
            // 
            // toolStrip_People
            // 
            this.toolStrip_People.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_People.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddPeople,
            this.toolStripButton_ModifyPeople,
            this.toolStripButton_DeletePeople,
            this.toolStripSeparator1,
            this.toolStripButton_Refresh,
            this.toolStripTextBox_Search,
            this.toolStripButton_Search});
            this.toolStrip_People.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_People.Name = "toolStrip_People";
            this.toolStrip_People.Size = new System.Drawing.Size(1190, 27);
            this.toolStrip_People.TabIndex = 2;
            this.toolStrip_People.Text = "toolStrip1";
            this.toolStrip_People.Visible = false;
            // 
            // toolStripButton_AddPeople
            // 
            this.toolStripButton_AddPeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AddPeople.Image = global::CommuteManager_V6.Properties.Resources.Image_PeopleNew;
            this.toolStripButton_AddPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddPeople.Name = "toolStripButton_AddPeople";
            this.toolStripButton_AddPeople.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_AddPeople.Click += new System.EventHandler(this.toolStripButton_AddPeople_Click);
            // 
            // toolStripButton_ModifyPeople
            // 
            this.toolStripButton_ModifyPeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ModifyPeople.Image = global::CommuteManager_V6.Properties.Resources.Image_PeopleModify;
            this.toolStripButton_ModifyPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ModifyPeople.Name = "toolStripButton_ModifyPeople";
            this.toolStripButton_ModifyPeople.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_ModifyPeople.Text = "toolStripButton2";
            // 
            // toolStripButton_DeletePeople
            // 
            this.toolStripButton_DeletePeople.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DeletePeople.Image = global::CommuteManager_V6.Properties.Resources.Image_PeopleDelete;
            this.toolStripButton_DeletePeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeletePeople.Name = "toolStripButton_DeletePeople";
            this.toolStripButton_DeletePeople.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_DeletePeople.Text = "toolStripButton3";
            this.toolStripButton_DeletePeople.Click += new System.EventHandler(this.toolStripButton_DeletePeople_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Refresh.Image = global::CommuteManager_V6.Properties.Resources.Image_Refresh;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Refresh.Text = "toolStripButton4";
            // 
            // toolStripTextBox_Search
            // 
            this.toolStripTextBox_Search.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_Search.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox_Search.Name = "toolStripTextBox_Search";
            this.toolStripTextBox_Search.Size = new System.Drawing.Size(96, 27);
            // 
            // toolStripButton_Search
            // 
            this.toolStripButton_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Search.Image = global::CommuteManager_V6.Properties.Resources.Image_Search;
            this.toolStripButton_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Search.Name = "toolStripButton_Search";
            this.toolStripButton_Search.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Search.Text = "toolStripButton5";
            // 
            // listView_People
            // 
            this.listView_People.BackColor = System.Drawing.Color.White;
            this.listView_People.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_People.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewHeader_PeopleStatus,
            this.ListViewHeader_PeopleName,
            this.ListViewHeader_PeopleTagID,
            this.ListViewHeader_PeopleJob,
            this.ListViewHeader_PeopleCompany});
            this.listView_People.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView_People.FullRowSelect = true;
            this.listView_People.GridLines = true;
            this.listView_People.HideSelection = false;
            this.listView_People.Location = new System.Drawing.Point(871, 262);
            this.listView_People.Name = "listView_People";
            this.listView_People.Size = new System.Drawing.Size(690, 751);
            this.listView_People.TabIndex = 4;
            this.listView_People.UseCompatibleStateImageBehavior = false;
            this.listView_People.View = System.Windows.Forms.View.Details;
            this.listView_People.DoubleClick += new System.EventHandler(this.listView_People_DoubleClick);
            this.listView_People.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_People_KeyDown);
            // 
            // ListViewHeader_PeopleStatus
            // 
            this.ListViewHeader_PeopleStatus.Text = "상태";
            this.ListViewHeader_PeopleStatus.Width = 93;
            // 
            // ListViewHeader_PeopleName
            // 
            this.ListViewHeader_PeopleName.Text = "이름";
            this.ListViewHeader_PeopleName.Width = 95;
            // 
            // ListViewHeader_PeopleTagID
            // 
            this.ListViewHeader_PeopleTagID.Text = "태그ID";
            this.ListViewHeader_PeopleTagID.Width = 325;
            // 
            // ListViewHeader_PeopleJob
            // 
            this.ListViewHeader_PeopleJob.Text = "공종";
            this.ListViewHeader_PeopleJob.Width = 63;
            // 
            // ListViewHeader_PeopleCompany
            // 
            this.ListViewHeader_PeopleCompany.Text = "회사";
            this.ListViewHeader_PeopleCompany.Width = 115;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lbltime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1002);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1891, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 22);
            this.lblStatus.Text = "NSCL";
            // 
            // lbltime
            // 
            this.lbltime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltime.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(211, 20);
            this.lbltime.Text = "0000년 00월 00일  00:00:00시";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_CommuteCheck
            // 
            this.timer_CommuteCheck.Enabled = true;
            this.timer_CommuteCheck.Interval = 20;
            this.timer_CommuteCheck.Tick += new System.EventHandler(this.timer_CommuteCheck_Tick);
            // 
            // panLogin
            // 
            this.panLogin.BackColor = System.Drawing.Color.White;
            this.panLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLogin.Controls.Add(this.pictureBox1);
            this.panLogin.Controls.Add(this.lblWho);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.txtId);
            this.panLogin.Location = new System.Drawing.Point(470, 262);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(378, 230);
            this.panLogin.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CommuteManager_V6.Properties.Resources.skd;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 120);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.BackColor = System.Drawing.Color.Transparent;
            this.lblWho.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWho.Location = new System.Drawing.Point(10, 42);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(68, 17);
            this.lblWho.TabIndex = 16;
            this.lblWho.Text = "label1";
            this.lblWho.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_lock_963;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Location = new System.Drawing.Point(240, 93);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 120);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPassword.Location = new System.Drawing.Point(100, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(260, 26);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "1234";
            this.txtPassword.Click += new System.EventHandler(this.txtPw_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtId.Location = new System.Drawing.Point(100, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(260, 26);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "ID를 입력하세요.";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblGate5);
            this.panel8.Controls.Add(this.Led5_1);
            this.panel8.Controls.Add(this.Led5_2);
            this.panel8.Location = new System.Drawing.Point(606, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 25);
            this.panel8.TabIndex = 44;
            this.panel8.Visible = false;
            // 
            // lblGate5
            // 
            this.lblGate5.AutoSize = true;
            this.lblGate5.Location = new System.Drawing.Point(13, 5);
            this.lblGate5.Name = "lblGate5";
            this.lblGate5.Size = new System.Drawing.Size(78, 17);
            this.lblGate5.TabIndex = 36;
            this.lblGate5.Text = "GATE5:";
            // 
            // Led5_1
            // 
            this.Led5_1.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led5_1.Location = new System.Drawing.Point(107, 2);
            this.Led5_1.Name = "Led5_1";
            this.Led5_1.Size = new System.Drawing.Size(20, 20);
            this.Led5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led5_1.TabIndex = 35;
            this.Led5_1.TabStop = false;
            // 
            // Led5_2
            // 
            this.Led5_2.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led5_2.Location = new System.Drawing.Point(129, 2);
            this.Led5_2.Name = "Led5_2";
            this.Led5_2.Size = new System.Drawing.Size(20, 20);
            this.Led5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led5_2.TabIndex = 37;
            this.Led5_2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblGate4);
            this.panel7.Controls.Add(this.Led4_1);
            this.panel7.Controls.Add(this.Led4_2);
            this.panel7.Location = new System.Drawing.Point(606, 116);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(177, 25);
            this.panel7.TabIndex = 43;
            this.panel7.Visible = false;
            // 
            // lblGate4
            // 
            this.lblGate4.AutoSize = true;
            this.lblGate4.Location = new System.Drawing.Point(13, 5);
            this.lblGate4.Name = "lblGate4";
            this.lblGate4.Size = new System.Drawing.Size(78, 17);
            this.lblGate4.TabIndex = 27;
            this.lblGate4.Text = "GATE4:";
            // 
            // Led4_1
            // 
            this.Led4_1.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led4_1.Location = new System.Drawing.Point(107, 2);
            this.Led4_1.Name = "Led4_1";
            this.Led4_1.Size = new System.Drawing.Size(20, 20);
            this.Led4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led4_1.TabIndex = 25;
            this.Led4_1.TabStop = false;
            // 
            // Led4_2
            // 
            this.Led4_2.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led4_2.Location = new System.Drawing.Point(129, 2);
            this.Led4_2.Name = "Led4_2";
            this.Led4_2.Size = new System.Drawing.Size(20, 20);
            this.Led4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led4_2.TabIndex = 32;
            this.Led4_2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblGate3);
            this.panel6.Controls.Add(this.Led3_1);
            this.panel6.Controls.Add(this.Led3_2);
            this.panel6.Location = new System.Drawing.Point(606, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 25);
            this.panel6.TabIndex = 42;
            this.panel6.Visible = false;
            // 
            // lblGate3
            // 
            this.lblGate3.AutoSize = true;
            this.lblGate3.Location = new System.Drawing.Point(13, 7);
            this.lblGate3.Name = "lblGate3";
            this.lblGate3.Size = new System.Drawing.Size(78, 17);
            this.lblGate3.TabIndex = 28;
            this.lblGate3.Text = "GATE3:";
            // 
            // Led3_1
            // 
            this.Led3_1.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led3_1.Location = new System.Drawing.Point(107, 2);
            this.Led3_1.Name = "Led3_1";
            this.Led3_1.Size = new System.Drawing.Size(20, 20);
            this.Led3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led3_1.TabIndex = 26;
            this.Led3_1.TabStop = false;
            // 
            // Led3_2
            // 
            this.Led3_2.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led3_2.Location = new System.Drawing.Point(129, 2);
            this.Led3_2.Name = "Led3_2";
            this.Led3_2.Size = new System.Drawing.Size(20, 20);
            this.Led3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led3_2.TabIndex = 29;
            this.Led3_2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblGate2);
            this.panel5.Controls.Add(this.Led2_1);
            this.panel5.Controls.Add(this.Led2_2);
            this.panel5.Location = new System.Drawing.Point(606, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 25);
            this.panel5.TabIndex = 41;
            this.panel5.Visible = false;
            // 
            // lblGate2
            // 
            this.lblGate2.AutoSize = true;
            this.lblGate2.Location = new System.Drawing.Point(13, 4);
            this.lblGate2.Name = "lblGate2";
            this.lblGate2.Size = new System.Drawing.Size(78, 17);
            this.lblGate2.TabIndex = 18;
            this.lblGate2.Text = "GATE2:";
            // 
            // Led2_1
            // 
            this.Led2_1.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led2_1.Location = new System.Drawing.Point(107, 2);
            this.Led2_1.Name = "Led2_1";
            this.Led2_1.Size = new System.Drawing.Size(20, 20);
            this.Led2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led2_1.TabIndex = 17;
            this.Led2_1.TabStop = false;
            // 
            // Led2_2
            // 
            this.Led2_2.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led2_2.Location = new System.Drawing.Point(129, 2);
            this.Led2_2.Name = "Led2_2";
            this.Led2_2.Size = new System.Drawing.Size(20, 20);
            this.Led2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led2_2.TabIndex = 22;
            this.Led2_2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Led1_1);
            this.panel4.Controls.Add(this.lblGate1);
            this.panel4.Controls.Add(this.Led1_2);
            this.panel4.Location = new System.Drawing.Point(606, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 25);
            this.panel4.TabIndex = 40;
            this.panel4.Visible = false;
            // 
            // Led1_1
            // 
            this.Led1_1.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led1_1.Location = new System.Drawing.Point(107, 3);
            this.Led1_1.Name = "Led1_1";
            this.Led1_1.Size = new System.Drawing.Size(20, 20);
            this.Led1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led1_1.TabIndex = 17;
            this.Led1_1.TabStop = false;
            // 
            // lblGate1
            // 
            this.lblGate1.AutoSize = true;
            this.lblGate1.Location = new System.Drawing.Point(13, 3);
            this.lblGate1.Name = "lblGate1";
            this.lblGate1.Size = new System.Drawing.Size(78, 17);
            this.lblGate1.TabIndex = 18;
            this.lblGate1.Text = "GATE1:";
            // 
            // Led1_2
            // 
            this.Led1_2.Image = global::CommuteManager_V6.Properties.Resources.LED_OFF;
            this.Led1_2.Location = new System.Drawing.Point(129, 3);
            this.Led1_2.Name = "Led1_2";
            this.Led1_2.Size = new System.Drawing.Size(20, 20);
            this.Led1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Led1_2.TabIndex = 19;
            this.Led1_2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConnect2);
            this.panel1.Controls.Add(this.btnServerStart);
            this.panel1.Controls.Add(this.btn활성화);
            this.panel1.Controls.Add(this.btnTagMonitor);
            this.panel1.Controls.Add(this.btn대기);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 227);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(78, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "서버";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(480, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "태그 모니터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "대기";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "활성화";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(299, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "연결";
            // 
            // btnConnect2
            // 
            this.btnConnect2.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect2.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_wi_fi_96;
            this.btnConnect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect2.Location = new System.Drawing.Point(19, 21);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(160, 160);
            this.btnConnect2.TabIndex = 7;
            this.btnConnect2.UseVisualStyleBackColor = false;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            this.btnConnect2.MouseHover += new System.EventHandler(this.btnConnect2_MouseHover);
            // 
            // btnServerStart
            // 
            this.btnServerStart.BackColor = System.Drawing.Color.Transparent;
            this.btnServerStart.BackgroundImage = global::CommuteManager_V6.Properties.Resources._0;
            this.btnServerStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServerStart.Location = new System.Drawing.Point(237, 21);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(160, 160);
            this.btnServerStart.TabIndex = 11;
            this.btnServerStart.UseVisualStyleBackColor = false;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            this.btnServerStart.MouseHover += new System.EventHandler(this.btnServerStart_MouseHover);
            // 
            // btn활성화
            // 
            this.btn활성화.BackColor = System.Drawing.Color.White;
            this.btn활성화.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_checked_480;
            this.btn활성화.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn활성화.Location = new System.Drawing.Point(108, 34);
            this.btn활성화.Name = "btn활성화";
            this.btn활성화.Size = new System.Drawing.Size(187, 186);
            this.btn활성화.TabIndex = 8;
            this.btn활성화.UseVisualStyleBackColor = false;
            this.btn활성화.Visible = false;
            this.btn활성화.Click += new System.EventHandler(this.btn활성화_Click);
            this.btn활성화.MouseHover += new System.EventHandler(this.btn활성화_MouseHover);
            // 
            // btnTagMonitor
            // 
            this.btnTagMonitor.BackColor = System.Drawing.Color.Transparent;
            this.btnTagMonitor.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_rfid_sensor_96;
            this.btnTagMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTagMonitor.Location = new System.Drawing.Point(449, 21);
            this.btnTagMonitor.Name = "btnTagMonitor";
            this.btnTagMonitor.Size = new System.Drawing.Size(160, 160);
            this.btnTagMonitor.TabIndex = 9;
            this.btnTagMonitor.UseVisualStyleBackColor = false;
            this.btnTagMonitor.Click += new System.EventHandler(this.btnTagMonitor_Click);
            this.btnTagMonitor.MouseHover += new System.EventHandler(this.btnTagMonitor_MouseHover);
            // 
            // btn대기
            // 
            this.btn대기.BackColor = System.Drawing.Color.White;
            this.btn대기.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_pause_button_96;
            this.btn대기.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn대기.Enabled = false;
            this.btn대기.Location = new System.Drawing.Point(767, 3);
            this.btn대기.Name = "btn대기";
            this.btn대기.Size = new System.Drawing.Size(200, 200);
            this.btn대기.TabIndex = 8;
            this.btn대기.UseVisualStyleBackColor = false;
            this.btn대기.Visible = false;
            this.btn대기.Click += new System.EventHandler(this.btn대기_Click);
            this.btn대기.MouseHover += new System.EventHandler(this.btn대기_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lblJob);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnJob);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.btnTotal);
            this.panel2.Location = new System.Drawing.Point(745, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 227);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(464, 194);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 17);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "일자별 현황";
            this.lblDate.Visible = false;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblJob.Location = new System.Drawing.Point(266, 194);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(96, 17);
            this.lblJob.TabIndex = 14;
            this.lblJob.Text = "공종별 현황";
            this.lblJob.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(60, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 17);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "전체 현황";
            this.lblTotal.Visible = false;
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.Color.Transparent;
            this.btnJob.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_construction_workers_96;
            this.btnJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJob.Location = new System.Drawing.Point(230, 21);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(160, 160);
            this.btnJob.TabIndex = 14;
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Visible = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            this.btnJob.MouseHover += new System.EventHandler(this.btnJob_MouseHover);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.Transparent;
            this.btnDate.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_calendar_96;
            this.btnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDate.Location = new System.Drawing.Point(432, 21);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(160, 160);
            this.btnDate.TabIndex = 13;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Visible = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            this.btnDate.MouseHover += new System.EventHandler(this.btnDate_MouseHover);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Transparent;
            this.btnTotal.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_bulleted_list_96;
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTotal.Location = new System.Drawing.Point(20, 21);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(160, 160);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Visible = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            this.btnTotal.MouseHover += new System.EventHandler(this.btnTotal_MouseHover);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblAdd);
            this.panel3.Controls.Add(this.btnSupervisor);
            this.panel3.Controls.Add(this.btnAddPeople);
            this.panel3.Location = new System.Drawing.Point(20, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 230);
            this.panel3.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(266, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "관리자 메뉴";
            this.label12.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAdd.Location = new System.Drawing.Point(63, 197);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(96, 17);
            this.lblAdd.TabIndex = 15;
            this.lblAdd.Text = "사용자 등록";
            this.lblAdd.Visible = false;
            // 
            // btnSupervisor
            // 
            this.btnSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.btnSupervisor.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_businessman_96;
            this.btnSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupervisor.Location = new System.Drawing.Point(237, 22);
            this.btnSupervisor.Name = "btnSupervisor";
            this.btnSupervisor.Size = new System.Drawing.Size(160, 160);
            this.btnSupervisor.TabIndex = 14;
            this.btnSupervisor.UseVisualStyleBackColor = false;
            this.btnSupervisor.Visible = false;
            this.btnSupervisor.Click += new System.EventHandler(this.btnSupervisor_Click);
            this.btnSupervisor.MouseHover += new System.EventHandler(this.btnSupervisor_MouseHover);
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPeople.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_worker_96;
            this.btnAddPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPeople.Location = new System.Drawing.Point(25, 22);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(160, 160);
            this.btnAddPeople.TabIndex = 12;
            this.btnAddPeople.UseVisualStyleBackColor = false;
            this.btnAddPeople.Visible = false;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            this.btnAddPeople.MouseHover += new System.EventHandler(this.btnAddPeople_MouseHover);
            // 
            // panSupervisor
            // 
            this.panSupervisor.AutoSize = true;
            this.panSupervisor.BackColor = System.Drawing.Color.White;
            this.panSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupervisor.Controls.Add(this.lvSup);
            this.panSupervisor.Controls.Add(this.groupBox1);
            this.panSupervisor.Location = new System.Drawing.Point(1581, 12);
            this.panSupervisor.Name = "panSupervisor";
            this.panSupervisor.Size = new System.Drawing.Size(314, 1001);
            this.panSupervisor.TabIndex = 15;
            this.panSupervisor.Visible = false;
            // 
            // lvSup
            // 
            this.lvSup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSup.GridLines = true;
            this.lvSup.HideSelection = false;
            this.lvSup.Location = new System.Drawing.Point(3, 206);
            this.lvSup.Name = "lvSup";
            this.lvSup.Size = new System.Drawing.Size(306, 783);
            this.lvSup.TabIndex = 1;
            this.lvSup.UseCompatibleStateImageBehavior = false;
            this.lvSup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PW";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "접근권한";
            this.columnHeader4.Width = 175;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdd);
            this.groupBox1.Controls.Add(this.chkDate);
            this.groupBox1.Controls.Add(this.chkJob);
            this.groupBox1.Controls.Add(this.chkTotal);
            this.groupBox1.Controls.Add(this.btnRegisor);
            this.groupBox1.Controls.Add(this.txtSupPw);
            this.groupBox1.Controls.Add(this.txtSupId);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리자 등록";
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Checked = true;
            this.chkAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdd.Location = new System.Drawing.Point(6, 170);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(107, 21);
            this.chkAdd.TabIndex = 19;
            this.chkAdd.Text = "사용자등록";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(6, 149);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(107, 21);
            this.chkDate.TabIndex = 18;
            this.chkDate.Text = "일자별현황";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkJob
            // 
            this.chkJob.AutoSize = true;
            this.chkJob.Checked = true;
            this.chkJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJob.Location = new System.Drawing.Point(6, 127);
            this.chkJob.Name = "chkJob";
            this.chkJob.Size = new System.Drawing.Size(107, 21);
            this.chkJob.TabIndex = 17;
            this.chkJob.Text = "공종별현황";
            this.chkJob.UseVisualStyleBackColor = true;
            // 
            // chkTotal
            // 
            this.chkTotal.AutoSize = true;
            this.chkTotal.Checked = true;
            this.chkTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotal.Location = new System.Drawing.Point(6, 105);
            this.chkTotal.Name = "chkTotal";
            this.chkTotal.Size = new System.Drawing.Size(91, 21);
            this.chkTotal.TabIndex = 16;
            this.chkTotal.Text = "전체현황";
            this.chkTotal.UseVisualStyleBackColor = true;
            // 
            // btnRegisor
            // 
            this.btnRegisor.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisor.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_name_tag_96;
            this.btnRegisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisor.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRegisor.Location = new System.Drawing.Point(138, 20);
            this.btnRegisor.Name = "btnRegisor";
            this.btnRegisor.Size = new System.Drawing.Size(168, 166);
            this.btnRegisor.TabIndex = 15;
            this.btnRegisor.UseVisualStyleBackColor = false;
            this.btnRegisor.Click += new System.EventHandler(this.btnRegisor_Click);
            // 
            // txtSupPw
            // 
            this.txtSupPw.Location = new System.Drawing.Point(6, 68);
            this.txtSupPw.Name = "txtSupPw";
            this.txtSupPw.PasswordChar = '●';
            this.txtSupPw.Size = new System.Drawing.Size(100, 26);
            this.txtSupPw.TabIndex = 1;
            // 
            // txtSupId
            // 
            this.txtSupId.Location = new System.Drawing.Point(6, 31);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(100, 26);
            this.txtSupId.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CommuteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1891, 1027);
            this.Controls.Add(this.panSupervisor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip_People);
            this.Controls.Add(this.listView_People);
            this.Controls.Add(this.toolStrip_main);
            this.Controls.Add(this.listView_Main);
            this.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CommuteManager";
            this.Text = "안전관리시스템";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommuteManager_FormClosing);
            this.Load += new System.EventHandler(this.CommuteManager_Load);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.toolStrip_People.ResumeLayout(false);
            this.toolStrip_People.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led5_2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led4_2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led3_2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led2_2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Led1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led1_2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panSupervisor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripButton btnSetting;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitBtn_Mode;
		private System.Windows.Forms.ToolStripButton toolStripButton_TagMonitor;
		private System.Windows.Forms.ToolStripButton toolStripButton_MainRefresh;
		private System.Windows.Forms.ToolStripMenuItem 활성화ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 대기ToolStripMenuItem;
		private System.Windows.Forms.ListView listView_Main;
		private System.Windows.Forms.ColumnHeader ListViewHeader_MainTime;
		private System.Windows.Forms.ColumnHeader ListViewHeader_MainCommute;
		private System.Windows.Forms.ColumnHeader ListViewHeader_MainName;
		private System.Windows.Forms.ColumnHeader ListViewHeader_MainID;
		private System.Windows.Forms.ToolStrip toolStrip_People;
		private System.Windows.Forms.ToolStripButton toolStripButton_AddPeople;
		private System.Windows.Forms.ToolStripButton toolStripButton_ModifyPeople;
		private System.Windows.Forms.ToolStripButton toolStripButton_DeletePeople;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Search;
		private System.Windows.Forms.ToolStripButton toolStripButton_Search;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ListView listView_People;
		private System.Windows.Forms.ColumnHeader ListViewHeader_PeopleStatus;
		private System.Windows.Forms.ColumnHeader ListViewHeader_PeopleName;
		private System.Windows.Forms.ColumnHeader ListViewHeader_PeopleTagID;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel lblStatus;
		private System.Windows.Forms.ToolStripLabel lbltime;
		private System.IO.Ports.SerialPort serialPort_RFID;
		private System.Windows.Forms.ToolStripButton toolStripButton_ServerStart;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		public System.Windows.Forms.ToolStripButton btnConnect;
		public System.Windows.Forms.ToolStrip toolStrip_main;
		private System.Windows.Forms.ColumnHeader ListViewHeader_MainGATE;
		private System.Windows.Forms.Timer timer_CommuteCheck;
        private System.Windows.Forms.ColumnHeader ListViewHeader_MainJob;
        private System.Windows.Forms.ColumnHeader ListViewHeader_PeopleJob;
        private System.Windows.Forms.ToolStripButton tsbtnDetail;
        private System.Windows.Forms.ToolStripComboBox tsComboxInout;
        private System.Windows.Forms.ColumnHeader ListviewHeader_MainLoca;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Button btn대기;
        private System.Windows.Forms.Button btnTagMonitor;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSupervisor;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Panel panSupervisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegisor;
        private System.Windows.Forms.TextBox txtSupPw;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkJob;
        private System.Windows.Forms.CheckBox chkTotal;
        private System.Windows.Forms.ListView lvSup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox Led1_1;
        private System.Windows.Forms.Label lblGate1;
        private System.Windows.Forms.PictureBox Led2_1;
        private System.Windows.Forms.Label lblGate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn활성화;
        private System.Windows.Forms.ColumnHeader ListviewHeader_MainCompany;
        private System.Windows.Forms.ColumnHeader ListViewHeader_PeopleCompany;
        private System.Windows.Forms.PictureBox Led4_2;
        private System.Windows.Forms.PictureBox Led3_2;
        private System.Windows.Forms.Label lblGate4;
        private System.Windows.Forms.Label lblGate3;
        private System.Windows.Forms.PictureBox Led4_1;
        private System.Windows.Forms.PictureBox Led3_1;
        private System.Windows.Forms.PictureBox Led2_2;
        private System.Windows.Forms.PictureBox Led1_2;
        private System.Windows.Forms.PictureBox Led5_2;
        private System.Windows.Forms.Label lblGate5;
        private System.Windows.Forms.PictureBox Led5_1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

