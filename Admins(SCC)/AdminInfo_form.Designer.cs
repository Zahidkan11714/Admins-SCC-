namespace Admins_SCC_
{
    partial class AdminInfo_form
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
            panel1 = new Panel();
            president_btn = new Button();
            vc_btn = new Button();
            registrar_btn = new Button();
            sso_btn = new Button();
            Show_recordPanel = new Panel();
            button1 = new Button();
            password_text = new TextBox();
            email_text = new TextBox();
            name_text = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            id_text = new TextBox();
            panel1.SuspendLayout();
            Show_recordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 0);
            panel1.Controls.Add(president_btn);
            panel1.Controls.Add(vc_btn);
            panel1.Controls.Add(registrar_btn);
            panel1.Controls.Add(sso_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 76);
            panel1.TabIndex = 0;
            // 
            // president_btn
            // 
            president_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            president_btn.Location = new Point(578, 12);
            president_btn.Name = "president_btn";
            president_btn.Size = new Size(162, 42);
            president_btn.TabIndex = 0;
            president_btn.Text = "President";
            president_btn.UseVisualStyleBackColor = true;
            president_btn.Click += president_btn_Click;
            // 
            // vc_btn
            // 
            vc_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vc_btn.Location = new Point(391, 12);
            vc_btn.Name = "vc_btn";
            vc_btn.Size = new Size(162, 42);
            vc_btn.TabIndex = 0;
            vc_btn.Text = "VC";
            vc_btn.UseVisualStyleBackColor = true;
            vc_btn.Click += vc_btn_Click;
            // 
            // registrar_btn
            // 
            registrar_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar_btn.Location = new Point(208, 12);
            registrar_btn.Name = "registrar_btn";
            registrar_btn.Size = new Size(162, 42);
            registrar_btn.TabIndex = 0;
            registrar_btn.Text = "Registrar";
            registrar_btn.UseVisualStyleBackColor = true;
            registrar_btn.Click += registrar_btn_Click;
            // 
            // sso_btn
            // 
            sso_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sso_btn.Location = new Point(27, 12);
            sso_btn.Name = "sso_btn";
            sso_btn.Size = new Size(162, 42);
            sso_btn.TabIndex = 0;
            sso_btn.Text = "SSO";
            sso_btn.UseVisualStyleBackColor = true;
            sso_btn.Click += sso_btn_Click;
            // 
            // Show_recordPanel
            // 
            Show_recordPanel.Controls.Add(button1);
            Show_recordPanel.Controls.Add(password_text);
            Show_recordPanel.Controls.Add(email_text);
            Show_recordPanel.Controls.Add(name_text);
            Show_recordPanel.Controls.Add(label5);
            Show_recordPanel.Controls.Add(label4);
            Show_recordPanel.Controls.Add(label3);
            Show_recordPanel.Controls.Add(label2);
            Show_recordPanel.Controls.Add(label1);
            Show_recordPanel.Controls.Add(id_text);
            Show_recordPanel.Dock = DockStyle.Fill;
            Show_recordPanel.Location = new Point(0, 76);
            Show_recordPanel.Name = "Show_recordPanel";
            Show_recordPanel.Size = new Size(847, 624);
            Show_recordPanel.TabIndex = 1;
            Show_recordPanel.Paint += Show_recordPanel_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(504, 471);
            button1.Name = "button1";
            button1.Size = new Size(115, 33);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password_text
            // 
            password_text.Location = new Point(519, 367);
            password_text.Name = "password_text";
            password_text.Size = new Size(188, 23);
            password_text.TabIndex = 5;
            // 
            // email_text
            // 
            email_text.Location = new Point(519, 301);
            email_text.Name = "email_text";
            email_text.Size = new Size(188, 23);
            email_text.TabIndex = 4;
            // 
            // name_text
            // 
            name_text.Location = new Point(519, 228);
            name_text.Name = "name_text";
            name_text.Size = new Size(171, 23);
            name_text.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 369);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 2;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 299);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 230);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 163);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(359, 78);
            label1.Name = "label1";
            label1.Size = new Size(393, 30);
            label1.TabIndex = 1;
            label1.Text = " *** Update a Admin Log in Record ***";
            // 
            // id_text
            // 
            id_text.Location = new Point(519, 163);
            id_text.Name = "id_text";
            id_text.Size = new Size(171, 23);
            id_text.TabIndex = 0;
            // 
            // AdminInfo_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 700);
            Controls.Add(Show_recordPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminInfo_form";
            Text = "message_form";
            panel1.ResumeLayout(false);
            Show_recordPanel.ResumeLayout(false);
            Show_recordPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button sso_btn;
        private Button president_btn;
        private Button vc_btn;
        private Button registrar_btn;
        private Panel Show_recordPanel;
        private TextBox id_text;
        private Label label1;
        private TextBox password_text;
        private TextBox email_text;
        private TextBox name_text;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}