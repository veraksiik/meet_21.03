using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet_21._03
{
    public struct Human
    {
        public string name;
        public string surname;
        public string patronumic;//отчество


        public Human(string name, string surname, string patronumic)
        { 
            this.name = name;
            this.surname = surname;
            this.patronumic = patronumic;
        }
        public string FIO()
        {
            return $"Фамилия:{surname}, Имя: {name}, Отчество: {patronumic}";
        }
    }
}
