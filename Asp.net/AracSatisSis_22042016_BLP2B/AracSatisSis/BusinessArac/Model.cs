using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessArac
{
    public class Model
    {
        private string aracModel;

        public string AracModel
        {
            get { return aracModel; }
            set { aracModel = value; }
        }
        private int aracModelId;

        public int AracModelId
        {
            get { return aracModelId; }
            set { aracModelId = value; }
        }
    }
}
