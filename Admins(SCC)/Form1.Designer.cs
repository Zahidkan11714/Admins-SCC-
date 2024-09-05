namespace Admins_SCC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            email_textbox = new TextBox();
            password_textbox = new TextBox();
            label2 = new Label();
            logIn_btn = new Button();
            label3 = new Label();
            sso_radiobtn = new RadioButton();
            registrar_radiobtn = new RadioButton();
            vc_radiobtn = new RadioButton();
            president_radiobtn = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(594, 187);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // email_textbox
            // 
            email_textbox.Location = new Point(594, 211);
            email_textbox.Name = "email_textbox";
            email_textbox.Size = new Size(191, 23);
            email_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(594, 279);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(191, 23);
            password_textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 255);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // logIn_btn
            // 
            logIn_btn.BackColor = Color.FromArgb(128, 128, 255);
            logIn_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logIn_btn.Location = new Point(623, 438);
            logIn_btn.Name = "logIn_btn";
            logIn_btn.Size = new Size(139, 36);
            logIn_btn.TabIndex = 6;
            logIn_btn.Text = "Log In";
            logIn_btn.UseVisualStyleBackColor = false;
            logIn_btn.Click += logIn_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(570, 340);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 7;
            label3.Text = "Select role:";
            // 
            // sso_radiobtn
            // 
            sso_radiobtn.AutoSize = true;
            sso_radiobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sso_radiobtn.Location = new Point(674, 340);
            sso_radiobtn.Name = "sso_radiobtn";
            sso_radiobtn.Size = new Size(50, 21);
            sso_radiobtn.TabIndex = 8;
            sso_radiobtn.TabStop = true;
            sso_radiobtn.Text = "SSO";
            sso_radiobtn.UseVisualStyleBackColor = true;
            // 
            // registrar_radiobtn
            // 
            registrar_radiobtn.AutoSize = true;
            registrar_radiobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrar_radiobtn.Location = new Point(738, 338);
            registrar_radiobtn.Name = "registrar_radiobtn";
            registrar_radiobtn.Size = new Size(81, 21);
            registrar_radiobtn.TabIndex = 9;
            registrar_radiobtn.TabStop = true;
            registrar_radiobtn.Text = "Registrar";
            registrar_radiobtn.UseVisualStyleBackColor = true;
            // 
            // vc_radiobtn
            // 
            vc_radiobtn.AutoSize = true;
            vc_radiobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vc_radiobtn.Location = new Point(674, 376);
            vc_radiobtn.Name = "vc_radiobtn";
            vc_radiobtn.Size = new Size(43, 21);
            vc_radiobtn.TabIndex = 10;
            vc_radiobtn.TabStop = true;
            vc_radiobtn.Text = "VC";
            vc_radiobtn.UseVisualStyleBackColor = true;
            // 
            // president_radiobtn
            // 
            president_radiobtn.AutoSize = true;
            president_radiobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            president_radiobtn.Location = new Point(738, 376);
            president_radiobtn.Name = "president_radiobtn";
            president_radiobtn.Size = new Size(84, 21);
            president_radiobtn.TabIndex = 11;
            president_radiobtn.TabStop = true;
            president_radiobtn.Text = "President";
            president_radiobtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 471);
            Controls.Add(president_radiobtn);
            Controls.Add(vc_radiobtn);
            Controls.Add(registrar_radiobtn);
            Controls.Add(sso_radiobtn);
            Controls.Add(label3);
            Controls.Add(logIn_btn);
            Controls.Add(password_textbox);
            Controls.Add(label2);
            Controls.Add(email_textbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox email_textbox;
        private TextBox password_textbox;
        private Label label2;
        private Button logIn_btn;
        private Label label3;
        private RadioButton sso_radiobtn;
        private RadioButton registrar_radiobtn;
        private RadioButton vc_radiobtn;
        private RadioButton president_radiobtn;
    }
}
