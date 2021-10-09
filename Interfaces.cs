using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    public interface IGenel { }               //Genel arayüz, başka nesneler için de kullanabiliriz
    public interface IMeyve: IGenel           // IGenel arayüzüden miras alınır
    {
        double Pure();                        //meyvede püre oranı bulmak için
        double Sivi();                        //meyvede sıvı oranı bulmak için
        double Agirlik { get; set; }          //Meyvenin gramajını bulmak için
        double PureProp { get; set; }         //meyvede kac pure yüzdelik oranı bulmak için
    }
    public interface IResim
    {
        System.Drawing.Image Image { get; set; }         
    }
}
