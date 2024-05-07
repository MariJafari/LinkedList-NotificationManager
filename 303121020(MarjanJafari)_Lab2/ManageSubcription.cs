using Q2_WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212Lab2
{
    public partial class ManageSubcription : Form
    {
        private SubscriptionManager subscriptionManager;
        public ManageSubcription(SubscriptionManager manager)
        {
            InitializeComponent();
            subscriptionManager = manager;

            tebEmail.Enabled = chbEmail.Checked;
            tebSMS.Enabled = chbSMS.Checked;

            tebEmail.TextChanged += TebEmail_TextChanged;
            tebSMS.TextChanged += TebSMS_TextChanged;

            UpdateButtonStates();
        }

        private void ManageSubcription_Load(object sender, EventArgs e)
        {

        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbEmail.Checked)
                {
                    subscriptionManager.AddSubscriber(tebEmail.Text, null);
                }
                if (chbSMS.Checked)
                {
                    subscriptionManager.AddSubscriber(null, tebSMS.Text);
                }

                MessageBox.Show("Subscription successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnscubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbEmail.Checked)
                {
                    subscriptionManager.RemoveSubscriber(tebEmail.Text, null);
                }
                if (chbSMS.Checked)
                {
                    subscriptionManager.RemoveSubscriber(null, tebSMS.Text);
                }

                MessageBox.Show("Unsubscription successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TebEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(); 

        }

        private void TebSMS_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(); 
        }

        private void emailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tebEmail.Enabled = chbEmail.Checked;
            UpdateButtonStates();
        }
        private void phoneNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tebSMS.Enabled = chbSMS.Checked;
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool isEmailValid = chbEmail.Checked && !string.IsNullOrWhiteSpace(tebEmail.Text);
            bool isSMSValid = chbSMS.Checked && !string.IsNullOrWhiteSpace(tebSMS.Text);

            btnSubscribe.Enabled = isEmailValid || isSMSValid;
            btnUnscubscribe.Enabled = isEmailValid || isSMSValid;
        }
    }
}
