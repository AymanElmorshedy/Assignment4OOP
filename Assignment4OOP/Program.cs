namespace Assignment4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1

            //int a = 10, b = 20, c = 30;
            //double x = 2.5, y = 2.5;
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Sum(a, b, c));
            //Console.WriteLine(calculator.Sum(x, y));
            //Console.WriteLine(calculator.Sum(a, b));

            #endregion

            #region Q2
            //Rectangel rectangel1 = new Rectangel();
            //Console.WriteLine(rectangel1.Height);
            //Console.WriteLine(rectangel1.Width);
            //Console.WriteLine(*****************************************);
            //Rectangel rectangel2 = new Rectangel(1, 2);
            //Console.WriteLine(rectangel2.Height);
            //Console.WriteLine(rectangel2.Width);
            //Console.WriteLine(******************************************);
            //Rectangel rectangel3 = new Rectangel(3);
            //Console.WriteLine(rectangel3.Height);
            //Console.WriteLine(rectangel3.Width);

            #endregion

            #region Q03
            //ComplexNumber c1 = new ComplexNumber();
            //ComplexNumber c2 = new ComplexNumber();
            //c1.Real = 2;
            //c1.Imagine = 3;
            //c2.Real = 1;
            //c2.Imagine = 2;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c1 + c2);
            //Console.WriteLine(c1 - c2);
            #endregion

            #region Q04
            //Employee employee = new Employee();
            //employee.Print();
            //Employee employee2 = new Maneger();
            //employee2.Print();
            #endregion

            #region Q05
            //BaseClass baseClass = new BaseClass();
            //baseClass.Print();

            //BaseClass base2 = new DrivedClass1();
            //base2.Print();//dynamic polymorphism -dynamic override-dynamic binding -late binding
            //              //runtime 
            //              //This myfun02 from child typeB and A :10
            //              //MyFun02() viryual method overrided using (override)
            //              //resolve on run time based on object type

            //BaseClass base3 = new DrivedClass2();
            //base3.Print();//static polymorphism -static binding-early binding vased on referance type
            //              //compilation time
            //MyFun01 method non virtual overide using(new)
            //              //resolve in compile time based on referance type


            #endregion

            #endregion

            #region Part02
            Duration dur = new Duration(1, 2, 3);
            Duration dur2 = new Duration(1, 2, 4);

            Console.WriteLine(dur.GetHashCode());

            if (dur.Equals(dur2)) Console.WriteLine("True");
            else Console.WriteLine("false");

            Duration d1 = new Duration(1, 10, 15);
            d1.ToString();

            Duration d2 = new Duration(3600);
            d2.ToString();

            Duration d3 = new Duration(7800);
            d3.ToString();

            Duration d4 = new Duration(666);
            d4.ToString();
            Console.WriteLine("**************************************************");
            d3.ToString();
            d3 = d1 + 7800;
            d3.ToString();
            d3 = 666 + d3;
            d3.ToString();
            d3 = ++d1;
            d3.ToString();
            d3 = --d2;
            d3.ToString();
            d1 = d1 - d2;
            d1.ToString();
            if (d1 > d2) Console.WriteLine("D1 > D2");
            else Console.WriteLine("D2 > D1");
            if (d1 <= d2) Console.WriteLine("D2 >= D2");
            else Console.WriteLine("D1 >= D2");
            #endregion
        }
    }
}
