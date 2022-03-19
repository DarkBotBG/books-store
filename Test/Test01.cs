using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test01
    {
        [TestCase]

        public void AddSHOULDproduct()
        {
            var product = new book("limoni", 2, 4);
            var coutext = new ShopingProductContext();
            var controler = new ProductControler(context);

            controler.Add(product);
        }
    }
}
