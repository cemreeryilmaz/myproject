using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_7
{
    class Sayac
    {
        private int _deger = 0;
        private int _max = 10;
        private int _min = 0;

        public int Deger
        {
            get { return _deger; }
            set 
            {
                int gelen = value;
                if (gelen < _min || gelen > _max)
                    throw new Exception("Değer Max ile Min Arasında Olmalıdır!!!");
                else
                    _deger = gelen; 
            }
        }

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        
        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public Sayac()
        {

        }

        public Sayac(int max, int min)
        {
            this.Max = _max;
            this.Min = min;
            this.Deger = min;
        }

        public Sayac(int deger, int max, int min)
        {
            this.Max = _max;
            this.Min = min;
            this.Deger = deger;
        }

    }
}
