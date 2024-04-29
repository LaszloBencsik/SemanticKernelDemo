namespace DesignCopilotDemo
{
    partial class FormLightingDemo
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
            components = new System.ComponentModel.Container();
            textBoxInput = new TextBox();
            textBoxHistory = new TextBox();
            textBoxLog = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelCopilot = new Label();
            label2 = new Label();
            label4 = new Label();
            panelMainLeft = new Panel();
            pictureBoxLamp = new PictureBox();
            panel3 = new Panel();
            panelCopilotBottom = new Panel();
            panelMainRight = new Panel();
            panelMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamp).BeginInit();
            panel3.SuspendLayout();
            panelCopilotBottom.SuspendLayout();
            panelMainRight.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Bottom;
            textBoxInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(0, 12);
            textBoxInput.Margin = new Padding(1);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "prompt";
            textBoxInput.Size = new Size(429, 32);
            textBoxInput.TabIndex = 1;
            textBoxInput.TabStop = false;
            textBoxInput.KeyDown += textBoxInput_KeyDown;
            // 
            // textBoxHistory
            // 
            textBoxHistory.BackColor = SystemColors.ControlLight;
            textBoxHistory.Dock = DockStyle.Fill;
            textBoxHistory.Font = new Font("Segoe UI", 14F);
            textBoxHistory.Location = new Point(7, 31);
            textBoxHistory.Margin = new Padding(1);
            textBoxHistory.MinimumSize = new Size(38, 9);
            textBoxHistory.Multiline = true;
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.ReadOnly = true;
            textBoxHistory.Size = new Size(429, 501);
            textBoxHistory.TabIndex = 0;
            textBoxHistory.TabStop = false;
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = SystemColors.ControlLight;
            textBoxLog.Dock = DockStyle.Fill;
            textBoxLog.Location = new Point(7, 31);
            textBoxLog.Margin = new Padding(1, 9, 1, 1);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.Size = new Size(268, 545);
            textBoxLog.TabIndex = 2;
            textBoxLog.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // labelCopilot
            // 
            labelCopilot.AutoSize = true;
            labelCopilot.Dock = DockStyle.Top;
            labelCopilot.Font = new Font("Segoe UI", 14F);
            labelCopilot.Location = new Point(7, 6);
            labelCopilot.Margin = new Padding(1, 0, 1, 0);
            labelCopilot.Name = "labelCopilot";
            labelCopilot.Size = new Size(183, 25);
            labelCopilot.TabIndex = 5;
            labelCopilot.Text = "copilot conversation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(7, 6);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 6;
            label2.Text = "technical log";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(7, 6);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 6;
            label4.Text = "virtual lamp";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMainLeft
            // 
            panelMainLeft.Controls.Add(pictureBoxLamp);
            panelMainLeft.Controls.Add(label4);
            panelMainLeft.Dock = DockStyle.Left;
            panelMainLeft.Location = new Point(0, 0);
            panelMainLeft.Margin = new Padding(1);
            panelMainLeft.Name = "panelMainLeft";
            panelMainLeft.Padding = new Padding(7, 6, 7, 6);
            panelMainLeft.Size = new Size(234, 582);
            panelMainLeft.TabIndex = 7;
            // 
            // pictureBoxLamp
            // 
            pictureBoxLamp.BackColor = SystemColors.Highlight;
            pictureBoxLamp.Image = Properties.Resources.lamp;
            pictureBoxLamp.Location = new Point(7, 32);
            pictureBoxLamp.Margin = new Padding(1);
            pictureBoxLamp.Name = "pictureBoxLamp";
            pictureBoxLamp.Size = new Size(216, 220);
            pictureBoxLamp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLamp.TabIndex = 11;
            pictureBoxLamp.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(textBoxHistory);
            panel3.Controls.Add(panelCopilotBottom);
            panel3.Controls.Add(labelCopilot);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(234, 0);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7, 6, 7, 6);
            panel3.Size = new Size(443, 582);
            panel3.TabIndex = 8;
            // 
            // panelCopilotBottom
            // 
            panelCopilotBottom.Controls.Add(textBoxInput);
            panelCopilotBottom.Dock = DockStyle.Bottom;
            panelCopilotBottom.Location = new Point(7, 532);
            panelCopilotBottom.Margin = new Padding(1);
            panelCopilotBottom.Name = "panelCopilotBottom";
            panelCopilotBottom.Size = new Size(429, 44);
            panelCopilotBottom.TabIndex = 9;
            // 
            // panelMainRight
            // 
            panelMainRight.Controls.Add(textBoxLog);
            panelMainRight.Controls.Add(label2);
            panelMainRight.Dock = DockStyle.Right;
            panelMainRight.Location = new Point(677, 0);
            panelMainRight.Margin = new Padding(1);
            panelMainRight.Name = "panelMainRight";
            panelMainRight.Padding = new Padding(7, 6, 7, 6);
            panelMainRight.Size = new Size(282, 582);
            panelMainRight.TabIndex = 9;
            // 
            // FormLightingDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(959, 582);
            Controls.Add(panel3);
            Controls.Add(panelMainRight);
            Controls.Add(panelMainLeft);
            Margin = new Padding(1);
            Name = "FormLightingDemo";
            Text = "Semantic Kernel Demo for Azure Open AI - Lighting Copilot";
            WindowState = FormWindowState.Maximized;
            Load += FormLightingDemo_Load;
            panelMainLeft.ResumeLayout(false);
            panelMainLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLamp).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelCopilotBottom.ResumeLayout(false);
            panelCopilotBottom.PerformLayout();
            panelMainRight.ResumeLayout(false);
            panelMainRight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private TextBox textBoxHistory;
        private TextBox textBoxLog;
        private System.Windows.Forms.Timer timer1;
        private Label labelCopilot;
        private Label label2;
        private Label label4;
        private Panel panelMainLeft;
        private Panel panel3;
        private Panel panelMainRight;
        private Panel panelCopilotBottom;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLamp;
    }
}
