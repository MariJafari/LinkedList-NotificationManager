namespace COMP212Lab2
{
    partial class PublishNotificationForm
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
            textBox1 = new TextBox();
            labNoti = new Label();
            btnPublish = new Button();
            btnExit2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 95);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 31);
            textBox1.TabIndex = 0;
            // 
            // labNoti
            // 
            labNoti.AutoSize = true;
            labNoti.Location = new Point(50, 98);
            labNoti.Margin = new Padding(4, 0, 4, 0);
            labNoti.Name = "labNoti";
            labNoti.Size = new Size(172, 25);
            labNoti.TabIndex = 1;
            labNoti.Text = "Notification Content";
            labNoti.Click += labNoti_Click;
            // 
            // btnPublish
            // 
            btnPublish.Location = new Point(149, 158);
            btnPublish.Margin = new Padding(4, 5, 4, 5);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(166, 60);
            btnPublish.TabIndex = 2;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // btnExit2
            // 
            btnExit2.Location = new Point(435, 158);
            btnExit2.Margin = new Padding(4, 5, 4, 5);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(166, 60);
            btnExit2.TabIndex = 3;
            btnExit2.Text = "Exit";
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(17, 250);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(711, 104);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // PublishNotificationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 386);
            Controls.Add(listBox1);
            Controls.Add(btnExit2);
            Controls.Add(btnPublish);
            Controls.Add(labNoti);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PublishNotificationForm";
            Text = "Publish Notification";
            Load += PublishNotificationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void labNoti_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private Label labNoti;
        private Button btnPublish;
        private Button btnExit2;
        private ListBox listBox1;
    }
}