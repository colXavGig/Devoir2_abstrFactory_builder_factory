using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.Data.Building
{
    internal class Duplex : IBuilding
    {
        IBasement basement;
        IStructure structure;
        IInterior interior;
        IRoof roof;

        public void setBasement(IBasement basement)
        {
            this.basement = basement;
        }

        public void setStructure(IStructure structure)
        {
            this.structure = structure;
        }
        public void setInterior(IInterior interior)
        {
            this.interior = interior;  
        }

        public void setRoof(IRoof roof)
        {
            this.roof = roof;
        }
        public string Display()
        {
            return $"This duplex as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
