using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                //DialogResult dialogResult;
                // dialogResult =
                //         MessageBox.Show(
                //             $@"Bạn ơi, phần mềm của bạn có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
                //             MessageBoxButtons.YesNo,
                //             MessageBoxIcon.Information);

                //if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                //{
                try
                {
                    if (AutoUpdater.DownloadUpdate(args))
                    {
                        Application.Exit();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                //}

            }
            //else
            //{
            //    MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            progressBar1.Visible = true;
         
            this.progressBar1.Value = this.progressBar1.Value + 2;
            if (this.progressBar1.Value == 10)
            {
                label3.Text = "Đang kiểm tra hệ thống..";
            }
            else if (this.progressBar1.Value == 20)
            {
                label3.Text = "Hệ thống đang bật.";
            }
            else if (this.progressBar1.Value == 40)
            {
                label3.Text = "Khởi chạy..";
            }
            else if (this.progressBar1.Value == 60)
            {
                label3.Text = "Lọc dữ liệu..";
            }
            else if (this.progressBar1.Value == 80)
            {
                label3.Text = "Khởi chạy thành công..";
            }
            else if (this.progressBar1.Value == 100)
            {
                frm.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            progressBar1.Width = this.Width;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            //AutoUpdater.Start("http://upload.winerp.org:8182/upload/update.xml");
            AutoUpdater.Start("http://desktop-4b45dmq/update-POS.xml");
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.ReportErrors = true;
            AutoUpdater.UpdateMode = Mode.Forced;
            AutoUpdater.RunUpdateAsAdmin = true;
            string version = fvi.FileVersion;
            label2.Text = "Phiên bản: " + version;
            AutoUpdater.DownloadPath = "update";
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 15 * 60 * 1000,
                SynchronizingObject = this
            };
            timer.Elapsed += delegate
            {
                //AutoUpdater.Start("http://upload.winerp.org:8182/upload/update.xml");//KD: update.xml , KT: update_kt.xml
                AutoUpdater.Start("http://desktop-4b45dmq/update-POS.xml");
            };
            timer.Start();
        }
    }
}
