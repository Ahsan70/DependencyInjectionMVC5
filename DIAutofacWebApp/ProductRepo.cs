using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIAutofacWebApp
{
    public class ProductRepo : IProductRepo
    {
        public bool AddProduct()
        {
            return true;
        }
        public string GetName()
        {
            return "Hey I,m working AUtoFac !";
        }

    }
}