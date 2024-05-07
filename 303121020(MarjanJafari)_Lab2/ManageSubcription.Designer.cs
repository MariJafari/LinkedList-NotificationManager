namespace COMP212Lab2
{
    partial class ManageSubcription
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
            chbEmail = new CheckBox();
            chbSMS = new CheckBox();
            tebEmail = new TextBox();
            tebSMS = new TextBox();
            btnSubscribe = new Button();
            btnUnscubscribe = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // chbEmail
            // 
            chbEmail.AutoSize = true;
            chbEmail.Location = new Point(65, 60);
            chbEmail.Margin = new Padding(4, 5, 4, 5);
            chbEmail.Name = "chbEmail";
            chbEmail.Size = new Size(242, 29);
            chbEmail.TabIndex = 0;
            chbEmail.Text = "Notification Sent by Email";
            chbEmail.UseVisualStyleBackColor = true;
            chbEmail.CheckedChanged += emailCheckBox_CheckedChanged;
            // 
            // chbSMS
            // 
            chbSMS.AutoSize = true;
            chbSMS.Location = new Point(65, 148);
            chbSMS.Margin = new Padding(4, 5, 4, 5);
            chbSMS.Name = "chbSMS";
            chbSMS.Size = new Size(236, 29);
            chbSMS.TabIndex = 1;
            chbSMS.Text = "Notification Sent by SMS";
            chbSMS.UseVisualStyleBackColor = true;
            chbSMS.CheckedChanged += phoneNumberCheckBox_CheckedChanged;
            // 
            // tebEmail
            // 
            tebEmail.Location = new Point(378, 60);
            tebEmail.Margin = new Padding(4, 5, 4, 5);
            tebEmail.Name = "tebEmail";
            tebEmail.Size = new Size(260, 31);
            tebEmail.TabIndex = 2;
            // 
            // tebSMS
            // 
            tebSMS.Location = new Point(378, 148);
            tebSMS.Margin = new Padding(4, 5, 4, 5);
            tebSMS.Name = "tebSMS";
            tebSMS.Size = new Size(260, 31);
            tebSMS.TabIndex = 3;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(39, 240);
            btnSubscribe.Margin = new Padding(4, 5, 4, 5);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(170, 60);
            btnSubscribe.TabIndex = 4;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubscribe_Click;
            // 
            // btnUnscubscribe
            // 
            btnUnscubscribe.Location = new Point(270, 240);
            btnUnscubscribe.Margin = new Padding(4, 5, 4, 5);
            btnUnscubscribe.Name = "btnUnscubscribe";
            btnUnscubscribe.Size = new Size(170, 60);
            btnUnscubscribe.TabIndex = 5;
            btnUnscubscribe.Text = "Unsubscribe";
            btnUnscubscribe.UseVisualStyleBackColor = true;
            btnUnscubscribe.Click += btnUnscubscribe_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(503, 240);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 60);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ManageSubcription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 360);
            Controls.Add(btnCancel);
            Controls.Add(btnUnscubscribe);
            Controls.Add(btnSubscribe);
            Controls.Add(tebSMS);
            Controls.Add(tebEmail);
            Controls.Add(chbSMS);
            Controls.Add(chbEmail);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ManageSubcription";
            Text = "Manage_Subcription";
            Load += ManageSubcription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbEmail;
        private CheckBox chbSMS;
        private TextBox tebEmail;
        private TextBox tebSMS;
        private Button btnSubscribe;
        private Button btnUnscubscribe;
        private Button btnCancel;
    }
}