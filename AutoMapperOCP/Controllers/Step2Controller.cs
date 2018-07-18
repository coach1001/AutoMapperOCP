using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperOCP.BusinessLogic.DomainModels;
using AutoMapperOCP.BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperOCP.Controllers
{
    [Produces("application/json")]
    [Route("api/Step2")]
    public class Step2Controller : Controller
    {
        private readonly IMapper _mapper;

        public Step2Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        // POST: api/Step2
        [HttpPost]
        public DM_Person Post([FromBody]VM_Step2 value)
        {
            var result = new DM_Person();
            result.Id = Guid.Parse("3d01ebda-b2af-4372-af38-f151740b7e3b");
            result.Details = new DM_Person_Details();
            result.Details.Id = Guid.Parse("99e12ae9-b3f3-4a60-8bb8-bb5c4bead54c");
            result.Details.FirstName = "Step";
            result.Details.LastName = "One";
            result.Details.Gender = "Female";
            result.Relations = new List<DM_Relation>();

           
            result.Relations.Add(new DM_Relation()
            {
                Id = Guid.Parse("4084cf49-a49d-4a81-8732-88062776a4b4"),
                FirstName = "Relation",
                LastName = "One",
                Relationship = "Brother"
            });

            result.Relations.Add(new DM_Relation()
            {
                Id = Guid.Parse("042ffb5e-203d-4962-8554-1a89b56c0011"),
                FirstName = "Relation",
                LastName = "Two",
                Relationship = "Sister"
            });

            result.Relations.Add(new DM_Relation()
            {
                Id = Guid.Parse("94a7ee20-2984-4988-862f-75cdca82b053"),
                FirstName = "Relation",
                LastName = "Three",
                Relationship = "Father"
            });

            result = _mapper.Map(value, result);

            return result;
        }
    }
}
