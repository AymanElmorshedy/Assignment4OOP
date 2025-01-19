using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP
{
    internal class Calculator
    {
        #region Prpperites
        //public int Number01 { get; set; }
        //public int Number02 { get; set; }

        //public int Number03 { get; set; }

        //public double Number04 { get; set; }

        //public double Number05 { get; set; }


        #endregion
        #region Methods
        public  int Sum(int x, int y)
        {
            return x + y;
        }

        public  int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public  double Sum(double x, double y)
        {
            return x + y;
        }
            
        #endregion
    }
}
