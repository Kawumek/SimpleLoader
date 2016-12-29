namespace SimpleLoader_Reborn
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.MainButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathButton = new System.Windows.Forms.Button();
            this.CpyRght = new System.Windows.Forms.Label();
            this.LangBox = new System.Windows.Forms.Button();
            this.CloseChck = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // LinkBox
            // 
            this.LinkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkBox.Location = new System.Drawing.Point(12, 12);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(501, 22);
            this.LinkBox.TabIndex = 1;
            this.LinkBox.Text = "Вставьте ссылку сюда";
            this.LinkBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LinkBox.Click += new System.EventHandler(this.LinkBox_Click);
            this.LinkBox.TextChanged += new System.EventHandler(this.LinkBox_TextChanged);
            // 
            // MainButton
            // 
            this.MainButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(0, 96);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(525, 64);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Скачать";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(12, 68);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(501, 22);
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.Visible = false;
            // 
            // PathBox
            // 
            this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathBox.Enabled = false;
            this.PathBox.Location = new System.Drawing.Point(12, 40);
            this.PathBox.Name = "PathBox";
            this.PathBox.ReadOnly = true;
            this.PathBox.Size = new System.Drawing.Size(464, 22);
            this.PathBox.TabIndex = 3;
            this.PathBox.Text = "Путь к файлу";
            this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PathButton
            // 
            this.PathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PathButton.Location = new System.Drawing.Point(482, 40);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(31, 22);
            this.PathButton.TabIndex = 4;
            this.PathButton.Text = "...";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // CpyRght
            // 
            this.CpyRght.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpyRght.AutoSize = true;
            this.CpyRght.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.CpyRght.Location = new System.Drawing.Point(12, 69);
            this.CpyRght.Name = "CpyRght";
            this.CpyRght.Size = new System.Drawing.Size(88, 20);
            this.CpyRght.TabIndex = 5;
            this.CpyRght.Text = "© kawumek";
            // 
            // LangBox
            // 
            this.LangBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LangBox.Location = new System.Drawing.Point(482, 68);
            this.LangBox.Name = "LangBox";
            this.LangBox.Size = new System.Drawing.Size(31, 23);
            this.LangBox.TabIndex = 6;
            this.LangBox.Text = "RU";
            this.LangBox.UseVisualStyleBackColor = true;
            this.LangBox.Click += new System.EventHandler(this.LangBox_Click);
            // 
            // CloseChck
            // 
            this.CloseChck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseChck.AutoSize = true;
            this.CloseChck.Location = new System.Drawing.Point(309, 72);
            this.CloseChck.Name = "CloseChck";
            this.CloseChck.Size = new System.Drawing.Size(167, 17);
            this.CloseChck.TabIndex = 7;
            this.CloseChck.Text = "Закрыть после окончания";
            this.CloseChck.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Notification";
            this.notifyIcon1.Visible = true;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 160);
            this.Controls.Add(this.CloseChck);
            this.Controls.Add(this.LangBox);
            this.Controls.Add(this.CpyRght);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.LinkBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 199);
            this.MinimumSize = new System.Drawing.Size(345, 199);
            this.Name = "mainform";
            this.Text = "Simpleloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label CpyRght;
        private System.Windows.Forms.Button LangBox;
        private System.Windows.Forms.CheckBox CloseChck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

