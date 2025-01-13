using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace Example1
{
    public partial class FormMain : Form
    {
        private VideoCapture _capture = null;
        private Mat _frame = new Mat(); // Mat สำหรับเก็บเฟรมจากกล้อง
        private bool IsConnect = true;
        private bool isCapturing = true; // Track connection state


        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"D:\SoftDev\haarcascade_frontalface_default\haarcascade_frontalface_default.xml");


        #region ProcessFrame
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture == null || _capture.Ptr == IntPtr.Zero) return;

            // ดึงเฟรมจากกล้องโดยใช้ Retrieve
            _capture.Retrieve(_frame);
            if (!_frame.IsEmpty)
            {
                // แปลงเฟรมเป็นรูปแบบ Image<Bgr, Byte>
                using (var imageFrame = _frame.ToImage<Bgr, Byte>())
                {
                    if (imageFrame != null)
                    {
                        // แปลงภาพเป็น Gray สำหรับการตรวจจับใบหน้า
                        using (var grayFrame = imageFrame.Convert<Gray, byte>())
                        {
                            // ตรวจจับใบหน้า
                            var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);

                            // วาดกรอบรอบใบหน้าที่ตรวจพบ
                            foreach (var face in faces)
                            {
                                imageFrame.Draw(face, new Bgr(Color.MistyRose), 3);
                            }

                            // แสดงผลใน imageBox1
                            Invoke(new Action(() =>
                            {
                                imageBox1.Image = imageFrame;

                                // แสดงภาพใบหน้าที่ตัดมาใน imageBox2
                                if (faces.Length > 0)
                                {
                                    Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, 190, 190);
                                    grayFrame.ROI = face_roi;
                                    imageBox2.Image = grayFrame.Copy();
                                }
                            }));
                        }
                    }
                }
            }
        }
        #endregion

        #region FormMain_FormClosing
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
                _capture.Dispose();
                _capture = null;
            }
            // แสดงข้อความแจ้งเตือน (ถ้าต้องการ)
            DialogResult result = MessageBox.Show("คุณต้องการปิดโปรแกรมใช่หรือไม่?",
                                                  "ยืนยันการปิด",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // ยกเลิกการปิดฟอร์ม
            }
        }
        #endregion

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
            buttonStsrt.Enabled = false; // ปิดปุ่ม Start ไว้ก่อนจนกว่าจะ Connect
            timerClock.Enabled = true;   // เปิดตัวโชว์นาฬิกา

            snapshotTimer = new Timer();
            snapshotTimer.Interval = 3000; // ตั้งเวลาเป็น 3 วินาที
            snapshotTimer.Tick += snapshotTimer_Tick;
        }
        #endregion


        #region FormMain_Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            UpDownChoosetime.Minimum = 1; // นาทีต่ำสุด
            UpDownChoosetime.Maximum = 10; // นาทีสูงสุด
            UpDownChoosetime.Value = 1;   // ค่าเริ่มต้น
            UpDownChoosetime.Increment = 1; // เพิ่มทีละ 1 นาที

            UpDownChoosetime.ValueChanged += UpDownChoosetime_ValueChanged;

            
        }
        #endregion

        #region butttonFlipHor
        private void buttonFlipHor_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipHorizontal = !_capture.FlipHorizontal;
        }
        #endregion

        #region buttonFlipVer
        private void buttonFlipVer_Click(object sender, EventArgs e)
        {
            if (_capture != null)
                _capture.FlipVertical = !_capture.FlipVertical;
        }
        #endregion

        private void imageBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #region ShowConnect
        private void ShowConnect_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
                _frame = new Mat();



            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }
        #endregion

        #region bottonConnect
        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            if (IsConnect)
            {
                buttonConnect.Text = "Disconnect";
                ShowConnect.BackColor = Color.Green;
                ShowConnect.Text = "Connected";
                buttonStsrt.Enabled = true;

                try
                {
                    // Initialize VideoCapture asynchronously
                    await Task.Run(() =>
                    {
                        _capture = new VideoCapture();
                        _capture.ImageGrabbed += ProcessFrame;
                        _frame = new Mat();
                    });
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
                catch (Exception excpt)
                {
                    MessageBox.Show($"Unexpected error: {excpt.Message}");
                }
            }
            else
            {
                buttonConnect.Text = "Connect";
                ShowConnect.BackColor = Color.Red;
                ShowConnect.Text = "Disconnected";
                buttonStsrt.Enabled = false;

                try
                {
                    // Release resources asynchronously
                    await Task.Run(() =>
                    {
                        if (_capture != null)
                        {
                            _capture.Pause();
                            _capture.Dispose();
                            _capture = null;
                        }
                    });
                }
                catch (Exception excpt)
                {
                    MessageBox.Show($"Unexpected error: {excpt.Message}");
                }
            }

            IsConnect = !IsConnect;
        }

        #endregion

        #region buttonStsrt
        private async void buttonStsrt_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                buttonStsrt.Text = "Pause";
                ShowStsrt.BackColor = Color.Green;
                ShowStsrt.Text = "Record";
                buttonConnect.Enabled = false;

                if (_capture != null)
                {
                    // Start capturing asynchronously
                    await Task.Run(() => _capture.Start());
                }

                snapshotTimer.Start(); // Start the snapshot timer
            }
            else
            {
                snapshotTimer.Stop();
                buttonStsrt.Text = "Start";
                ShowStsrt.BackColor = Color.Red;
                ShowStsrt.Text = "No record";
                buttonConnect.Enabled = true;

                try
                {
                    if (_capture != null)
                    {
                        await Task.Run(() =>
                        {
                            // Reinitialize the capture object asynchronously
                            _capture = new VideoCapture();
                            _capture.ImageGrabbed += ProcessFrame; // Attach the event handler
                            _frame = new Mat();
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error starting the camera: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            isCapturing = !isCapturing;
        }

        #endregion

        #region showStsrt
        private void ShowStsrt_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
                _frame = new Mat();

            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        #endregion


        #region TimeClock
        private void timerClock_Tick(object sender, EventArgs e)
        {
            string formatStringClock = "HH:mm:ss";
            string formatStringDate = "yyyy-MMM-dd";

            DateTime dtNow = DateTime.Now;
            statusLabelClock.Text = dtNow.ToString(formatStringClock);
            statusLabalDate.Text = dtNow.ToString(formatStringDate);
        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        #region imageBox2grey
        private void imageBox2_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                snapshotTimer.Stop(); // หยุดจับภาพ
                isCapturing = false;
                //MessageBox.Show("หยุดการจับภาพ", "สถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int selectedMinutes = (int)UpDownChoosetime.Value;
                snapshotTimer.Interval = selectedMinutes * 60 * 1000; // กำหนดเวลาในมิลลิวินาที
                snapshotTimer.Start(); // เริ่มจับภาพ
                isCapturing = true;
                //MessageBox.Show($"เริ่มจับภาพทุก ๆ {selectedMinutes} นาที", "สถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        #region CheckBoxRecognizer
        private void checkBoxRecognizer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecognizer.Checked)
            {
                checkBoxSnpshot.Enabled = false; // ล็อก checkBoxSnpshot

            }
            else
            {
                checkBoxSnpshot.Enabled = true; // ปลดล็อก checkBoxSnpshot

            }

        }
        #endregion

        #region CheckBoxSnpshot
        private void checkBoxSnpshot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSnpshot.Checked)
            {
                checkBoxRecognizer.Enabled = false; // ล็อก checkBoxRecognizer
                snapshotTimer.Start(); // เริ่มจับเวลา
            }
            else
            {
                checkBoxRecognizer.Enabled = true; // ปลดล็อก checkBoxRecognizer
                snapshotTimer.Stop(); // หยุดจับเวลา
            }

        }
        #endregion


        #region buttonBrowse
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // ตั้งค่าต่างๆ ของ FolderBrowserDialog
                folderDialog.Description = "กรุณาเลือกโฟลเดอร์";
                folderDialog.ShowNewFolderButton = true; // อนุญาตให้สร้างโฟลเดอร์ใหม่
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // กำหนดโฟลเดอร์เริ่มต้น

                // แสดงหน้าต่างเลือกโฟลเดอร์
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // แสดงเส้นทางที่เลือกใน MessageBox หรือ TextBox
                    string selectedPath = folderDialog.SelectedPath;
                    textBoxImageFolder.Text = selectedPath;
                }
            }
        }
        #endregion


        #region SnapshotTimer
        private void snapshotTimer_Tick(object sender, EventArgs e)
        {
            string folderPath = textBoxImageFolder.Text;
            if (!string.IsNullOrEmpty(folderPath) && System.IO.Directory.Exists(folderPath))
            {
                // สร้างชื่อไฟล์แบบไดนามิก
                string fileName = $"snapshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string filePath = System.IO.Path.Combine(folderPath, fileName);

                // จับภาพหน้าจอและบันทึกในโฟลเดอร์
                using (var imageFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
                {
                    if (imageFrame != null)
                    {
                        var grayFrame = imageFrame.Convert<Gray, byte>();
                        var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);
                        if (faces.Length > 0)
                        {
                            try
                            {
                                int interval = (int)UpDownChoosetime.Value * 1000;
                                snapshotTimer.Interval = interval;
                                Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, faces[0].Width, faces[0].Height);
                                grayFrame.ROI = face_roi;
                                var faceImage = grayFrame.Copy();
                                faceImage.Save(filePath);
                                textBoxShowim.AppendText($"Snapshot saved to : {filePath}{Environment.NewLine}");
                                textBoxShowim.AppendText($"Timer Interval: {snapshotTimer.Interval} ms{Environment.NewLine}");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error saving snapshot: {ex.Message}");
                            }
                        }

                    }
                }
            }
        
            else
            {
                MessageBox.Show("กรุณาเลือกโฟลเดอร์ที่ถูกต้องสำหรับการบันทึกภาพ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                snapshotTimer.Stop(); // หยุดจับเวลา
                checkBoxSnpshot.Checked = false; // ยกเลิกการเลือก CheckBox
            }

        }
        #endregion



        private void textBoxShowim_TextChanged(object sender, EventArgs e)
        {

        }
        #region UpDoownChoosetim
        private void UpDownChoosetime_ValueChanged(object sender, EventArgs e)
        {
            int selectedMinutes = (int)UpDownChoosetime.Value;

            
            //int milliseconds = selectedMinutes * 60 * 1000; // แปลงนาทีเป็นมิลลิวินาที
            //snapshotTimer.Interval = milliseconds;
            
        }
        #endregion

        private void statusLabalDate_Click(object sender, EventArgs e)
        {

        }
    }
}