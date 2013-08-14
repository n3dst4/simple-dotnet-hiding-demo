using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hiding
{

    public class Food
    {
        public string Name { get; set; }
        public virtual string VirtualName { get; set; }
        public virtual string SealedName { get; set; }
    }

    public class Fruit : Food
    {
        public string Name { get; set; }
        public override string VirtualName { get; set; }
        public sealed override string SealedName { get; set; }
    }

    public class Banana : Fruit
    {
        // compile error because Food.SealedName is sealed
        //public override string SealedName { get; set; }

        // but you can still do this:
        public new string SealedName { get; set; }

    }



}
