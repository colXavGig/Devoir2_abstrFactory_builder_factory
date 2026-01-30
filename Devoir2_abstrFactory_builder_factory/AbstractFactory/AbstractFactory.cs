using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.AbstractFactory
{
    internal interface IAbstractFactory
    {
        public IBasement makeBasement();
        public IStructure makeStructure();
        public IInterior makeInterior();
        public IRoof makeRoof();
    }
}
