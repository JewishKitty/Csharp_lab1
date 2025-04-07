using System;
using Logic;
using Validation;

namespace Checking
{
    class Tests
    {

        public void RunAllTests()
        {
            TestCopyConstructor();
            TestExistence();
            TestSquare();
            TestImplicitDouble();
            TestExplicitBool();
            TestComparisonOperators();
        }


        //Тест конструктора копирования
        public void TestCopyConstructor()
        {
            Console.WriteLine($"Тест конструктора копирования");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            if (!ABC.DoExist())
            {
                throw new InvalidOperationException("Невозможно скопировать: треугольник не существует.");
            }
            var MKL = new Triangle(ABC);
            Console.WriteLine($"MKL: {MKL.ToString()}");
        }

        //Тест существования
        public void TestExistence()
        {
            Console.WriteLine($"Тест существования");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            Console.WriteLine($"[TestExistence]: {ABC.DoExist()}");
        }

        //Тест нахождения площади
        public void TestSquare()
        {
            Console.WriteLine($"Тест площади");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            if (!ABC.DoExist())
            {
                throw new InvalidOperationException("Невозможно вычислить площадь: треугольник не существует.");
            }
            double actual = ABC.Square();
            Console.WriteLine($"[TestSquare] Площадь: {actual}");
        }

        //Тест неявного приведения к типу double
        public void TestImplicitDouble()
        {
            Console.WriteLine($"Тест неявного приведения к типу double(подсчёт периметра) ");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            if (!ABC.DoExist())
            {
                throw new InvalidOperationException("Невозможно вычислить периметр: треугольник не существует.");
            }
            double perimeter = ABC; 
            Console.WriteLine($"[TestImplicitDouble] Периметр: {perimeter}");
        }

        //Тест явного приведения к типу bool
        public void TestExplicitBool()
        {
            Console.WriteLine($"Тест явного приведения к типу bool (существование треугольника)");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            bool existing = (bool)ABC;
            Console.WriteLine($"[TestExplicitBool] Треугольник  существует? {existing}");
        }

        //Тест операторов сравнения
        public void TestComparisonOperators()
        {
            Console.WriteLine($"Тест переопределённых операторов сравнения (сравнение площадей) ");
            Console.WriteLine($"Введите длинны сторон треугольника ABC (a, b, c)");
            var ABC = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            if (!ABC.DoExist())
            {
                throw new InvalidOperationException("Невозможно вычислить площадь: треугольник не существует.");
            }
            Console.WriteLine($"Введите длинны сторон треугольника MKL (m, k, l)");
            var MKL = new Triangle(InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation(), InputDataWithCheck.InputDoubleWithValidation());
            if (!MKL.DoExist())
            {
                throw new InvalidOperationException("Невозможно вычислить площадь: треугольник не существует.");
            }
            Console.WriteLine($"[TestComparisonOperators] ABC < MKL? {ABC < MKL} ");
            Console.WriteLine($"[TestComparisonOperators] ABC > MKL? {ABC > MKL} ");
        }
    }
}
