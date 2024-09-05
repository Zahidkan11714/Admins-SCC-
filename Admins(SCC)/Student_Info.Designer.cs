namespace Admins_SCC_
{
    partial class Student_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Info));
            panel1 = new Panel();
            search_tb = new TextBox();
            label1 = new Label();
            search_pb = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            id_tb = new TextBox();
            name_tb = new TextBox();
            email_tb = new TextBox();
            password_tb = new TextBox();
            update_btn = new Button();
            delete_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_pb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(142, 202, 230);
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(search_pb);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 78);
            panel1.TabIndex = 0;
            // 
            // search_tb
            // 
            search_tb.Location = new Point(415, 28);
            search_tb.Name = "search_tb";
            search_tb.Size = new Size(260, 23);
            search_tb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // search_pb
            // 
            search_pb.Image = (Image)resources.GetObject("search_pb.Image");
            search_pb.Location = new Point(696, 12);
            search_pb.Name = "search_pb";
            search_pb.Size = new Size(56, 45);
            search_pb.SizeMode = PictureBoxSizeMode.Zoom;
            search_pb.TabIndex = 3;
            search_pb.TabStop = false;
            search_pb.Click += search_pb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 125);
            label2.Name = "label2";
            label2.Size = new Size(365, 32);
            label2.TabIndex = 1;
            label2.Text = "*** Student Sign Up Record ***";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 229);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "ID: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 287);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 3;
            label4.Text = "Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(393, 341);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(368, 400);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 5;
            label6.Text = "Password: ";
            // 
            // id_tb
            // 
            id_tb.Location = new Point(494, 231);
            id_tb.Name = "id_tb";
            id_tb.Size = new Size(181, 23);
            id_tb.TabIndex = 6;
            // 
            // name_tb
            // 
            name_tb.Location = new Point(494, 292);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(226, 23);
            name_tb.TabIndex = 7;
            // 
            // email_tb
            // 
            email_tb.Location = new Point(494, 346);
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(226, 23);
            email_tb.TabIndex = 8;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(494, 400);
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(190, 23);
            password_tb.TabIndex = 9;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(255, 224, 192);
            update_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_btn.Location = new Point(434, 515);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(139, 35);
            update_btn.TabIndex = 10;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(255, 128, 128);
            delete_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(585, 515);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(135, 35);
            delete_btn.TabIndex = 11;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Student_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 646);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(password_tb);
            Controls.Add(email_tb);
            Controls.Add(name_tb);
            Controls.Add(id_tb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student_Info";
            Text = "Student_Info";
            Load += Student_Info_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox search_tb;
        private Label label1;
        private PictureBox search_pb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox id_tb;
        private TextBox name_tb;
        private TextBox email_tb;
        private TextBox password_tb;
        private Button update_btn;
        private Button delete_btn;
    }
}