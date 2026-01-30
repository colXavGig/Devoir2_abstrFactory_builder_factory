using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.AbstractFactory
{
    internal class QuebecoisFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new QuebecoisBasement();
        }
        public IStructure makeStructure()
        {
            return new QuebecoisStructure();
        }

        public IInterior makeInterior()
        {
            return new QuebecoisInterior();
        }

        public IRoof makeRoof()
        {
            return new QuebecoisRoof();
        }


    }
}
