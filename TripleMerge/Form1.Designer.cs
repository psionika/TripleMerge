namespace TripleMerge
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbTextSource = new System.Windows.Forms.TextBox();
            this.txbText1 = new System.Windows.Forms.TextBox();
            this.txbText2 = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.txbTextSource, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbText1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbText2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbResult, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMerge, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpen1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpen2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txbTextSource
            // 
            this.txbTextSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTextSource.Location = new System.Drawing.Point(3, 48);
            this.txbTextSource.Multiline = true;
            this.txbTextSource.Name = "txbTextSource";
            this.txbTextSource.ReadOnly = true;
            this.txbTextSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbTextSource.Size = new System.Drawing.Size(190, 187);
            this.txbTextSource.TabIndex = 0;
            // 
            // txbText1
            // 
            this.txbText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbText1.Location = new System.Drawing.Point(199, 48);
            this.txbText1.Multiline = true;
            this.txbText1.Name = "txbText1";
            this.txbText1.ReadOnly = true;
            this.txbText1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbText1.Size = new System.Drawing.Size(184, 187);
            this.txbText1.TabIndex = 1;
            // 
            // txbText2
            // 
            this.txbText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbText2.Location = new System.Drawing.Point(389, 48);
            this.txbText2.Multiline = true;
            this.txbText2.Name = "txbText2";
            this.txbText2.ReadOnly = true;
            this.txbText2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbText2.Size = new System.Drawing.Size(185, 187);
            this.txbText2.TabIndex = 2;
            // 
            // txbResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txbResult, 3);
            this.txbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbResult.Location = new System.Drawing.Point(3, 286);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbResult.Size = new System.Drawing.Size(571, 187);
            this.txbResult.TabIndex = 3;
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMerge.Location = new System.Drawing.Point(216, 249);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(150, 23);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(216, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenSource.Location = new System.Drawing.Point(23, 10);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(150, 25);
            this.btnOpenSource.TabIndex = 7;
            this.btnOpenSource.Text = "Open Source File";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen1.Location = new System.Drawing.Point(216, 10);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(150, 25);
            this.btnOpen1.TabIndex = 7;
            this.btnOpen1.Text = "Open 1 edit File";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen2.Location = new System.Drawing.Point(406, 10);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(150, 25);
            this.btnOpen2.TabIndex = 7;
            this.btnOpen2.Text = "Open 2 edit File";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 375);
            this.Name = "FormMain";
            this.Text = "Triple Merge";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbTextSource;
        private System.Windows.Forms.TextBox txbText1;
        private System.Windows.Forms.TextBox txbText2;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
    }
}

