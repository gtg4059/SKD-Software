namespace CommuteManager_V6
{
	partial class TagMonitor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listView_Tag = new System.Windows.Forms.ListView();
			this.ListViewHeader_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewHeader_EPCID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewHeader_Ant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewHeader_RSSI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewHeader_GATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ListViewHeader_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Check = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton_Close = new System.Windows.Forms.ToolStripButton();
			this.timer_Update = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView_Tag
			// 
			this.listView_Tag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewHeader_Number,
            this.ListViewHeader_EPCID,
            this.ListViewHeader_Ant,
            this.ListViewHeader_RSSI,
            this.ListViewHeader_GATE,
            this.ListViewHeader_Time});
			this.listView_Tag.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView_Tag.FullRowSelect = true;
			this.listView_Tag.Location = new System.Drawing.Point(0, 0);
			this.listView_Tag.Name = "listView_Tag";
			this.listView_Tag.Size = new System.Drawing.Size(477, 291);
			this.listView_Tag.TabIndex = 0;
			this.listView_Tag.UseCompatibleStateImageBehavior = false;
			this.listView_Tag.View = System.Windows.Forms.View.Details;
			// 
			// ListViewHeader_Number
			// 
			this.ListViewHeader_Number.Text = "번호";
			// 
			// ListViewHeader_EPCID
			// 
			this.ListViewHeader_EPCID.Text = "EPC ID";
			this.ListViewHeader_EPCID.Width = 163;
			// 
			// ListViewHeader_Ant
			// 
			this.ListViewHeader_Ant.Text = "안테나";
			// 
			// ListViewHeader_RSSI
			// 
			this.ListViewHeader_RSSI.Text = "RSSI";
			// 
			// ListViewHeader_GATE
			// 
			this.ListViewHeader_GATE.Text = "GATE";
			// 
			// ListViewHeader_Time
			// 
			this.ListViewHeader_Time.Text = "시간경과";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Refresh,
            this.toolStripButton_Stop,
            this.toolStripButton_Check,
            this.toolStripButton_Close});
			this.toolStrip1.Location = new System.Drawing.Point(0, 266);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(477, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton_Refresh
			// 
			this.toolStripButton_Refresh.Image = global::CommuteManager_V6.Properties.Resources.Image_Refresh1;
			this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
			this.toolStripButton_Refresh.Size = new System.Drawing.Size(75, 22);
			this.toolStripButton_Refresh.Text = "새로고침";
			// 
			// toolStripButton_Stop
			// 
			this.toolStripButton_Stop.Image = global::CommuteManager_V6.Properties.Resources.Image_Stop;
			this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Stop.Name = "toolStripButton_Stop";
			this.toolStripButton_Stop.Size = new System.Drawing.Size(75, 22);
			this.toolStripButton_Stop.Text = "일시정지";
			this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
			// 
			// toolStripButton_Check
			// 
			this.toolStripButton_Check.Image = global::CommuteManager_V6.Properties.Resources.Image_Select;
			this.toolStripButton_Check.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Check.Name = "toolStripButton_Check";
			this.toolStripButton_Check.Size = new System.Drawing.Size(51, 22);
			this.toolStripButton_Check.Text = "선택";
			this.toolStripButton_Check.ToolTipText = "선택";
			this.toolStripButton_Check.Click += new System.EventHandler(this.toolStripButton_Check_Click);
			// 
			// toolStripButton_Close
			// 
			this.toolStripButton_Close.Image = global::CommuteManager_V6.Properties.Resources.Image_Close;
			this.toolStripButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton_Close.Name = "toolStripButton_Close";
			this.toolStripButton_Close.Size = new System.Drawing.Size(51, 22);
			this.toolStripButton_Close.Text = "닫기";
			this.toolStripButton_Close.Click += new System.EventHandler(this.toolStripButton_Close_Click);
			// 
			// timer_Update
			// 
			this.timer_Update.Enabled = true;
			this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
			// 
			// TagMonitor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 291);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.listView_Tag);
			this.Name = "TagMonitor";
			this.Text = "TagMonitor";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView_Tag;
		private System.Windows.Forms.ColumnHeader ListViewHeader_Number;
		private System.Windows.Forms.ColumnHeader ListViewHeader_EPCID;
		private System.Windows.Forms.ColumnHeader ListViewHeader_Ant;
		private System.Windows.Forms.ColumnHeader ListViewHeader_RSSI;
		private System.Windows.Forms.ColumnHeader ListViewHeader_GATE;
		private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;
		private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
		private System.Windows.Forms.ToolStripButton toolStripButton_Close;
		public System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Timer timer_Update;
		private System.Windows.Forms.ColumnHeader ListViewHeader_Time;
		private System.Windows.Forms.ToolStripButton toolStripButton_Check;
	}
}