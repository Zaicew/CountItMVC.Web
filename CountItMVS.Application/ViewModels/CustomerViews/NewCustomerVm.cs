using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class NewCustomerVm : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public bool isActive { get; set; }
        public List<AddressForListVm> Addresses { get; set; }
        public List<EmailsForListVm> Emails { get; set; }
        public List<PhoneNumbersForListVm> PhoneNumbers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCustomerVm, Customer>()
                .ForMember(s => s.Addresses, opt => opt.Ignore())
                .ForMember(s => s.ContactDetails, opt => opt.Ignore())
                .ForMember(s => s.Days, opt => opt.Ignore()).ReverseMap();
        }
    }

    public class NewCustomerValidation : AbstractValidator<NewCustomerVm>
    {
        public NewCustomerValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.NationalId).Length(10);
            RuleFor(x => x.Name).Length(3, 255);
        }
    }
}
