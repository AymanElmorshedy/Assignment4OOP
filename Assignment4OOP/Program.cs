namespace Assignment4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //Calculator calculator = new Calculator();
            //calculator.Number01 = 10;
            //calculator.Number02 = 10;
            //calculator.Number03 = 10;
            //calculator.Number04 = 2.5;
            //calculator.Number05 = 2.5;
            //calculator.sum(calculator.Number01,calculator.Number02);
            //calculator.sum(calculator.Number01,calculator.Number02,calculator.Number03);
            //calculator.sum(calculator.Number04,calculator.Number02);
            int a=10,b=20,c=30;
            double x = 2.5, y = 2.5;
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(a, b, c));
            Console.WriteLine(calculator.Sum(x, y));
            Console.WriteLine(calculator.Sum(a,b));

            #endregion

            #region Q2

            #endregion
            #endregion
        }
    }
}
