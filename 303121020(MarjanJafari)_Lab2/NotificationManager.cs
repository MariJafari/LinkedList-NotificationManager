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
    public partial class NotificationManager : Form
    {
        private SubscriptionManager subscriptionManager;
        public NotificationManager()
        {
            InitializeComponent();
            subscriptionManager = new SubscriptionManager();
            subscriptionManager.SubscriptionAdded += SubscriptionManager_SubscriptionChanged;
            subscriptionManager.SubscriptionRemoved += SubscriptionManager_SubscriptionChanged;
            UpdatePublishButtonState();
        }

        private void SubscriptionManager_SubscriptionChanged(object sender, NotificationEventArgs e)
        {
            UpdatePublishButtonState();
        }

        private void UpdatePublishButtonState()
        {
     
            btnPubNoti.Enabled = subscriptionManager.HasSubscribers();
        }

        private void btnManageSub_Click(object sender, EventArgs e)
        {
            ManageSubcription subscriptionForm = new ManageSubcription(subscriptionManager);
            subscriptionForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPubNoti_Click(object sender, EventArgs e)
        {
            PublishNotificationForm publishForm = new PublishNotificationForm(subscriptionManager);

            publishForm.ShowDialog();
        }
    }
}
