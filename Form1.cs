using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace SimpleLoader_Reborn
{
    public partial class mainform : Form
    {
        public string pathtofile;                                       
        private string filedef;
        private bool link_contains = false;
        private bool nullByClick = true;
                                                                    
        private bool ConnectionAvailable(string strServer)
        {
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(strServer);

                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    rspFP.Close();
                    return true;
                }
                else
                {
                    rspFP.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }       

        public mainform()
        {
            InitializeComponent();
            if (Clipboard.GetText().StartsWith("http"))
            {
                this.LinkBox.Text = Clipboard.GetText();
                this.LinkBox.TextAlign = HorizontalAlignment.Left;
            }
            this.MainButton.Focus();
        }                                        

        private void MainButton_Click(object sender, EventArgs e)
        {
            if (link_contains)
            {
                if (ConnectionAvailable(this.LinkBox.Text))
                {
                    this.CpyRght.Visible = false;
                    this.LangBox.Visible = false;
                    this.CloseChck.Visible = false;
                    this.ProgressBar.Visible = true;
                    using (WebClient download = new WebClient())
                    {
                        download.DownloadProgressChanged += Download_DownloadProgressChanged;
                        download.DownloadFileAsync(new System.Uri(this.LinkBox.Text),
                        pathtofile);
                    }
                }
                else
                {
                    DialogResult error;
                    string server = this.LinkBox.Text.Substring(this.LinkBox.Text.IndexOf('/') + 2);
                    server = server.Substring(0, server.IndexOf("/"));
                    if (this.LangBox.Text == "RU")
                    {
                        error = MessageBox.Show(this, "Нет соединения с " + server + ".\nУбедитесь в наличии интернет-соединения, правильности ссылки и попробуйте снова", "Отсутствует соединение с сервером!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        error = MessageBox.Show(this, "No connection to " + server + ".\nBe sure in having internet access, correctness of the link and retry", "No connection!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.ProgressBar.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 100 && this.CloseChck.Checked == true)
            {
                if (this.LangBox.Text == "RU")
                    notifyIcon1.ShowBalloonTip(10, "Загрузка завершена!", "Ваш файл находится в " + pathtofile + "\nНажмите, чтобы открыть папку", ToolTipIcon.Info);
                else
                    notifyIcon1.ShowBalloonTip(10, "Download complete!", "Downloaded file is in " + pathtofile + "\nClick to open the folder", ToolTipIcon.Info);
                Timer timer1 = new Timer();
                timer1.Enabled = true;
                timer1.Interval = 10000;
                timer1.Tick += closeform;
            }
            if (e.ProgressPercentage == 100 && this.CloseChck.Checked == false)
            {
                if (this.LangBox.Text == "RU")
                    notifyIcon1.ShowBalloonTip(10, "Загрузка завершена!", "Ваш файл находится в " + pathtofile + "\nНажмите, чтобы открыть папку\nНажмите дважды, чтобы показать окно", ToolTipIcon.Info);
                else
                    notifyIcon1.ShowBalloonTip(10, "Download complete!", "Downloaded file is in " + pathtofile + "\nClick to open the folder\nDouble click to show window", ToolTipIcon.Info);
                this.CpyRght.Visible = true;
                this.LangBox.Visible = true;
                this.CloseChck.Visible = true;
                this.ProgressBar.Visible = false;
                nullByClick = true;
            }
        }

        private void closeform(object sender, EventArgs e)
        {
            Application.Exit();
        }           

        private void PathButton_Click(object sender, EventArgs e)
        {
            if (link_contains)
            {
                var fresult = folderBrowserDialog1.ShowDialog();
                if (fresult == DialogResult.OK)
                {
                    pathtofile = folderBrowserDialog1.SelectedPath + "\\" + filedef;
                }
            }
            else
            {
                saveFileDialog1.Filter = "Any type|*.*|Windows Application|*.exe|ZIP archive|*.zip|RAR archive|*.rar|7Z archive|*.7z|JPEG Image|*.jpg |PNG Image|*.png|BITMAP Image|*.bmp|GIF Image|*.gif|TXT file|*.txt|MS WORD doc|*.docx|MS Power Point slideshow|*.pptx|PDF file|*.pdf|FB2 book|*.fb2|EPUB book|*.epub|HTML page|*.html|XML file|*.xml";
                var result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pathtofile = saveFileDialog1.FileName;
                }
                else if (!(result == DialogResult.Cancel))
                {
                    var select = MessageBox.Show("Файл не был выбран", "Error!",
                                 MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error);
                    if (select == DialogResult.Retry)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            pathtofile = saveFileDialog1.FileName;
                            this.PathBox.Text = pathtofile;
                            this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                        }
                        else
                        {
                            MessageBox.Show("Файл не был выбран", "Error!",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                        }
                    }
                }
            }
            this.PathBox.Text = pathtofile;
            this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }    

        private void LangBox_Click(object sender, EventArgs e)
        {
            if (this.LangBox.Text == "RU")
            {
                this.LangBox.Text = "EN";
                if (!link_contains)
                {
                    this.LinkBox.Text = "Paste the link here";
                    this.LinkBox.TextAlign = HorizontalAlignment.Center;
                }
                if (!(this.PathBox.Text == pathtofile))
                {
                    this.PathBox.Text = "Path to file";
                    this.PathBox.TextAlign = HorizontalAlignment.Center;
                }
                this.MainButton.Text = "Download";
                this.CloseChck.Text = "Exit after download";
            }
            else
            {
                this.LangBox.Text = "RU";
                if (!(this.PathBox.Text == pathtofile))
                {
                    this.PathBox.Text = "Путь к файлу";
                    this.PathBox.TextAlign = HorizontalAlignment.Center;
                }
                if (!link_contains)
                {
                    this.LinkBox.Text = "Вставьте ссылку сюда";
                    this.LinkBox.TextAlign = HorizontalAlignment.Center;
                }
                this.MainButton.Text = "Скачать";
                this.CloseChck.Text = "Закрыть после окончания";
            }
        }       

        private void LinkBox_Click(object sender, EventArgs e)
        {
            if (nullByClick)
            {
                this.LinkBox.Text = null;
                this.LinkBox.TextAlign = HorizontalAlignment.Left;
            }
        }       

        private void LinkBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LinkBox.Text.StartsWith("http://") || this.LinkBox.Text.StartsWith("https://"))
            {
                nullByClick = false;
                filedef = this.LinkBox.Text.Substring(this.LinkBox.Text.LastIndexOf('/') + 1);
                if (filedef.Contains("."))
                {
                    pathtofile = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString() + "\\" + filedef;
                    link_contains = true;
                    this.PathBox.Text = pathtofile;
                    this.PathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                }
            }
        } 
    }
}
