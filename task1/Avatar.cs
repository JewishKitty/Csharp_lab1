

namespace Logic
{
    /*
     Класс Avatar наследуется из класса BaseConjuction
     Поля: IsUsingWaterMagic - используется ли сейчас магия воды, IsUsingElectricBomb - используется ли сейчас электробомба, avatarName - имя аватара
     */
    class Avatar : BaseConjunction
    {
        // Свойства
        public string avatarName { get; set; }

        // Конструкторы
        // Стандартный конструктор
        public Avatar(bool IsUsingWaterMagic, bool IsUsingElectricBomb, string avatarName) : base(IsUsingWaterMagic, IsUsingElectricBomb)
        {
            this.avatarName = avatarName;
        }

        // Конструктор копирования
        public Avatar(Avatar other) : base(other)
        {
            this.avatarName = other.avatarName;
        }

        // Метод определения бонусного урона
        public bool IsBonusDamage()
        {
            return Conjunction();
        }

        // Метод использования водяной бомбы
        public void UseWaterMagis()
        {
            firstVariable = true;
        }

        // Метод использования электробомбы
        public void UseElectricBomb()
        {
            secondVariable = true; 
        }

        // Метод отдыха автара
        public void Inactive()
        {
            firstVariable=secondVariable=false;
        }

        // Перегрузка метода ToString()
        public override string ToString()
        {
            return $"Avatar: {avatarName}, Using water magic: {firstVariable}, Using electric bomb: {secondVariable}, Bonus damage: {IsBonusDamage()}";
        }
    }
}
