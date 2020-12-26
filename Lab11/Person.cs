using System;

namespace Lab11
{
    class Person
    {
        string ID { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        public string Email { get; set; }
        public float Salary { get; set; }
        public string Skill { get; set; }
        public float Tax { get; set; }

        public static Person Create(string str)
        {
            Person p = new Person();
            string[] e = str.Split(',');
            p.ID = e[0].Trim();
            p.LastName = e[1].Trim();
            p.FirstName = e[2].Trim();
            p.Email = e[3].Trim();
            p.Salary = Convert.ToSingle(e[4].TrimStart('$').Replace('.', ','));
            p.Skill = e[5].Trim();
            if (e.Length == 7)
                p.Tax = Convert.ToSingle(e[6].TrimStart('$').Replace('.', ','));
            else p.Tax = 0;
            return p;
        }

        public override string ToString()
        {
            string s = string.Format("********************************" +
                "\nID: {0} \nФамилия: {1} \nИмя: {2} \nE-mail: {3} " +
                "\nЗарплата: {4} \nНавык: {5} \nНалог: {6}" +
                "\n********************************",
                ID, LastName, FirstName, Email, Salary, Skill, Tax);
            return s;
        }
    }
}