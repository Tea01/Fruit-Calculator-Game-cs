using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    public class Resim : IResim
    {
        public Resim(Image image)
        {
            Image = image;
        }
        public Image Image { get; set; }
    }
}
