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
            this.GBScan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBScan = new System.Windows.Forms.TextBox();
            this.BT_OK = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.GBScan.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBScan
            // 
            this.GBScan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GBScan.Controls.Add(this.label1);
            this.GBScan.Controls.Add(this.TBScan);
            this.GBScan.Location = new System.Drawing.Point(354, 12);
            this.GBScan.Name = "GBScan";
            this.GBScan.Size = new System.Drawing.Size(1031, 279);
            this.GBScan.TabIndex = 0;
            this.GBScan.TabStop = false;
            this.GBScan.Text = "Scan";
            this.GBScan.Visible = false;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 633);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.List);
            this.Controls.Add(this.GBScan);
            this.Name = "Form1";
            this.Text = "Scrap";
            this.GBScan.ResumeLayout(false);
            this.GBScan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBScan;
        private System.Windows.Forms.Button BT_OK;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBScan;
    }
}

