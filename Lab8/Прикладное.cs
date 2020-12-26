using System;

namespace Lab8
{
    public enum Виды_ППО_общ_назначения
    {
        текстовый_редактор,
        текстовый_процессор,
        графический_редактор
    }

    class Прикладное : ПО
    {
        public Прикладное() : base() { }

        public Прикладное(Виды_ППО_общ_назначения В, string Н, string Д_и)
            : base(Д_и)
        {
            Вид_ППО_общ_назначения = В;
            Название = Н;
        }

        public Виды_ППО_общ_назначения Вид_ППО_общ_назначения;
        public string Название = "";

        public override void Info()
        {
            if (Название != "")
            {
                Console.WriteLine("Вид ППО: " + Вид_ППО_общ_назначения);
                Console.WriteLine("Название: " + Название);
            }
            base.Info();
        }
    }
}
