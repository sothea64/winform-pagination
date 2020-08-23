using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_pagination.Properties;

namespace winform_pagination
{
    public enum PagingStyle
    {
        /// <summary>
        /// This will show the page that user can navigate to
        /// </summary>
        ShowPages = 1,
        /// <summary>
        /// This will show only current page number
        /// </summary>
        ShowOnlyPageNumber = 2
    }

    public partial class ExtPagination : UserControl
    {
        [Browsable(false)]
        public int CountPage { get; set; }

        /// <summary>
        /// Current Page that user clicked
        /// </summary>
        [Browsable(false)]
        public int CurrentPage { get; set; } = 1;

        private int _selectedPage = 1;
        /// <summary>
        /// Page that user has select, this will be useful when paginate style is ShowPages
        /// </summary>
        [Browsable(false)]
        public int SelectedPage
        {
            get
            {
                return _selectedPage;
            }
            set
            {
                _selectedPage = value;
                RenderPage(true);
            }
        }

        /// <summary>
        /// Enable user to click next
        /// </summary>
        public bool EnableNext
        {
            get
            {
                return nextPanel.Enabled;
            }
            set
            {
                nextPanel.Enabled = value;
            }
        }

        /// <summary>
        /// Enable user to click previous
        /// </summary>
        public bool EnablePrevious
        {
            get
            {
                return previousPanel.Enabled;
            }
            set
            {
                previousPanel.Enabled = value;
            }
        }

        /// <summary>
        /// Event for after user click next
        /// </summary>
        public EventHandler NextPageClicked;
        public virtual void OnNextPageClicked(EventArgs e)
        {
            if (NextPageClicked != null)
            {
                NextPageClicked(this, e);
            }
        }

        /// <summary>
        /// Event after user clicked previous
        /// </summary>
        public EventHandler PreviousPageClicked;
        public virtual void OnPreviousPagedClicked(EventArgs e)
        {
            if (PreviousPageClicked != null)
            {
                PreviousPageClicked(this, e);
            }
        }

        /// <summary>
        /// Event after user select a page
        /// Useful only when paging style is ShowPages
        /// </summary>
        public EventHandler PagedClicked;
        public virtual void OnPagedClicked(EventArgs e)
        {
            if (PagedClicked != null)
            {
                PagedClicked(this, e);
            }
        }

        /// <summary>
        /// The number the page will show for user to select
        /// </summary>
        [Browsable(true)]
        public int CountShowPages { get; set; } = 10;

        /// <summary>
        /// Set style for paging
        /// </summary>
        [Browsable(true)]
        public PagingStyle PagingStyle { get; set; } = PagingStyle.ShowPages;

        public ExtPagination()
        {
            InitializeComponent();
            Bind();
            InitEvent();
        }

        protected override void OnLoad(EventArgs e)
        {
            RenderPage(true);
            base.OnLoad(e);
        }

        /// <summary>
        /// This is the method to bind the controller with data
        /// *Not neccessary, force of habit
        /// </summary>
        private void Bind()
        {

        }

        /// <summary>
        /// This is the method to bind the controller with data
        /// *Not neccessary, force of habit
        /// </summary>
        private void InitEvent()
        {
            this.AutoSize = true;
            //
            btnNext.Click += btnNext_Click;
            nextPanel.Click += btnNext_Click;
            imgNext.Click += btnNext_Click;
            //
            btnPrevious.Click += btnPrevious_Click;
            previousPanel.Click += btnPrevious_Click;
            imgPrevious.Click += btnPrevious_Click;
        }

        /// <summary>
        /// method to create new LinkLabel object, just to tidy up the code
        /// </summary>
        /// <returns>new object of LinkLabel</returns>
        private LinkLabel newLinkLabel()
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.Text = string.Empty;
            linkLabel.Dock = DockStyle.Right;
            linkLabel.AutoSize = true;
            linkLabel.Font = this.Font;
            linkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel.MinimumSize = new Size(20, btnPrevious.Height);
            linkLabel.AutoEllipsis = true;

            return linkLabel;
        }

        /// <summary>
        /// Method use to re-render pages
        /// checkExists is use to check if any control represent current page, if have we will mark them to be current page and not re-draw everything again
        /// </summary>
        /// <param name="checkExists"></param>
        public void RenderPage(bool checkExists = false)
        {
            if (PagingStyle == PagingStyle.ShowPages)
            {
                renderShowPages(checkExists);
            }
            else
            {
                renderShowPageNumberOnly();
            }
        }

        /// <summary>
        /// Render method for show page number only mode
        /// </summary>
        private void renderShowPageNumberOnly()
        {
            if (pagingPanel.Controls.OfType<LinkLabel>().Any())
            {
                var linkLabels = pagingPanel.Controls.OfType<LinkLabel>().ToList();
                linkLabels.ForEach(x =>
                {
                    pagingPanel.Controls.Remove(x);
                });
            }

            Label label = null;

            if (!pagingPanel.Controls.OfType<Label>().Any())
            {
                label = new Label();
                label.Text = string.Empty;
                label.Dock = DockStyle.Left;
                label.AutoSize = false;
                label.Font = this.Font;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoEllipsis = true;
                label.Padding = new Padding(1);
                label.Margin = btnNext.Margin;
                label.Width = 75;
                label.Tag = null;

                pagingPanel.Controls.Add(label);
            }

            label = label == null ? pagingPanel.Controls.OfType<Label>().FirstOrDefault() : label;

            if (label != null)
            {
                label.Text = string.Format(Resources.Page_, $"{CurrentPage}");
            }
        }

