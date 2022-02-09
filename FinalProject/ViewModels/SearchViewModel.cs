using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject.ViewModels
{
    public class SearchViewModel
    {
        public string searchTerm { get; set; }
        
    }
}
        /* public Search(searchTerm)
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

        public Search()
        {

        }
    }
}*/

/*
 
 using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.Models
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
*/

/*

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobSkillViewModel
    {
        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "Skill is required")]
        public int SkillId { get; set; }

        public Job Job { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public AddJobSkillViewModel(Job theJob, List<Skill> possibleSkills)
        {
            Skills = new List<SelectListItem>();

            foreach (var skill in possibleSkills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                });
            }

            Job = theJob;
        }

        public AddJobSkillViewModel()
        {
        }
    }
}
*/


/*

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<int> SkillId { get; set; }
        public List<Skill> Skills { get; set; }
        

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            foreach(var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });

                }

                Skills = skills;

        }

        public AddJobViewModel()
        {
            
        }
    }
}
*/

/*

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<int> SkillId { get; set; }
        public List<Skill> Skills { get; set; }
        

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            foreach(var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });

                }

                Skills = skills;

        }

        public AddJobViewModel()
        {
            
        }
    }
}

 
 */