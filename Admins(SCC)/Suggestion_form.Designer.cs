namespace Admins_SCC_
{
    partial class Suggestion_form
    {
        private System.Windows.Forms.Panel scrollPanel;

        private void InitializeComponent()
        {
            scrollPanel = new Panel();
            message_tb = new Label();
            scrollPanel.SuspendLayout();
            SuspendLayout();
            // 
            // scrollPanel
            // 
            scrollPanel.AutoScroll = true;
            scrollPanel.Controls.Add(message_tb);
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.Location = new Point(0, 0);
            scrollPanel.Margin = new Padding(2);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Size = new Size(759, 457);
            scrollPanel.TabIndex = 1;
            scrollPanel.Paint += scrollPanel_Paint;
            // 
            // message_tb
            // 
            message_tb.AutoSize = true;
            message_tb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message_tb.Location = new Point(503, 295);
            message_tb.Name = "message_tb";
            message_tb.Size = new Size(133, 21);
            message_tb.TabIndex = 2;
            message_tb.Text = "No suggestions!";
            // 
            // Suggestion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 457);
            Controls.Add(scrollPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Suggestion_form";
            Text = "Suggestion Form";
            scrollPanel.ResumeLayout(false);
            scrollPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label message_tb;
    }

}