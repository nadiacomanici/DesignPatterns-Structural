using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Students_Demo.ViewModels;
using Structural_Models;

namespace Adapter_Students_Demo.Adapters
{
    public class StudentAdapter
    {
        public static StudentViewModel ConvertStudentToViewModel(Student student)
        {
            return new StudentViewModel
            {
                Id = student.Id,
                FirstName = student.Name,
                LastName = student.Surname
            };
        }

        public static List<StudentViewModel> ConvertStudentsToViewModels(IEnumerable<Student> students)
        {
            List<StudentViewModel> viewModels = new List<StudentViewModel>();

            foreach (var student in students)
            {
                viewModels.Add(ConvertStudentToViewModel(student));
            }

            return viewModels;
        }
    }
}
