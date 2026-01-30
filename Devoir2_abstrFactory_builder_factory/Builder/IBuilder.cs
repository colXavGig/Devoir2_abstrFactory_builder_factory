using Devoir2_abstrFactory_builder_factory.Data.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Builder
{
    internal interface IBuilder
    {
        IBuilder buildBasement();
        IBuilder buildStructure();
        IBuilder buildInterior();
        IBuilder buildRoof();
        IBuilding make();
    }
}
