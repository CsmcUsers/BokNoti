namespace BokNoti_1WinForm
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
            panel1 = new Panel();
            btnListen = new Button();
            txtBoxLog = new TextBox();
            panel2 = new Panel();
            btnStopListen = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBoxLog);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 447);
            panel1.TabIndex = 0;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(3, 3);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(82, 39);
            btnListen.TabIndex = 1;
            btnListen.Text = "啟用";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // txtBoxLog
            // 
            txtBoxLog.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLog.Location = new Point(0, 3);
            txtBoxLog.Multiline = true;
            txtBoxLog.Name = "txtBoxLog";
            txtBoxLog.Size = new Size(703, 441);
            txtBoxLog.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnStopListen);
            panel2.Controls.Add(btnListen);
            panel2.Location = new Point(711, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(88, 444);
            panel2.TabIndex = 2;
            // 
            // btnStopListen
            // 
            btnStopListen.Location = new Point(3, 48);
            btnStopListen.Name = "btnStopListen";
            btnStopListen.Size = new Size(82, 39);
            btnStopListen.TabIndex = 2;
            btnStopListen.Text = "停止";
            btnStopListen.UseVisualStyleBackColor = true;
            btnStopListen.Click += btnStopListen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnListen;
        private TextBox txtBoxLog;
        private Panel panel2;
        private Button btnStopListen;
    }
}