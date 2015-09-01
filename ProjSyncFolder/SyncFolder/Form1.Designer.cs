namespace SyncFolder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.toFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonBrowseFrom = new System.Windows.Forms.Button();
            this.buttonBrowseTo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To here:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(27, 57);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(327, 20);
            this.textBoxFrom.TabIndex = 3;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(27, 115);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(327, 20);
            this.textBoxTo.TabIndex = 4;
            // 
            // buttonBrowseFrom
            // 
            this.buttonBrowseFrom.Location = new System.Drawing.Point(368, 56);
            this.buttonBrowseFrom.Name = "buttonBrowseFrom";
            this.buttonBrowseFrom.Size = new System.Drawing.Size(26, 20);
            this.buttonBrowseFrom.TabIndex = 5;
            this.buttonBrowseFrom.Text = "...";
            this.buttonBrowseFrom.UseVisualStyleBackColor = true;
            this.buttonBrowseFrom.Click += new System.EventHandler(this.buttonBrowseFrom_Click);
            // 
            // buttonBrowseTo
            // 
            this.buttonBrowseTo.Location = new System.Drawing.Point(368, 114);
            this.buttonBrowseTo.Name = "buttonBrowseTo";
            this.buttonBrowseTo.Size = new System.Drawing.Size(26, 20);
            this.buttonBrowseTo.TabIndex = 6;
            this.buttonBrowseTo.Text = "...";
            this.buttonBrowseTo.UseVisualStyleBackColor = true;
            this.buttonBrowseTo.Click += new System.EventHandler(this.buttonBrowseTo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(27, 157);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(37, 13);
            this.labelResponse.TabIndex = 8;
            this.labelResponse.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 209);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBrowseTo);
            this.Controls.Add(this.buttonBrowseFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fromFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog toFolderBrowser;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonBrowseFrom;
        private System.Windows.Forms.Button buttonBrowseTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResponse;
    }
}

