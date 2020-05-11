using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

       
    }
}
