using System.Collections.Generic;
using Database;

namespace Presentation.ViewInterfaces
{
    public delegate void VoidEventHandler();

    public interface IView
    {
        event VoidEventHandler PrepareView;
        IList<Customer> Customers { set; }
    }
}