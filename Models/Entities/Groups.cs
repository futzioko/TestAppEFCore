using System.Collections.Generic;

namespace Test.Models.Entities
{
    public class Groups
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public virtual List<Students>? Students { get; set; }
    }
}
