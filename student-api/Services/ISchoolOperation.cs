using System;
using student_api.Model;

namespace student_api.Services
{
	public interface ISchoolOperation
	{
		public IEnumerable<Studentdetail> GetBtechAllStudent();
		public Studentdetail GetBtechStudentDetails(String stdName);
        public IEnumerable<Mbastudentdetail> GetMbaAllStudent();
        public Mbastudentdetail GetMbaStudentDetails(String stdName);
    }
}

