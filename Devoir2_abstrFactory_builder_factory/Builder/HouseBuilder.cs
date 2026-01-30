using Devoir2_abstrFactory_builder_factory.AbstractFactory;
using Devoir2_abstrFactory_builder_factory.Data.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Builder
{
    internal class HouseBuilder : IBuilder
    {
        IAbstractFactory factory;
        House house;

        public HouseBuilder(IAbstractFactory factory)
        {
            this.factory = factory;
            house = new House();
        }

        public IBuilder buildBasement()
        {
            house.setBasement(factory.makeBasement());
            return this; 
        }
        public IBuilder buildStructure()
        {
            house.setStructure(factory.makeStructure());
            return this;
        }
        public IBuilder buildInterior()
        {
            house.setInterior(factory.makeInterior());
            return this;
        }

        public IBuilder buildRoof()
        {
            house.setRoof(factory.makeRoof());
            return this;
        }


        public IBuilding make()
        {
            return house;
        }
    }
}
