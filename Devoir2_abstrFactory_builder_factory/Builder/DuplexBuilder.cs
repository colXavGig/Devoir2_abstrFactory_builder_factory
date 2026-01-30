using Devoir2_abstrFactory_builder_factory.AbstractFactory;
using Devoir2_abstrFactory_builder_factory.Data.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Builder
{
    internal class DuplexBuilder : IBuilder
    {
        IAbstractFactory factory;
        Duplex duplex;
        
        public DuplexBuilder(IAbstractFactory factory)
        {
            this.factory = factory;
            duplex = new Duplex();
        }
        public IBuilder buildBasement()
        {
            duplex.setBasement(factory.makeBasement());
            return this;
        }

        public IBuilder buildInterior()
        {
            duplex.setInterior(factory.makeInterior());
            return this;
        }

        public IBuilder buildRoof()
        {
            duplex.setRoof(factory.makeRoof());
            return this;
        }

        public IBuilder buildStructure()
        {
            duplex.setStructure(factory.makeStructure());
            return this;
        }

        public IBuilding make()
        {
            return duplex;
        }
    }
}
