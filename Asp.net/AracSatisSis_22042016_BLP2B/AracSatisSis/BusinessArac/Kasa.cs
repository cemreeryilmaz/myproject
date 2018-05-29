using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Kasa
    {
        private string kasaTipi;

        public string KasaTipi
        {
            get { return kasaTipi; }
            set { kasaTipi = value; }
        }
        private int kasaTipiId;

        public int KasaTipiId
        {
            get { return kasaTipiId; }
            set { kasaTipiId = value; }
        }
    }
}
