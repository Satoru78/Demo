using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkani.Model
{
     public partial class Product
    {
        public string GetImage
        {
            get
            {
               return Environment.CurrentDirectory + "\\" + Image;
            }
            set
            {
                Image = value;
            }
        }
    }
}
