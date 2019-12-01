namespace ChaosGame
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
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.fractionTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.fractionLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sidesLbl = new System.Windows.Forms.Label();
            this.sidesTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.iterationTxt = new System.Windows.Forms.TextBox();
            this.iterationLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iterPerStepTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vertChk = new System.Windows.Forms.CheckBox();
            this.runChk = new System.Windows.Forms.CheckBox();
            this.runOpTimer = new System.Windows.Forms.Timer(this.components);
            this.progress = new System.Windows.Forms.ProgressBar();
            this.displayIterTxt = new System.Windows.Forms.TextBox();
            this.RunPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.RunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameImage
            // 
            this.gameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameImage.BackColor = System.Drawing.Color.Black;
            this.gameImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameImage.Location = new System.Drawing.Point(2, 2);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(400, 400);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImage.TabIndex = 0;
            this.gameImage.TabStop = false;
            // 
            // fractionTxt
            // 
            this.fractionTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fractionTxt.Location = new System.Drawing.Point(13, 32);
            this.fractionTxt.MaxLength = 15;
            this.fractionTxt.Name = "fractionTxt";
            this.fractionTxt.Size = new System.Drawing.Size(100, 20);
            this.fractionTxt.TabIndex = 1;
            this.fractionTxt.Text = ".5";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.vertChk, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.runChk, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(407, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 229);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.fractionLbl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fractionTxt, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(126, 58);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // fractionLbl
            // 
            this.fractionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fractionLbl.AutoSize = true;
            this.fractionLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fractionLbl.Location = new System.Drawing.Point(8, 5);
            this.fractionLbl.Name = "fractionLbl";
            this.fractionLbl.Size = new System.Drawing.Size(110, 18);
            this.fractionLbl.TabIndex = 6;
            this.fractionLbl.Text = "Fraction? (0-1)";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.sidesLbl, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.sidesTxt, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(114, 58);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // sidesLbl
            // 
            this.sidesLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidesLbl.AutoSize = true;
            this.sidesLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesLbl.Location = new System.Drawing.Point(27, 5);
            this.sidesLbl.Name = "sidesLbl";
            this.sidesLbl.Size = new System.Drawing.Size(60, 18);
            this.sidesLbl.TabIndex = 7;
            this.sidesLbl.Text = "N-gon?";
            // 
            // sidesTxt
            // 
            this.sidesTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sidesTxt.Location = new System.Drawing.Point(7, 32);
            this.sidesTxt.MaxLength = 15;
            this.sidesTxt.Name = "sidesTxt";
            this.sidesTxt.Size = new System.Drawing.Size(100, 20);
            this.sidesTxt.TabIndex = 2;
            this.sidesTxt.Text = "3";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.iterationTxt, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.iterationLbl, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(126, 92);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // iterationTxt
            // 
            this.iterationTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iterationTxt.Location = new System.Drawing.Point(13, 49);
            this.iterationTxt.MaxLength = 15;
            this.iterationTxt.Name = "iterationTxt";
            this.iterationTxt.Size = new System.Drawing.Size(100, 20);
            this.iterationTxt.TabIndex = 9;
            this.iterationTxt.Text = "500000\r\n";
            // 
            // iterationLbl
            // 
            this.iterationLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iterationLbl.AutoSize = true;
            this.iterationLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationLbl.Location = new System.Drawing.Point(21, 5);
            this.iterationLbl.Name = "iterationLbl";
            this.iterationLbl.Size = new System.Drawing.Size(84, 36);
            this.iterationLbl.TabIndex = 8;
            this.iterationLbl.Text = "Total Iterations?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.iterPerStepTxt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(135, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(154, 58);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // iterPerStepTxt
            // 
            this.iterPerStepTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iterPerStepTxt.Location = new System.Drawing.Point(27, 32);
            this.iterPerStepTxt.MaxLength = 15;
            this.iterPerStepTxt.Name = "iterPerStepTxt";
            this.iterPerStepTxt.Size = new System.Drawing.Size(100, 20);
            this.iterPerStepTxt.TabIndex = 8;
            this.iterPerStepTxt.Text = "5000";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iterations per Step";
            // 
            // vertChk
            // 
            this.vertChk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vertChk.AutoSize = true;
            this.vertChk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vertChk.Location = new System.Drawing.Point(135, 86);
            this.vertChk.Name = "vertChk";
            this.vertChk.Size = new System.Drawing.Size(154, 23);
            this.vertChk.TabIndex = 9;
            this.vertChk.Text = "Visible Vertices?";
            this.vertChk.UseVisualStyleBackColor = true;
            // 
            // runChk
            // 
            this.runChk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.runChk.AutoSize = true;
            this.runChk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runChk.Location = new System.Drawing.Point(135, 168);
            this.runChk.Name = "runChk";
            this.runChk.Size = new System.Drawing.Size(70, 23);
            this.runChk.TabIndex = 10;
            this.runChk.Text = "Run?";
            this.runChk.UseVisualStyleBackColor = true;
            // 
            // runOpTimer
            // 
            this.runOpTimer.Enabled = true;
            this.runOpTimer.Interval = 10;
            this.runOpTimer.Tick += new System.EventHandler(this.runOpTimer_Tick);
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.White;
            this.progress.ForeColor = System.Drawing.Color.Green;
            this.progress.Location = new System.Drawing.Point(0, 81);
            this.progress.Margin = new System.Windows.Forms.Padding(0);
            this.progress.Maximum = 1000;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(305, 23);
            this.progress.Step = 1;
            this.progress.TabIndex = 1;
            // 
            // displayIterTxt
            // 
            this.displayIterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayIterTxt.BackColor = System.Drawing.SystemColors.Window;
            this.displayIterTxt.Enabled = false;
            this.displayIterTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayIterTxt.Location = new System.Drawing.Point(0, 24);
            this.displayIterTxt.Margin = new System.Windows.Forms.Padding(0);
            this.displayIterTxt.Name = "displayIterTxt";
            this.displayIterTxt.Size = new System.Drawing.Size(315, 32);
            this.displayIterTxt.TabIndex = 0;
            // 
            // RunPanel
            // 
            this.RunPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunPanel.BackColor = System.Drawing.Color.Transparent;
            this.RunPanel.ColumnCount = 1;
            this.RunPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunPanel.Controls.Add(this.displayIterTxt, 0, 0);
            this.RunPanel.Controls.Add(this.progress, 0, 1);
            this.RunPanel.Location = new System.Drawing.Point(407, 245);
            this.RunPanel.Name = "RunPanel";
            this.RunPanel.RowCount = 2;
            this.RunPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.RunPanel.Size = new System.Drawing.Size(315, 123);
            this.RunPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::ChaosGame.Properties.Resources.BackGroundBlurBlue1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.RunPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gameImage);
            this.MinimumSize = new System.Drawing.Size(740, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.RunPanel.ResumeLayout(false);
            this.RunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.TextBox fractionTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sidesTxt;
        private System.Windows.Forms.Label fractionLbl;
        private System.Windows.Forms.Label sidesLbl;
        private System.Windows.Forms.Label iterationLbl;
        private System.Windows.Forms.Timer runOpTimer;
        private System.Windows.Forms.CheckBox vertChk;
        private System.Windows.Forms.CheckBox runChk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox iterPerStepTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox iterationTxt;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TextBox displayIterTxt;
        private System.Windows.Forms.TableLayoutPanel RunPanel;
    }
}

