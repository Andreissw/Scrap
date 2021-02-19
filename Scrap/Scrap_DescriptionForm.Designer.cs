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
            this.SaveBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.ComboBox();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodeDefect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathDoc
            // 
            this.PathDoc.Enabled = false;
            this.PathDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathDoc.Location = new System.Drawing.Point(49, 77);
            this.PathDoc.Name = "PathDoc";
            this.PathDoc.Size = new System.Drawing.Size(631, 31);
            this.PathDoc.TabIndex = 0;
            // 
            // AddDoc
            // 
            this.AddDoc.Location = new System.Drawing.Point(686, 77);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(65, 31);
            this.AddDoc.TabIndex = 1;
            this.AddDoc.Text = "Добавить";
            this.AddDoc.UseVisualStyleBackColor = true;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 77);
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
            this.TBDescription.Location = new System.Drawing.Point(14, 165);
            this.TBDescription.Multiline = true;
            this.TBDescription.Name = "TBDescription";
            this.TBDescription.Size = new System.Drawing.Size(737, 179);
            this.TBDescription.TabIndex = 4;
            // 
            // BTBack
            // 
            this.BTBack.BackColor = System.Drawing.Color.Salmon;
            this.BTBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BTBack.FlatAppearance.BorderSize = 0;
            this.BTBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTBack.Location = new System.Drawing.Point(13, 347);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(363, 46);
            this.BTBack.TabIndex = 7;
            this.BTBack.Text = "Отмена";
            this.BTBack.UseVisualStyleBackColor = false;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // BTOK
            // 
            this.BTOK.BackColor = System.Drawing.Color.Gold;
            this.BTOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTOK.FlatAppearance.BorderSize = 0;
            this.BTOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOK.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTOK.Location = new System.Drawing.Point(382, 347);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(369, 46);
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
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.Chartreuse;
            this.SaveBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBT.FlatAppearance.BorderSize = 0;
            this.SaveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBT.Location = new System.Drawing.Point(14, 399);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(740, 46);
            this.SaveBT.TabIndex = 9;
            this.SaveBT.Text = "Сохранить";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "PDF Документ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Описание ";
            // 
            // ActName
            // 
            this.ActName.AutoSize = true;
            this.ActName.Location = new System.Drawing.Point(46, 111);
            this.ActName.Name = "ActName";
            this.ActName.Size = new System.Drawing.Size(51, 13);
            this.ActName.TabIndex = 22;
            this.ActName.Text = "ActName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(753, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Код виновника";
            // 
            // Code
            // 
            this.Code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code.FormattingEnabled = true;
            this.Code.Location = new System.Drawing.Point(757, 187);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(313, 28);
            this.Code.TabIndex = 24;
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "01 - Поставщик",
            "09 - Завод"});
            this.ComboStatus.Location = new System.Drawing.Point(757, 248);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(313, 28);
            this.ComboStatus.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(754, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Статус";
            // 
            // CodeDefect
            // 
            this.CodeDefect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CodeDefect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CodeDefect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeDefect.FormattingEnabled = true;
            this.CodeDefect.Items.AddRange(new object[] {
            "01 - Поставщик",
            "09 - Завод"});
            this.CodeDefect.Location = new System.Drawing.Point(758, 304);
            this.CodeDefect.Name = "CodeDefect";
            this.CodeDefect.Size = new System.Drawing.Size(671, 24);
            this.CodeDefect.TabIndex = 28;
            this.CodeDefect.SelectedValueChanged += new System.EventHandler(this.CodeDefect_SelectedValueChanged);
            this.CodeDefect.Leave += new System.EventHandler(this.CodeDefect_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(755, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Код Дефекта";
            // 
            // Scrap_DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1441, 460);
            this.Controls.Add(this.CodeDefect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBT);
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
            this.Load += new System.EventHandler(this.Scrap_DescriptionForm_Load);
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
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ActName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Code;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CodeDefect;
        private System.Windows.Forms.Label label6;
    }
}