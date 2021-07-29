using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using CountItMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class PhoneNumbersForListVm : IMapFrom<ContactDetail>
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContactDetail, PhoneNumbersForListVm>()
                .ForMember(p => p.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(p => p.PhoneNumber, opt => opt.MapFrom(d => d.ContactDetailInformation));
        }
    }
}
