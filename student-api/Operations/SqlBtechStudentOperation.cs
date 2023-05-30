using System;
using student_api.Services;
using student_api.Model;

namespace student_api.Operations
{
	public class SqlBtechStudentOperation : ISchoolOperation
	{
		private readonly StudentdbContext _context;

		public SqlBtechStudentOperation(StudentdbContext context)
		{
			this._context = context;
		}

        public IEnumerable<Studentdetail> GetBtechAllStudent()
        {
            return this._context.Studentdetails;
        }

        public Studentdetail GetBtechStudentDetails(string stdName)
        {
            return this._context.Studentdetails.Find(stdName);
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

