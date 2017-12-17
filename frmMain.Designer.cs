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
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibThresh = new Emgu.CV.UI.ImageBox();
            this.loadedScore = new System.Windows.Forms.TextBox();
            this.rTeamBox = new System.Windows.Forms.TextBox();
            this.lTeamBox = new System.Windows.Forms.TextBox();
            this.loadScore = new System.Windows.Forms.Button();
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.save_with_data_table = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tlpOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.97237F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.02763F));
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 1);
            this.tlpOuter.Controls.Add(this.ibOriginal, 0, 0);
            this.tlpOuter.Controls.Add(this.ibThresh, 1, 0);
            this.tlpOuter.Location = new System.Drawing.Point(12, 12);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.2906F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.709402F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOuter.Size = new System.Drawing.Size(1158, 383);
            this.tlpOuter.TabIndex = 0;
            this.tlpOuter.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpOuter_Paint);
            // 
            // tlpInner
            // 
            this.tlpInner.ColumnCount = 2;
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.Location = new System.Drawing.Point(3, 379);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 2;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.Size = new System.Drawing.Size(573, 1);
            this.tlpInner.TabIndex = 0;
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Location = new System.Drawing.Point(3, 3);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(619, 370);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibThresh
            // 
            this.ibThresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibThresh.Location = new System.Drawing.Point(628, 3);
            this.ibThresh.Name = "ibThresh";
            this.ibThresh.Size = new System.Drawing.Size(527, 370);
            this.ibThresh.TabIndex = 2;
            this.ibThresh.TabStop = false;
            // 
            // loadedScore
            // 
            this.loadedScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedScore.Location = new System.Drawing.Point(1550, 537);
            this.loadedScore.Name = "loadedScore";
            this.loadedScore.Size = new System.Drawing.Size(267, 32);
            this.loadedScore.TabIndex = 1;
            // 
            // rTeamBox
            // 
            this.rTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTeamBox.Location = new System.Drawing.Point(216, 440);
            this.rTeamBox.Name = "rTeamBox";
            this.rTeamBox.ShortcutsEnabled = false;
            this.rTeamBox.Size = new System.Drawing.Size(226, 32);
            this.rTeamBox.TabIndex = 2;
            this.rTeamBox.Text = "Blue team score: 0";
            // 
            // lTeamBox
            // 
            this.lTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeamBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lTeamBox.Location = new System.Drawing.Point(216, 494);
            this.lTeamBox.Name = "lTeamBox";
            this.lTeamBox.Size = new System.Drawing.Size(226, 32);
            this.lTeamBox.TabIndex = 1;
            this.lTeamBox.Text = "Red team score: 0";
            // 
            // loadScore
            // 
            this.loadScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadScore.Location = new System.Drawing.Point(1264, 537);
            this.loadScore.Name = "loadScore";
            this.loadScore.Size = new System.Drawing.Size(155, 44);
            this.loadScore.TabIndex = 3;
            this.loadScore.Text = "load score";
            this.loadScore.UseVisualStyleBackColor = true;
            this.loadScore.Click += new System.EventHandler(this.loadScore_Click);
            // 
            // bluePlayers
            // 
            this.bluePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePlayers.Location = new System.Drawing.Point(1833, 534);
            this.bluePlayers.Name = "bluePlayers";
            this.bluePlayers.Size = new System.Drawing.Size(155, 47);
            this.bluePlayers.TabIndex = 3;
            this.bluePlayers.Text = "Blue team";
            this.bluePlayers.UseVisualStyleBackColor = true;
            this.bluePlayers.Click += new System.EventHandler(this.bluePlayers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2083, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1977, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1977, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1922, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1922, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Button";
            // 
            // blue_team_last_result
            // 
            this.blue_team_last_result.Location = new System.Drawing.Point(1346, 383);
            this.blue_team_last_result.Name = "blue_team_last_result";
            this.blue_team_last_result.Size = new System.Drawing.Size(100, 20);
            this.blue_team_last_result.TabIndex = 6;
            // 
            // last_match_result
            // 
            this.last_match_result.Location = new System.Drawing.Point(1346, 417);
            this.last_match_result.Name = "last_match_result";
            this.last_match_result.Size = new System.Drawing.Size(100, 20);
            this.last_match_result.TabIndex = 7;
            // 
            // red_team_last_result
            // 
            this.red_team_last_result.Location = new System.Drawing.Point(1461, 383);
            this.red_team_last_result.Name = "red_team_last_result";
            this.red_team_last_result.Size = new System.Drawing.Size(100, 20);
            this.red_team_last_result.TabIndex = 8;
            // 
            // last_match_time
            // 
            this.last_match_time.Location = new System.Drawing.Point(1461, 416);
            this.last_match_time.Name = "last_match_time";
            this.last_match_time.Size = new System.Drawing.Size(100, 20);
            this.last_match_time.TabIndex = 9;
            // 
            // load_last_rezult
            // 
            this.load_last_rezult.Location = new System.Drawing.Point(1593, 380);
            this.load_last_rezult.Name = "load_last_rezult";
            this.load_last_rezult.Size = new System.Drawing.Size(113, 23);
            this.load_last_rezult.TabIndex = 10;
            this.load_last_rezult.Text = "Load Last Result";
            this.load_last_rezult.UseVisualStyleBackColor = true;
            this.load_last_rezult.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1193, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "SELECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(1758, 384);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(111, 74);
            this.Data.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1174, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(1193, 269);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(84, 30);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "DELETE ALL";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(1193, 305);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(84, 30);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(1193, 344);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(84, 30);
            this.insert_button.TabIndex = 16;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // save_with_data_table
            // 
            this.save_with_data_table.Location = new System.Drawing.Point(1593, 415);
            this.save_with_data_table.Name = "save_with_data_table";
            this.save_with_data_table.Size = new System.Drawing.Size(113, 23);
            this.save_with_data_table.TabIndex = 17;
            this.save_with_data_table.Text = "Save with data table";
            this.save_with_data_table.UseVisualStyleBackColor = true;
            this.save_with_data_table.Click += new System.EventHandler(this.save_with_data_table_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.Location = new System.Drawing.Point(1193, 380);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(84, 35);
            this.buttonGroup.TabIndex = 18;
            this.buttonGroup.Text = "Group";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1193, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1193, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 20;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-91, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 664);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Match history";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MatchHistory_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 644);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lTeamBox);
            this.Controls.Add(this.rTeamBox);
            this.Controls.Add(this.loadedScore);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bluePlayers);
            this.Controls.Add(this.loadScore);
            this.Controls.Add(this.buttonGroup);
            this.Controls.Add(this.save_with_data_table);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.listBox1);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpOuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button save_with_data_table;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}

