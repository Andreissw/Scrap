namespace Scrap
{
    partial class Scrap_DescriptionForm
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
            this.PathDoc = new System.Windows.Forms.TextBox();
            this.AddDoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBDescription = new System.Windows.Forms.TextBox();
            this.BTBack = new System.Windows.Forms.Button();
            this.BTOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathDoc
            // 
            this.PathDoc.Enabled = false;
            this.PathDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathDoc.Location = new System.Drawing.Point(50, 43);
            this.PathDoc.Name = "PathDoc";
            this.PathDoc.Size = new System.Drawing.Size(631, 31);
            this.PathDoc.TabIndex = 0;
            // 
            // AddDoc
            // 
            this.AddDoc.Location = new System.Drawing.Point(687, 43);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(65, 31);
            this.AddDoc.TabIndex = 1;
            this.AddDoc.Text = "Добавить";
            this.AddDoc.UseVisualStyleBackColor = true;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Х";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBDescription
            // 
            this.TBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDescription.Location = new System.Drawing.Point(11, 80);
            this.TBDescription.Multiline = true;
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(738, 179);
            this.TBDescription.TabIndex = 4;
            // 
            // BTBack
            // 
            this.BTBack.BackColor = System.Drawing.Color.Salmon;
            this.BTBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BTBack.FlatAppearance.BorderSize = 0;
            this.BTBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTBack.Location = new System.Drawing.Point(12, 265);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(365, 46);
            this.BTBack.TabIndex = 7;
            this.BTBack.Text = "Отмена";
            this.BTBack.UseVisualStyleBackColor = false;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // BTOK
            // 
            this.BTOK.BackColor = System.Drawing.Color.Chartreuse;
            this.BTOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTOK.FlatAppearance.BorderSize = 0;
            this.BTOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOK.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTOK.Location = new System.Drawing.Point(383, 265);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(366, 46);
            this.BTOK.TabIndex = 6;
            this.BTOK.Text = "Далее(Фото)";
            this.BTOK.UseVisualStyleBackColor = false;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавьте акт списания (документ) и добавьте описание дефектной платы";
            // 
            // Scrap_DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(761, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTBack);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.TBDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddDoc);
            this.Controls.Add(this.PathDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scrap_DescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrap_DescriptionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scrap_DescriptionForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathDoc;
        private System.Windows.Forms.Button AddDoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBDescription;
        private System.Windows.Forms.Button BTBack;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Label label1;
    }
}