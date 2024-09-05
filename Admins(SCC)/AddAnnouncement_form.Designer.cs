namespace Admins_SCC_
{
    partial class AddAnnouncement_form
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
            subject_text = new TextBox();
            discribtion_text = new TextBox();
            Add_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 120);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Subject: ";
            // 
            // subject_text
            // 
            subject_text.Location = new Point(340, 120);
            subject_text.Name = "subject_text";
            subject_text.Size = new Size(223, 23);
            subject_text.TabIndex = 1;
            // 
            // discribtion_text
            // 
            discribtion_text.Location = new Point(279, 167);
            discribtion_text.Multiline = true;
            discribtion_text.Name = "discribtion_text";
            discribtion_text.Size = new Size(308, 159);
            discribtion_text.TabIndex = 2;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = Color.FromArgb(192, 192, 255);
            Add_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_btn.Location = new Point(367, 362);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(136, 35);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Submit";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // AddAnnouncement_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_btn);
            Controls.Add(discribtion_text);
            Controls.Add(subject_text);
            Controls.Add(label1);
            Name = "AddAnnouncement_form";
            Text = "AddAnnouncement_form";
            Load += AddAnnouncement_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox subject_text;
        private TextBox discribtion_text;
        private Button Add_btn;
    }
}