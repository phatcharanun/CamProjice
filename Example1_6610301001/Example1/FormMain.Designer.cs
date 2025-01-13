namespace Example1
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFlipVer = new System.Windows.Forms.Button();
            this.buttonFlipHor = new System.Windows.Forms.Button();
            this.buttonStsrt = new System.Windows.Forms.Button();
            this.ShowConnect = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowStsrt = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.statusLabalDate = new System.Windows.Forms.Label();
            this.statusLabelClock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImageFolder = new System.Windows.Forms.TextBox();
            this.snapshotTimer = new System.Windows.Forms.Timer(this.components);
            this.textBoxShowim = new System.Windows.Forms.TextBox();
            this.checkBoxRecognizer = new System.Windows.Forms.CheckBox();
            this.checkBoxSnpshot = new System.Windows.Forms.CheckBox();
            this.GroupBoxFaces = new System.Windows.Forms.GroupBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.groupBoxRecognizer = new System.Windows.Forms.GroupBox();
            this.UpDownChoosetime = new System.Windows.Forms.NumericUpDown();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.GroupBoxFaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.groupBoxRecognizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChoosetime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.BackgroundImage = global::Example1.Properties.Resources.pngtree_prohibition_icon_in_public_image_2274212;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.Location = new System.Drawing.Point(15, 21);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(378, 232);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConnect.Location = new System.Drawing.Point(10, 34);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(110, 64);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonFlipVer);
            this.groupBox2.Controls.Add(this.buttonFlipHor);
            this.groupBox2.Controls.Add(this.buttonStsrt);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Location = new System.Drawing.Point(36, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool";
            // 
            // buttonFlipVer
            // 
            this.buttonFlipVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipVer.Location = new System.Drawing.Point(243, 77);
            this.buttonFlipVer.Name = "buttonFlipVer";
            this.buttonFlipVer.Size = new System.Drawing.Size(62, 21);
            this.buttonFlipVer.TabIndex = 5;
            this.buttonFlipVer.Text = "FlipVer";
            this.buttonFlipVer.UseVisualStyleBackColor = true;
            this.buttonFlipVer.Click += new System.EventHandler(this.buttonFlipVer_Click);
            // 
            // buttonFlipHor
            // 
            this.buttonFlipHor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipHor.Location = new System.Drawing.Point(243, 42);
            this.buttonFlipHor.Name = "buttonFlipHor";
            this.buttonFlipHor.Size = new System.Drawing.Size(62, 28);
            this.buttonFlipHor.TabIndex = 4;
            this.buttonFlipHor.Text = "FlipHor";
            this.buttonFlipHor.UseVisualStyleBackColor = true;
            this.buttonFlipHor.Click += new System.EventHandler(this.buttonFlipHor_Click);
            // 
            // buttonStsrt
            // 
            this.buttonStsrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonStsrt.Location = new System.Drawing.Point(127, 34);
            this.buttonStsrt.Name = "buttonStsrt";
            this.buttonStsrt.Size = new System.Drawing.Size(109, 64);
            this.buttonStsrt.TabIndex = 6;
            this.buttonStsrt.Text = "Stsrt";
            this.buttonStsrt.UseVisualStyleBackColor = true;
            this.buttonStsrt.Click += new System.EventHandler(this.buttonStsrt_Click);
            // 
            // ShowConnect
            // 
            this.ShowConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowConnect.Location = new System.Drawing.Point(12, 416);
            this.ShowConnect.Name = "ShowConnect";
            this.ShowConnect.Size = new System.Drawing.Size(159, 22);
            this.ShowConnect.TabIndex = 4;
            this.ShowConnect.TextChanged += new System.EventHandler(this.ShowConnect_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 28);
            this.contextMenuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ShowStsrt
            // 
            this.ShowStsrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowStsrt.Location = new System.Drawing.Point(171, 416);
            this.ShowStsrt.Name = "ShowStsrt";
            this.ShowStsrt.Size = new System.Drawing.Size(170, 22);
            this.ShowStsrt.TabIndex = 7;
            this.ShowStsrt.TextChanged += new System.EventHandler(this.ShowStsrt_TextChanged_2);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // statusLabalDate
            // 
            this.statusLabalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabalDate.AutoSize = true;
            this.statusLabalDate.Location = new System.Drawing.Point(721, 419);
            this.statusLabalDate.Name = "statusLabalDate";
            this.statusLabalDate.Size = new System.Drawing.Size(32, 16);
            this.statusLabalDate.TabIndex = 8;
            this.statusLabalDate.Text = "Day";
            this.statusLabalDate.Click += new System.EventHandler(this.statusLabalDate_Click);
            // 
            // statusLabelClock
            // 
            this.statusLabelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabelClock.AutoSize = true;
            this.statusLabelClock.Location = new System.Drawing.Point(646, 419);
            this.statusLabelClock.Name = "statusLabelClock";
            this.statusLabelClock.Size = new System.Drawing.Size(38, 16);
            this.statusLabelClock.TabIndex = 9;
            this.statusLabelClock.Text = "Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Training lmage(s) Folder";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxImageFolder
            // 
            this.textBoxImageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFolder.Location = new System.Drawing.Point(21, 90);
            this.textBoxImageFolder.Name = "textBoxImageFolder";
            this.textBoxImageFolder.Size = new System.Drawing.Size(204, 22);
            this.textBoxImageFolder.TabIndex = 14;
            // 
            // snapshotTimer
            // 
            this.snapshotTimer.Tick += new System.EventHandler(this.snapshotTimer_Tick);
            // 
            // textBoxShowim
            // 
            this.textBoxShowim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShowim.Location = new System.Drawing.Point(427, 215);
            this.textBoxShowim.Multiline = true;
            this.textBoxShowim.Name = "textBoxShowim";
            this.textBoxShowim.ReadOnly = true;
            this.textBoxShowim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxShowim.Size = new System.Drawing.Size(396, 195);
            this.textBoxShowim.TabIndex = 15;
            this.textBoxShowim.UseWaitCursor = true;
            this.textBoxShowim.TextChanged += new System.EventHandler(this.textBoxShowim_TextChanged);
            // 
            // checkBoxRecognizer
            // 
            this.checkBoxRecognizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRecognizer.AutoSize = true;
            this.checkBoxRecognizer.Location = new System.Drawing.Point(21, 22);
            this.checkBoxRecognizer.Name = "checkBoxRecognizer";
            this.checkBoxRecognizer.Size = new System.Drawing.Size(142, 20);
            this.checkBoxRecognizer.TabIndex = 16;
            this.checkBoxRecognizer.Text = "On / off Recognizer";
            this.checkBoxRecognizer.UseVisualStyleBackColor = true;
            this.checkBoxRecognizer.CheckedChanged += new System.EventHandler(this.checkBoxRecognizer_CheckedChanged);
            // 
            // checkBoxSnpshot
            // 
            this.checkBoxSnpshot.AutoSize = true;
            this.checkBoxSnpshot.Location = new System.Drawing.Point(21, 48);
            this.checkBoxSnpshot.Name = "checkBoxSnpshot";
            this.checkBoxSnpshot.Size = new System.Drawing.Size(120, 20);
            this.checkBoxSnpshot.TabIndex = 17;
            this.checkBoxSnpshot.Text = "on / off Snpshot";
            this.checkBoxSnpshot.UseVisualStyleBackColor = true;
            this.checkBoxSnpshot.CheckedChanged += new System.EventHandler(this.checkBoxSnpshot_CheckedChanged);
            // 
            // GroupBoxFaces
            // 
            this.GroupBoxFaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFaces.Controls.Add(this.imageBox2);
            this.GroupBoxFaces.Location = new System.Drawing.Point(427, 24);
            this.GroupBoxFaces.Name = "GroupBoxFaces";
            this.GroupBoxFaces.Size = new System.Drawing.Size(148, 139);
            this.GroupBoxFaces.TabIndex = 19;
            this.GroupBoxFaces.TabStop = false;
            this.GroupBoxFaces.Text = "Faces";
            // 
            // imageBox2
            // 
            this.imageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox2.BackgroundImage = global::Example1.Properties.Resources.pngtree_prohibition_icon_in_public_image_2274212;
            this.imageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox2.Location = new System.Drawing.Point(13, 18);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(114, 110);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // groupBoxRecognizer
            // 
            this.groupBoxRecognizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecognizer.Controls.Add(this.UpDownChoosetime);
            this.groupBoxRecognizer.Controls.Add(this.buttonBrowse);
            this.groupBoxRecognizer.Controls.Add(this.checkBoxRecognizer);
            this.groupBoxRecognizer.Controls.Add(this.textBoxImageFolder);
            this.groupBoxRecognizer.Controls.Add(this.checkBoxSnpshot);
            this.groupBoxRecognizer.Controls.Add(this.label4);
            this.groupBoxRecognizer.Location = new System.Drawing.Point(581, 24);
            this.groupBoxRecognizer.Name = "groupBoxRecognizer";
            this.groupBoxRecognizer.Size = new System.Drawing.Size(242, 174);
            this.groupBoxRecognizer.TabIndex = 7;
            this.groupBoxRecognizer.TabStop = false;
            this.groupBoxRecognizer.Text = "Recognizer";
            // 
            // UpDownChoosetime
            // 
            this.UpDownChoosetime.Location = new System.Drawing.Point(147, 48);
            this.UpDownChoosetime.Name = "UpDownChoosetime";
            this.UpDownChoosetime.Size = new System.Drawing.Size(48, 22);
            this.UpDownChoosetime.TabIndex = 20;
            this.UpDownChoosetime.ValueChanged += new System.EventHandler(this.UpDownChoosetime_ValueChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(150, 118);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 19;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.groupBoxRecognizer);
            this.Controls.Add(this.GroupBoxFaces);
            this.Controls.Add(this.textBoxShowim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusLabelClock);
            this.Controls.Add(this.statusLabalDate);
            this.Controls.Add(this.ShowStsrt);
            this.Controls.Add(this.ShowConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GroupBoxFaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.groupBoxRecognizer.ResumeLayout(false);
            this.groupBoxRecognizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChoosetime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFlipHor;
        private System.Windows.Forms.Button buttonFlipVer;
        private System.Windows.Forms.TextBox ShowConnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonStsrt;
        private System.Windows.Forms.TextBox ShowStsrt;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label statusLabalDate;
        private System.Windows.Forms.Label statusLabelClock;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImageFolder;
        private System.Windows.Forms.Timer snapshotTimer;
        private System.Windows.Forms.TextBox textBoxShowim;
        private System.Windows.Forms.CheckBox checkBoxRecognizer;
        private System.Windows.Forms.CheckBox checkBoxSnpshot;
        private System.Windows.Forms.GroupBox GroupBoxFaces;
        private System.Windows.Forms.GroupBox groupBoxRecognizer;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.NumericUpDown UpDownChoosetime;
    }
}

