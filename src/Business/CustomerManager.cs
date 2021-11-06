using System.Collections.Generic;
using System.Linq;
using Database;

namespace Business
{
    public class CustomerManager
    {
        private readonly SouthwindEntities context;

        #region Constructor(s)

        public CustomerManager()
        {
            context = new SouthwindEntities();
        }

        #endregion

        #region Methods

        // Retrieve a generic list of Customer entities.
        // This method will return all the customers found in the Customer table.
        public List<Customer> GetCustomers()
        {
            var q = from c in context.Customers
                    select c;
            return q.ToList();
        }

        #endregion
    }
}
