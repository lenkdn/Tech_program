using System;

namespace Lab8
{
    class СвободныеОС : ОС
    {
        public СвободныеОС() : base() { }

        public СвободныеОС(string Н)
            : base()
        {
            Название = Н;
        }

        public СвободныеОС(Режимы_работы Р, Типы_интерфейса Т_и, Типы_аппаратной_платформы Т_а, string Н, int Г_в, string Д_и)
            : base(Р, Т_и, Т_а, Д_и)
        {
            Название = Н;
            Год_выхода = Г_в;
        }

        public string Название = "";
        public int Год_выхода = 0;

        public override void Info()
        {
            if (Название != "")
            {
                Console.WriteLine("Режим работы: " + Режим_работы);
                Console.WriteLine("Тип интерфейса: " + Тип_интерфейса);
                Console.WriteLine("Тип аппаратной платформы: " + Тип_аппаратной_платформы);
                Console.WriteLine("Название: " + Название);
                Console.WriteLine("Год_выхода: " + Год_выхода);
            }
            base.Info();
        }
    }
}
