namespace winform_pagination
{
    partial class TestingForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCountShowPages = new System.Windows.Forms.Label();
            this.txtCountShowPages = new System.Windows.Forms.TextBox();
            this.txtCountPage = new System.Windows.Forms.TextBox();
            this.lblCountPage = new System.Windows.Forms.Label();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.showPageNumberPagin = new winform_pagination.ExtPagination();
            this.showPagesPagination = new winform_pagination.ExtPagination();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.dgvLeft);
            this.leftPanel.Controls.Add(this.txtCountPage);
            this.leftPanel.Controls.Add(this.lblCountPage);
            this.leftPanel.Controls.Add(this.txtCountShowPages);
            this.leftPanel.Controls.Add(this.lblCountShowPages);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.showPagesPagination);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(396, 450);
            this.leftPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.dgvRight);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.showPageNumberPagin);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(396, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(404, 450);
            this.rightPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Pages Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show Page Number Mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountShowPages
            // 
            this.lblCountShowPages.AutoSize = true;
            this.lblCountShowPages.Location = new System.Drawing.Point(9, 30);
            this.lblCountShowPages.Name = "lblCountShowPages";
            this.lblCountShowPages.Size = new System.Drawing.Size(92, 13);
            this.lblCountShowPages.TabIndex = 2;
            this.lblCountShowPages.Text = "CountShowPages";
            // 
            // txtCountShowPages
            // 
            this.txtCountShowPages.Location = new System.Drawing.Point(126, 26);
            this.txtCountShowPages.Name = "txtCountShowPages";
            this.txtCountShowPages.ReadOnly = true;
            this.txtCountShowPages.Size = new System.Drawing.Size(263, 20);
            this.txtCountShowPages.TabIndex = 3;
            this.txtCountShowPages.Text = "10";
            // 
            // txtCountPage
            // 
            this.txtCountPage.Location = new System.Drawing.Point(126, 52);
            this.txtCountPage.Name = "txtCountPage";
            this.txtCountPage.ReadOnly = true;
            this.txtCountPage.Size = new System.Drawing.Size(263, 20);
            this.txtCountPage.TabIndex = 5;
            this.txtCountPage.Text = "1";
            // 
            // lblCountPage
            // 
            this.lblCountPage.AutoSize = true;
            this.lblCountPage.Location = new System.Drawing.Point(9, 56);
            this.lblCountPage.Name = "lblCountPage";
            this.lblCountPage.Size = new System.Drawing.Size(60, 13);
            this.lblCountPage.TabIndex = 4;
            this.lblCountPage.Text = "CountPage";
            // 
            // dgvLeft
            // 
            this.dgvLeft.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeft.Location = new System.Drawing.Point(12, 78);
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.Size = new System.Drawing.Size(377, 327);
            this.dgvLeft.TabIndex = 6;
            // 
            // dgvRight
            // 
            this.dgvRight.BackgroundColor = System.Drawing.Color.White;
            this.dgvRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRight.Location = new System.Drawing.Point(6, 78);
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.Size = new System.Drawing.Size(385, 327);
            this.dgvRight.TabIndex = 7;
            // 
            // showPageNumberPagin
            // 
            this.showPageNumberPagin.AutoSize = true;
            this.showPageNumberPagin.CountPage = 0;
            this.showPageNumberPagin.CountShowPages = 10;
            this.showPageNumberPagin.CurrentPage = 1;
            this.showPageNumberPagin.EnableNext = true;
            this.showPageNumberPagin.EnablePrevious = true;
            this.showPageNumberPagin.Location = new System.Drawing.Point(6, 407);
            this.showPageNumberPagin.Name = "showPageNumberPagin";
            this.showPageNumberPagin.PagingStyle = winform_pagination.PagingStyle.ShowOnlyPageNumber;
            this.showPageNumberPagin.SelectedPage = 1;
            this.showPageNumberPagin.Size = new System.Drawing.Size(225, 31);
            this.showPageNumberPagin.TabIndex = 1;
            // 
            // showPagesPagination
            // 
            this.showPagesPagination.AutoSize = true;
            this.showPagesPagination.CountPage = 0;
            this.showPagesPagination.CountShowPages = 10;
            this.showPagesPagination.CurrentPage = 1;
            this.showPagesPagination.EnableNext = true;
            this.showPagesPagination.EnablePrevious = true;
            this.showPagesPagination.Location = new System.Drawing.Point(3, 411);
            this.showPagesPagination.Name = "showPagesPagination";
            this.showPagesPagination.PagingStyle = winform_pagination.PagingStyle.ShowPages;
            this.showPagesPagination.SelectedPage = 1;
            this.showPagesPagination.Size = new System.Drawing.Size(170, 27);
            this.showPagesPagination.TabIndex = 0;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.MaximizeBox = false;
            this.Name = "TestingForm";
            this.Text = "Demo Form";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtPagination showPagesPagination;
        private ExtPagination showPageNumberPagin;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountShowPages;
        private System.Windows.Forms.Label lblCountShowPages;
        private System.Windows.Forms.TextBox txtCountPage;
        private System.Windows.Forms.Label lblCountPage;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.DataGridView dgvRight;
    }
}

