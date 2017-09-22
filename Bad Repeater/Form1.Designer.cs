namespace Bad_Repeater
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RepeatCountBox = new System.Windows.Forms.TextBox();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.CustomAttackRadioButton = new System.Windows.Forms.RadioButton();
            this.QuickFloodRadioButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShortcutLabel = new System.Windows.Forms.Label();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 235);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text To Send";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RepeatCountBox);
            this.groupBox2.Controls.Add(this.IntervalTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SendTypeBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AttackLabel);
            this.groupBox2.Controls.Add(this.CustomAttackRadioButton);
            this.groupBox2.Controls.Add(this.QuickFloodRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(448, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0 = unlimited";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Repeat Count:";
            // 
            // RepeatCountBox
            // 
            this.RepeatCountBox.Location = new System.Drawing.Point(177, 122);
            this.RepeatCountBox.Name = "RepeatCountBox";
            this.RepeatCountBox.Size = new System.Drawing.Size(151, 22);
            this.RepeatCountBox.TabIndex = 10;
            this.RepeatCountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigitsTextBox_KeyPress);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(177, 77);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(151, 22);
            this.IntervalTextBox.TabIndex = 9;
            this.IntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyDigitsTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Set interval (milisec):";
            // 
            // SendTypeBox
            // 
            this.SendTypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.SendTypeBox.FormattingEnabled = true;
            this.SendTypeBox.Items.AddRange(new object[] {
            "All text",
            "Letter by Letter",
            "Single words",
            "Fragments"});
            this.SendTypeBox.Location = new System.Drawing.Point(174, 30);
            this.SendTypeBox.Name = "SendTypeBox";
            this.SendTypeBox.Size = new System.Drawing.Size(151, 24);
            this.SendTypeBox.TabIndex = 7;
            this.SendTypeBox.SelectedIndexChanged += new System.EventHandler(this.SendTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Send Type:";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(7, 30);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(133, 17);
            this.AttackLabel.TabIndex = 5;
            this.AttackLabel.Text = "Choose attack type:";
            // 
            // CustomAttackRadioButton
            // 
            this.CustomAttackRadioButton.AutoSize = true;
            this.CustomAttackRadioButton.Location = new System.Drawing.Point(10, 77);
            this.CustomAttackRadioButton.Name = "CustomAttackRadioButton";
            this.CustomAttackRadioButton.Size = new System.Drawing.Size(119, 21);
            this.CustomAttackRadioButton.TabIndex = 4;
            this.CustomAttackRadioButton.Text = "Custom Attack";
            this.CustomAttackRadioButton.UseVisualStyleBackColor = true;
            this.CustomAttackRadioButton.CheckedChanged += new System.EventHandler(this.CustomAttackRadioButton_CheckedChanged);
            // 
            // QuickFloodRadioButton
            // 
            this.QuickFloodRadioButton.AutoSize = true;
            this.QuickFloodRadioButton.Location = new System.Drawing.Point(10, 50);
            this.QuickFloodRadioButton.Name = "QuickFloodRadioButton";
            this.QuickFloodRadioButton.Size = new System.Drawing.Size(104, 21);
            this.QuickFloodRadioButton.TabIndex = 3;
            this.QuickFloodRadioButton.Text = "Quick Flood";
            this.QuickFloodRadioButton.UseVisualStyleBackColor = true;
            this.QuickFloodRadioButton.CheckedChanged += new System.EventHandler(this.QuickFloodRadioButton_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(448, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Enable Standby Mode";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShortcutLabel);
            this.groupBox3.Controls.Add(this.ChangeKeyButton);
            this.groupBox3.Location = new System.Drawing.Point(448, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // ShortcutLabel
            // 
            this.ShortcutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortcutLabel.Location = new System.Drawing.Point(171, 21);
            this.ShortcutLabel.Name = "ShortcutLabel";
            this.ShortcutLabel.Size = new System.Drawing.Size(157, 36);
            this.ShortcutLabel.TabIndex = 1;
            this.ShortcutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeKeyButton.Location = new System.Drawing.Point(6, 21);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(159, 36);
            this.ChangeKeyButton.TabIndex = 0;
            this.ChangeKeyButton.Text = "Change Launch Key";
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Flood Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(130, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 326);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.RadioButton CustomAttackRadioButton;
        private System.Windows.Forms.RadioButton QuickFloodRadioButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Label ShortcutLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SendTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.TextBox RepeatCountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

