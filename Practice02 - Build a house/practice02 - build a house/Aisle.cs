using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    class Aisle : Location
    {
        private string decoration;

        public Aisle(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
