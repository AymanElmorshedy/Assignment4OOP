#region Q2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP
{
    internal class Rectangel
    {
        #region Properites
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Constructor
        public Rectangel()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangel(int h,int w)
        {
            Height = h;
            Width = w;
        }

        public Rectangel(int number)
        {
            Height=number;
            Width = number;
        }
        #endregion
    }
} 
#endregion
