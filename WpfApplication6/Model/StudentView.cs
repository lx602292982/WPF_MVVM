using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6.Model
{
    class StudentView : NotificationObject
    {
        /**
         * 学生ID
         * */
        private int studentid;

        public int StudentId
        {
            get { return studentid; }
            set {
                studentid = value;
                RaisePropertyChanged("StudentId");
            }
        }

        /**
         * 学生姓名
         * */
        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set {
                studentName = value;
                RaisePropertyChanged("StudentName");
            }
        }


        /**
         * 学生email
         * */
        private string studentEmail;

        public string StudentEmail
        {
            get { return studentEmail; }
            set {
                studentEmail = value;
                RaisePropertyChanged("StudentEmail");
            }
        }


        /**
         * 学生性别
         * */
        private string  studentSex;

        public string  StudentSex
        {
            get { return studentSex; }
            set {
                studentSex = value;
                RaisePropertyChanged("StudentSex");
            }
        }

        private int studentAge;

        public int StudentAge
        {
            get { return studentAge; }
            set {
                studentAge = value;
                RaisePropertyChanged("StudentAge");
            }
        }


    }
}
