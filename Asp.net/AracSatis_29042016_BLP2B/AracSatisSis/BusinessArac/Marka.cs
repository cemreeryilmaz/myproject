using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Marka
    {
        private string aracMarka;

        public string AracMarka
        {
            get { return aracMarka; }
            set { aracMarka = value; }
        }
        private int aracMarkaId;

        public int AracMarkaId
        {
            get { return aracMarkaId; }
            set { aracMarkaId = value; }
        }
    }
}
