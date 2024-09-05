namespace Admins_SCC_
{
    partial class Home_form : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelScrollable;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_form));
            btnAdd = new Button();
            panelScrollable = new Panel();
            search_pannel = new Panel();
            pictureBox2 = new PictureBox();
            search_box = new TextBox();
            label1 = new Label();
            message_tb = new Label();
            panelScrollable.SuspendLayout();
            search_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 14);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // panelScrollable
            // 
            panelScrollable.AutoScroll = true;
            panelScrollable.BorderStyle = BorderStyle.FixedSingle;
            panelScrollable.Controls.Add(message_tb);
            panelScrollable.Controls.Add(search_pannel);
            panelScrollable.Dock = DockStyle.Fill;
            panelScrollable.Location = new Point(0, 0);
            panelScrollable.Margin = new Padding(4, 3, 4, 3);
            panelScrollable.Name = "panelScrollable";
            panelScrollable.Size = new Size(915, 532);
            panelScrollable.TabIndex = 1;
            panelScrollable.Paint += panelScrollable_Paint;
            // 
            // search_pannel
            // 
            search_pannel.BackColor = Color.Teal;
            search_pannel.Controls.Add(pictureBox2);
            search_pannel.Controls.Add(search_box);
            search_pannel.Controls.Add(label1);
            search_pannel.Dock = DockStyle.Top;
            search_pannel.Location = new Point(0, 0);
            search_pannel.Name = "search_pannel";
            search_pannel.Size = new Size(913, 51);
            search_pannel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(492, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(117, 17);
            search_box.Name = "search_box";
            search_box.PlaceholderText = "Search complaint by id...";
            search_box.Size = new Size(353, 23);
            search_box.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(426, 254);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(129, 21);
            message_tb.TabIndex = 2;
            message_tb.Text = "No Complaints!";
            // 
            // Home_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(panelScrollable);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_form";
            panelScrollable.ResumeLayout(false);
            panelScrollable.PerformLayout();
            search_pannel.ResumeLayout(false);
            search_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private Panel search_pannel;
        private PictureBox pictureBox2;
        private TextBox search_box;
        private Label label1;
        private Label message_tb;
    }
}
