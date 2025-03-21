using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace meet_21._03
{
    internal class Laptop
    {
        private string _model;
        private double _frequency;
        private double _RAMСapacity;
        private double _CapacityНardDrive;
        private double _Massa;


        public Laptop(string model, double frequency, double RAMСapacity, double CapacityНardDrive, double Massa)
        {
            _model = model;
            _frequency = frequency;
            _RAMСapacity = RAMСapacity;
            _CapacityНardDrive = CapacityНardDrive;
            _Massa = Massa;
        }
        public string Info()
        {
            return $"Модель:{_model}, Тактовая частота: {_frequency}, Объём оперативки: {_RAMСapacity}, Объём жёсткого диска: {_CapacityНardDrive} , Масса: {_Massa}";
        }

    }
}
