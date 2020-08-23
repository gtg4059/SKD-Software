namespace CommuteManager_V6
{
    partial class Detail
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
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.GateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDgvTotal = new System.Windows.Forms.Label();
            this.lblDgvLoca = new System.Windows.Forms.Label();
            this.dgvLoca = new System.Windows.Forms.DataGridView();
            this.dgvLocaCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocaCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocaCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocaCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblRef = new System.Windows.Forms.ToolStripLabel();
            this.lvEvent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCompnay = new System.Windows.Forms.Label();
            this.dgvCompnay = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJob = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoca)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompnay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotal
            // 
            this.dgvTotal.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GateName,
            this.In,
            this.Out,
            this.Sum});
            this.dgvTotal.Location = new System.Drawing.Point(12, 8);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersWidth = 10;
            this.dgvTotal.RowTemplate.Height = 23;
            this.dgvTotal.Size = new System.Drawing.Size(412, 355);
            this.dgvTotal.TabIndex = 2;
            this.dgvTotal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotal_CellDoubleClick);
            // 
            // GateName
            // 
            this.GateName.Frozen = true;
            this.GateName.HeaderText = "Main Gate명";
            this.GateName.Name = "GateName";
            this.GateName.ReadOnly = true;
            // 
            // In
            // 
            this.In.Frozen = true;
            this.In.HeaderText = "입";
            this.In.Name = "In";
            this.In.ReadOnly = true;
            // 
            // Out
            // 
            this.Out.Frozen = true;
            this.Out.HeaderText = "출";
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.Frozen = true;
            this.Sum.HeaderText = "상주계";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // lblDgvTotal
            // 
            this.lblDgvTotal.AutoSize = true;
            this.lblDgvTotal.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDgvTotal.Location = new System.Drawing.Point(174, 366);
            this.lblDgvTotal.Name = "lblDgvTotal";
            this.lblDgvTotal.Size = new System.Drawing.Size(111, 17);
            this.lblDgvTotal.TabIndex = 3;
            this.lblDgvTotal.Text = "Gate별 현황";
            // 
            // lblDgvLoca
            // 
            this.lblDgvLoca.AutoSize = true;
            this.lblDgvLoca.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDgvLoca.Location = new System.Drawing.Point(174, 781);
            this.lblDgvLoca.Name = "lblDgvLoca";
            this.lblDgvLoca.Size = new System.Drawing.Size(96, 17);
            this.lblDgvLoca.TabIndex = 5;
            this.lblDgvLoca.Text = "구역별 현황";
            // 
            // dgvLoca
            // 
            this.dgvLoca.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLocaCol0,
            this.dgvLocaCol1,
            this.dgvLocaCol2,
            this.dgvLocaCol3});
            this.dgvLoca.Location = new System.Drawing.Point(12, 410);
            this.dgvLoca.Name = "dgvLoca";
            this.dgvLoca.ReadOnly = true;
            this.dgvLoca.RowHeadersWidth = 10;
            this.dgvLoca.RowTemplate.Height = 23;
            this.dgvLoca.Size = new System.Drawing.Size(412, 368);
            this.dgvLoca.TabIndex = 4;
            this.dgvLoca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoca_CellDoubleClick);
            // 
            // dgvLocaCol0
            // 
            this.dgvLocaCol0.Frozen = true;
            this.dgvLocaCol0.HeaderText = "Main Gate명";
            this.dgvLocaCol0.Name = "dgvLocaCol0";
            this.dgvLocaCol0.ReadOnly = true;
            // 
            // dgvLocaCol1
            // 
            this.dgvLocaCol1.Frozen = true;
            this.dgvLocaCol1.HeaderText = "입";
            this.dgvLocaCol1.Name = "dgvLocaCol1";
            this.dgvLocaCol1.ReadOnly = true;
            // 
            // dgvLocaCol2
            // 
            this.dgvLocaCol2.Frozen = true;
            this.dgvLocaCol2.HeaderText = "출";
            this.dgvLocaCol2.Name = "dgvLocaCol2";
            this.dgvLocaCol2.ReadOnly = true;
            // 
            // dgvLocaCol3
            // 
            this.dgvLocaCol3.Frozen = true;
            this.dgvLocaCol3.HeaderText = "상주계";
            this.dgvLocaCol3.Name = "dgvLocaCol3";
            this.dgvLocaCol3.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblRef});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1194);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblRef
            // 
            this.tslblRef.Name = "tslblRef";
            this.tslblRef.Size = new System.Drawing.Size(62, 22);
            this.tslblRef.Text = "기준 시간:";
            // 
            // lvEvent
            // 
            this.lvEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEvent.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvEvent.GridLines = true;
            this.lvEvent.Location = new System.Drawing.Point(430, 8);
            this.lvEvent.Name = "lvEvent";
            this.lvEvent.Size = new System.Drawing.Size(362, 1171);
            this.lvEvent.TabIndex = 8;
            this.lvEvent.UseCompatibleStateImageBehavior = false;
            this.lvEvent.View = System.Windows.Forms.View.Details;
            this.lvEvent.DoubleClick += new System.EventHandler(this.lvEvent_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "성명";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "게이트명";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "공종";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "태그번호";
            this.columnHeader4.Width = 141;
            // 
            // lblCompnay
            // 
            this.lblCompnay.AutoSize = true;
            this.lblCompnay.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompnay.Location = new System.Drawing.Point(174, 1165);
            this.lblCompnay.Name = "lblCompnay";
            this.lblCompnay.Size = new System.Drawing.Size(96, 17);
            this.lblCompnay.TabIndex = 10;
            this.lblCompnay.Text = "업체별 현황";
            // 
            // dgvCompnay
            // 
            this.dgvCompnay.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompnay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCompnay.Location = new System.Drawing.Point(12, 839);
            this.dgvCompnay.Name = "dgvCompnay";
            this.dgvCompnay.ReadOnly = true;
            this.dgvCompnay.RowHeadersWidth = 10;
            this.dgvCompnay.RowTemplate.Height = 23;
            this.dgvCompnay.Size = new System.Drawing.Size(412, 313);
            this.dgvCompnay.TabIndex = 11;
            this.dgvCompnay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompnay_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "업체명";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "입";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "출";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "상주계";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvJob
            // 
            this.dgvJob.BackgroundColor = System.Drawing.Color.White;
            this.dgvJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvJob.Location = new System.Drawing.Point(12, 8);
            this.dgvJob.Name = "dgvJob";
            this.dgvJob.ReadOnly = true;
            this.dgvJob.RowHeadersWidth = 10;
            this.dgvJob.RowTemplate.Height = 23;
            this.dgvJob.Size = new System.Drawing.Size(412, 527);
            this.dgvJob.TabIndex = 12;
            this.dgvJob.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJob_CellDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "공종";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "입";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "출";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "상주계";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 1219);
            this.Controls.Add(this.dgvJob);
            this.Controls.Add(this.dgvCompnay);
            this.Controls.Add(this.lblCompnay);
            this.Controls.Add(this.lvEvent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblDgvLoca);
            this.Controls.Add(this.dgvLoca);
            this.Controls.Add(this.lblDgvTotal);
            this.Controls.Add(this.dgvTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detail";
            this.ShowIcon = false;
            this.Text = "현황";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Detail_FormClosing);
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoca)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompnay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.Label lblDgvTotal;
        private System.Windows.Forms.Label lblDgvLoca;
        private System.Windows.Forms.DataGridView dgvLoca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvJobCol4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocaCol0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocaCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocaCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocaCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.ListView lvEvent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblCompnay;
        private System.Windows.Forms.DataGridView dgvCompnay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}