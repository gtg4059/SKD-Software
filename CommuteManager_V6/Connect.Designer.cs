namespace CommuteManager_V6
{
	partial class Connect_Setting
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
            this.lv_Port = new System.Windows.Forms.ListView();
            this.Num2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnServer_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnt = new System.Windows.Forms.TextBox();
            this.btnDel_Gate = new System.Windows.Forms.Button();
            this.txtHostIP = new System.Windows.Forms.TextBox();
            this.txtGATENumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUIP = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFixIP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comb_Reader = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGateName = new System.Windows.Forms.TextBox();
            this.btnGateName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGate = new System.Windows.Forms.TextBox();
            this.btnGate_set = new System.Windows.Forms.Button();
            this.tv_Gate = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Port
            // 
            this.lv_Port.CheckBoxes = true;
            this.lv_Port.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num2,
            this.ColPort,
            this.colGate2});
            this.lv_Port.GridLines = true;
            this.lv_Port.Location = new System.Drawing.Point(3, 8);
            this.lv_Port.Name = "lv_Port";
            this.lv_Port.Size = new System.Drawing.Size(193, 142);
            this.lv_Port.TabIndex = 6;
            this.lv_Port.UseCompatibleStateImageBehavior = false;
            this.lv_Port.View = System.Windows.Forms.View.Details;
            this.lv_Port.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lv_Port_ItemCheck);
            // 
            // Num2
            // 
            this.Num2.Text = "M/S";
            // 
            // ColPort
            // 
            this.ColPort.Text = "Port";
            // 
            // colGate2
            // 
            this.colGate2.Text = "현장이름";
            // 
            // btnServer_Connect
            // 
            this.btnServer_Connect.Location = new System.Drawing.Point(14, 237);
            this.btnServer_Connect.Name = "btnServer_Connect";
            this.btnServer_Connect.Size = new System.Drawing.Size(165, 31);
            this.btnServer_Connect.TabIndex = 1;
            this.btnServer_Connect.Text = "연결";
            this.btnServer_Connect.UseVisualStyleBackColor = true;
            this.btnServer_Connect.Click += new System.EventHandler(this.btnServer_Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // txtAnt
            // 
            this.txtAnt.Location = new System.Drawing.Point(58, 91);
            this.txtAnt.Name = "txtAnt";
            this.txtAnt.Size = new System.Drawing.Size(55, 21);
            this.txtAnt.TabIndex = 8;
            // 
            // btnDel_Gate
            // 
            this.btnDel_Gate.Location = new System.Drawing.Point(12, 150);
            this.btnDel_Gate.Name = "btnDel_Gate";
            this.btnDel_Gate.Size = new System.Drawing.Size(207, 36);
            this.btnDel_Gate.TabIndex = 1;
            this.btnDel_Gate.Text = "게이트삭제";
            this.btnDel_Gate.UseVisualStyleBackColor = true;
            this.btnDel_Gate.Click += new System.EventHandler(this.btnDel_Gate_Click);
            // 
            // txtHostIP
            // 
            this.txtHostIP.Location = new System.Drawing.Point(8, 23);
            this.txtHostIP.Name = "txtHostIP";
            this.txtHostIP.Size = new System.Drawing.Size(119, 21);
            this.txtHostIP.TabIndex = 2;
            // 
            // txtGATENumber
            // 
            this.txtGATENumber.Location = new System.Drawing.Point(8, 67);
            this.txtGATENumber.Name = "txtGATENumber";
            this.txtGATENumber.Size = new System.Drawing.Size(74, 21);
            this.txtGATENumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "현장이름";
            // 
            // btnUIP
            // 
            this.btnUIP.Location = new System.Drawing.Point(133, 23);
            this.btnUIP.Name = "btnUIP";
            this.btnUIP.Size = new System.Drawing.Size(86, 37);
            this.btnUIP.TabIndex = 7;
            this.btnUIP.Text = "게이트IP추가";
            this.btnUIP.UseVisualStyleBackColor = true;
            this.btnUIP.Click += new System.EventHandler(this.btnUIP_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(88, 67);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(39, 21);
            this.txtPort.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFixIP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAnt);
            this.panel1.Controls.Add(this.comb_Reader);
            this.panel1.Controls.Add(this.btnUIP);
            this.panel1.Controls.Add(this.btnDel_Gate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHostIP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGATENumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 277);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // btnFixIP
            // 
            this.btnFixIP.Location = new System.Drawing.Point(133, 65);
            this.btnFixIP.Name = "btnFixIP";
            this.btnFixIP.Size = new System.Drawing.Size(89, 38);
            this.btnFixIP.TabIndex = 10;
            this.btnFixIP.Text = "게이트IP수정";
            this.btnFixIP.UseVisualStyleBackColor = true;
            this.btnFixIP.Click += new System.EventHandler(this.btnFixIP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Antenna";
            // 
            // comb_Reader
            // 
            this.comb_Reader.FormattingEnabled = true;
            this.comb_Reader.Location = new System.Drawing.Point(7, 118);
            this.comb_Reader.Name = "comb_Reader";
            this.comb_Reader.Size = new System.Drawing.Size(212, 20);
            this.comb_Reader.TabIndex = 8;
            this.comb_Reader.Text = "Select IP, Gate, Port, Ant";
            this.comb_Reader.SelectionChangeCommitted += new System.EventHandler(this.comb_Reader_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtGateName);
            this.panel2.Controls.Add(this.btnGateName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtGate);
            this.panel2.Controls.Add(this.btnGate_set);
            this.panel2.Controls.Add(this.lv_Port);
            this.panel2.Controls.Add(this.btnServer_Connect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(412, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 277);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "현장(게이트) 이름 등록";
            // 
            // txtGateName
            // 
            this.txtGateName.Location = new System.Drawing.Point(15, 207);
            this.txtGateName.Name = "txtGateName";
            this.txtGateName.Size = new System.Drawing.Size(79, 21);
            this.txtGateName.TabIndex = 11;
            // 
            // btnGateName
            // 
            this.btnGateName.Location = new System.Drawing.Point(100, 207);
            this.btnGateName.Name = "btnGateName";
            this.btnGateName.Size = new System.Drawing.Size(80, 21);
            this.btnGateName.TabIndex = 10;
            this.btnGateName.Text = "현장등록";
            this.btnGateName.UseVisualStyleBackColor = true;
            this.btnGateName.Click += new System.EventHandler(this.btnGateName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "등록예시- Main : 1 Sub : 1-2-1";
            // 
            // txtGate
            // 
            this.txtGate.Location = new System.Drawing.Point(15, 168);
            this.txtGate.Name = "txtGate";
            this.txtGate.Size = new System.Drawing.Size(79, 21);
            this.txtGate.TabIndex = 8;
            // 
            // btnGate_set
            // 
            this.btnGate_set.Location = new System.Drawing.Point(100, 168);
            this.btnGate_set.Name = "btnGate_set";
            this.btnGate_set.Size = new System.Drawing.Size(80, 21);
            this.btnGate_set.TabIndex = 7;
            this.btnGate_set.Text = "게이트 등록";
            this.btnGate_set.UseVisualStyleBackColor = true;
            this.btnGate_set.Click += new System.EventHandler(this.btnGate_set_Click);
            // 
            // tv_Gate
            // 
            this.tv_Gate.Location = new System.Drawing.Point(231, 0);
            this.tv_Gate.Name = "tv_Gate";
            this.tv_Gate.Size = new System.Drawing.Size(181, 290);
            this.tv_Gate.TabIndex = 6;
            // 
            // Connect_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(611, 277);
            this.Controls.Add(this.tv_Gate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Connect_Setting";
            this.Text = "GATE 통신 연결";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connect_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnServer_Connect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAnt;
        private System.Windows.Forms.Button btnDel_Gate;
        private System.Windows.Forms.TextBox txtHostIP;
        private System.Windows.Forms.TextBox txtGATENumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_Port;
        private System.Windows.Forms.ColumnHeader Num2;
        private System.Windows.Forms.ColumnHeader ColPort;
        private System.Windows.Forms.ColumnHeader colGate2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnUIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comb_Reader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGate;
        private System.Windows.Forms.Button btnGate_set;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGateName;
        private System.Windows.Forms.Button btnGateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFixIP;
        private System.Windows.Forms.TreeView tv_Gate;
    }
}