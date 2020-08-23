namespace winform_pagination
{
    partial class ExtPagination
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previousPanel = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.LinkLabel();
            this.imgPrevious = new System.Windows.Forms.PictureBox();
            this.nextPanel = new System.Windows.Forms.Panel();
            this.imgNext = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.LinkLabel();
            this.pagingPanel = new System.Windows.Forms.Panel();
            this.previousPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevious)).BeginInit();
            this.nextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).BeginInit();
            this.SuspendLayout();
            // 
            // previousPanel
            // 
            this.previousPanel.AutoSize = true;
            this.previousPanel.Controls.Add(this.btnPrevious);
            this.previousPanel.Controls.Add(this.imgPrevious);
            this.previousPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.previousPanel.Location = new System.Drawing.Point(0, 0);
            this.previousPanel.Name = "previousPanel";
            this.previousPanel.Padding = new System.Windows.Forms.Padding(2);
            this.previousPanel.Size = new System.Drawing.Size(87, 32);
            this.previousPanel.TabIndex = 3;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.Font = new System.Drawing.Font("Khmer OS Siemreap", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnPrevious.LinkColor = System.Drawing.Color.Blue;
            this.btnPrevious.Location = new System.Drawing.Point(18, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 28);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = true;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPrevious
            // 
            this.imgPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgPrevious.Image = global::winform_pagination.Properties.Resources.left_arrow;
            this.imgPrevious.Location = new System.Drawing.Point(2, 2);
            this.imgPrevious.Name = "imgPrevious";
            this.imgPrevious.Size = new System.Drawing.Size(16, 28);
            this.imgPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgPrevious.TabIndex = 1;
            this.imgPrevious.TabStop = false;
            // 
            // nextPanel
            // 
            this.nextPanel.AutoSize = true;
            this.nextPanel.Controls.Add(this.imgNext);
            this.nextPanel.Controls.Add(this.btnNext);
            this.nextPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPanel.Location = new System.Drawing.Point(251, 0);
            this.nextPanel.Name = "nextPanel";
            this.nextPanel.Padding = new System.Windows.Forms.Padding(2);
            this.nextPanel.Size = new System.Drawing.Size(59, 32);
            this.nextPanel.TabIndex = 4;
            // 
            // imgNext
            // 
            this.imgNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgNext.Image = global::winform_pagination.Properties.Resources.right_arrow;
            this.imgNext.Location = new System.Drawing.Point(41, 2);
            this.imgNext.Name = "imgNext";
            this.imgNext.Size = new System.Drawing.Size(16, 28);
            this.imgNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgNext.TabIndex = 1;
            this.imgNext.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Font = new System.Drawing.Font("Khmer OS Siemreap", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnNext.LinkColor = System.Drawing.Color.Blue;
            this.btnNext.Location = new System.Drawing.Point(2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 28);
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = true;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagingPanel
            // 
            this.pagingPanel.AutoSize = true;
            this.pagingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagingPanel.Location = new System.Drawing.Point(87, 0);
            this.pagingPanel.Name = "pagingPanel";
            this.pagingPanel.Padding = new System.Windows.Forms.Padding(2);
            this.pagingPanel.Size = new System.Drawing.Size(164, 32);
            this.pagingPanel.TabIndex = 5;
            // 
            // ExtPagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pagingPanel);
            this.Controls.Add(this.nextPanel);
            this.Controls.Add(this.previousPanel);
            this.Name = "ExtPagination";
            this.Size = new System.Drawing.Size(310, 32);
            this.previousPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevious)).EndInit();
            this.nextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel previousPanel;
        private System.Windows.Forms.LinkLabel btnPrevious;
        private System.Windows.Forms.PictureBox imgPrevious;
        private System.Windows.Forms.Panel nextPanel;
        private System.Windows.Forms.PictureBox imgNext;
        private System.Windows.Forms.LinkLabel btnNext;
        private System.Windows.Forms.Panel pagingPanel;
    }
}
