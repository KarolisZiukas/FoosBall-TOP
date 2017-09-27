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
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibThresh = new Emgu.CV.UI.ImageBox();
            this.loadScore = new System.Windows.Forms.Button();
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
            this.tlpOuter.Location = new System.Drawing.Point(12, 12);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.28571F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.71428F));
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
            this.tlpInner.Location = new System.Drawing.Point(3, 367);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 2;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInner.Size = new System.Drawing.Size(573, 100);
            this.tlpInner.TabIndex = 0;
            // 
            // loadedScore
            // 
            this.loadedScore.Location = new System.Drawing.Point(289, 3);
            this.loadedScore.Name = "loadedScore";
            this.loadedScore.Size = new System.Drawing.Size(115, 20);
            this.loadedScore.TabIndex = 1;
            // 
            // rTeamBox
            // 
            this.rTeamBox.Location = new System.Drawing.Point(3, 53);
            this.rTeamBox.Name = "rTeamBox";
            this.rTeamBox.ShortcutsEnabled = false;
            this.rTeamBox.Size = new System.Drawing.Size(114, 20);
            this.rTeamBox.TabIndex = 2;
            this.rTeamBox.Text = "Blue team score: 0";
            // 
            // lTeamBox
            // 
            this.lTeamBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lTeamBox.Location = new System.Drawing.Point(289, 53);
            this.lTeamBox.Name = "lTeamBox";
            this.lTeamBox.Size = new System.Drawing.Size(115, 20);
            this.lTeamBox.TabIndex = 1;
            this.lTeamBox.Text = "Red team score: 0";
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Location = new System.Drawing.Point(3, 3);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(573, 358);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibThresh
            // 
            this.ibThresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibThresh.Location = new System.Drawing.Point(582, 3);
            this.ibThresh.Name = "ibThresh";
            this.ibThresh.Size = new System.Drawing.Size(573, 358);
            this.ibThresh.TabIndex = 2;
            this.ibThresh.TabStop = false;
            // 
            // loadScore
            // 
            this.loadScore.Location = new System.Drawing.Point(3, 3);
            this.loadScore.Name = "loadScore";
            this.loadScore.Size = new System.Drawing.Size(75, 23);
            this.loadScore.TabIndex = 3;
            this.loadScore.Text = "load score";
            this.loadScore.UseVisualStyleBackColor = true;
            this.loadScore.Click += new System.EventHandler(this.loadScore_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 644);
            this.Controls.Add(this.tlpOuter);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tlpOuter.ResumeLayout(false);
            this.tlpInner.ResumeLayout(false);
            this.tlpInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibThresh;
        private System.Windows.Forms.TextBox rTeamBox;
        private System.Windows.Forms.TextBox lTeamBox;
        private System.Windows.Forms.TextBox loadedScore;
        private System.Windows.Forms.Button loadScore;
    }
}

