using System;
using student_api.Services;
using student_api.Model;

namespace student_api.Operations
{
	public class MbaStudentOperation : ISchoolOperation
	{
        List<Mbastudentdetail> stdList = new List<Mbastudentdetail>
            {
                new Mbastudentdetail
                {
                    Mbastdname="biplab",
                    Mbastdgrade="A",
                    Mbastdmark=50
                },
                new Mbastudentdetail
                {
                    Mbastdname="Happy",
                    Mbastdgrade="B",
                    Mbastdmark=70
                },
                new Mbastudentdetail
                {
                    Mbastdname="rout",
                    Mbastdgrade="C",
                    Mbastdmark=90
                }
            };
        public MbaStudentOperation() 
		{

		}

        public IEnumerable<Studentdetail> GetBtechAllStudent()
        {
            throw new NotImplementedException();
        }

        public Studentdetail GetBtechStudentDetails(string stdName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mbastudentdetail> GetMbaAllStudent()
		{
            return stdList;
        }

        public Mbastudentdetail GetMbaStudentDetails(String stdName)
        {
            Mbastudentdetail s = new Mbastudentdetail();
            foreach(var x in stdList)
            {
                if(x.Mbastdname.Equals(stdName))
                {
                    s = x;
                    break;
                }
            }

            return s;
        }

    }
}

