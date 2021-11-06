using System;
using System.Windows.Forms;
using Presentation.Presenters;
using Presentation.ViewInterfaces;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form, IView
    {
        private CustomersPresenter presenter;

        public Form1()
        {
            InitializeComponent();

            presenter = new CustomersPresenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PrepareView();
        }

        #region IView Members

        public event VoidEventHandler PrepareView;

        public System.Collections.Generic.IList<Database.Customer> Customers
        {
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        #endregion
    }
}
