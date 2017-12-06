namespace RedBallTracker
{
    partial class frmMain
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
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInner = new System.Windows.Forms.TableLayoutPanel();
            this.loadedScore = new System.Windows.Forms.TextBox();
            this.rTeamBox = new System.Windows.Forms.TextBox();
            this.lTeamBox = new System.Windows.Forms.TextBox();
            this.loadScore = new System.Windows.Forms.Button();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibThresh = new Emgu.CV.UI.ImageBox();
            this.bluePlayers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blue_team_last_result = new System.Windows.Forms.TextBox();
            this.last_match_result = new System.Windows.Forms.TextBox();
            this.red_team_last_result = new System.Windows.Forms.TextBox();
            this.last_match_time = new System.Windows.Forms.TextBox();
            this.load_last_rezult = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.TextBox();
            this.tlpOuter.SuspendLayout();
            this.tlpInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 1);
            this.tlpOuter.Controls.Add(this.ibOriginal, 0, 0);
            this.tlpOuter.Controls.Add(this.ibThresh, 1, 0);
            this.tlpOuter.Controls.Add(this.bluePlayers, 1, 1);
            this.tlpOuter.Location = new System.Drawing.Point(12, 12);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.4898F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5102F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOuter.Size = new System.Drawing.Size(1158, 490);
            this.tlpOuter.TabIndex = 0;
            // 
            // tlpInner
            // 
            this.tlpInner.ColumnCount = 2;
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.Controls.Add(this.loadedScore, 1, 0);
            this.tlpInner.Controls.Add(this.rTeamBox, 0, 1);
            this.tlpInner.Controls.Add(this.lTeamBox, 1, 1);
            this.tlpInner.Controls.Add(this.loadScore, 0, 0);
            this.tlpInner.Location = new System.Drawing.Point(3, 368);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 2;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.Size = new System.Drawing.Size(573, 100);
            this.tlpInner.TabIndex = 0;
            // 
            // loadedScore
            // 
            this.loadedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedScore.Location = new System.Drawing.Point(289, 3);
            this.loadedScore.Name = "loadedScore";
            this.loadedScore.Size = new System.Drawing.Size(267, 32);
            this.loadedScore.TabIndex = 1;
            // 
            // rTeamBox
            // 
            this.rTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTeamBox.Location = new System.Drawing.Point(3, 53);
            this.rTeamBox.Name = "rTeamBox";
            this.rTeamBox.ShortcutsEnabled = false;
            this.rTeamBox.Size = new System.Drawing.Size(280, 32);
            this.rTeamBox.TabIndex = 2;
            this.rTeamBox.Text = "Blue team score: 0";
            // 
            // lTeamBox
            // 
            this.lTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeamBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lTeamBox.Location = new System.Drawing.Point(289, 53);
            this.lTeamBox.Name = "lTeamBox";
            this.lTeamBox.Size = new System.Drawing.Size(226, 32);
            this.lTeamBox.TabIndex = 1;
            this.lTeamBox.Text = "Red team score: 0";
            // 
            // loadScore
            // 
            this.loadScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadScore.Location = new System.Drawing.Point(3, 3);
            this.loadScore.Name = "loadScore";
            this.loadScore.Size = new System.Drawing.Size(155, 44);
            this.loadScore.TabIndex = 3;
            this.loadScore.Text = "load score";
            this.loadScore.UseVisualStyleBackColor = true;
            this.loadScore.Click += new System.EventHandler(this.loadScore_Click);
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Location = new System.Drawing.Point(3, 3);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(573, 359);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibThresh
            // 
            this.ibThresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibThresh.Location = new System.Drawing.Point(582, 3);
            this.ibThresh.Name = "ibThresh";
            this.ibThresh.Size = new System.Drawing.Size(573, 359);
            this.ibThresh.TabIndex = 2;
            this.ibThresh.TabStop = false;
            // 
            // bluePlayers
            // 
            this.bluePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePlayers.Location = new System.Drawing.Point(582, 368);
            this.bluePlayers.Name = "bluePlayers";
            this.bluePlayers.Size = new System.Drawing.Size(155, 47);
            this.bluePlayers.TabIndex = 3;
            this.bluePlayers.Text = "Blue team";
            this.bluePlayers.UseVisualStyleBackColor = true;
            this.bluePlayers.Click += new System.EventHandler(this.bluePlayers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 527);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(649, 554);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Button";
            // 
            // blue_team_last_result
            // 
            this.blue_team_last_result.Location = new System.Drawing.Point(18, 526);
            this.blue_team_last_result.Name = "blue_team_last_result";
            this.blue_team_last_result.Size = new System.Drawing.Size(100, 20);
            this.blue_team_last_result.TabIndex = 6;
            // 
            // last_match_result
            // 
            this.last_match_result.Location = new System.Drawing.Point(18, 560);
            this.last_match_result.Name = "last_match_result";
            this.last_match_result.Size = new System.Drawing.Size(100, 20);
            this.last_match_result.TabIndex = 7;
            // 
            // red_team_last_result
            // 
            this.red_team_last_result.Location = new System.Drawing.Point(133, 526);
            this.red_team_last_result.Name = "red_team_last_result";
            this.red_team_last_result.Size = new System.Drawing.Size(100, 20);
            this.red_team_last_result.TabIndex = 8;
            // 
            // last_match_time
            // 
            this.last_match_time.Location = new System.Drawing.Point(133, 559);
            this.last_match_time.Name = "last_match_time";
            this.last_match_time.Size = new System.Drawing.Size(100, 20);
            this.last_match_time.TabIndex = 9;
            // 
            // load_last_rezult
            // 
            this.load_last_rezult.Location = new System.Drawing.Point(265, 523);
            this.load_last_rezult.Name = "load_last_rezult";
            this.load_last_rezult.Size = new System.Drawing.Size(113, 23);
            this.load_last_rezult.TabIndex = 10;
            this.load_last_rezult.Text = "Load Last Rezult";
            this.load_last_rezult.UseVisualStyleBackColor = true;
            this.load_last_rezult.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(978, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(430, 527);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(111, 74);
            this.Data.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 644);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.load_last_rezult);
            this.Controls.Add(this.last_match_time);
            this.Controls.Add(this.red_team_last_result);
            this.Controls.Add(this.last_match_result);
            this.Controls.Add(this.blue_team_last_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlpOuter);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpOuter.ResumeLayout(false);
            this.tlpInner.ResumeLayout(false);
            this.tlpInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private System.Windows.Forms.TextBox rTeamBox;
        private System.Windows.Forms.TextBox lTeamBox;
        private System.Windows.Forms.TextBox loadedScore;
        private System.Windows.Forms.Button loadScore;
        public Emgu.CV.UI.ImageBox ibOriginal;
        public Emgu.CV.UI.ImageBox ibThresh;
        private System.Windows.Forms.Button bluePlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox blue_team_last_result;
        private System.Windows.Forms.TextBox last_match_result;
        private System.Windows.Forms.TextBox red_team_last_result;
        private System.Windows.Forms.TextBox last_match_time;
        private System.Windows.Forms.Button load_last_rezult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Data;
    }
}

