using System;

namespace Logic
{
    class BaseConjunction
    {
        //Поля со свойствами
        protected bool firstVariable { get; set; }
        protected bool secondVariable { get; set; }

        // Конструкторы
        // Конструктор копирования
        public BaseConjunction(BaseConjunction original)
        {
            this.firstVariable = original.firstVariable;
            this.secondVariable = original.secondVariable;
        }

        // Конструктор класса
        public BaseConjunction(bool first_variable, bool second_variable)
        {
            this.firstVariable = first_variable;
            this.secondVariable = second_variable;
        }

        // Методы
        // Поиск дизъюнкта
        public bool Conjunction()
        {
            bool conjunct = this.firstVariable && this.secondVariable;
            return conjunct;
        }
        public override string ToString()
        {
            return $"First Variable: {firstVariable}, Second Variable: {secondVariable}";
        }
    }
}
