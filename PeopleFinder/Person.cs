using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeopleFinder {
    public abstract class DomainObject { }

    public class Person : DomainObject {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
