using Q2_WinForm;

namespace COMP212Lab2
{
    public partial class PublishNotificationForm : Form
    {
        private NotificationService notificationService;
        private SubscriptionManager subscriptionManager;
        private List<string> publishedMessages = new List<string>();

        public PublishNotificationForm(SubscriptionManager manager)
        {
            InitializeComponent();
            subscriptionManager = manager;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                var allSubscribers = subscriptionManager.GetAllSubscribers();

                listBox1.Items.Clear();

                foreach (var subscriber in allSubscribers)
                {
                    string displayMessage = $"{message} have been sent to {subscriber}";
                    listBox1.Items.Add(displayMessage);
                }

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a message to publish.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void NotificationReceived(string message)
        {
         
        }

        private void UpdatePublishedMessagesList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = publishedMessages;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            notificationService.NotifySubscribersEvent -= NotificationReceived;
        }

    private void PublishNotificationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
