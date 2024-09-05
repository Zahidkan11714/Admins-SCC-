namespace Admins_SCC_
{
    partial class Annocuncement_form : Form
    {
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel scrollPanel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Annocuncement_form));
            scrollPanel = new Panel();
            message_tb = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            scrollPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // scrollPanel
            // 
            scrollPanel.AutoScroll = true;
            scrollPanel.AutoSize = true;
            scrollPanel.BorderStyle = BorderStyle.FixedSingle;
            scrollPanel.Controls.Add(message_tb);
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.Location = new Point(0, 0);
            scrollPanel.Margin = new Padding(4, 3, 4, 3);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Size = new Size(933, 519);
            scrollPanel.TabIndex = 1;
            scrollPanel.Paint += scrollPanel_Paint;
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(504, 269);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(165, 21);
            message_tb.TabIndex = 0;
            message_tb.Text = "No announcements!";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 426);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 93);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1030, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Annocuncement_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panel1);
            Controls.Add(scrollPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Annocuncement_form";
            Text = "Annocuncement_form";
            scrollPanel.ResumeLayout(false);
            scrollPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label message_tb;
    }
}
