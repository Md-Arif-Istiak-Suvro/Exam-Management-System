namespace Exam_Management_System
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            pictureBox1 = new PictureBox();
            SubjectLabel = new Label();
            ResetBtn = new MaterialSkin.Controls.MaterialButton();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            SaveBtn = new MaterialSkin.Controls.MaterialButton();
            SNameTb = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            QsnQsnPanel = new Panel();
            QsnCandidates = new Label();
            Qsnsub = new Label();
            QsnName1 = new Label();
            QsnBack2 = new Panel();
            pictureBox2 = new PictureBox();
            QsnQsn = new Label();
            QsnBack1 = new Panel();
            SubjectsDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            QsnBack2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            QsnBack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectsDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SubjectLabel
            // 
            SubjectLabel.AutoSize = true;
            SubjectLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectLabel.Location = new Point(503, 290);
            SubjectLabel.Name = "SubjectLabel";
            SubjectLabel.Size = new Size(121, 28);
            SubjectLabel.TabIndex = 16;
            SubjectLabel.Text = "Subject List";
            // 
            // ResetBtn
            // 
            ResetBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResetBtn.BackColor = Color.GhostWhite;
            ResetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResetBtn.Depth = 0;
            ResetBtn.ForeColor = SystemColors.ButtonHighlight;
            ResetBtn.HighEmphasis = true;
            ResetBtn.Icon = null;
            ResetBtn.Location = new Point(672, 233);
            ResetBtn.Margin = new Padding(4, 6, 4, 6);
            ResetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ResetBtn.Name = "ResetBtn";
            ResetBtn.NoAccentTextColor = Color.Empty;
            ResetBtn.Size = new Size(65, 36);
            ResetBtn.TabIndex = 14;
            ResetBtn.Text = "Reset";
            ResetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ResetBtn.UseAccentColor = false;
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditBtn.BackColor = Color.GhostWhite;
            EditBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditBtn.Depth = 0;
            EditBtn.ForeColor = SystemColors.ButtonHighlight;
            EditBtn.HighEmphasis = true;
            EditBtn.Icon = null;
            EditBtn.Location = new Point(528, 233);
            EditBtn.Margin = new Padding(4, 6, 4, 6);
            EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBtn.Name = "EditBtn";
            EditBtn.NoAccentTextColor = Color.Empty;
            EditBtn.Size = new Size(64, 36);
            EditBtn.TabIndex = 13;
            EditBtn.Text = "Edit";
            EditBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditBtn.UseAccentColor = false;
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBtn.BackColor = Color.GhostWhite;
            SaveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveBtn.Depth = 0;
            SaveBtn.ForeColor = SystemColors.ButtonHighlight;
            SaveBtn.HighEmphasis = true;
            SaveBtn.Icon = null;
            SaveBtn.Location = new Point(365, 233);
            SaveBtn.Margin = new Padding(4, 6, 4, 6);
            SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NoAccentTextColor = Color.Empty;
            SaveBtn.Size = new Size(64, 36);
            SaveBtn.TabIndex = 12;
            SaveBtn.Text = "Save";
            SaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveBtn.UseAccentColor = false;
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // SNameTb
            // 
            SNameTb.AnimateReadOnly = false;
            SNameTb.BackgroundImageLayout = ImageLayout.None;
            SNameTb.CharacterCasing = CharacterCasing.Normal;
            SNameTb.Depth = 0;
            SNameTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SNameTb.HideSelection = true;
            SNameTb.LeadingIcon = null;
            SNameTb.Location = new Point(423, 141);
            SNameTb.MaxLength = 32767;
            SNameTb.MouseState = MaterialSkin.MouseState.OUT;
            SNameTb.Name = "SNameTb";
            SNameTb.PasswordChar = '\0';
            SNameTb.PrefixSuffixText = null;
            SNameTb.ReadOnly = false;
            SNameTb.RightToLeft = RightToLeft.No;
            SNameTb.SelectedText = "";
            SNameTb.SelectionLength = 0;
            SNameTb.SelectionStart = 0;
            SNameTb.ShortcutsEnabled = true;
            SNameTb.Size = new Size(270, 48);
            SNameTb.TabIndex = 9;
            SNameTb.TabStop = false;
            SNameTb.Text = "Subject Name";
            SNameTb.TextAlign = HorizontalAlignment.Center;
            SNameTb.TrailingIcon = null;
            SNameTb.UseSystemPasswordChar = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 433);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 58);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 536);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 334);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // QsnQsnPanel
            // 
            QsnQsnPanel.BackColor = SystemColors.WindowText;
            QsnQsnPanel.Location = new Point(519, 68);
            QsnQsnPanel.Name = "QsnQsnPanel";
            QsnQsnPanel.Size = new Size(85, 5);
            QsnQsnPanel.TabIndex = 5;
            // 
            // QsnCandidates
            // 
            QsnCandidates.AutoSize = true;
            QsnCandidates.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QsnCandidates.Location = new Point(697, 40);
            QsnCandidates.Name = "QsnCandidates";
            QsnCandidates.Size = new Size(106, 25);
            QsnCandidates.TabIndex = 4;
            QsnCandidates.Text = "Candidates";
            QsnCandidates.Click += QsnCandidates_Click;
            // 
            // Qsnsub
            // 
            Qsnsub.AutoSize = true;
            Qsnsub.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Qsnsub.Location = new Point(519, 40);
            Qsnsub.Name = "Qsnsub";
            Qsnsub.Size = new Size(83, 25);
            Qsnsub.TabIndex = 3;
            Qsnsub.Text = "Subjects";
            // 
            // QsnName1
            // 
            QsnName1.AutoSize = true;
            QsnName1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QsnName1.Location = new Point(12, 9);
            QsnName1.Name = "QsnName1";
            QsnName1.Size = new Size(199, 20);
            QsnName1.TabIndex = 1;
            QsnName1.Text = "Exam Management System";
            // 
            // QsnBack2
            // 
            QsnBack2.BackColor = Color.Black;
            QsnBack2.Controls.Add(pictureBox6);
            QsnBack2.Controls.Add(pictureBox5);
            QsnBack2.Controls.Add(pictureBox4);
            QsnBack2.Controls.Add(pictureBox3);
            QsnBack2.Controls.Add(pictureBox2);
            QsnBack2.Controls.Add(pictureBox1);
            QsnBack2.Location = new Point(1088, 0);
            QsnBack2.Name = "QsnBack2";
            QsnBack2.Size = new Size(63, 687);
            QsnBack2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // QsnQsn
            // 
            QsnQsn.AutoSize = true;
            QsnQsn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QsnQsn.Location = new Point(332, 40);
            QsnQsn.Name = "QsnQsn";
            QsnQsn.Size = new Size(97, 25);
            QsnQsn.TabIndex = 2;
            QsnQsn.Text = "Questions";
            QsnQsn.Click += QsnQsn_Click;
            // 
            // QsnBack1
            // 
            QsnBack1.BackColor = Color.MediumPurple;
            QsnBack1.Controls.Add(SubjectsDGV);
            QsnBack1.Controls.Add(SubjectLabel);
            QsnBack1.Controls.Add(ResetBtn);
            QsnBack1.Controls.Add(EditBtn);
            QsnBack1.Controls.Add(SaveBtn);
            QsnBack1.Controls.Add(SNameTb);
            QsnBack1.Controls.Add(QsnQsnPanel);
            QsnBack1.Controls.Add(QsnCandidates);
            QsnBack1.Controls.Add(Qsnsub);
            QsnBack1.Controls.Add(QsnQsn);
            QsnBack1.Controls.Add(QsnName1);
            QsnBack1.Controls.Add(QsnBack2);
            QsnBack1.Location = new Point(0, 0);
            QsnBack1.Name = "QsnBack1";
            QsnBack1.Size = new Size(1151, 687);
            QsnBack1.TabIndex = 1;
            // 
            // SubjectsDGV
            // 
            SubjectsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubjectsDGV.BackgroundColor = SystemColors.ButtonHighlight;
            SubjectsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectsDGV.Location = new Point(3, 334);
            SubjectsDGV.Name = "SubjectsDGV";
            SubjectsDGV.RowHeadersWidth = 51;
            SubjectsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubjectsDGV.Size = new Size(1085, 353);
            SubjectsDGV.TabIndex = 17;
            SubjectsDGV.CellContentClick += SubjectsDGV_CellContentClick;
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 686);
            Controls.Add(QsnBack1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Subjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            QsnBack2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            QsnBack1.ResumeLayout(false);
            QsnBack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectsDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label SubjectLabel;
        private MaterialSkin.Controls.MaterialButton ResetBtn;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialTextBox2 Opt4;
        private MaterialSkin.Controls.MaterialTextBox2 Opt2;
        private MaterialSkin.Controls.MaterialTextBox2 SNameTb;
        private MaterialSkin.Controls.MaterialTextBox2 Opt3;
        private ComboBox SubjrctSelect;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox2 QsnWrite;
        private Panel QsnQsnPanel;
        private Label QsnCandidates;
        private Label Qsnsub;
        private Label QsnName1;
        private Panel QsnBack2;
        private PictureBox pictureBox2;
        private Label QsnQsn;
        private Panel QsnBack1;
        private DataGridView SubjectsDGV;
    }
}