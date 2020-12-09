using System;
using System.Collections.Generic;
using System.Text;

namespace app_console
{
    public class Animal
    {
        public string Cri { get; set; }
        public string AnimalDescription { get; set; }
        public int Age { get; set; }
        public int AgeMaximum { get; set; }

        public Animal(int age, int agemaximum)
        {
            this.Age = age;
            this.AgeMaximum = agemaximum;
        }

        public Animal(int age, int agemaximum, string cri, string description) : this(age, agemaximum)
        {
            this.Cri = cri;
            this.AnimalDescription = description;
        }

        public string Crier()
        {
            return this.Cri;
        }

        public string SeDeplace(int metres)
        {
            return $"L'animal se déplace de {metres} mètres";
        }

        public string Vieillie()
        {
            this.Age++;
            if(this.Age <= this.AgeMaximum)
            {
                return $"L'animal a {this.Age} ans";
            }
            return null;
        }

        public string Vieillie(int annees)
        {
            this.Age += annees;
            if (this.Age <= this.AgeMaximum)
            {
                return $"L'animal a {this.Age} ans";
            }
            return null;
        }

        public string Mange()
        {
            return $"L'animal mange {this.Cri}";
        }

        public string Description()
        {
            return this.AnimalDescription;
        }
    }
}
