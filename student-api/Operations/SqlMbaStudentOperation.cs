using System;
using student_api.Model;
using student_api.Services;
namespace student_api.Operations
{
	public class SqlMbaStudentOperation : ISchoolOperation
	{
        private readonly StudentdbContext _context;
        public SqlMbaStudentOperation(StudentdbContext context)
		{
            this._context = context;
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
            return this._context.Mbastudentdetails;
        }

        public Mbastudentdetail GetMbaStudentDetails(string stdName)
        {
            return this._context.Mbastudentdetails.Find(stdName);
        }
    }
}

