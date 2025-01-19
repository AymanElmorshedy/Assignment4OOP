using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP
{
    internal class ComplexNumber
    {
        #region Properites
        public int Real { get; set; }
        public int Imagine { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Real}+{Imagine}i";
        }
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
               Real= (left?.Real ??0) + (right?.Real ??0),
               Imagine= (left?.Imagine??0) + (right?.Imagine ??0),
            };
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imagine = (left?.Imagine ?? 0) - (right?.Imagine ?? 0),
            };
        }
        #endregion
    }
}
