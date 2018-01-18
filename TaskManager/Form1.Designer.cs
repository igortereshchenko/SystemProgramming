namespace TaskManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lstBoxProcesses = new System.Windows.Forms.ListBox();
            this.btnEndProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxProcesses
            // 
            this.lstBoxProcesses.ContextMenuStrip = this.contextMenuStrip;
            this.lstBoxProcesses.FormattingEnabled = true;
            this.lstBoxProcesses.Location = new System.Drawing.Point(12, 65);
            this.lstBoxProcesses.Name = "lstBoxProcesses";
            this.lstBoxProcesses.Size = new System.Drawing.Size(369, 316);
            this.lstBoxProcesses.TabIndex = 0;
            // 
            // btnEndProcess
            // 
            this.btnEndProcess.Location = new System.Drawing.Point(12, 25);
            this.btnEndProcess.Name = "btnEndProcess";
            this.btnEndProcess.Size = new System.Drawing.Size(75, 23);
            this.btnEndProcess.TabIndex = 1;
            this.btnEndProcess.Text = "End process";
            this.btnEndProcess.UseVisualStyleBackColor = true;
            this.btnEndProcess.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(144, 30);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(13, 13);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "0";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killProcessToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.killProcessToolStripMenuItem.Text = "End process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.btnEndProcess_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 386);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndProcess);
            this.Controls.Add(this.lstBoxProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxProcesses;
        private System.Windows.Forms.Button btnEndProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
    }
}

