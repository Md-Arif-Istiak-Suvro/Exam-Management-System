namespace Exam_Management_System
{
    partial class Candidates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidates));
            pictureBox1 = new PictureBox();
            QsnBankLabel = new Label();
            CandidatesDGV = new DataGridView();
            ResetBtn = new MaterialSkin.Controls.MaterialButton();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            SaveBtn = new MaterialSkin.Controls.MaterialButton();
            PhoneTb = new MaterialSkin.Controls.MaterialTextBox2();
            AddressTb = new MaterialSkin.Controls.MaterialTextBox2();
            CAgeTb = new MaterialSkin.Controls.MaterialTextBox2();
            PasswordTb = new MaterialSkin.Controls.MaterialTextBox2();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            CNameTb = new MaterialSkin.Controls.MaterialTextBox2();
            QsnQsnPanel = new Panel();
            QsnCandidates = new Label();
            Qsnsub = new Label();
            QsnName1 = new Label();
            QsnBack2 = new Panel();
            pictureBox2 = new PictureBox();
            QsnQsn = new Label();
            QsnBack1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CandidatesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            QsnBack2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            QsnBack1.SuspendLayout();
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
            // QsnBankLabel
            // 
            QsnBankLabel.AutoSize = true;
            QsnBankLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QsnBankLabel.Location = new Point(480, 347);
            QsnBankLabel.Name = "QsnBankLabel";
            QsnBankLabel.Size = new Size(155, 28);
            QsnBankLabel.TabIndex = 16;
            QsnBankLabel.Text = "Candidates List";
            // 
            // CandidatesDGV
            // 
            CandidatesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CandidatesDGV.BackgroundColor = SystemColors.ButtonHighlight;
            CandidatesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CandidatesDGV.Location = new Point(3, 381);
            CandidatesDGV.Name = "CandidatesDGV";
            CandidatesDGV.RowHeadersWidth = 51;
            CandidatesDGV.Size = new Size(1085, 303);
            CandidatesDGV.TabIndex = 15;
            CandidatesDGV.CellContentClick += CandidatesDGV_CellContentClick;
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
            ResetBtn.Location = new Point(681, 305);
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
            EditBtn.Location = new Point(519, 305);
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
            SaveBtn.Location = new Point(365, 305);
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
            // PhoneTb
            // 
            PhoneTb.AnimateReadOnly = false;
            PhoneTb.BackgroundImageLayout = ImageLayout.None;
            PhoneTb.CharacterCasing = CharacterCasing.Normal;
            PhoneTb.Depth = 0;
            PhoneTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneTb.HideSelection = true;
            PhoneTb.LeadingIcon = null;
            PhoneTb.Location = new Point(607, 224);
            PhoneTb.MaxLength = 32767;
            PhoneTb.MouseState = MaterialSkin.MouseState.OUT;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.PasswordChar = '\0';
            PhoneTb.PrefixSuffixText = null;
            PhoneTb.ReadOnly = false;
            PhoneTb.RightToLeft = RightToLeft.No;
            PhoneTb.SelectedText = "";
            PhoneTb.SelectionLength = 0;
            PhoneTb.SelectionStart = 0;
            PhoneTb.ShortcutsEnabled = true;
            PhoneTb.Size = new Size(268, 48);
            PhoneTb.TabIndex = 11;
            PhoneTb.TabStop = false;
            PhoneTb.Text = "Phone";
            PhoneTb.TextAlign = HorizontalAlignment.Center;
            PhoneTb.TrailingIcon = null;
            PhoneTb.UseSystemPasswordChar = false;
            // 
            // AddressTb
            // 
            AddressTb.AnimateReadOnly = false;
            AddressTb.BackgroundImageLayout = ImageLayout.None;
            AddressTb.CharacterCasing = CharacterCasing.Normal;
            AddressTb.Depth = 0;
            AddressTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressTb.HideSelection = true;
            AddressTb.LeadingIcon = null;
            AddressTb.Location = new Point(661, 129);
            AddressTb.MaxLength = 32767;
            AddressTb.MouseState = MaterialSkin.MouseState.OUT;
            AddressTb.Name = "AddressTb";
            AddressTb.PasswordChar = '\0';
            AddressTb.PrefixSuffixText = null;
            AddressTb.ReadOnly = false;
            AddressTb.RightToLeft = RightToLeft.No;
            AddressTb.SelectedText = "";
            AddressTb.SelectionLength = 0;
            AddressTb.SelectionStart = 0;
            AddressTb.ShortcutsEnabled = true;
            AddressTb.Size = new Size(393, 48);
            AddressTb.TabIndex = 10;
            AddressTb.TabStop = false;
            AddressTb.Text = "Address";
            AddressTb.TextAlign = HorizontalAlignment.Center;
            AddressTb.TrailingIcon = null;
            AddressTb.UseSystemPasswordChar = false;
            // 
            // CAgeTb
            // 
            CAgeTb.AnimateReadOnly = false;
            CAgeTb.BackgroundImageLayout = ImageLayout.None;
            CAgeTb.CharacterCasing = CharacterCasing.Normal;
            CAgeTb.Depth = 0;
            CAgeTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CAgeTb.HideSelection = true;
            CAgeTb.LeadingIcon = null;
            CAgeTb.Location = new Point(471, 129);
            CAgeTb.MaxLength = 32767;
            CAgeTb.MouseState = MaterialSkin.MouseState.OUT;
            CAgeTb.Name = "CAgeTb";
            CAgeTb.PasswordChar = '\0';
            CAgeTb.PrefixSuffixText = null;
            CAgeTb.ReadOnly = false;
            CAgeTb.RightToLeft = RightToLeft.No;
            CAgeTb.SelectedText = "";
            CAgeTb.SelectionLength = 0;
            CAgeTb.SelectionStart = 0;
            CAgeTb.ShortcutsEnabled = true;
            CAgeTb.Size = new Size(145, 48);
            CAgeTb.TabIndex = 9;
            CAgeTb.TabStop = false;
            CAgeTb.Text = "Age";
            CAgeTb.TextAlign = HorizontalAlignment.Center;
            CAgeTb.TrailingIcon = null;
            CAgeTb.UseSystemPasswordChar = false;
            // 
            // PasswordTb
            // 
            PasswordTb.AnimateReadOnly = false;
            PasswordTb.BackgroundImageLayout = ImageLayout.None;
            PasswordTb.CharacterCasing = CharacterCasing.Normal;
            PasswordTb.Depth = 0;
            PasswordTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTb.HideSelection = true;
            PasswordTb.LeadingIcon = null;
            PasswordTb.Location = new Point(227, 224);
            PasswordTb.MaxLength = 32767;
            PasswordTb.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '\0';
            PasswordTb.PrefixSuffixText = null;
            PasswordTb.ReadOnly = false;
            PasswordTb.RightToLeft = RightToLeft.No;
            PasswordTb.SelectedText = "";
            PasswordTb.SelectionLength = 0;
            PasswordTb.SelectionStart = 0;
            PasswordTb.ShortcutsEnabled = true;
            PasswordTb.Size = new Size(270, 48);
            PasswordTb.TabIndex = 8;
            PasswordTb.TabStop = false;
            PasswordTb.Text = "Password";
            PasswordTb.TextAlign = HorizontalAlignment.Center;
            PasswordTb.TrailingIcon = null;
            PasswordTb.UseSystemPasswordChar = false;
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
            pictureBox3.Click += pictureBox3_Click;
            // 
            // CNameTb
            // 
            CNameTb.AnimateReadOnly = false;
            CNameTb.BackgroundImageLayout = ImageLayout.None;
            CNameTb.CharacterCasing = CharacterCasing.Normal;
            CNameTb.Depth = 0;
            CNameTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CNameTb.HideSelection = true;
            CNameTb.LeadingIcon = null;
            CNameTb.Location = new Point(38, 129);
            CNameTb.MaxLength = 32767;
            CNameTb.MouseState = MaterialSkin.MouseState.OUT;
            CNameTb.Name = "CNameTb";
            CNameTb.PasswordChar = '\0';
            CNameTb.PrefixSuffixText = null;
            CNameTb.ReadOnly = false;
            CNameTb.RightToLeft = RightToLeft.No;
            CNameTb.SelectedText = "";
            CNameTb.SelectionLength = 0;
            CNameTb.SelectionStart = 0;
            CNameTb.ShortcutsEnabled = true;
            CNameTb.Size = new Size(391, 48);
            CNameTb.TabIndex = 6;
            CNameTb.TabStop = false;
            CNameTb.Text = "Name";
            CNameTb.TextAlign = HorizontalAlignment.Center;
            CNameTb.TrailingIcon = null;
            CNameTb.UseSystemPasswordChar = false;
            // 
            // QsnQsnPanel
            // 
            QsnQsnPanel.BackColor = SystemColors.WindowText;
            QsnQsnPanel.Location = new Point(697, 68);
            QsnQsnPanel.Name = "QsnQsnPanel";
            QsnQsnPanel.Size = new Size(100, 5);
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
            Qsnsub.Click += Qsnsub_Click;
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
            // 
            // QsnBack1
            // 
            QsnBack1.BackColor = Color.MediumPurple;
            QsnBack1.Controls.Add(QsnBankLabel);
            QsnBack1.Controls.Add(CandidatesDGV);
            QsnBack1.Controls.Add(ResetBtn);
            QsnBack1.Controls.Add(EditBtn);
            QsnBack1.Controls.Add(SaveBtn);
            QsnBack1.Controls.Add(PhoneTb);
            QsnBack1.Controls.Add(AddressTb);
            QsnBack1.Controls.Add(CAgeTb);
            QsnBack1.Controls.Add(PasswordTb);
            QsnBack1.Controls.Add(CNameTb);
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
            // Candidates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 686);
            Controls.Add(QsnBack1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Candidates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Candidates";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CandidatesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            QsnBack2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            QsnBack1.ResumeLayout(false);
            QsnBack1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label QsnBankLabel;
        private DataGridView CandidatesDGV;
        private MaterialSkin.Controls.MaterialButton ResetBtn;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialTextBox2 PhoneTb;
        private MaterialSkin.Controls.MaterialTextBox2 AddressTb;
        private MaterialSkin.Controls.MaterialTextBox2 CAgeTb;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordTb;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox2 CNameTb;
        private Panel QsnQsnPanel;
        private Label QsnCandidates;
        private Label Qsnsub;
        private Label QsnName1;
        private Panel QsnBack2;
        private PictureBox pictureBox2;
        private Label QsnQsn;
        private Panel QsnBack1;
    }
}