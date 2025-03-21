using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet_21._03
{
    public struct Car
    {
        public string _numberDV;
        public string _brand;
        public string _model;
        public double _year;
        public string _color;

        public Car(string numberDV, string brand, string model, double year, string color)
        {
            _numberDV = numberDV;
            _brand = brand;
            _model = model;
            _year = year;
            _color = color;
        }

        public string Info
        {
            get
            {
                return $"Номер двигателя:{_numberDV}, Марка: {_brand}, Модель: {_model}, Год выпуска: {_year} , Цвет: {_color}";
            }
        }

        public void Compare(string AnotherVIN)
        {
           
            Console.WriteLine(AnotherVIN == _numberDV ? true : false);
               

        }
    }
}
