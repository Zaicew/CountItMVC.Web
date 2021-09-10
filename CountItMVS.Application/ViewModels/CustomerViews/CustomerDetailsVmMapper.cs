//using AutoMapper;
//using CountItMVC.Application.Mapping;
//using CountItMVC.Domain.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CountItMVC.Application.ViewModels
//{
//    public class CustomerDetailsVmMapper : IMapFrom<Customer>
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string NationalId { get; set; }
//        public bool isActive { get; set; }
//        public List<AddressForListVm> Addresses { get; set; }
//        public List<EmailsForListVm> Emails { get; set; }
//        public List<PhoneNumbersForListVm> PhoneNumbers { get; set; }


//        //public void Mapping(Profile profile)
//        //{
//        //    var config = new MapperConfiguration(cfg =>
//        //    {
//        //        cfg.CreateMap<Customer, CustomerDetailsVmMapper>();
//        //        cfg.CreateMap<Address, AddressForListVm>();
//        //        cfg.CreateMap<ContactDetail, EmailsForListVm>();
//        //        cfg.CreateMap<ContactDetail, PhoneNumbersForListVm>();
//        //    });

//        //    config.AssertConfigurationIsValid();

//        //    var source = new Customer
//        //    {
               
//        //    };
//        //    var mapper = config.CreateMapper();
//        //    mapper.Map<Customer, CustomerDetailsVmMapper>(source)
//        //        .Addresses addressForListVms,

//        //    profile.CreateMap<Customer, CustomerDetailsVm>()
//        //        .ForMember(s => s.Addresses, opt => opt.())
//        //        .ForMember(s => s.Emails, opt => opt.Ignore())
//        //        .ForMember(s => s.PhoneNumbers, opt => opt.Ignore());
//        //}


//        //public void Mapping(Profile profile)
//        //{
//        //    profile.CreateMap<ContactDetail, PhoneNumbersForListVm>()
//        //        .ForMember(p => p.Id, opt => opt.MapFrom(d => d.Id))
//        //        .ForMember(p => p.PhoneNumber, opt => opt.MapFrom(d => d.ContactDetailInformation));
//        //}
//    }
//}
