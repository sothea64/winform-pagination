using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_pagination
{
    public class Sample
    {
        public string Value { get; set; }
    }

    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
            initData();
            initEvent();
        }

        public List<Sample> Datas { get; set; } = new List<Sample>();
        int PageSize = 10;
        int ShowPageCount = 10;

        private void initData()
        {
            for (int i = 0; i <= 300; i++)
            {
                Datas.Add(new Sample() { Value = $"Value: {i}" });
            }
            //
            //
            txtCountShowPages.Text = $"{ShowPageCount}";
        }

        private void initEvent()
        {
            /*
             * Show Pages Event
             */
            showPagesPagination.NextPageClicked += showPagesPagin_NextPageClicked;
            showPagesPagination.PreviousPageClicked += showPagesPagin_PreviousPageClicked;
            showPagesPagination.PagedClicked += showPagesPagin_PageClicked;
            showPagesPagination.CountShowPages = ShowPageCount;
            //Count page for pagination
            var countPage = Datas.Count / PageSize;
            showPagesPagination.CountPage = countPage;
            txtCountPage.Text = $"{countPage}";
            /*
             * Show Page Number Only Event
             */
            showPageNumberPagin.NextPageClicked += showPageNumberPagin_NextPageClicked;
            showPageNumberPagin.PreviousPageClicked += showPageNumberPagin_PreviousPageClicked;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Set data for left data grid view
            setDataSourceForShowPagesPaging();

            //Set data for right data grid view
            setDataSourceForShowPageNumberPaging();
        }

        private List<Sample> paginate(int currentPage)
        {
            List<Sample> result = new List<Sample>();

            var skip = (currentPage - 1) * PageSize;
            result = Datas.Skip(skip).Take(PageSize).ToList();
            return result;
        }

        private void setDataSourceForShowPagesPaging()
        {
            var result = paginate(showPagesPagination.CurrentPage);
            dgvLeft.DataSource = result;
        }

        private void showPagesPagin_NextPageClicked(object s, EventArgs e)
        {
            setDataSourceForShowPagesPaging();
        }

        private void showPagesPagin_PreviousPageClicked(object s, EventArgs e)
        {
            setDataSourceForShowPagesPaging();
        }

        private void showPagesPagin_PageClicked(object s, EventArgs e)
        {
            setDataSourceForShowPagesPaging();
        }

        private void setDataSourceForShowPageNumberPaging()
        {
            var result = paginate(showPageNumberPagin.CurrentPage);
            if (result?.Any()??false)
            {
                dgvRight.DataSource = result;
            }
            else
            {
                showPageNumberPagin.CurrentPage = showPageNumberPagin.CurrentPage - 1;
                showPageNumberPagin.SelectedPage = showPageNumberPagin.CurrentPage;
            }
        }

        private void showPageNumberPagin_NextPageClicked(object s, EventArgs e)
        {
            setDataSourceForShowPageNumberPaging();
        }

        private void showPageNumberPagin_PreviousPageClicked(object s, EventArgs e)
        {
            setDataSourceForShowPageNumberPaging();
        }
    }
}
