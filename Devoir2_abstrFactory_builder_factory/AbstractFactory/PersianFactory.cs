using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.AbstractFactory
{
    internal class PersianFactory: IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new PersianBasement();
        }
        public IStructure makeStructure()
        {
            return new PersianStructure();
        }

        public IInterior makeInterior()
        {
            return new PersianInterior();
        }

        public IRoof makeRoof()
        {
            return new PersianRoof();
        }
    }
}
