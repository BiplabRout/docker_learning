using System;
using student_api.Services;
using student_api.Model;

namespace student_api.Operations
{
    public class BtechStudentOperation : ISchoolOperation
    {
        List<Studentdetail> stdList = new List<Studentdetail>
            {
                new Studentdetail
                {
                    Stdname="rahul",
                    Stdgrade="A",
                    Stdmark=50
                },
                new Studentdetail
                {
                    Stdname="siba",
                    Stdgrade="B",
                    Stdmark=70
                },
                new Studentdetail
                {
                    Stdname="aditya",
                    Stdgrade="C",
                    Stdmark=90
                }
            };
        public BtechStudentOperation()
        {

        }

        public IEnumerable<Studentdetail> GetBtechAllStudent()
        {
            return stdList;
        }

        public Studentdetail GetBtechStudentDetails(String stdName)
        {
            Studentdetail s = new Studentdetail();
            foreach (var x in stdList)
            {
                if (x.Stdname.Equals(stdName))
                {
                    s = x;
                    break;
                }
            }

            return s;
        }

        public IEnumerable<Mbastudentdetail> GetMbaAllStudent()
        {
            throw new NotImplementedException();
        }

        public Mbastudentdetail GetMbaStudentDetails(string stdName)
        {
            throw new NotImplementedException();
        }
    }
}