        private string dots = "...";
        /// <summary>
        /// Render method for show pages mode
        /// </summary>
        /// <param name="checkExists"></param>
        private void renderShowPages(bool checkExists = false)
        {
            /*
             * JUST IN CASE... HAHA XD
             */
            if (pagingPanel.Controls.OfType<Label>().Where(x => x.Tag == null).Any())
            {
                var labels = pagingPanel.Controls.OfType<Label>().ToList();
                labels.ForEach(x =>
                {
                    pagingPanel.Controls.Remove(x);
                });
            }

            /*
             * Search for link for current page so we don't need to re-draw everything
             */
            if (checkExists)
            {
                var currentPageLink = pagingPanel.Controls.OfType<Control>().FirstOrDefault(x => x.Text != dots && (int)(x.Tag) == CurrentPage);
                if (currentPageLink != null)
                {
                    if (currentPageLink is LinkLabel linkLabel)
                    {
                        // Underline current page 
                        linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
                        // Remove Underline from other
                        pagingPanel.Controls.OfType<LinkLabel>().Where(x => x.LinkBehavior == LinkBehavior.AlwaysUnderline && (int)(x.Tag) != CurrentPage)
                                                                .ToList().ForEach(x =>
                                                                {
                                                                    x.LinkBehavior = LinkBehavior.HoverUnderline;
                                                                });
                        //In case there is already pages drawed, we skip
                        if (pagingPanel.Controls.Count == CountShowPages || pagingPanel.Controls.Count == CountPage)
                        {
                            return;
                        }
                    }
                }
            }


            /*
             * Re-draw everything when don't have link for current page
             * The algorithm is not nearly good, but it will get the job done
             */
            pagingPanel.Controls.Clear();
            int mid = CountShowPages / 2;
            int aftermid = 0;

            for (int i = 1; i <= CountShowPages; i++)
            {
                LinkLabel linkLabel = newLinkLabel();
                linkLabel.Click += pageLinkLabel_Click;
                int displayPage = 0;

                if (CountPage == 1 || CountPage == 0)
                {
                    displayPage = 1;
                }
                else if (CountShowPages >= CountPage && i <= CountPage)
                {
                    displayPage = i;
                }
                else if (CountShowPages < CountPage)
                {
                    if (CurrentPage >= mid)
                    {
                        if (i < mid - 1)
                        {
                            displayPage = i;
                        }
                        else if (i == mid - 1 || i == CountShowPages - 1)
                        {
                            linkLabel.Text = dots;
                            linkLabel.Tag = dots;
                        }
                        else if (i == mid)
                        {
                            displayPage = CurrentPage;
                        }
                        else if (i > mid && i < CountShowPages - 1)
                        {
                            aftermid++;
                            displayPage = CurrentPage + aftermid;
                        }
                        else if (i == CountShowPages)
                        {
                            displayPage = CountPage;
                        }
                    }
                    else
                    {
                        if (i < mid)
                        {
                            displayPage = i;
                        }
                        else if (i == mid)
                        {
                            linkLabel.Text = dots;
                            linkLabel.Tag = dots;
                        }
                        else if (i > mid)
                        {
                            int afterMidToAllPage = (CountShowPages + 1) - i;
                            displayPage = CountPage - afterMidToAllPage + 1;
                        }
                    }
                }

                if (displayPage > CountPage && CountPage > 1)
                {
                    break;
                }

                if (displayPage != 0)
                {
                    linkLabel.Text = $"{displayPage}";
                    linkLabel.Tag = displayPage;
                    if (displayPage == CurrentPage)
                    {
                        linkLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
                    }
                }

                if (!string.IsNullOrEmpty(linkLabel.Text))
                {
                    pagingPanel.Controls.Add(linkLabel);

                    if (CountPage <= 1 || displayPage == CountPage)
                    {
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// An event when user select page, work only in show pages mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageLinkLabel_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel linkLabel)
            {
                if (linkLabel.Text == dots)
                {
                    return;
                }

                if (linkLabel.Tag is int pageNumber)
                {
                    SelectedPage = CurrentPage = pageNumber;
                    RenderPage(true);
                    this.OnPagedClicked(e);
                }
            }
        }

        /// <summary>
        /// An event when user click next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1)
            {
                return;
            }

            SelectedPage = CurrentPage = CurrentPage - 1;
            this.OnPreviousPagedClicked(e);
        }

        /// <summary>
        /// An event when user click previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PagingStyle == PagingStyle.ShowPages && CurrentPage == CountPage)
            {
                return;
            }

            SelectedPage = CurrentPage = CurrentPage + 1;
            this.OnNextPageClicked(e);
        }
    }
}
