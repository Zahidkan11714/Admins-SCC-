namespace Admins_SCC_
{
    partial class ShowNotification_form
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
            label1 = new Label();
            btnAdd = new Button();
            panelComplaints = new Panel();
            message_tb = new Label();
            panelComplaints.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 187);
            label1.Name = "label1";
            label1.Size = new Size(377, 32);
            label1.TabIndex = 0;
            label1.Text = "You will see notifications here...";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelComplaints
            // 
            panelComplaints.AutoScroll = true;
            panelComplaints.Controls.Add(message_tb);
            panelComplaints.Dock = DockStyle.Fill;
            panelComplaints.Location = new Point(0, 0);
            panelComplaints.Name = "panelComplaints";
            panelComplaints.Size = new Size(800, 450);
            panelComplaints.TabIndex = 2;
            panelComplaints.Paint += panelComplaints_Paint;
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(560, 261);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(139, 21);
            message_tb.TabIndex = 0;
            message_tb.Text = "No notifications!";
            // 
            // ShowNotification_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelComplaints);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowNotification_form";
            Text = "ShowNotification_form";
            Load += ShowNotification_form_Load;
            panelComplaints.ResumeLayout(false);
            panelComplaints.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelComplaints;
        private Label message_tb;
    }
}
