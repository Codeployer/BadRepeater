using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bad_Repeater
{
    public partial class Form1 : Form
    {

        void CustomSettingsUsage(bool x)
        {
            if (!x)
            {
                SendTypeBox.SelectedIndex = Properties.Settings.Default.SendTypeIndex;
                IntervalTextBox.Text = Properties.Settings.Default.Interval;
                RepeatCountBox.Text = Properties.Settings.Default.RepeatCount;

                SendTypeBox.Enabled     = false;
                IntervalTextBox.Enabled = false;
                RepeatCountBox.Enabled  = false;
            }
            else
            {
                SendTypeBox.Enabled     = true;
                IntervalTextBox.Enabled = true;
                RepeatCountBox.Enabled  = true;

                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Bad Repeater";
            ShortcutLabel.Text = Properties.Settings.Default.Shortcut;
            QuickFloodRadioButton.Checked = true;
            SendTypeBox.SelectedIndex = Properties.Settings.Default.SendTypeIndex;
            IntervalTextBox.Text = Properties.Settings.Default.Interval;
            RepeatCountBox.Text = Properties.Settings.Default.RepeatCount;
        }

        // Radio Buttons //
        private void QuickFloodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CustomSettingsUsage(false);
        }

        private void CustomAttackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Interval = IntervalTextBox.Text;
            Properties.Settings.Default.RepeatCount = RepeatCountBox.Text;
            Properties.Settings.Default.Save();

            CustomSettingsUsage(true);
        }

        // Custom Attack Settings //
        private void SendTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SendTypeIndex = SendTypeBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        // Settings //
        private void ChangeKeyButton_Click(object sender, EventArgs e)
        {
            /// Create MessageBox that asks for shortcut key
            /// Feature is WIP
            MessageBox.Show("This feature is not available yet", "Sorry...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void AllowOnlyDigitsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RepeatCountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
