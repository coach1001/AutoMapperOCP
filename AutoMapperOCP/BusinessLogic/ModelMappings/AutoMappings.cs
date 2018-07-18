using AutoMapper;

using AutoMapperOCP.BusinessLogic.ViewModels;
using AutoMapperOCP.BusinessLogic.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.EquivalencyExpression;

namespace AutoMapperOCP.BusinessLogic.ModelMappings
{
    public class AutoMappings : Profile
    {
        public AutoMappings()
        {
            var m1 = CreateMap<DM_Relation, VM_Relation>();
            m1.EqualityComparison((vm, dm) => vm.Id == dm.Id).ReverseMap();
            m1.ForMember(vm => vm.Id, opt => opt.MapFrom(dm => dm.Id)).ReverseMap();
            m1.ForMember(vm => vm.FirstName, opt => opt.MapFrom(dm => dm.FirstName)).ReverseMap();
            m1.ForMember(vm => vm.LastName, opt => opt.MapFrom(dm => dm.LastName)).ReverseMap();
            m1.ForMember(vm => vm.Relationship, opt => opt.MapFrom(dm => dm.Relationship)).ReverseMap();

            var m2 = CreateMap<DM_Person, VM_Step1>();
            m2.ForMember(vm => vm.FirstName, opt => opt.MapFrom(dm => dm.Details.FirstName)).ReverseMap();
            m2.ForMember(vm => vm.LastName, opt => opt.MapFrom(dm => dm.Details.LastName)).ReverseMap();

            var m3 = CreateMap<DM_Person, VM_Step2>();
            m3.ForMember(vm => vm.Gender, opt => opt.MapFrom(dm => dm.Details.Gender)).ReverseMap();
            m3.ForMember(vm => vm.Relations, opt => opt.MapFrom(dm => dm.Relations)).ReverseMap();
        }
    }
}
