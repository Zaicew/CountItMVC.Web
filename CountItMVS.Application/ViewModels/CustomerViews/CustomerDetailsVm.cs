//using AutoMapper;
//using CountItMVC.Application.Mapping;
//using CountItMVC.Domain.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CountItMVC.Application.ViewModels
//{
//    public class CustomerDetailsVm : IMapFrom<Customer>
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string NationalId { get; set; }
//        public bool isActive { get; set; }
//        public List<AddressForListVm> Addresses { get; set; }
//        public List<EmailsForListVm> Emails { get; set; }
//        public List<PhoneNumbersForListVm> PhoneNumbers { get; set; }


//        public void Mapping(Profile profile)
//        {
//            profile.CreateMap<Customer, CustomerDetailsVm>()
//                .ForMember(s => s.Addresses, opt => opt.Ignore())
//                .ForMember(s => s.Emails, opt => opt.Ignore())
//                .ForMember(s => s.PhoneNumbers, opt => opt.Ignore());
//        }
//    }
//}
