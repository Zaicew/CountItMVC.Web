using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.ViewModels
{
    public class EmailsForListVm : IMapFrom<Customer>
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
