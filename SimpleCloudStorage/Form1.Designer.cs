namespace SimpleCloudStorage
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxContainer = new System.Windows.Forms.ListBox();
            this.lbxBlobs = new System.Windows.Forms.ListBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(197, 44);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Container";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxContainer
            // 
            this.lbxContainer.FormattingEnabled = true;
            this.lbxContainer.ItemHeight = 15;
            this.lbxContainer.Location = new System.Drawing.Point(12, 78);
            this.lbxContainer.Name = "lbxContainer";
            this.lbxContainer.Size = new System.Drawing.Size(197, 319);
            this.lbxContainer.TabIndex = 1;
            this.lbxContainer.Click += new System.EventHandler(this.lbxContainer_Click);
            // 
            // lbxBlobs
            // 
            this.lbxBlobs.FormattingEnabled = true;
            this.lbxBlobs.ItemHeight = 15;
            this.lbxBlobs.Location = new System.Drawing.Point(225, 28);
            this.lbxBlobs.Name = "lbxBlobs";
            this.lbxBlobs.Size = new System.Drawing.Size(194, 319);
            this.lbxBlobs.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(225, 353);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(197, 44);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbxBlobs);
            this.Controls.Add(this.lbxContainer);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoad;
        private ListBox lbxContainer;
        private ListBox lbxBlobs;
        private Button btnDownload;
    }
}