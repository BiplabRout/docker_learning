using System;
using student_api.Model;

namespace student_api.Services
{
	public interface ISchoolOperation
	{
		public List<StudentDetails> GetAllStudent();
		public StudentDetails GetStudentDetails(String stdName);
	}
}

