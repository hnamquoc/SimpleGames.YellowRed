namespace SimpleGames.YellowRed
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
        	this.pnlCell = new System.Windows.Forms.Panel();
        	this.btnReset = new System.Windows.Forms.Button();
        	this.lblScore = new System.Windows.Forms.Label();
        	this.pnlControl = new System.Windows.Forms.Panel();
        	this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
        	this.pnlControl.SuspendLayout();
        	this.pnlMain.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// pnlCell
        	// 
        	this.pnlCell.AutoSize = true;
        	this.pnlCell.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlCell.Location = new System.Drawing.Point(0, 0);
        	this.pnlCell.Margin = new System.Windows.Forms.Padding(0);
        	this.pnlCell.Name = "pnlCell";
        	this.pnlCell.Size = new System.Drawing.Size(1, 139);
        	this.pnlCell.TabIndex = 0;
        	// 
        	// btnReset
        	// 
        	this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnReset.Location = new System.Drawing.Point(12, 12);
        	this.btnReset.Name = "btnReset";
        	this.btnReset.Size = new System.Drawing.Size(109, 75);
        	this.btnReset.TabIndex = 1;
        	this.btnReset.Text = "RESET";
        	this.btnReset.UseVisualStyleBackColor = true;
        	this.btnReset.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// lblScore
        	// 
        	this.lblScore.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblScore.ForeColor = System.Drawing.Color.Red;
        	this.lblScore.Location = new System.Drawing.Point(0, 85);
        	this.lblScore.Name = "lblScore";
        	this.lblScore.Size = new System.Drawing.Size(137, 54);
        	this.lblScore.TabIndex = 2;
        	this.lblScore.Text = "0";
        	this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// pnlControl
        	// 
        	this.pnlControl.Controls.Add(this.btnReset);
        	this.pnlControl.Controls.Add(this.lblScore);
        	this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlControl.Location = new System.Drawing.Point(0, 0);
        	this.pnlControl.Margin = new System.Windows.Forms.Padding(0);
        	this.pnlControl.Name = "pnlControl";
        	this.pnlControl.Size = new System.Drawing.Size(137, 139);
        	this.pnlControl.TabIndex = 0;
        	// 
        	// pnlMain
        	// 
        	this.pnlMain.ColumnCount = 2;
        	this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.pnlMain.Controls.Add(this.pnlControl, 1, 0);
        	this.pnlMain.Controls.Add(this.pnlCell, 0, 0);
        	this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pnlMain.Location = new System.Drawing.Point(0, 0);
        	this.pnlMain.Name = "pnlMain";
        	this.pnlMain.RowCount = 1;
        	this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.pnlMain.Size = new System.Drawing.Size(124, 139);
        	this.pnlMain.TabIndex = 0;
        	// 
        	// frmMain
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(124, 139);
        	this.Controls.Add(this.pnlMain);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmMain";
        	this.ShowIcon = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Yellow Red (5x5)";
        	this.pnlControl.ResumeLayout(false);
        	this.pnlMain.ResumeLayout(false);
        	this.pnlMain.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCell;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
    }
}

