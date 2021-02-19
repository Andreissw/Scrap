namespace Scrap
{
    partial class FormInfo
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
            this.PanelNew = new System.Windows.Forms.Panel();
            this.UserLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PathDoc = new System.Windows.Forms.TextBox();
            this.OpenPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DescTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatulLB = new System.Windows.Forms.Label();
            this.Vinovnik = new System.Windows.Forms.Label();
            this.DecodeLB = new System.Windows.Forms.TextBox();
            this.CodeDefectLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelNew
            // 
            this.PanelNew.AutoScroll = true;
            this.PanelNew.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PanelNew.Location = new System.Drawing.Point(12, 515);
            this.PanelNew.Name = "PanelNew";
            this.PanelNew.Size = new System.Drawing.Size(937, 97);
            this.PanelNew.TabIndex = 13;
            // 
            // UserLB
            // 
            this.UserLB.AutoSize = true;
            this.UserLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLB.Location = new System.Drawing.Point(12, 48);
            this.UserLB.Name = "UserLB";
            this.UserLB.Size = new System.Drawing.Size(46, 20);
            this.UserLB.TabIndex = 14;
            this.UserLB.Text = "User";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(937, 56);
            this.button1.TabIndex = 15;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathDoc
            // 
            this.PathDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathDoc.Location = new System.Drawing.Point(18, 218);
            this.PathDoc.Name = "PathDoc";
            this.PathDoc.ReadOnly = true;
            this.PathDoc.Size = new System.Drawing.Size(802, 31);
            this.PathDoc.TabIndex = 16;
            // 
            // OpenPDF
            // 
            this.OpenPDF.Location = new System.Drawing.Point(826, 218);
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(128, 31);
            this.OpenPDF.TabIndex = 17;
            this.OpenPDF.Text = "Открыть";
            this.OpenPDF.UseVisualStyleBackColor = true;
            this.OpenPDF.Click += new System.EventHandler(this.OpenPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "PDF Документ";
            // 
            // DescTB
            // 
            this.DescTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescTB.Location = new System.Drawing.Point(18, 275);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.ReadOnly = true;
            this.DescTB.Size = new System.Drawing.Size(936, 234);
            this.DescTB.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Описание ";
            // 
            // StatulLB
            // 
            this.StatulLB.AutoSize = true;
            this.StatulLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatulLB.Location = new System.Drawing.Point(13, 70);
            this.StatulLB.Name = "StatulLB";
            this.StatulLB.Size = new System.Drawing.Size(62, 20);
            this.StatulLB.TabIndex = 21;
            this.StatulLB.Text = "Status";
            // 
            // Vinovnik
            // 
            this.Vinovnik.AutoSize = true;
            this.Vinovnik.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vinovnik.Location = new System.Drawing.Point(13, 90);
            this.Vinovnik.Name = "Vinovnik";
            this.Vinovnik.Size = new System.Drawing.Size(89, 20);
            this.Vinovnik.TabIndex = 22;
            this.Vinovnik.Text = "Виновник";
            // 
            // DecodeLB
            // 
            this.DecodeLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F);
            this.DecodeLB.Location = new System.Drawing.Point(12, 12);
            this.DecodeLB.Name = "DecodeLB";
            this.DecodeLB.ReadOnly = true;
            this.DecodeLB.Size = new System.Drawing.Size(867, 33);
            this.DecodeLB.TabIndex = 23;
            this.DecodeLB.Text = "DecodeLB";
            // 
            // CodeDefectLB
            // 
            this.CodeDefectLB.AutoSize = true;
            this.CodeDefectLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeDefectLB.Location = new System.Drawing.Point(13, 110);
            this.CodeDefectLB.Name = "CodeDefectLB";
            this.CodeDefectLB.Size = new System.Drawing.Size(117, 20);
            this.CodeDefectLB.TabIndex = 24;
            this.CodeDefectLB.Text = "Код Дефекта";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 684);
            this.Controls.Add(this.CodeDefectLB);
            this.Controls.Add(this.DecodeLB);
            this.Controls.Add(this.Vinovnik);
            this.Controls.Add(this.StatulLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenPDF);
            this.Controls.Add(this.PathDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserLB);
            this.Controls.Add(this.PanelNew);
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная карта";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelNew;
        private System.Windows.Forms.Label UserLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PathDoc;
        private System.Windows.Forms.Button OpenPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatulLB;
        private System.Windows.Forms.Label Vinovnik;
        private System.Windows.Forms.TextBox DecodeLB;
        private System.Windows.Forms.Label CodeDefectLB;
    }
}