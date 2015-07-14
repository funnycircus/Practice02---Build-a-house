using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    class AisleWithDoorAndStair : AisleWithDoor, IHasExteriorDoor, IHasStairs
    {
        public AisleWithDoorAndStair(string name, string decoration, string doorDescription, string stairDescrption)
            : base(name, decoration, doorDescription)
        {
            StairDescription = stairDescrption;
        }

        public string StairDescription { get; private set; }

        public Location StairLocation { get; set; }
    }
}

