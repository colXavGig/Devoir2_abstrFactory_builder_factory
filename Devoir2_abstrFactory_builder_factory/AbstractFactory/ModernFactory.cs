using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.AbstractFactory
{
    internal class ModernFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new ModernBasement();
        }

        public IInterior makeInterior()
        {
            return new ModernInterior();
        }

        public IRoof makeRoof()
        {
            return new ModernRoof();
        }

        public IStructure makeStructure()
        {
            return new ModernStructure();
        }
    }
}
