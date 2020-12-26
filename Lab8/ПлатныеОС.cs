using System;

namespace Lab8
{
    class ПлатныеОС : ОС
    {
        public ПлатныеОС() : base() { }

        public ПлатныеОС(Режимы_работы Р, Типы_интерфейса Т_и, Типы_аппаратной_платформы Т_а, string Н, int Г_в, string Ц, string Д_и)
            : base(Р, Т_и, Т_а, Д_и)
        {
            Название = Н;
            Год_выхода = Г_в;
            Цена = Ц;
        }

        public string Название = "";
        public int Год_выхода = 0;
        public string Цена = "";

        public override void Info()
        {
            if (Название != "") 
            {
                Console.WriteLine("Режим работы: " + Режим_работы);
                Console.WriteLine("Тип интерфейса: " + Тип_интерфейса);
                Console.WriteLine("Тип аппаратной платформы: " + Тип_аппаратной_платформы);
                Console.WriteLine("Название: " + Название);
                Console.WriteLine("Год_выхода: " + Год_выхода);
                Console.WriteLine("Цена: " + Цена);
            }
            base.Info();
        }
    }
}