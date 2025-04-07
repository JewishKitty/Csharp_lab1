using Logic;
using Validation;
using Checking;
class Program1
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Введите последовательно длинны трёх сторон треугольника: a, b, c");
        //Triangle ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
        //Console.WriteLine(ABC.ToString());
        var test1 = new Tests();
        test1.RunAllTests();
    }

}

