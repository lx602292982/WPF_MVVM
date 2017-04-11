using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication6.Model;

namespace WpfApplication6.ViewModel
{
    class StudentViewModel
    {
        public DelegateCommand delegateCommand { set; get; }
        public StudentView Student { get; set; }
        public StudentViewModel()
        {
            Student = new StudentView();
            delegateCommand = new DelegateCommand();
            delegateCommand.ExecuteCommand = new Action<object>(StudentData);
        }

        public void StudentData(object obj)
        {
            Student.StudentId = 1;
            Student.StudentName = "xiang";
            Student.StudentAge = 25;
            Student.StudentEmail = "xiangli005@outlook.com";
            Student.StudentSex = "享哥";
        }
    }
}
