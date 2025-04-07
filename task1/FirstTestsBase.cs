

namespace Logic
{
    class BaseConjuctionTests
    {
        public static void Tests() 
        {
            
            // 1. Создание объектов BaseConjunction
            var BaseConjunction1 = new BaseConjunction(false, false);
            Console.WriteLine(BaseConjunction1.ToString()); 

            var BaseConjunction2 = new BaseConjunction(true, false);
            Console.WriteLine(BaseConjunction2.ToString()); 

            var BaseConjunction3 = new BaseConjunction(false, true);
            Console.WriteLine(BaseConjunction3.ToString());

            var BaseConjunction4 = new BaseConjunction(true, true);
            Console.WriteLine(BaseConjunction4.ToString()); 

            // 2. Тестирование метода Conjunction()
            Console.WriteLine($"\nТест Conjunction_1(): {BaseConjunction1.Conjunction()} (Ожидаем False)");
            Console.WriteLine($"Тест Conjunction_2(): {BaseConjunction2.Conjunction()} (Ожидаем False)");
            Console.WriteLine($"Тест Conjunction_3(): {BaseConjunction3.Conjunction()} (Ожидаем False)");
            Console.WriteLine($"Тест Conjunction_4(): {BaseConjunction4.Conjunction()} (Ожидаем True)");

            // 3. Тестирование конструктора копирования
            Console.WriteLine("\nТест конструктора копирования BaseConjunction:");
            var copiedBaseConjunction = new BaseConjunction(BaseConjunction4);
            Console.WriteLine($"Оригинал: {BaseConjunction4}");
            Console.WriteLine($"Копия:    {copiedBaseConjunction}\n");

        }
    }
}
