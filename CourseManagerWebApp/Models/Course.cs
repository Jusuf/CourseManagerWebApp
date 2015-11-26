using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManagerWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Course()
        {
            this.Students = new List<Student>();
        }

        public virtual ICollection<Student> Students { get; set; }

        public IEnumerable<SelectListItem> AllStudents { get; set; }

        private List<int> selectedStudents;

        public List<int> SelectedStudents
        {
            get 
            { 
                if(selectedStudents == null)
                {
                    selectedStudents = Students.Select(m => m.Id).ToList();
                }
                return selectedStudents;
            }
            set
            {
                selectedStudents = value;
            }
        }
    }
}