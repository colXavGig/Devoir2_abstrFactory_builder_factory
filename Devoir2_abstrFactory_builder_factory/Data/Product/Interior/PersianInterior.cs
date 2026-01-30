using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Data.Product.Interior
{
    internal class PersianInterior: IInterior
    {
        public string display()
        {
            return "persian interior";
        }
    }
}
