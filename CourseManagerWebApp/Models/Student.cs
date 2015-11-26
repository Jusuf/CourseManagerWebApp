using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManagerWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]

        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]

        public string Lastname { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public IEnumerable<SelectListItem> AllCourses { get; set; }

        private List<int> selectedCourses;

        public List<int> SelectedCourses
        {
            get
            {
                if(selectedCourses == null)
                {
                    selectedCourses = Courses.Select(m => m.Id).ToList();
                }
                return selectedCourses;
            }
            set{selectedCourses = value;}
        }

        public Student()
        {
            this.Courses = new List<Course>();
        }
    }
}