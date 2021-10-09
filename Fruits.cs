using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    class Elma : Kati                                //Kati abstract sınıfından miras alır
    { 
        public double VitaminA()                     //Elmada kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 54) / 100; 
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                     //Elmada kaç Vitamin c olduğunu hesaplanır
        {
            double vitC = (Agirlik * 5) / 100;
            return Math.Ceiling(vitC);
        }
    }
    class Armut : Kati                                //Kati abstract sınıfından miras alır
    {
        public double VitaminA()                      //Armuta kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 25) / 100;
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                      //Armuta kaç Vitamin C olduğunu hesaplanır
        {
            double vitC = (Agirlik * 5) / 100;
            return Math.Ceiling(vitC);
        }
    }
    class Cilek : Kati                                //Kati abstract sınıfından miras alır
    {
        public double VitaminA()                      //Çİlekte kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 12) / 100;
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                      //Çilekye kaç Vitamin C olduğunu hesaplanır
        {
            double vitC = (Agirlik * 60) / 100;
            return Math.Ceiling(vitC);
        }
    }
    class Portakal : Narenciye                        //Narenciye abstract sınıfından miras alır
    {
        public double VitaminA()                      //Portokalda kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 225) / 100;
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                      //Portakalda kaç Vitamin C olduğunu hesaplanır
        {
            double vitC = (Agirlik * 45) / 100;
            return Math.Ceiling(vitC);
        }
    }
    class Mandalina : Narenciye                       //Narenciye abstract sınıfından miras alır
    {
        public double VitaminA()                      //mandalinada kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 681) / 100;
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                      //Mandalinada kaç Vitamin C olduğunu hesaplanır
        {
            double vitC = (Agirlik * 26) / 100;
            return Math.Ceiling(vitC);
        }
    }
    class Greyfurt : Narenciye                        //Narenciye abstract sınıfından miras alır
    {
        public double VitaminA()                      //Greyfurtte kaç Vitamin A olduğunu hesaplanır
        {
            double vitA = (Agirlik * 3) / 100;
            return Math.Ceiling(vitA);
        }
        public double VitaminC()                      //Greyfurtte kaç Vitamin C olduğunu hesaplanır
        {
            double vitC = (Agirlik * 44) / 100;
            return Math.Ceiling(vitC);
        }
    }
}
