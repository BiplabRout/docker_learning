using System;
using student_api.Services;
using student_api.Model;

namespace student_api.Operations
{
    public class BtechStudentOperation : ISchoolOperation
    {
        List<StudentDetails> stdList = new List<StudentDetails>
            {
                new StudentDetails
                {
                    StdName="rahul",
                    StdGrade="A",
                    StdMark=50
                },
                new StudentDetails
                {
                    StdName="siba",
                    StdGrade="B",
                    StdMark=70
                },
                new StudentDetails
                {
                    StdName="aditya",
                    StdGrade="C",
                    StdMark=90
                }
            };
        public BtechStudentOperation()
        {

        }

        public List<StudentDetails> GetAllStudent()
        {
            return stdList;
        }

        public StudentDetails GetStudentDetails(String stdName)
        {
            StudentDetails s = new StudentDetails();
            foreach (var x in stdList)
            {
                if (x.StdName.Equals(stdName))
                {
                    s = x;
                    break;
                }
            }

            return s;
        }

    }
}

