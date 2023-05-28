using System;
using student_api.Services;
using student_api.Model;

namespace student_api.Operations
{
	public class MbaStudentOperation : ISchoolOperation
	{
        List<StudentDetails> stdList = new List<StudentDetails>
            {
                new StudentDetails
                {
                    StdName="biplab",
                    StdGrade="A",
                    StdMark=50
                },
                new StudentDetails
                {
                    StdName="Happy",
                    StdGrade="B",
                    StdMark=70
                },
                new StudentDetails
                {
                    StdName="rout",
                    StdGrade="C",
                    StdMark=90
                }
            };
        public MbaStudentOperation() 
		{

		}

		public List<StudentDetails> GetAllStudent()
		{
            return stdList;
        }

        public StudentDetails GetStudentDetails(String stdName)
        {
            StudentDetails s = new StudentDetails();
            foreach(var x in stdList)
            {
                if(x.StdName.Equals(stdName))
                {
                    s = x;
                    break;
                }
            }

            return s;
        }

    }
}

