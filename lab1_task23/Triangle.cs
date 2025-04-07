using System;

namespace Logic
{
    class Triangle
    {
        // Свойства 
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        // Конструктор копирования
        public Triangle(Triangle original)
        {
            this.a = original.a;
            this.b = original.b;
            this.c = original.c;
        }

        // Основной конструктор
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Проверка существования треугольника
        public bool DoExist()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Площадь по формуле Герона
        public double Square()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Операция неявного приведения к double -> периметр
        public static implicit operator double(Triangle ABC)
        {
            return ABC.a + ABC.b + ABC.c;
        }

        // Операция явного приведения к bool -> существует ли треугольник
        public static explicit operator bool(Triangle ABC)
        {
            return ABC.DoExist();
        }

        //Бинарная операция сравнения площадей треугольников (площадь левого больше правого)
        public static bool operator >(Triangle ABC, Triangle MKL)
        {
            return ABC.Square() > MKL.Square();
        }

        //Бинарная операция сравнения площадей треугольников (площадь правого больше левого)
        public static bool operator <(Triangle ABC, Triangle MKL)
        {
            return ABC.Square() < MKL.Square();
        }

        //Перегрузка метода ToString()
        public override string ToString()
        {
            return $"Длина a: {a}, Длина b: {b}, Длина c: {c}, Существование: {DoExist()}";
        }
    }
}
