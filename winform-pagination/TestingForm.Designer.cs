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
            this.extPagination2 = new winform_pagination.ExtPagination();
            this.extPagination1 = new winform_pagination.ExtPagination();
            this.SuspendLayout();
            // 
            // extPagination2
            // 
            this.extPagination2.AutoSize = true;
            this.extPagination2.CountPage = 0;
            this.extPagination2.CurrentPage = 1;
            this.extPagination2.EnableNext = true;
            this.extPagination2.EnablePrevious = true;
            this.extPagination2.Location = new System.Drawing.Point(563, 407);
            this.extPagination2.Name = "extPagination2";
            this.extPagination2.PagingStyle = winform_pagination.PagingStyle.ShowOnlyPageNumber;
            this.extPagination2.SelectedPage = 1;
            this.extPagination2.CountShowPages = 10;
            this.extPagination2.Size = new System.Drawing.Size(225, 31);
            this.extPagination2.TabIndex = 1;
            // 
            // extPagination1
            // 
            this.extPagination1.AutoSize = true;
            this.extPagination1.CountPage = 0;
            this.extPagination1.CurrentPage = 1;
            this.extPagination1.EnableNext = true;
            this.extPagination1.EnablePrevious = true;
            this.extPagination1.Location = new System.Drawing.Point(12, 407);
            this.extPagination1.Name = "extPagination1";
            this.extPagination1.PagingStyle = winform_pagination.PagingStyle.ShowPages;
            this.extPagination1.SelectedPage = 1;
            this.extPagination1.CountShowPages = 10;
            this.extPagination1.Size = new System.Drawing.Size(170, 31);
            this.extPagination1.TabIndex = 0;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extPagination2);
            this.Controls.Add(this.extPagination1);
            this.Name = "TestingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExtPagination extPagination1;
        private ExtPagination extPagination2;
    }
}

