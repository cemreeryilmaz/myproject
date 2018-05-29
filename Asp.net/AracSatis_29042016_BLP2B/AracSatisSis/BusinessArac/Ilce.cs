using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Ilce
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string ilceIsim;

        public string IlceIsim
        {
            get { return ilceIsim; }
            set { ilceIsim = value; }
        }
        private int ilId;

        public int IlId
        {
            get { return ilId; }
            set { ilId = value; }
        }
    }
}
