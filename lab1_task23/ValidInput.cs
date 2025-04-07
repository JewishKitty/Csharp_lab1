using System;

namespace Validation
{
    class InputDataWithCheck
    {
        static public double InputDoubleWithValidation() // ���� ������ ����� � ��������� ������������ �����, � ��� ����� �������������� � ���������� ���������.                                                                                         
        {
            bool ok = false;
            double a;
            string value;
            do
            {
                Console.WriteLine("������� ������������ ����� (��� ��������� ������� ����� ����� �������)");
                value = Console.ReadLine();
                ok = double.TryParse(value, out a);
                //Console.WriteLine(value);
                if (!ok)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n��������� ������ ����� �������� ������");
                    Console.WriteLine("��������� ����\n");
                    Console.ForegroundColor = tmp;
                }
            } while (!ok);
            Console.WriteLine("����� ������ �������!\n");
            return a;
        }

    }

}