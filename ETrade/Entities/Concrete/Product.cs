using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public short ProductStock { get; set; }
        public string ProductQuantity { get; set; }
    }
}