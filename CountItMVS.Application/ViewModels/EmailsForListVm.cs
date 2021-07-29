using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class EmailsForListVm : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContactDetail, EmailsForListVm>()
                .ForMember(p => p.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(p => p.Email, opt => opt.MapFrom(d => d.ContactDetailInformation));
        }
    }
}
