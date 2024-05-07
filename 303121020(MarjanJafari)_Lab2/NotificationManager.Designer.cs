namespace COMP212Lab2
{
    partial class NotificationManager
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
            btnManageSub = new Button();
            btnPubNoti = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnManageSub
            // 
            btnManageSub.Location = new Point(24, 122);
            btnManageSub.Margin = new Padding(4, 5, 4, 5);
            btnManageSub.Name = "btnManageSub";
            btnManageSub.Size = new Size(214, 75);
            btnManageSub.TabIndex = 0;
            btnManageSub.Text = "Manage Subscription";
            btnManageSub.UseVisualStyleBackColor = true;
            btnManageSub.Click += btnManageSub_Click;
            // 
            // btnPubNoti
            // 
            btnPubNoti.Location = new Point(267, 122);
            btnPubNoti.Margin = new Padding(4, 5, 4, 5);
            btnPubNoti.Name = "btnPubNoti";
            btnPubNoti.Size = new Size(214, 75);
            btnPubNoti.TabIndex = 1;
            btnPubNoti.Text = "Publish Notification";
            btnPubNoti.UseVisualStyleBackColor = true;
            btnPubNoti.Click += btnPubNoti_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(543, 110);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(152, 98);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // NotificationManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 322);
            Controls.Add(btnExit);
            Controls.Add(btnPubNoti);
            Controls.Add(btnManageSub);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NotificationManager";
            Text = "Notification_Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button btnManageSub;
        private Button btnPubNoti;
        private Button btnExit;
    }
}