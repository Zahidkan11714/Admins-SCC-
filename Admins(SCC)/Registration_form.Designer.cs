namespace Admins_SCC_
{
    partial class Registration_form : Form
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
            btnAddView = new Button();
            panelContainer = new Panel();
            message_tb = new Label();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddView
            // 
            btnAddView.Location = new Point(14, 14);
            btnAddView.Margin = new Padding(4, 3, 4, 3);
            btnAddView.Name = "btnAddView";
            btnAddView.Size = new Size(88, 27);
            btnAddView.TabIndex = 0;
            btnAddView.Text = "Add View";
            btnAddView.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Controls.Add(message_tb);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Margin = new Padding(4, 3, 4, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(933, 519);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(535, 268);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(91, 21);
            message_tb.TabIndex = 2;
            message_tb.Text = "No record!";
            // 
            // Registration_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelContainer);
            Controls.Add(btnAddView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registration_form";
            Text = "Dynamic View Example";
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddView;
        private System.Windows.Forms.Panel panelContainer;
        private Label message_tb;
    }
}
