using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
    }
}