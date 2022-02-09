using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.ViewModels
{
    public class AddProductViewModel
    {
        public string productName { get; set; }
        public string productType { get; set; }
        public string productPrice { get; set; }
        public string productUnitAmount { get; set; }

        public AddProductViewModel()
        {

        }

    }
}
    /*public Add(searchTerm)
    {
        Products = new List<SelectListItem>();
        foreach (var employer in employers)
        {
            Employers.Add(new SelectListItem
            {
                Value = employer.Id.ToString(),
                Text = employer.Name
            });

        }

        Skills = skills;

    }

    public Add()
    {

    }
}*/

