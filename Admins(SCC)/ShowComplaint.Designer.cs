namespace Admins_SCC_
{
    partial class ShowComplaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowComplaint));
            panel1 = new Panel();
            stdID_lable = new Label();
            pictureBox1 = new PictureBox();
            subject_lable = new Label();
            discrib_lable = new Label();
            picture_boxT = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            status_lable = new Label();
            stage_lable = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_boxT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(stdID_lable);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 73);
            panel1.TabIndex = 0;
            // 
            // stdID_lable
            // 
            stdID_lable.AutoSize = true;
            stdID_lable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdID_lable.Location = new Point(130, 19);
            stdID_lable.Name = "stdID_lable";
            stdID_lable.Size = new Size(97, 37);
            stdID_lable.TabIndex = 1;
            stdID_lable.Text = "11714";
            stdID_lable.Click += stdID_lable_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // subject_lable
            // 
            subject_lable.AutoSize = true;
            subject_lable.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subject_lable.Location = new Point(12, 76);
            subject_lable.Name = "subject_lable";
            subject_lable.Size = new Size(162, 30);
            subject_lable.TabIndex = 1;
            subject_lable.Text = "21: Technology";
            // 
            // discrib_lable
            // 
            discrib_lable.AutoSize = true;
            discrib_lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discrib_lable.Location = new Point(143, 212);
            discrib_lable.Name = "discrib_lable";
            discrib_lable.Size = new Size(354, 21);
            discrib_lable.TabIndex = 2;
            discrib_lable.Text = "Discribtion: There are many problems in systems, ";
            discrib_lable.Click += label1_Click;
            // 
            // picture_boxT
            // 
            picture_boxT.Location = new Point(271, 310);
            picture_boxT.Name = "picture_boxT";
            picture_boxT.Size = new Size(500, 430);
            picture_boxT.SizeMode = PictureBoxSizeMode.Zoom;
            picture_boxT.TabIndex = 3;
            picture_boxT.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 210);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 4;
            label2.Text = "Discribtion: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 159);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 5;
            label3.Text = "Stage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 119);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 6;
            label4.Text = "Status:";
            // 
            // status_lable
            // 
            status_lable.AutoSize = true;
            status_lable.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status_lable.Location = new Point(105, 120);
            status_lable.Name = "status_lable";
            status_lable.Size = new Size(64, 20);
            status_lable.TabIndex = 7;
            status_lable.Text = "pending";
            // 
            // stage_lable
            // 
            stage_lable.AutoSize = true;
            stage_lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stage_lable.Location = new Point(105, 160);
            stage_lable.Name = "stage_lable";
            stage_lable.Size = new Size(95, 21);
            stage_lable.TabIndex = 8;
            stage_lable.Text = "Main Admin";
            // 
            // ShowComplaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(843, 749);
            Controls.Add(stage_lable);
            Controls.Add(status_lable);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picture_boxT);
            Controls.Add(discrib_lable);
            Controls.Add(subject_lable);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ShowComplaint";
            Text = "ShowComplaint";
            WindowState = FormWindowState.Maximized;
            Load += ShowComplaint_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_boxT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label stdID_lable;
        private Label subject_lable;
        private Label discrib_lable;
        private PictureBox picture_boxT;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label status_lable;
        private Label stage_lable;
    }
}