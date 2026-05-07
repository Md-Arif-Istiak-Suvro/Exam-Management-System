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
            dataGridViewQsn = new DataGridView();
            resetBtn = new MaterialSkin.Controls.MaterialButton();
            editBtn = new MaterialSkin.Controls.MaterialButton();
            saveBtn = new MaterialSkin.Controls.MaterialButton();
            CanPhn = new MaterialSkin.Controls.MaterialTextBox2();
            CanAddress = new MaterialSkin.Controls.MaterialTextBox2();
            CanAge = new MaterialSkin.Controls.MaterialTextBox2();
            CanPass = new MaterialSkin.Controls.MaterialTextBox2();
            SubjrctSelect = new ComboBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            CanName = new MaterialSkin.Controls.MaterialTextBox2();
            QsnQsnPanel = new Panel();
            QsnCandidates = new Label();
            Qsnsub = new Label();
            QsnName1 = new Label();
            QsnBack2 = new Panel();
            pictureBox2 = new PictureBox();
            QsnQsn = new Label();
            QsnBack1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQsn).BeginInit();
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
            // dataGridViewQsn
            // 
            dataGridViewQsn.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewQsn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQsn.Location = new Point(12, 381);
            dataGridViewQsn.Name = "dataGridViewQsn";
            dataGridViewQsn.RowHeadersWidth = 51;
            dataGridViewQsn.Size = new Size(1061, 293);
            dataGridViewQsn.TabIndex = 15;
            // 
            // resetBtn
            // 
            resetBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resetBtn.BackColor = Color.GhostWhite;
            resetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            resetBtn.Depth = 0;
            resetBtn.ForeColor = SystemColors.ButtonHighlight;
            resetBtn.HighEmphasis = true;
            resetBtn.Icon = null;
            resetBtn.Location = new Point(681, 305);
            resetBtn.Margin = new Padding(4, 6, 4, 6);
            resetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            resetBtn.Name = "resetBtn";
            resetBtn.NoAccentTextColor = Color.Empty;
            resetBtn.Size = new Size(65, 36);
            resetBtn.TabIndex = 14;
            resetBtn.Text = "Reset";
            resetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            resetBtn.UseAccentColor = false;
            resetBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editBtn.BackColor = Color.GhostWhite;
            editBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            editBtn.Depth = 0;
            editBtn.ForeColor = SystemColors.ButtonHighlight;
            editBtn.HighEmphasis = true;
            editBtn.Icon = null;
            editBtn.Location = new Point(519, 305);
            editBtn.Margin = new Padding(4, 6, 4, 6);
            editBtn.MouseState = MaterialSkin.MouseState.HOVER;
            editBtn.Name = "editBtn";
            editBtn.NoAccentTextColor = Color.Empty;
            editBtn.Size = new Size(64, 36);
            editBtn.TabIndex = 13;
            editBtn.Text = "Edit";
            editBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            editBtn.UseAccentColor = false;
            editBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.BackColor = Color.GhostWhite;
            saveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveBtn.Depth = 0;
            saveBtn.ForeColor = SystemColors.ButtonHighlight;
            saveBtn.HighEmphasis = true;
            saveBtn.Icon = null;
            saveBtn.Location = new Point(365, 305);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(64, 36);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // CanPhn
            // 
            CanPhn.AnimateReadOnly = false;
            CanPhn.BackgroundImageLayout = ImageLayout.None;
            CanPhn.CharacterCasing = CharacterCasing.Normal;
            CanPhn.Depth = 0;
            CanPhn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CanPhn.HideSelection = true;
            CanPhn.LeadingIcon = null;
            CanPhn.Location = new Point(607, 224);
            CanPhn.MaxLength = 32767;
            CanPhn.MouseState = MaterialSkin.MouseState.OUT;
            CanPhn.Name = "CanPhn";
            CanPhn.PasswordChar = '\0';
            CanPhn.PrefixSuffixText = null;
            CanPhn.ReadOnly = false;
            CanPhn.RightToLeft = RightToLeft.No;
            CanPhn.SelectedText = "";
            CanPhn.SelectionLength = 0;
            CanPhn.SelectionStart = 0;
            CanPhn.ShortcutsEnabled = true;
            CanPhn.Size = new Size(268, 48);
            CanPhn.TabIndex = 11;
            CanPhn.TabStop = false;
            CanPhn.Text = "Phone";
            CanPhn.TextAlign = HorizontalAlignment.Center;
            CanPhn.TrailingIcon = null;
            CanPhn.UseSystemPasswordChar = false;
            // 
            // CanAddress
            // 
            CanAddress.AnimateReadOnly = false;
            CanAddress.BackgroundImageLayout = ImageLayout.None;
            CanAddress.CharacterCasing = CharacterCasing.Normal;
            CanAddress.Depth = 0;
            CanAddress.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CanAddress.HideSelection = true;
            CanAddress.LeadingIcon = null;
            CanAddress.Location = new Point(781, 129);
            CanAddress.MaxLength = 32767;
            CanAddress.MouseState = MaterialSkin.MouseState.OUT;
            CanAddress.Name = "CanAddress";
            CanAddress.PasswordChar = '\0';
            CanAddress.PrefixSuffixText = null;
            CanAddress.ReadOnly = false;
            CanAddress.RightToLeft = RightToLeft.No;
            CanAddress.SelectedText = "";
            CanAddress.SelectionLength = 0;
            CanAddress.SelectionStart = 0;
            CanAddress.ShortcutsEnabled = true;
            CanAddress.Size = new Size(268, 48);
            CanAddress.TabIndex = 10;
            CanAddress.TabStop = false;
            CanAddress.Text = "Address";
            CanAddress.TextAlign = HorizontalAlignment.Center;
            CanAddress.TrailingIcon = null;
            CanAddress.UseSystemPasswordChar = false;
            // 
            // CanAge
            // 
            CanAge.AnimateReadOnly = false;
            CanAge.BackgroundImageLayout = ImageLayout.None;
            CanAge.CharacterCasing = CharacterCasing.Normal;
            CanAge.Depth = 0;
            CanAge.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CanAge.HideSelection = true;
            CanAge.LeadingIcon = null;
            CanAge.Location = new Point(421, 129);
            CanAge.MaxLength = 32767;
            CanAge.MouseState = MaterialSkin.MouseState.OUT;
            CanAge.Name = "CanAge";
            CanAge.PasswordChar = '\0';
            CanAge.PrefixSuffixText = null;
            CanAge.ReadOnly = false;
            CanAge.RightToLeft = RightToLeft.No;
            CanAge.SelectedText = "";
            CanAge.SelectionLength = 0;
            CanAge.SelectionStart = 0;
            CanAge.ShortcutsEnabled = true;
            CanAge.Size = new Size(270, 48);
            CanAge.TabIndex = 9;
            CanAge.TabStop = false;
            CanAge.Text = "Age";
            CanAge.TextAlign = HorizontalAlignment.Center;
            CanAge.TrailingIcon = null;
            CanAge.UseSystemPasswordChar = false;
            // 
            // CanPass
            // 
            CanPass.AnimateReadOnly = false;
            CanPass.BackgroundImageLayout = ImageLayout.None;
            CanPass.CharacterCasing = CharacterCasing.Normal;
            CanPass.Depth = 0;
            CanPass.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CanPass.HideSelection = true;
            CanPass.LeadingIcon = null;
            CanPass.Location = new Point(227, 224);
            CanPass.MaxLength = 32767;
            CanPass.MouseState = MaterialSkin.MouseState.OUT;
            CanPass.Name = "CanPass";
            CanPass.PasswordChar = '\0';
            CanPass.PrefixSuffixText = null;
            CanPass.ReadOnly = false;
            CanPass.RightToLeft = RightToLeft.No;
            CanPass.SelectedText = "";
            CanPass.SelectionLength = 0;
            CanPass.SelectionStart = 0;
            CanPass.ShortcutsEnabled = true;
            CanPass.Size = new Size(270, 48);
            CanPass.TabIndex = 8;
            CanPass.TabStop = false;
            CanPass.Text = "Password";
            CanPass.TextAlign = HorizontalAlignment.Center;
            CanPass.TrailingIcon = null;
            CanPass.UseSystemPasswordChar = false;
            // 
            // SubjrctSelect
            // 
            SubjrctSelect.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubjrctSelect.ForeColor = SystemColors.ControlText;
            SubjrctSelect.FormattingEnabled = true;
            SubjrctSelect.Location = new Point(845, 40);
            SubjrctSelect.Name = "SubjrctSelect";
            SubjrctSelect.Size = new Size(154, 36);
            SubjrctSelect.TabIndex = 7;
            SubjrctSelect.Text = "Subject";
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
            // 
            // CanName
            // 
            CanName.AnimateReadOnly = false;
            CanName.BackgroundImageLayout = ImageLayout.None;
            CanName.CharacterCasing = CharacterCasing.Normal;
            CanName.Depth = 0;
            CanName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CanName.HideSelection = true;
            CanName.LeadingIcon = null;
            CanName.Location = new Point(74, 129);
            CanName.MaxLength = 32767;
            CanName.MouseState = MaterialSkin.MouseState.OUT;
            CanName.Name = "CanName";
            CanName.PasswordChar = '\0';
            CanName.PrefixSuffixText = null;
            CanName.ReadOnly = false;
            CanName.RightToLeft = RightToLeft.No;
            CanName.SelectedText = "";
            CanName.SelectionLength = 0;
            CanName.SelectionStart = 0;
            CanName.ShortcutsEnabled = true;
            CanName.Size = new Size(268, 48);
            CanName.TabIndex = 6;
            CanName.TabStop = false;
            CanName.Text = "Name";
            CanName.TextAlign = HorizontalAlignment.Center;
            CanName.TrailingIcon = null;
            CanName.UseSystemPasswordChar = false;
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
            QsnBack1.BackColor = Color.BlueViolet;
            QsnBack1.Controls.Add(QsnBankLabel);
            QsnBack1.Controls.Add(dataGridViewQsn);
            QsnBack1.Controls.Add(resetBtn);
            QsnBack1.Controls.Add(editBtn);
            QsnBack1.Controls.Add(saveBtn);
            QsnBack1.Controls.Add(CanPhn);
            QsnBack1.Controls.Add(CanAddress);
            QsnBack1.Controls.Add(CanAge);
            QsnBack1.Controls.Add(CanPass);
            QsnBack1.Controls.Add(SubjrctSelect);
            QsnBack1.Controls.Add(CanName);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewQsn).EndInit();
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
        private DataGridView dataGridViewQsn;
        private MaterialSkin.Controls.MaterialButton resetBtn;
        private MaterialSkin.Controls.MaterialButton editBtn;
        private MaterialSkin.Controls.MaterialButton saveBtn;
        private MaterialSkin.Controls.MaterialTextBox2 CanPhn;
        private MaterialSkin.Controls.MaterialTextBox2 CanAddress;
        private MaterialSkin.Controls.MaterialTextBox2 CanAge;
        private MaterialSkin.Controls.MaterialTextBox2 CanPass;
        private ComboBox SubjrctSelect;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox2 CanName;
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