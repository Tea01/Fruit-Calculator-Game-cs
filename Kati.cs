using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    abstract class Kati : IMeyve                  //IMeyve arayüzden miras alarak Kati abstract sınıfı oluşturdum
    {
        private double mass;                     // random olarak meyvenin ağırılığnı verir
        private double puree;                    // random olarak meyvede püre oranı verir
        public double Agirlik                    //Random olarak meyvenin ağırılığnı oranı alır ve mass değişkenine aktarır
        {
            get { return mass; }
            set { mass = value; }
        }
        public double PureProp                   //Random olarak meyvenin püre oranı alır ve puree değişkenine aktarır
        {
            get { return puree; }
            set
            { puree = value;}
        }
        public double Pure()                     //meyvede püre oranını hesaplanan metod
        {
            double oran = PureProp / 100;
            double sonuc = Agirlik * oran;
            return Math.Ceiling(sonuc);           //Math.Ceiling-> uzun bir yüzdelik oran vermemesi için kullandım
        }
        public double Sivi()                      //meyvede sıvı oranını hesaplanan metod
        {
            double oran = (100 - PureProp) / 100;
            double sonuc = Agirlik * oran-1;
            return Math.Ceiling(sonuc);
        }
    }
}
