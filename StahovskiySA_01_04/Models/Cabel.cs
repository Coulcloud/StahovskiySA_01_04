using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StahovskiySA_01_04.Models
{
    public class Cabel
    {
        //описание полей базового класса
        public string Type { get; set; } //тип кабеля
        public int Count{ get; set; } //количество жил кабеля
        public int Diametr { get; set; } //диаметр кабеля
        
        //Описание конструктора базового класса
        public Cabel(string type,int count,int diametr)
        {
            Type = type;
            Count = count;
            Diametr = diametr;
        }
        //Функция качества объекта
        public virtual double CalculateQuality()
        {
            return Diametr / Count;
        }
        //Вывод информации об объекте
        public void PrintInformation()
        {
            Console.WriteLine($"Тип кабеля: {Type}");
            Console.WriteLine($"Количество жил кабеля: {Count}");
            Console.WriteLine($"Диаметр кабеля: {Diametr}");
        }
    }
}
