using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIWebApp
{
  public  interface IProductRepo
    {
        bool AddProduct();
        string GetName();
    }
}
