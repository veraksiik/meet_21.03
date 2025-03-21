using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet_21._03
{
    public class Cat
    {
        private string _name;
        private double _weight;
        private bool _sex;

        public string Name 
        {
            get { return _name; }
            set {
                if (value != null) _name = value;
                else _name = "КОт";
            
            }  
        }

        public string Color { get; set; }

        public Cat() { }
        public Cat(string name) : this(name, 0, true) { }
        public Cat(string name, double weight)
            : this(name, weight, false) { }
        public Cat(string name, double weight, bool sex)
        {
            _name = name;
            _weight = weight;
            _sex = sex;
        }

        public void Meow()
        {
            Console.WriteLine("МЯУУУУУУУУУУУУУУУУУУУ");
        }

        public string GetInfo()
        {
            var sex = _sex ? "Мальчик" : "Девочка";
            return $"Кличка котика: {_name}, Вес: {_weight}, "+ $"Пол: {sex}";

        }
    }
}
