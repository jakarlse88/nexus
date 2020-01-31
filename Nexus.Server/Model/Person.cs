using System;
using System.Collections.Generic;

namespace Nexus.Server.Model
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Biography { get; set; }
    }
}
