using System;

namespace Lab8
{
    class ПО
    {
        public ПО(string Д_и)
        {
            Доп_инф = Д_и;
        }

        public string Доп_инф = "";

        public ПО() { }

        public virtual void Info()
        {
            if (Доп_инф == "")
                Console.WriteLine("Дополнительная информация: не указана");
            else
                Console.WriteLine("Дополнительная информация: " + Доп_инф);
        }
    }
}