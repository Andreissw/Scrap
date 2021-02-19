namespace Scrap
{
    partial class PhotoForm
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
            this.BTBack = new System.Windows.Forms.Button();
            this.BTOK = new System.Windows.Forms.Button();
            this.PanelPhoto = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ddPhoto = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьФотографиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelNew = new System.Windows.Forms.Panel();
            this.Panel = new System.Windows.Forms.Panel();
            this.PanelPhoto.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTBack
            // 
            this.BTBack.BackColor = System.Drawing.Color.Salmon;
            this.BTBack.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BTBack.FlatAppearance.BorderSize = 0;
            this.BTBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTBack.Location = new System.Drawing.Point(12, 392);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(393, 46);
            this.BTBack.TabIndex = 9;
            this.BTBack.Text = "Назад";
            this.BTBack.UseVisualStyleBackColor = false;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // BTOK
            // 
            this.BTOK.BackColor = System.Drawing.Color.Chartreuse;
            this.BTOK.FlatAppearance.BorderSize = 0;
            this.BTOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOK.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTOK.Location = new System.Drawing.Point(411, 392);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(377, 46);
            this.BTOK.TabIndex = 8;
            this.BTOK.Text = "Далее";
            this.BTOK.UseVisualStyleBackColor = false;
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // PanelPhoto
            // 
            this.PanelPhoto.AllowDrop = true;
            this.PanelPhoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelPhoto.Controls.Add(this.RemoveButton);
            this.PanelPhoto.Controls.Add(this.ddPhoto);
            this.PanelPhoto.Location = new System.Drawing.Point(12, 12);
            this.PanelPhoto.Name = "PanelPhoto";
            this.PanelPhoto.Size = new System.Drawing.Size(776, 374);
            this.PanelPhoto.TabIndex = 10;
            this.PanelPhoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelPhoto_DragDrop);
            this.PanelPhoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelPhoto_DragEnter);
            this.PanelPhoto.DragLeave += new System.EventHandler(this.PanelPhoto_DragLeave);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(7, 7);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(130, 34);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Удалить всё";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Visible = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ddPhoto
            // 
            this.ddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddPhoto.Location = new System.Drawing.Point(268, 146);
            this.ddPhoto.Name = "ddPhoto";
            this.ddPhoto.Size = new System.Drawing.Size(254, 77);
            this.ddPhoto.TabIndex = 0;
            this.ddPhoto.Text = "Добавить фото";
            this.ddPhoto.UseVisualStyleBackColor = true;
            this.ddPhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьФотографиюToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            // 
            // удалитьФотографиюToolStripMenuItem
            // 
            this.удалитьФотографиюToolStripMenuItem.Name = "удалитьФотографиюToolStripMenuItem";
            this.удалитьФотографиюToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.удалитьФотографиюToolStripMenuItem.Text = "Удалить фотографию";
            // 
            // PanelNew
            // 
            this.PanelNew.AutoScroll = true;
            this.PanelNew.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PanelNew.Location = new System.Drawing.Point(12, 444);
            this.PanelNew.Name = "PanelNew";
            this.PanelNew.Size = new System.Drawing.Size(776, 97);
            this.PanelNew.TabIndex = 12;
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Panel.Location = new System.Drawing.Point(12, 547);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(776, 97);
            this.Panel.TabIndex = 13;
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PanelNew);
            this.Controls.Add(this.PanelPhoto);
            this.Controls.Add(this.BTBack);
            this.Controls.Add(this.BTOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhotoForm_FormClosed);
            this.Load += new System.EventHandler(this.PhotoForm_Load);
            this.PanelPhoto.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTBack;
        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Panel PanelPhoto;
        private System.Windows.Forms.Button ddPhoto;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьФотографиюToolStripMenuItem;
        private System.Windows.Forms.Panel PanelNew;
        private System.Windows.Forms.Panel Panel;
    }
}