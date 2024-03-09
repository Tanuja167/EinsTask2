using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EinsTask2
{
    public class User
    {
        internal readonly object id;

        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string State { get; set; }
        public string City { get; set; }

        public int Age { get;set; }

        
    }
}