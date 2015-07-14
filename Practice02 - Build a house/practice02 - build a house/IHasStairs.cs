using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    interface IHasStairs
    {
        string StairDescription { get; }
        Location StairLocation { get; set; }
    }
}
