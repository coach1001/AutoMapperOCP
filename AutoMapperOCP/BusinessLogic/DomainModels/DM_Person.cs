using AutoMapperOCP.BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperOCP.BusinessLogic.DomainModels
{
    public class DM_Person
    {
        public Guid Id { get; set; }
        public DM_Person_Details Details { get; set; }
        public List<DM_Relation> Relations { get; set; }
    }

    public class DM_Person_Details
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}
