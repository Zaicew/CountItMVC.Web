using AutoMapper;
using CountItMVC.Application.Mapping;
using CountItMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class CustomerDetailsVm : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public bool isActive { get; set; }
        public List<AddressForListVm> Addresses { get; set; }
        public List<ContactDetailListVm> Emails { get; set; }
        public List<ContactDetailListVm> PhoneNumbers { get; set; }


        public void Mapping(Profile profile)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customer, AddressForListVm>();
                cfg.CreateMap<CustomerDetailsVm, AddressForListVm>();
            });
            config.AssertConfigurationIsValid();

            var source = new Address
            {
                Id =
            };
            var mapper = config.CreateMapper();
            var dest = mapper.Map<OuterSource, OuterDest>(source);

            dest.Value.ShouldEqual(5);
            dest.Inner.ShouldNotBeNull();
            dest.Inner.OtherValue.ShouldEqual(15);

            profile.CreateMap<Customer, CustomerDetailsVm>();
        }
    }
}
