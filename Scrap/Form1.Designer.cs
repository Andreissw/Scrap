namespace Scrap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBScan = new System.Windows.Forms.GroupBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.BtAccept = new System.Windows.Forms.Button();
            this.ListDecodes = new System.Windows.Forms.ListBox();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBScan = new System.Windows.Forms.TextBox();
            this.BT_OK = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.GroupReport = new System.Windows.Forms.GroupBox();
            this.BT = new System.Windows.Forms.Button();
            this.ReportBT = new System.Windows.Forms.Button();
            this.GridList = new System.Windows.Forms.DataGridView();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBRemove = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBScanScrap = new System.Windows.Forms.TextBox();
            this.GBScan.SuspendLayout();
            this.GroupReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            this.CMS.SuspendLayout();
            this.GBRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBScan
            // 
            this.GBScan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GBScan.Controls.Add(this.ErrorLabel);
            this.GBScan.Controls.Add(this.BtAccept);
            this.GBScan.Controls.Add(this.ListDecodes);
            this.GBScan.Controls.Add(this.CheckBox);
            this.GBScan.Controls.Add(this.label1);
            this.GBScan.Controls.Add(this.TBScan);
            this.GBScan.Location = new System.Drawing.Point(1551, 66);
            this.GBScan.Name = "GBScan";
            this.GBScan.Size = new System.Drawing.Size(56, 26);
            this.GBScan.TabIndex = 0;
            this.GBScan.TabStop = false;
            this.GBScan.Text = "Scan";
            this.GBScan.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.LightCoral;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.Location = new System.Drawing.Point(6, 140);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(112, 25);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "ErrorLabel";
            this.ErrorLabel.Visible = false;
            // 
            // BtAccept
            // 
            this.BtAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAccept.Location = new System.Drawing.Point(6, 556);
            this.BtAccept.Name = "BtAccept";
            this.BtAccept.Size = new System.Drawing.Size(1019, 47);
            this.BtAccept.TabIndex = 4;
            this.BtAccept.Text = "Подтвердить";
            this.BtAccept.UseVisualStyleBackColor = true;
            this.BtAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // ListDecodes
            // 
            this.ListDecodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListDecodes.FormattingEnabled = true;
            this.ListDecodes.ItemHeight = 24;
            this.ListDecodes.Location = new System.Drawing.Point(6, 273);
            this.ListDecodes.Name = "ListDecodes";
            this.ListDecodes.Size = new System.Drawing.Size(1019, 268);
            this.ListDecodes.TabIndex = 3;
            this.ListDecodes.Click += new System.EventHandler(this.ListDecodes_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox.Location = new System.Drawing.Point(6, 19);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(462, 29);
            this.CheckBox.TabIndex = 2;
            this.CheckBox.TabStop = false;
            this.CheckBox.Text = "Сканирование пул номеров(Мульти-плата)";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отсканируйте номер бракованной платы";
            // 
            // TBScan
            // 
            this.TBScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBScan.Location = new System.Drawing.Point(6, 229);
            this.TBScan.Name = "TBScan";
            this.TBScan.Size = new System.Drawing.Size(1019, 38);
            this.TBScan.TabIndex = 0;
            this.TBScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBScan_KeyDown);
            // 
            // BT_OK
            // 
            this.BT_OK.BackColor = System.Drawing.Color.Wheat;
            this.BT_OK.FlatAppearance.BorderSize = 0;
            this.BT_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BT_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_OK.Location = new System.Drawing.Point(12, 406);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(336, 38);
            this.BT_OK.TabIndex = 4;
            this.BT_OK.Text = "Выбрать";
            this.BT_OK.UseVisualStyleBackColor = false;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 24;
            this.List.Location = new System.Drawing.Point(12, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(336, 388);
            this.List.TabIndex = 3;
            this.List.DoubleClick += new System.EventHandler(this.List_DoubleClick);
            // 
            // GroupReport
            // 
            this.GroupReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GroupReport.Controls.Add(this.BT);
            this.GroupReport.Controls.Add(this.ReportBT);
            this.GroupReport.Controls.Add(this.GridList);
            this.GroupReport.Location = new System.Drawing.Point(354, 13);
            this.GroupReport.Name = "GroupReport";
            this.GroupReport.Size = new System.Drawing.Size(1114, 616);
            this.GroupReport.TabIndex = 5;
            this.GroupReport.TabStop = false;
            this.GroupReport.Text = "Report";
            this.GroupReport.Visible = false;
            // 
            // BT
            // 
            this.BT.FlatAppearance.BorderSize = 0;
            this.BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT.Image = global::Scrap.Properties.Resources._2;
            this.BT.Location = new System.Drawing.Point(2, 19);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(56, 51);
            this.BT.TabIndex = 2;
            this.BT.Text = "Назад";
            this.BT.UseVisualStyleBackColor = true;
            this.BT.Click += new System.EventHandler(this.BT_Click);
            // 
            // ReportBT
            // 
            this.ReportBT.BackColor = System.Drawing.Color.YellowGreen;
            this.ReportBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportBT.Location = new System.Drawing.Point(62, 554);
            this.ReportBT.Name = "ReportBT";
            this.ReportBT.Size = new System.Drawing.Size(1032, 49);
            this.ReportBT.TabIndex = 1;
            this.ReportBT.Text = "Выбрать";
            this.ReportBT.UseVisualStyleBackColor = false;
            this.ReportBT.Click += new System.EventHandler(this.ReportBT_Click);
            // 
            // GridList
            // 
            this.GridList.AllowUserToAddRows = false;
            this.GridList.AllowUserToResizeColumns = false;
            this.GridList.AllowUserToResizeRows = false;
            this.GridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridList.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridList.Location = new System.Drawing.Point(62, 19);
            this.GridList.MultiSelect = false;
            this.GridList.Name = "GridList";
            this.GridList.ReadOnly = true;
            this.GridList.RowHeadersVisible = false;
            this.GridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridList.Size = new System.Drawing.Size(1032, 529);
            this.GridList.TabIndex = 0;
            this.GridList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridList_MouseDoubleClick);
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // GBRemove
            // 
            this.GBRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GBRemove.Controls.Add(this.label4);
            this.GBRemove.Controls.Add(this.label3);
            this.GBRemove.Controls.Add(this.TBScanScrap);
            this.GBRemove.Location = new System.Drawing.Point(1541, 35);
            this.GBRemove.Name = "GBRemove";
            this.GBRemove.Size = new System.Drawing.Size(74, 17);
            this.GBRemove.TabIndex = 6;
            this.GBRemove.TabStop = false;
            this.GBRemove.Text = "Remove";
            this.GBRemove.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "УДАЛЕНИЕ ПЛАТЫ ИЗ БРАКА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отсканируйте номер платы, которую надо вывести из брака";
            // 
            // TBScanScrap
            // 
            this.TBScanScrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBScanScrap.Location = new System.Drawing.Point(6, 229);
            this.TBScanScrap.Name = "TBScanScrap";
            this.TBScanScrap.Size = new System.Drawing.Size(1019, 38);
            this.TBScanScrap.TabIndex = 0;
            this.TBScanScrap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBScanScrap_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 626);
            this.Controls.Add(this.GBRemove);
            this.Controls.Add(this.GroupReport);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.List);
            this.Controls.Add(this.GBScan);
            this.Name = "Form1";
            this.Text = "Scrap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBScan.ResumeLayout(false);
            this.GBScan.PerformLayout();
            this.GroupReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            this.CMS.ResumeLayout(false);
            this.GBRemove.ResumeLayout(false);
            this.GBRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBScan;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBScan;
        private System.Windows.Forms.GroupBox GroupReport;
        private System.Windows.Forms.DataGridView GridList;
        private System.Windows.Forms.Button ReportBT;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Button BtAccept;
        private System.Windows.Forms.ListBox ListDecodes;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBScanScrap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT;
    }
}

