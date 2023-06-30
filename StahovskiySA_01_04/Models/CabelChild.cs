using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StahovskiySA_01_04.Models
{
   

    public class CabelChild:Cabel
    {
        public bool Availability { get; set; } //Наличие оплётки
        //Констурктор класса потомка
        public CabelChild(string type, int count,int diametr, bool availability) :base(type,count,diametr)
        {
            Availability = availability;
        }
        //функия, перекрывающая функиця качества базового класса
        public override double CalculateQuality()
        {
            if (Availability == true)
            {
                return base.CalculateQuality()*2;
            }
            else
            {
                return base.CalculateQuality()*0.7;
            }
            
        }




    }
}
