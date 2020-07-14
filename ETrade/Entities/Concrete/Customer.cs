using System.Reflection;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }

    }
}