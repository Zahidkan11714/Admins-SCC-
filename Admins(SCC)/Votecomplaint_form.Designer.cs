namespace Admins_SCC_
{
    partial class Votecomplaint_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            addButton = new Button();
            scrollablePanel = new Panel();
            message_tb = new Label();
            scrollablePanel.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(10, 10);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 30);
            addButton.TabIndex = 0;
            addButton.Text = "Add Complaint";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // scrollablePanel
            // 
            scrollablePanel.AutoScroll = true;
            scrollablePanel.BorderStyle = BorderStyle.FixedSingle;
            scrollablePanel.Controls.Add(message_tb);
            scrollablePanel.Dock = DockStyle.Fill;
            scrollablePanel.Location = new Point(0, 0);
            scrollablePanel.Name = "scrollablePanel";
            scrollablePanel.Size = new Size(800, 600);
            scrollablePanel.TabIndex = 1;
            scrollablePanel.Paint += scrollablePanel_Paint;
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(469, 259);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(129, 21);
            message_tb.TabIndex = 0;
            message_tb.Text = "No Complaints!";
            // 
            // Votecomplaint_form
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(scrollablePanel);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Votecomplaint_form";
            Text = "Voting Complaint App";
            scrollablePanel.ResumeLayout(false);
            scrollablePanel.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel scrollablePanel;
        private Label message_tb;
    }
}
