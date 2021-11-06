using System;
using System.Collections.Generic;
using Presentation.Presenters;
using Presentation.ViewInterfaces;

namespace WebApplication
{
    public partial class _Default : System.Web.UI.Page, IView
    {
        private CustomersPresenter presenter;

        protected override void OnInit(EventArgs e)
        {
            presenter = new CustomersPresenter(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareView();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            PrepareView();
        }

        #region IView Members

        public event VoidEventHandler PrepareView;

        public IList<Database.Customer> Customers
        {
            set 
            {
                GridView1.DataSource = value;
                GridView1.DataBind();
            }
        }

        #endregion
    }
}
