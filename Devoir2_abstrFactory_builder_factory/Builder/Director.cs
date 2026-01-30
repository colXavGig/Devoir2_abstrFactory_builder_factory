using Devoir2_abstrFactory_builder_factory.Data.Building;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Builder
{
    internal class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public IBuilding build()
        {
            return builder.buildBasement()
                          .buildStructure()
                          .buildInterior()
                          .buildRoof()
                          .make();
        }
    }
}
