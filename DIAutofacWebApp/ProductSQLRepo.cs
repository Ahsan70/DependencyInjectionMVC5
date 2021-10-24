using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIAutofacWebApp
{
    public class ProductSQLRepo : IProductRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool AddProduct()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "Hey I,m SQL AUtocFAC ";
        }
    }
}