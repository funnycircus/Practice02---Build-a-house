using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    class RoomWithDoorAndStair : RoomWithDoor, IHasExteriorDoor, IHasStairs
    {
        public RoomWithDoorAndStair(string name, string decoration, string doorDescription, string stairDescription)
            : base(name, decoration, doorDescription)
        {
            StairDescription = stairDescription;
        }

        public string StairDescription { get; private set; }

        public Location StairLocation { get; set; }
    }
}
