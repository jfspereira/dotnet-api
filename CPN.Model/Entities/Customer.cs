using System;
using System.Collections.Generic;
using System.Text;

namespace CPN.Model
{
    public class Customer : AuditableEntity<int>
    {
        public string Name { get; set; }
    }
}
