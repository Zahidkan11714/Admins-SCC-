namespace Admins_SCC_
{
    partial class notify_form
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
            suggestion_btn = new Button();
            Notify_btn = new Button();
            Notify_pannel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(suggestion_btn);
            panel1.Controls.Add(Notify_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 0;
            // 
            // suggestion_btn
            // 
            suggestion_btn.BackColor = Color.FromArgb(192, 255, 255);
            suggestion_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestion_btn.Location = new Point(207, 12);
            suggestion_btn.Name = "suggestion_btn";
            suggestion_btn.Size = new Size(179, 44);
            suggestion_btn.TabIndex = 1;
            suggestion_btn.Text = "Suggestions";
            suggestion_btn.UseVisualStyleBackColor = false;
            suggestion_btn.Click += suggestion_btn_Click;
            // 
            // Notify_btn
            // 
            Notify_btn.BackColor = Color.FromArgb(192, 255, 255);
            Notify_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Notify_btn.Location = new Point(12, 12);
            Notify_btn.Name = "Notify_btn";
            Notify_btn.Size = new Size(179, 44);
            Notify_btn.TabIndex = 0;
            Notify_btn.Text = "Notifications";
            Notify_btn.UseVisualStyleBackColor = false;
            Notify_btn.Click += Notify_btn_Click;
            // 
            // Notify_pannel
            // 
            Notify_pannel.BorderStyle = BorderStyle.FixedSingle;
            Notify_pannel.Dock = DockStyle.Fill;
            Notify_pannel.Location = new Point(0, 66);
            Notify_pannel.Name = "Notify_pannel";
            Notify_pannel.Size = new Size(800, 384);
            Notify_pannel.TabIndex = 1;
            Notify_pannel.Paint += Notify_pannel_Paint;
            // 
            // notify_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Notify_pannel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "notify_form";
            Text = "notify_form";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button suggestion_btn;
        private Button Notify_btn;
        private Panel Notify_pannel;
    }
}