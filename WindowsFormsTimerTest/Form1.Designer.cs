
namespace WindowsFormsTimerTest
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
            this.components = new System.ComponentModel.Container();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtManualCount = new System.Windows.Forms.TextBox();
            this.btnSlow = new System.Windows.Forms.Button();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.txtBackgroundWorkerCount = new System.Windows.Forms.TextBox();
            this.btnStartBackgroundWorker = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(38, 32);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 23);
            this.txtCount.TabIndex = 0;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(181, 32);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 1;
            this.btnTimer.Text = "Start";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(181, 98);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(31, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(225, 98);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(31, 23);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtManualCount
            // 
            this.txtManualCount.Location = new System.Drawing.Point(38, 97);
            this.txtManualCount.Name = "txtManualCount";
            this.txtManualCount.Size = new System.Drawing.Size(100, 23);
            this.txtManualCount.TabIndex = 4;
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(251, 202);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(146, 23);
            this.btnSlow.TabIndex = 5;
            this.btnSlow.Text = "Do Something Slow";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // bwMain
            // 
            this.bwMain.WorkerReportsProgress = true;
            this.bwMain.WorkerSupportsCancellation = true;
            this.bwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMain_DoWork);
            this.bwMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMain_ProgressChanged);
            this.bwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMain_RunWorkerCompleted);
            // 
            // txtBackgroundWorkerCount
            // 
            this.txtBackgroundWorkerCount.Location = new System.Drawing.Point(38, 156);
            this.txtBackgroundWorkerCount.Name = "txtBackgroundWorkerCount";
            this.txtBackgroundWorkerCount.Size = new System.Drawing.Size(100, 23);
            this.txtBackgroundWorkerCount.TabIndex = 6;
            // 
            // btnStartBackgroundWorker
            // 
            this.btnStartBackgroundWorker.Location = new System.Drawing.Point(181, 156);
            this.btnStartBackgroundWorker.Name = "btnStartBackgroundWorker";
            this.btnStartBackgroundWorker.Size = new System.Drawing.Size(166, 23);
            this.btnStartBackgroundWorker.TabIndex = 7;
            this.btnStartBackgroundWorker.Text = "Start Background Worker";
            this.btnStartBackgroundWorker.UseVisualStyleBackColor = true;
            this.btnStartBackgroundWorker.Click += new System.EventHandler(this.btnStartBackgroundWorker_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(367, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartBackgroundWorker);
            this.Controls.Add(this.txtBackgroundWorkerCount);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.txtManualCount);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.txtCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtManualCount;
        private System.Windows.Forms.Button btnSlow;
        private System.ComponentModel.BackgroundWorker bwMain;
        private System.Windows.Forms.TextBox txtBackgroundWorkerCount;
        private System.Windows.Forms.Button btnStartBackgroundWorker;
        private System.Windows.Forms.Button btnCancel;
    }
}

