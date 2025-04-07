using Logic;
using System;
class AvatarTests
{
    public static void Tests()
    { 
        // 1. Создание объекта Avatar
        var aang = new Avatar(false, false, "Aang");
        Console.WriteLine(aang.ToString());

        // 2. Тест метода UseWaterMagis()
        Console.WriteLine("\nАанг использует магию воды!");
        aang.UseWaterMagis();
        Console.WriteLine(aang.ToString());

        // 3. Тест метода UseElectricBomb()
        Console.WriteLine("\nАанг использует электробомбу и враг получает бонусный урон!");
        aang.UseElectricBomb();
        Console.WriteLine(aang.ToString());

        // 4.Тест метода Inactive()
        Console.WriteLine("\nАанг идёт отдыхать.");
        aang.Inactive();
        Console.WriteLine(aang.ToString()); 

        // 5. Тестирование копирования объекта Avatar
        Console.WriteLine("\nТест конструктора копирования Avatar:");
        aang.UseWaterMagis();
        aang.UseElectricBomb(); 
        var copyAvatar = new Avatar(aang);
        Console.WriteLine($"Оригинал: {aang.ToString()}"); 
        Console.WriteLine($"Копия:    {copyAvatar.ToString()}"); 

        // 6. Тест активного состояния
        Console.WriteLine("\nТест активного состояния IsBonusDamage():");
        Console.WriteLine($"Наносится ли бонусный урон? {aang.IsBonusDamage()}"); 
        aang.Inactive();
        Console.WriteLine($"Наносится ли бонусный урон, когда Аанг отдыхает? {aang.IsBonusDamage()}"); 

        
    }
} 
    

