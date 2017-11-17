namespace LYNX_FTY_V3
{
    partial class FTY1
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
            this.badBtn = new System.Windows.Forms.Button();
            this.goodBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.entriesListbox = new System.Windows.Forms.ListBox();
            this.tableTxt = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.Label();
            this.machineNameTxt = new System.Windows.Forms.Label();
            this.elapsedTimeTxt = new System.Windows.Forms.Label();
            this.startTimeTxt = new System.Windows.Forms.Label();
            this.orderTxt = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.Label();
            this.scrollUpBtn = new System.Windows.Forms.Button();
            this.scrollDownBtn = new System.Windows.Forms.Button();
            this.partNumberTxt = new System.Windows.Forms.Label();
            this.partNumberBtn = new System.Windows.Forms.Button();
            this.switchUserBtn = new System.Windows.Forms.Button();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.currentTimeTxt = new System.Windows.Forms.Label();
            this.undoEntryBtn = new System.Windows.Forms.Button();
            this.workOpartNTimer = new System.Windows.Forms.Timer(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitBtn = new System.Windows.Forms.Button();
            this.commitOnCloseChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastCommitLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // badBtn
            // 
            this.badBtn.BackColor = System.Drawing.Color.Firebrick;
            this.badBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.badBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badBtn.ForeColor = System.Drawing.Color.White;
            this.badBtn.Location = new System.Drawing.Point(276, 121);
            this.badBtn.Name = "badBtn";
            this.badBtn.Size = new System.Drawing.Size(225, 151);
            this.badBtn.TabIndex = 32;
            this.badBtn.Text = "Bad";
            this.badBtn.UseVisualStyleBackColor = false;
            this.badBtn.Click += new System.EventHandler(this.badBtn_Click);
            // 
            // goodBtn
            // 
            this.goodBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.goodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodBtn.ForeColor = System.Drawing.Color.White;
            this.goodBtn.Location = new System.Drawing.Point(12, 121);
            this.goodBtn.Name = "goodBtn";
            this.goodBtn.Size = new System.Drawing.Size(225, 151);
            this.goodBtn.TabIndex = 31;
            this.goodBtn.Text = "Good";
            this.goodBtn.UseVisualStyleBackColor = false;
            this.goodBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Order Entries:";
            // 
            // entriesListbox
            // 
            this.entriesListbox.FormattingEnabled = true;
            this.entriesListbox.HorizontalScrollbar = true;
            this.entriesListbox.Location = new System.Drawing.Point(119, 313);
            this.entriesListbox.Name = "entriesListbox";
            this.entriesListbox.Size = new System.Drawing.Size(393, 121);
            this.entriesListbox.TabIndex = 29;
            // 
            // tableTxt
            // 
            this.tableTxt.AutoSize = true;
            this.tableTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTxt.Location = new System.Drawing.Point(484, 33);
            this.tableTxt.Name = "tableTxt";
            this.tableTxt.Size = new System.Drawing.Size(52, 20);
            this.tableTxt.TabIndex = 28;
            this.tableTxt.Text = "Table:";
            // 
            // databaseTxt
            // 
            this.databaseTxt.AutoSize = true;
            this.databaseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTxt.Location = new System.Drawing.Point(190, 33);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(83, 20);
            this.databaseTxt.TabIndex = 27;
            this.databaseTxt.Text = "Database:";
            // 
            // machineNameTxt
            // 
            this.machineNameTxt.AutoSize = true;
            this.machineNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineNameTxt.Location = new System.Drawing.Point(4, 33);
            this.machineNameTxt.Name = "machineNameTxt";
            this.machineNameTxt.Size = new System.Drawing.Size(88, 24);
            this.machineNameTxt.TabIndex = 26;
            this.machineNameTxt.Text = "Machine:";
            // 
            // elapsedTimeTxt
            // 
            this.elapsedTimeTxt.AutoSize = true;
            this.elapsedTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeTxt.Location = new System.Drawing.Point(485, 57);
            this.elapsedTimeTxt.Name = "elapsedTimeTxt";
            this.elapsedTimeTxt.Size = new System.Drawing.Size(96, 16);
            this.elapsedTimeTxt.TabIndex = 25;
            this.elapsedTimeTxt.Text = "Elapsed Time:";
            // 
            // startTimeTxt
            // 
            this.startTimeTxt.AutoSize = true;
            this.startTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTxt.Location = new System.Drawing.Point(4, 57);
            this.startTimeTxt.Name = "startTimeTxt";
            this.startTimeTxt.Size = new System.Drawing.Size(72, 16);
            this.startTimeTxt.TabIndex = 24;
            this.startTimeTxt.Text = "Start Time:";
            // 
            // orderTxt
            // 
            this.orderTxt.AutoSize = true;
            this.orderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTxt.Location = new System.Drawing.Point(190, 5);
            this.orderTxt.Name = "orderTxt";
            this.orderTxt.Size = new System.Drawing.Size(154, 20);
            this.orderTxt.TabIndex = 23;
            this.orderTxt.Text = "Work Order Number:";
            this.orderTxt.Click += new System.EventHandler(this.orderTxt_Click);
            // 
            // userTxt
            // 
            this.userTxt.AutoSize = true;
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(4, 5);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(63, 25);
            this.userTxt.TabIndex = 22;
            this.userTxt.Text = "User:";
            // 
            // scrollUpBtn
            // 
            this.scrollUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollUpBtn.Location = new System.Drawing.Point(2, 290);
            this.scrollUpBtn.Name = "scrollUpBtn";
            this.scrollUpBtn.Size = new System.Drawing.Size(112, 30);
            this.scrollUpBtn.TabIndex = 33;
            this.scrollUpBtn.Text = "Scroll Up";
            this.scrollUpBtn.UseVisualStyleBackColor = true;
            this.scrollUpBtn.Click += new System.EventHandler(this.scrollUpBtn_Click);
            // 
            // scrollDownBtn
            // 
            this.scrollDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrollDownBtn.Location = new System.Drawing.Point(2, 323);
            this.scrollDownBtn.Name = "scrollDownBtn";
            this.scrollDownBtn.Size = new System.Drawing.Size(112, 30);
            this.scrollDownBtn.TabIndex = 34;
            this.scrollDownBtn.Text = "Scroll Down";
            this.scrollDownBtn.UseVisualStyleBackColor = true;
            this.scrollDownBtn.Click += new System.EventHandler(this.scrollDownBtn_Click);
            // 
            // partNumberTxt
            // 
            this.partNumberTxt.AutoSize = true;
            this.partNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberTxt.Location = new System.Drawing.Point(484, 5);
            this.partNumberTxt.Name = "partNumberTxt";
            this.partNumberTxt.Size = new System.Drawing.Size(102, 20);
            this.partNumberTxt.TabIndex = 35;
            this.partNumberTxt.Text = "Part Number:";
            // 
            // partNumberBtn
            // 
            this.partNumberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberBtn.Location = new System.Drawing.Point(516, 121);
            this.partNumberBtn.Name = "partNumberBtn";
            this.partNumberBtn.Size = new System.Drawing.Size(256, 83);
            this.partNumberBtn.TabIndex = 36;
            this.partNumberBtn.Text = "Change Work Order/ Part Number";
            this.partNumberBtn.UseVisualStyleBackColor = true;
            this.partNumberBtn.Click += new System.EventHandler(this.partNumberBtn_Click);
            // 
            // switchUserBtn
            // 
            this.switchUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchUserBtn.Location = new System.Drawing.Point(516, 210);
            this.switchUserBtn.Name = "switchUserBtn";
            this.switchUserBtn.Size = new System.Drawing.Size(190, 62);
            this.switchUserBtn.TabIndex = 38;
            this.switchUserBtn.Text = "Switch User/ Logout";
            this.switchUserBtn.UseVisualStyleBackColor = true;
            this.switchUserBtn.Click += new System.EventHandler(this.switchUserBtn_Click);
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // currentTimeTxt
            // 
            this.currentTimeTxt.AutoSize = true;
            this.currentTimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeTxt.Location = new System.Drawing.Point(191, 57);
            this.currentTimeTxt.Name = "currentTimeTxt";
            this.currentTimeTxt.Size = new System.Drawing.Size(87, 16);
            this.currentTimeTxt.TabIndex = 39;
            this.currentTimeTxt.Text = "Current Time:";
            // 
            // undoEntryBtn
            // 
            this.undoEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoEntryBtn.Location = new System.Drawing.Point(2, 369);
            this.undoEntryBtn.Name = "undoEntryBtn";
            this.undoEntryBtn.Size = new System.Drawing.Size(112, 65);
            this.undoEntryBtn.TabIndex = 40;
            this.undoEntryBtn.Text = "Undo Last Entry";
            this.undoEntryBtn.UseVisualStyleBackColor = true;
            this.undoEntryBtn.Click += new System.EventHandler(this.undoEntryBtn_Click);
            // 
            // workOpartNTimer
            // 
            this.workOpartNTimer.Tick += new System.EventHandler(this.workOpartNTimer_Tick);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(712, 210);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(62, 62);
            this.exitBtn.TabIndex = 42;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusLbl.Location = new System.Drawing.Point(46, 74);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(74, 13);
            this.statusLbl.TabIndex = 44;
            this.statusLbl.Text = "CONNECTED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Status:";
            // 
            // commitBtn
            // 
            this.commitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitBtn.Location = new System.Drawing.Point(516, 279);
            this.commitBtn.Name = "commitBtn";
            this.commitBtn.Size = new System.Drawing.Size(258, 134);
            this.commitBtn.TabIndex = 46;
            this.commitBtn.Text = "Commit Entries to Database";
            this.commitBtn.UseVisualStyleBackColor = true;
            this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
            // 
            // commitOnCloseChk
            // 
            this.commitOnCloseChk.AutoSize = true;
            this.commitOnCloseChk.Checked = true;
            this.commitOnCloseChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commitOnCloseChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitOnCloseChk.Location = new System.Drawing.Point(194, 72);
            this.commitOnCloseChk.Name = "commitOnCloseChk";
            this.commitOnCloseChk.Size = new System.Drawing.Size(212, 19);
            this.commitOnCloseChk.TabIndex = 47;
            this.commitOnCloseChk.Text = "Commit Entries on Exit/Close";
            this.commitOnCloseChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Last Committed:";
            // 
            // lastCommitLbl
            // 
            this.lastCommitLbl.AutoSize = true;
            this.lastCommitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastCommitLbl.Location = new System.Drawing.Point(613, 418);
            this.lastCommitLbl.Name = "lastCommitLbl";
            this.lastCommitLbl.Size = new System.Drawing.Size(31, 16);
            this.lastCommitLbl.TabIndex = 49;
            this.lastCommitLbl.Text = "N/A";
            // 
            // FTY1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.lastCommitLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commitOnCloseChk);
            this.Controls.Add(this.commitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.undoEntryBtn);
            this.Controls.Add(this.currentTimeTxt);
            this.Controls.Add(this.switchUserBtn);
            this.Controls.Add(this.partNumberBtn);
            this.Controls.Add(this.partNumberTxt);
            this.Controls.Add(this.scrollDownBtn);
            this.Controls.Add(this.scrollUpBtn);
            this.Controls.Add(this.badBtn);
            this.Controls.Add(this.goodBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.entriesListbox);
            this.Controls.Add(this.tableTxt);
            this.Controls.Add(this.databaseTxt);
            this.Controls.Add(this.machineNameTxt);
            this.Controls.Add(this.elapsedTimeTxt);
            this.Controls.Add(this.startTimeTxt);
            this.Controls.Add(this.orderTxt);
            this.Controls.Add(this.userTxt);
            this.Name = "FTY1";
            this.Text = "First Time Yield Entry ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTY1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTY1_FormClosed);
            this.Load += new System.EventHandler(this.FTY1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button badBtn;
        private System.Windows.Forms.Button goodBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox entriesListbox;
        private System.Windows.Forms.Label tableTxt;
        private System.Windows.Forms.Label databaseTxt;
        private System.Windows.Forms.Label machineNameTxt;
        private System.Windows.Forms.Label elapsedTimeTxt;
        private System.Windows.Forms.Label startTimeTxt;
        private System.Windows.Forms.Label orderTxt;
        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.Button scrollUpBtn;
        private System.Windows.Forms.Button scrollDownBtn;
        private System.Windows.Forms.Label partNumberTxt;
        private System.Windows.Forms.Button partNumberBtn;
        private System.Windows.Forms.Button switchUserBtn;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.Label currentTimeTxt;
        private System.Windows.Forms.Button undoEntryBtn;
        private System.Windows.Forms.Timer workOpartNTimer;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitBtn;
        private System.Windows.Forms.CheckBox commitOnCloseChk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastCommitLbl;
    }
}