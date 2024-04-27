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
            panel1 = new Panel();
            panelLight = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(1739, 1427);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(1079, 55);
            textBoxInput.TabIndex = 0;
            textBoxInput.KeyDown += textBoxInput_KeyDown;
            // 
            // textBoxHistory
            // 
            textBoxHistory.BackColor = SystemColors.ControlDark;
            textBoxHistory.Location = new Point(1739, 103);
            textBoxHistory.Multiline = true;
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.ReadOnly = true;
            textBoxHistory.Size = new Size(1067, 1287);
            textBoxHistory.TabIndex = 1;
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = SystemColors.ControlDark;
            textBoxLog.Location = new Point(773, 101);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.Size = new Size(921, 1289);
            textBoxLog.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panelLight);
            panel1.Location = new Point(86, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 488);
            panel1.TabIndex = 4;
            // 
            // panelLight
            // 
            panelLight.BackColor = Color.WhiteSmoke;
            panelLight.Location = new Point(75, 59);
            panelLight.Name = "panelLight";
            panelLight.Size = new Size(451, 359);
            panelLight.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1795, 52);
            label1.Name = "label1";
            label1.Size = new Size(342, 48);
            label1.TabIndex = 5;
            label1.Text = "copilot conversation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(806, 50);
            label2.Name = "label2";
            label2.Size = new Size(222, 48);
            label2.TabIndex = 6;
            label2.Text = "technical log";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1572, 1422);
            label3.Name = "label3";
            label3.Size = new Size(147, 48);
            label3.TabIndex = 6;
            label3.Text = "prompt:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(229, 430);
            label4.Name = "label4";
            label4.Size = new Size(323, 74);
            label4.TabIndex = 6;
            label4.Text = "virtual lamp";
            // 
            // FormLightingDemo
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2875, 1519);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBoxLog);
            Controls.Add(textBoxHistory);
            Controls.Add(textBoxInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLightingDemo";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private TextBox textBoxHistory;
        private TextBox textBoxLog;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panelLight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
