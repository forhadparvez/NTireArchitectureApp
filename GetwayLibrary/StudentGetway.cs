
using Core.Library;
using GetwayLibrary.DatabaseContext;
using System.Linq;

namespace GetwayLibrary
{
    public class StudentGetway
    {
        StudentDbContext db;

        public StudentGetway()
        {
            db = new StudentDbContext();
        }

        public int Add(Student aStudent)
        {
            db.Students.Add(aStudent);
            return db.SaveChanges();
        }

        public Student GetStudentByRegNo(string regNo)
        {
            var aStudent = db.Students.SingleOrDefault(c => c.RegNo == regNo);
            return aStudent;
        }
    }
}
