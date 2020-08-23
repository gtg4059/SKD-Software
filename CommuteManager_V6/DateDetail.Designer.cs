namespace CommuteManager_V6
{
    partial class DateDetail
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboJob = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInit = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDate = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDate_Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCalendar1.Location = new System.Drawing.Point(4, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboJob);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblFinal);
            this.panel1.Controls.Add(this.lblInit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(236, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 158);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "공종 :";
            // 
            // comboJob
            // 
            this.comboJob.FormattingEnabled = true;
            this.comboJob.Location = new System.Drawing.Point(54, 104);
            this.comboJob.Name = "comboJob";
            this.comboJob.Size = new System.Drawing.Size(100, 20);
            this.comboJob.TabIndex = 16;
            this.comboJob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboJob_MouseDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 12);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "이름 :";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(144, 32);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(89, 12);
            this.lblFinal.TabIndex = 13;
            this.lblFinal.Text = "2019-02-20";
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(124, 7);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(89, 12);
            this.lblInit.TabIndex = 12;
            this.lblInit.Text = "2019-02-09";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_search_filled_480;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(166, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 100);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "~";
            // 
            // lvDate
            // 
            this.lvDate.BackColor = System.Drawing.Color.White;
            this.lvDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.lvDate_Job,
            this.date,
            this.Time});
            this.lvDate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvDate.FullRowSelect = true;
            this.lvDate.GridLines = true;
            this.lvDate.Location = new System.Drawing.Point(4, 176);
            this.lvDate.Name = "lvDate";
            this.lvDate.Size = new System.Drawing.Size(507, 439);
            this.lvDate.TabIndex = 5;
            this.lvDate.UseCompatibleStateImageBehavior = false;
            this.lvDate.View = System.Windows.Forms.View.Details;
            this.lvDate.SelectedIndexChanged += new System.EventHandler(this.lvDate_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 117;
            // 
            // lvDate_Job
            // 
            this.lvDate_Job.Text = "공종";
            this.lvDate_Job.Width = 129;
            // 
            // date
            // 
            this.date.Text = "근무 일수";
            this.date.Width = 144;
            // 
            // Time
            // 
            this.Time.Text = "근무 시간";
            this.Time.Width = 125;
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.White;
            this.btnDate.BackgroundImage = global::CommuteManager_V6.Properties.Resources.icons8_search_filled_480;
            this.btnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Location = new System.Drawing.Point(166, 51);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(100, 100);
            this.btnDate.TabIndex = 18;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // DateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(509, 624);
            this.Controls.Add(this.lvDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateDetail";
            this.ShowIcon = false;
            this.Text = "일자별 출역 현황";
            this.Load += new System.EventHandler(this.DateDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lvDate;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader lvDate_Job;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ComboBox comboJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button btnDate;
    }
}