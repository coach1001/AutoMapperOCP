using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperOCP.BusinessLogic.ViewModels
{
    public class VM_Relation
    {
        public Guid Id { get; set; }
        public string Relationship { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
