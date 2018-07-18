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
    [Route("api/Step1")]
    public class Step1Controller : Controller
    {
        private readonly IMapper _mapper;

        public Step1Controller(IMapper mapper)
        {
            _mapper = mapper;
        }

        // POST: api/Step1
        [HttpPost]
        public DM_Person Post([FromBody]VM_Step1 value)
        {
            DM_Person result = new DM_Person();
            result = _mapper.Map<DM_Person>(value);
            return result;
        }

    }
}
