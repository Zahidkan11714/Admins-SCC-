namespace Admins_SCC_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            SideBar_panel = new Panel();
            registration_btn = new Button();
            studentInfo_btn = new Button();
            adminName_text = new Label();
            button1 = new Button();
            AdminInfo_btn = new Button();
            voteComplaint_btn = new Button();
            annocuncement_btn = new Button();
            notify_btn = new Button();
            home_btn = new Button();
            pictureBox1 = new PictureBox();
            main_panel = new Panel();
            SideBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SideBar_panel
            // 
            SideBar_panel.BackColor = Color.Silver;
            SideBar_panel.Controls.Add(registration_btn);
            SideBar_panel.Controls.Add(studentInfo_btn);
            SideBar_panel.Controls.Add(adminName_text);
            SideBar_panel.Controls.Add(button1);
            SideBar_panel.Controls.Add(AdminInfo_btn);
            SideBar_panel.Controls.Add(voteComplaint_btn);
            SideBar_panel.Controls.Add(annocuncement_btn);
            SideBar_panel.Controls.Add(notify_btn);
            SideBar_panel.Controls.Add(home_btn);
            SideBar_panel.Controls.Add(pictureBox1);
            SideBar_panel.Dock = DockStyle.Left;
            SideBar_panel.Location = new Point(0, 0);
            SideBar_panel.Name = "SideBar_panel";
            SideBar_panel.Size = new Size(222, 705);
            SideBar_panel.TabIndex = 0;
            // 
            // registration_btn
            // 
            registration_btn.BackColor = Color.FromArgb(255, 224, 192);
            registration_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registration_btn.Location = new Point(24, 455);
            registration_btn.Name = "registration_btn";
            registration_btn.Size = new Size(178, 47);
            registration_btn.TabIndex = 3;
            registration_btn.Text = "Registration";
            registration_btn.UseVisualStyleBackColor = false;
            registration_btn.Click += registration_btn_Click;
            // 
            // studentInfo_btn
            // 
            studentInfo_btn.BackColor = Color.FromArgb(255, 224, 192);
            studentInfo_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentInfo_btn.Location = new Point(24, 402);
            studentInfo_btn.Name = "studentInfo_btn";
            studentInfo_btn.Size = new Size(178, 47);
            studentInfo_btn.TabIndex = 5;
            studentInfo_btn.Text = "Student Info";
            studentInfo_btn.UseVisualStyleBackColor = false;
            studentInfo_btn.Click += studentInfo_btn_Click;
            // 
            // adminName_text
            // 
            adminName_text.AutoSize = true;
            adminName_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminName_text.Location = new Point(79, 97);
            adminName_text.Name = "adminName_text";
            adminName_text.Size = new Size(40, 21);
            adminName_text.TabIndex = 4;
            adminName_text.Text = "SSO";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 660);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 3;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminInfo_btn
            // 
            AdminInfo_btn.BackColor = Color.FromArgb(255, 224, 192);
            AdminInfo_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminInfo_btn.Location = new Point(24, 349);
            AdminInfo_btn.Name = "AdminInfo_btn";
            AdminInfo_btn.Size = new Size(178, 47);
            AdminInfo_btn.TabIndex = 2;
            AdminInfo_btn.Text = "Admin Info";
            AdminInfo_btn.UseVisualStyleBackColor = false;
            AdminInfo_btn.Click += AdminInfo_btn_Click;
            // 
            // voteComplaint_btn
            // 
            voteComplaint_btn.BackColor = Color.FromArgb(255, 224, 192);
            voteComplaint_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            voteComplaint_btn.Location = new Point(24, 190);
            voteComplaint_btn.Name = "voteComplaint_btn";
            voteComplaint_btn.Size = new Size(178, 47);
            voteComplaint_btn.TabIndex = 2;
            voteComplaint_btn.Text = "Vote Complaints";
            voteComplaint_btn.UseVisualStyleBackColor = false;
            voteComplaint_btn.Click += voteComplaint_btn_Click;
            // 
            // annocuncement_btn
            // 
            annocuncement_btn.BackColor = Color.FromArgb(255, 224, 192);
            annocuncement_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            annocuncement_btn.Location = new Point(24, 296);
            annocuncement_btn.Name = "annocuncement_btn";
            annocuncement_btn.Size = new Size(178, 47);
            annocuncement_btn.TabIndex = 2;
            annocuncement_btn.Text = "Annocuncement";
            annocuncement_btn.UseVisualStyleBackColor = false;
            annocuncement_btn.Click += annocuncement_btn_Click;
            // 
            // notify_btn
            // 
            notify_btn.BackColor = Color.FromArgb(255, 224, 192);
            notify_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notify_btn.Location = new Point(24, 243);
            notify_btn.Name = "notify_btn";
            notify_btn.Size = new Size(178, 47);
            notify_btn.TabIndex = 2;
            notify_btn.Text = "Notifications";
            notify_btn.UseVisualStyleBackColor = false;
            notify_btn.Click += notify_btn_Click;
            // 
            // home_btn
            // 
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            home_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            home_btn.Location = new Point(24, 134);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(178, 47);
            home_btn.TabIndex = 1;
            home_btn.Text = "Home";
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(222, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(637, 705);
            main_panel.TabIndex = 1;
            main_panel.Paint += main_panel_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(859, 705);
            Controls.Add(main_panel);
            Controls.Add(SideBar_panel);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            SideBar_panel.ResumeLayout(false);
            SideBar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SideBar_panel;
        private PictureBox pictureBox1;
        private Button annocuncement_btn;
        private Button AdminInfo_btn;
        private Button notify_btn;
        private Button home_btn;
        private Panel main_panel;
        private Button voteComplaint_btn;
        private Button button1;
        private Label adminName_text;
        private Button registration_btn;
        private Button studentInfo_btn;
    }
}