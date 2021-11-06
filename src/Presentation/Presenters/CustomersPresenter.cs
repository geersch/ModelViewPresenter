using System.Collections.Generic;
using Business;
using Database;
using Presentation.PresenterInterfaces;
using Presentation.ViewInterfaces;

namespace Presentation.Presenters
{
    public class CustomersPresenter : ICustomersPresenter
    {
        #region Fields

        private readonly IView view;

        #endregion

        #region Constructor(s)

        public CustomersPresenter(IView view)
        {
            // Save a reference to the view
            this.view = view;

            // Hook up an event handler for the events of the view
            view.PrepareView += view_PrepareView;
        }

        #endregion

        #region Private methods

        private static List<Customer> GetCustomers()
        {
            return new CustomerManager().GetCustomers();
        }

        #endregion

        #region ICustomersPresenter Members

        public virtual void view_PrepareView()
        {
            view.Customers = GetCustomers();
        }

        #endregion
    }
}
