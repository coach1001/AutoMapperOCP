using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperOCP.BusinessLogic.ViewModels
{
    public class VM_Step2
    {
        public string Gender { get; set; }
        public List<VM_Relation> Relations { get; set; }
    }
}
