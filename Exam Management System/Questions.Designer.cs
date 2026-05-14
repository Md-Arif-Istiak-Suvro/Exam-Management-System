namespace Exam_Management_System
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            QsnBack1 = new Panel();
            QuestionsDGV = new DataGridView();
            AnswerTb = new MaterialSkin.Controls.MaterialTextBox2();
            QsnBankLabel = new Label();
            ResetBtn = new MaterialSkin.Controls.MaterialButton();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            SaveBtn = new MaterialSkin.Controls.MaterialButton();
            Op4Tb = new MaterialSkin.Controls.MaterialTextBox2();
            Op2Tb = new MaterialSkin.Controls.MaterialTextBox2();
            Op1Tb = new MaterialSkin.Controls.MaterialTextBox2();
            Op3Tb = new MaterialSkin.Controls.MaterialTextBox2();
            SubjectCb = new ComboBox();
            QuestTb = new MaterialSkin.Controls.MaterialTextBox2();
            QsnQsnPanel = new Panel();
            QsnCandidates = new Label();
            Qsnsub = new Label();
            QsnQsn = new Label();
            QsnName1 = new Label();
            QsnBack2 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            QsnBack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsDGV).BeginInit();
            QsnBack2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // QsnBack1
            // 
            QsnBack1.BackColor = Color.MediumPurple;
            QsnBack1.Controls.Add(QuestionsDGV);
            QsnBack1.Controls.Add(AnswerTb);
            QsnBack1.Controls.Add(QsnBankLabel);
            QsnBack1.Controls.Add(ResetBtn);
            QsnBack1.Controls.Add(EditBtn);
            QsnBack1.Controls.Add(SaveBtn);
            QsnBack1.Controls.Add(Op4Tb);
            QsnBack1.Controls.Add(Op2Tb);
            QsnBack1.Controls.Add(Op1Tb);
            QsnBack1.Controls.Add(Op3Tb);
            QsnBack1.Controls.Add(SubjectCb);
            QsnBack1.Controls.Add(QuestTb);
            QsnBack1.Controls.Add(QsnQsnPanel);
            QsnBack1.Controls.Add(QsnCandidates);
            QsnBack1.Controls.Add(Qsnsub);
            QsnBack1.Controls.Add(QsnQsn);
            QsnBack1.Controls.Add(QsnName1);
            QsnBack1.Controls.Add(QsnBack2);
            QsnBack1.Location = new Point(0, 0);
            QsnBack1.Name = "QsnBack1";
            QsnBack1.Size = new Size(1151, 687);
            QsnBack1.TabIndex = 0;
            // 
            // QuestionsDGV
            // 
            QuestionsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            QuestionsDGV.BackgroundColor = SystemColors.ButtonHighlight;
            QuestionsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionsDGV.Location = new Point(0, 381);
            QuestionsDGV.Name = "QuestionsDGV";
            QuestionsDGV.RowHeadersWidth = 51;
            QuestionsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QuestionsDGV.Size = new Size(1085, 303);
            QuestionsDGV.TabIndex = 18;
            QuestionsDGV.CellContentClick += QuestionsDGV_CellContentClick;
            // 
            // AnswerTb
            // 
            AnswerTb.AnimateReadOnly = false;
            AnswerTb.BackgroundImageLayout = ImageLayout.None;
            AnswerTb.CharacterCasing = CharacterCasing.Normal;
            AnswerTb.Depth = 0;
            AnswerTb.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            AnswerTb.HideSelection = true;
            AnswerTb.LeadingIcon = null;
            AnswerTb.Location = new Point(35, 305);
            AnswerTb.MaxLength = 32767;
            AnswerTb.MouseState = MaterialSkin.MouseState.OUT;
            AnswerTb.Name = "AnswerTb";
            AnswerTb.PasswordChar = '\0';
            AnswerTb.PrefixSuffixText = null;
            AnswerTb.ReadOnly = false;
            AnswerTb.RightToLeft = RightToLeft.No;
            AnswerTb.SelectedText = "";
            AnswerTb.SelectionLength = 0;
            AnswerTb.SelectionStart = 0;
            AnswerTb.ShortcutsEnabled = true;
            AnswerTb.Size = new Size(268, 48);
            AnswerTb.TabIndex = 17;
            AnswerTb.TabStop = false;
            AnswerTb.Text = "Answer";
            AnswerTb.TextAlign = HorizontalAlignment.Left;
            AnswerTb.TrailingIcon = null;
            AnswerTb.UseSystemPasswordChar = false;
            // 
            // QsnBankLabel
            // 
            QsnBankLabel.AutoSize = true;
            QsnBankLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QsnBankLabel.Location = new Point(480, 347);
            QsnBankLabel.Name = "QsnBankLabel";
            QsnBankLabel.Size = new Size(150, 28);
            QsnBankLabel.TabIndex = 16;
            QsnBankLabel.Text = "Question Bank";
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
            // Op4Tb
            // 
            Op4Tb.AnimateReadOnly = false;
            Op4Tb.BackgroundImageLayout = ImageLayout.None;
            Op4Tb.CharacterCasing = CharacterCasing.Normal;
            Op4Tb.Depth = 0;
            Op4Tb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Op4Tb.HideSelection = true;
            Op4Tb.LeadingIcon = null;
            Op4Tb.Location = new Point(666, 233);
            Op4Tb.MaxLength = 32767;
            Op4Tb.MouseState = MaterialSkin.MouseState.OUT;
            Op4Tb.Name = "Op4Tb";
            Op4Tb.PasswordChar = '\0';
            Op4Tb.PrefixSuffixText = null;
            Op4Tb.ReadOnly = false;
            Op4Tb.RightToLeft = RightToLeft.No;
            Op4Tb.SelectedText = "";
            Op4Tb.SelectionLength = 0;
            Op4Tb.SelectionStart = 0;
            Op4Tb.ShortcutsEnabled = true;
            Op4Tb.Size = new Size(268, 48);
            Op4Tb.TabIndex = 11;
            Op4Tb.TabStop = false;
            Op4Tb.Text = "Option4";
            Op4Tb.TextAlign = HorizontalAlignment.Center;
            Op4Tb.TrailingIcon = null;
            Op4Tb.UseSystemPasswordChar = false;
            // 
            // Op2Tb
            // 
            Op2Tb.AnimateReadOnly = false;
            Op2Tb.BackgroundImageLayout = ImageLayout.None;
            Op2Tb.CharacterCasing = CharacterCasing.Normal;
            Op2Tb.Depth = 0;
            Op2Tb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Op2Tb.HideSelection = true;
            Op2Tb.LeadingIcon = null;
            Op2Tb.Location = new Point(666, 129);
            Op2Tb.MaxLength = 32767;
            Op2Tb.MouseState = MaterialSkin.MouseState.OUT;
            Op2Tb.Name = "Op2Tb";
            Op2Tb.PasswordChar = '\0';
            Op2Tb.PrefixSuffixText = null;
            Op2Tb.ReadOnly = false;
            Op2Tb.RightToLeft = RightToLeft.No;
            Op2Tb.SelectedText = "";
            Op2Tb.SelectionLength = 0;
            Op2Tb.SelectionStart = 0;
            Op2Tb.ShortcutsEnabled = true;
            Op2Tb.Size = new Size(268, 48);
            Op2Tb.TabIndex = 10;
            Op2Tb.TabStop = false;
            Op2Tb.Text = "Option2";
            Op2Tb.TextAlign = HorizontalAlignment.Center;
            Op2Tb.TrailingIcon = null;
            Op2Tb.UseSystemPasswordChar = false;
            // 
            // Op1Tb
            // 
            Op1Tb.AnimateReadOnly = false;
            Op1Tb.BackgroundImageLayout = ImageLayout.None;
            Op1Tb.CharacterCasing = CharacterCasing.Normal;
            Op1Tb.Depth = 0;
            Op1Tb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Op1Tb.HideSelection = true;
            Op1Tb.LeadingIcon = null;
            Op1Tb.Location = new Point(332, 129);
            Op1Tb.MaxLength = 32767;
            Op1Tb.MouseState = MaterialSkin.MouseState.OUT;
            Op1Tb.Name = "Op1Tb";
            Op1Tb.PasswordChar = '\0';
            Op1Tb.PrefixSuffixText = null;
            Op1Tb.ReadOnly = false;
            Op1Tb.RightToLeft = RightToLeft.No;
            Op1Tb.SelectedText = "";
            Op1Tb.SelectionLength = 0;
            Op1Tb.SelectionStart = 0;
            Op1Tb.ShortcutsEnabled = true;
            Op1Tb.Size = new Size(270, 48);
            Op1Tb.TabIndex = 9;
            Op1Tb.TabStop = false;
            Op1Tb.Text = "Option1";
            Op1Tb.TextAlign = HorizontalAlignment.Center;
            Op1Tb.TrailingIcon = null;
            Op1Tb.UseSystemPasswordChar = false;
            // 
            // Op3Tb
            // 
            Op3Tb.AnimateReadOnly = false;
            Op3Tb.BackgroundImageLayout = ImageLayout.None;
            Op3Tb.CharacterCasing = CharacterCasing.Normal;
            Op3Tb.Depth = 0;
            Op3Tb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Op3Tb.HideSelection = true;
            Op3Tb.LeadingIcon = null;
            Op3Tb.Location = new Point(332, 233);
            Op3Tb.MaxLength = 32767;
            Op3Tb.MouseState = MaterialSkin.MouseState.OUT;
            Op3Tb.Name = "Op3Tb";
            Op3Tb.PasswordChar = '\0';
            Op3Tb.PrefixSuffixText = null;
            Op3Tb.ReadOnly = false;
            Op3Tb.RightToLeft = RightToLeft.No;
            Op3Tb.SelectedText = "";
            Op3Tb.SelectionLength = 0;
            Op3Tb.SelectionStart = 0;
            Op3Tb.ShortcutsEnabled = true;
            Op3Tb.Size = new Size(270, 48);
            Op3Tb.TabIndex = 8;
            Op3Tb.TabStop = false;
            Op3Tb.Text = "Option3";
            Op3Tb.TextAlign = HorizontalAlignment.Center;
            Op3Tb.TrailingIcon = null;
            Op3Tb.UseSystemPasswordChar = false;
            // 
            // SubjectCb
            // 
            SubjectCb.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjectCb.ForeColor = Color.Black;
            SubjectCb.FormattingEnabled = true;
            SubjectCb.Location = new Point(825, 34);
            SubjectCb.Name = "SubjectCb";
            SubjectCb.Size = new Size(248, 36);
            SubjectCb.TabIndex = 7;
            SubjectCb.Text = "Subject";
            // 
            // QuestTb
            // 
            QuestTb.AnimateReadOnly = false;
            QuestTb.BackgroundImageLayout = ImageLayout.None;
            QuestTb.CharacterCasing = CharacterCasing.Normal;
            QuestTb.Depth = 0;
            QuestTb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuestTb.HideSelection = true;
            QuestTb.LeadingIcon = null;
            QuestTb.Location = new Point(35, 185);
            QuestTb.MaxLength = 32767;
            QuestTb.MouseState = MaterialSkin.MouseState.OUT;
            QuestTb.Name = "QuestTb";
            QuestTb.PasswordChar = '\0';
            QuestTb.PrefixSuffixText = null;
            QuestTb.ReadOnly = false;
            QuestTb.RightToLeft = RightToLeft.No;
            QuestTb.SelectedText = "";
            QuestTb.SelectionLength = 0;
            QuestTb.SelectionStart = 0;
            QuestTb.ShortcutsEnabled = true;
            QuestTb.Size = new Size(268, 48);
            QuestTb.TabIndex = 6;
            QuestTb.TabStop = false;
            QuestTb.Text = "Questions";
            QuestTb.TextAlign = HorizontalAlignment.Center;
            QuestTb.TrailingIcon = null;
            QuestTb.UseSystemPasswordChar = false;
            // 
            // QsnQsnPanel
            // 
            QsnQsnPanel.BackColor = SystemColors.WindowText;
            QsnQsnPanel.Location = new Point(332, 68);
            QsnQsnPanel.Name = "QsnQsnPanel";
            QsnQsnPanel.Size = new Size(97, 5);
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
            Qsnsub.Click += Qsnsub_Click;
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
            pictureBox3.Click += pictureBox3_Click;
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
            // Questions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 686);
            Controls.Add(QsnBack1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Questions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions";
            QsnBack1.ResumeLayout(false);
            QsnBack1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionsDGV).EndInit();
            QsnBack2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel QsnBack1;
        private Panel QsnBack2;
        private Label QsnName1;
        private Label QsnCandidates;
        private Label Qsnsub;
        private Label QsnQsn;
        private Panel QsnQsnPanel;
        private MaterialSkin.Controls.MaterialTextBox2 QuestTb;
        private ComboBox SubjectCb;
        private MaterialSkin.Controls.MaterialTextBox2 Op4Tb;
        private MaterialSkin.Controls.MaterialTextBox2 Op2Tb;
        private MaterialSkin.Controls.MaterialTextBox2 Op1Tb;
        private MaterialSkin.Controls.MaterialTextBox2 Op3Tb;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialButton ResetBtn;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private Label QsnBankLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialTextBox2 AnswerTb;
        private DataGridView QuestionsDGV;
    }
}