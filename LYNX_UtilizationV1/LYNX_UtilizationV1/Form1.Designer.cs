namespace LYNX_UtilizationV1
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
            this.excellentBtn = new System.Windows.Forms.Button();
            this.poorBtn = new System.Windows.Forms.Button();
            this.avgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qPromptLbl = new System.Windows.Forms.Label();
            this.startOverBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.testConnBtn = new System.Windows.Forms.Button();
            this.previewSubBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // excellentBtn
            // 
            this.excellentBtn.AllowDrop = true;
            this.excellentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.excellentBtn.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellentBtn.ForeColor = System.Drawing.Color.Snow;
            this.excellentBtn.Location = new System.Drawing.Point(6, 164);
            this.excellentBtn.Name = "excellentBtn";
            this.excellentBtn.Size = new System.Drawing.Size(258, 150);
            this.excellentBtn.TabIndex = 0;
            this.excellentBtn.Text = "Excellent";
            this.excellentBtn.UseVisualStyleBackColor = false;
            this.excellentBtn.Click += new System.EventHandler(this.excellentBtn_Click);
            // 
            // poorBtn
            // 
            this.poorBtn.BackColor = System.Drawing.Color.Red;
            this.poorBtn.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.poorBtn.Location = new System.Drawing.Point(534, 167);
            this.poorBtn.Name = "poorBtn";
            this.poorBtn.Size = new System.Drawing.Size(244, 150);
            this.poorBtn.TabIndex = 1;
            this.poorBtn.Text = "Poor";
            this.poorBtn.UseVisualStyleBackColor = false;
            this.poorBtn.Click += new System.EventHandler(this.poorBtn_Click);
            // 
            // avgBtn
            // 
            this.avgBtn.BackColor = System.Drawing.Color.Gold;
            this.avgBtn.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBtn.ForeColor = System.Drawing.Color.Snow;
            this.avgBtn.Location = new System.Drawing.Point(270, 164);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(258, 150);
            this.avgBtn.TabIndex = 2;
            this.avgBtn.Text = "Average";
            this.avgBtn.UseVisualStyleBackColor = false;
            this.avgBtn.Click += new System.EventHandler(this.avgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilization Data Entry";
            // 
            // qPromptLbl
            // 
            this.qPromptLbl.AutoSize = true;
            this.qPromptLbl.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qPromptLbl.Location = new System.Drawing.Point(320, 95);
            this.qPromptLbl.Name = "qPromptLbl";
            this.qPromptLbl.Size = new System.Drawing.Size(0, 34);
            this.qPromptLbl.TabIndex = 5;
            // 
            // startOverBtn
            // 
            this.startOverBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverBtn.Location = new System.Drawing.Point(12, 323);
            this.startOverBtn.Name = "startOverBtn";
            this.startOverBtn.Size = new System.Drawing.Size(195, 92);
            this.startOverBtn.TabIndex = 6;
            this.startOverBtn.Text = "Start Over";
            this.startOverBtn.UseVisualStyleBackColor = true;
            this.startOverBtn.Click += new System.EventHandler(this.startOverBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(6, 147);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(772, 170);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Begin";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(6, 95);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(772, 222);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit to Database";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // testConnBtn
            // 
            this.testConnBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testConnBtn.Location = new System.Drawing.Point(222, 323);
            this.testConnBtn.Name = "testConnBtn";
            this.testConnBtn.Size = new System.Drawing.Size(301, 92);
            this.testConnBtn.TabIndex = 9;
            this.testConnBtn.Text = "Test DB Connection";
            this.testConnBtn.UseVisualStyleBackColor = true;
            this.testConnBtn.Click += new System.EventHandler(this.testConnBtn_Click);
            // 
            // previewSubBtn
            // 
            this.previewSubBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewSubBtn.Location = new System.Drawing.Point(539, 323);
            this.previewSubBtn.Name = "previewSubBtn";
            this.previewSubBtn.Size = new System.Drawing.Size(223, 92);
            this.previewSubBtn.TabIndex = 10;
            this.previewSubBtn.Text = "Preview Submission";
            this.previewSubBtn.UseVisualStyleBackColor = true;
            this.previewSubBtn.Click += new System.EventHandler(this.previewSubBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "N704";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.previewSubBtn);
            this.Controls.Add(this.testConnBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.startOverBtn);
            this.Controls.Add(this.qPromptLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.poorBtn);
            this.Controls.Add(this.excellentBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "LYNX_Utilization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excellentBtn;
        private System.Windows.Forms.Button poorBtn;
        private System.Windows.Forms.Button avgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qPromptLbl;
        private System.Windows.Forms.Button startOverBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button testConnBtn;
        private System.Windows.Forms.Button previewSubBtn;
        private System.Windows.Forms.Label label2;
    }
}

