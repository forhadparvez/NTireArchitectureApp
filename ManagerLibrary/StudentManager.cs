
using Core.Library;
using GetwayLibrary;

namespace ManagerLibrary
{
    public class StudentManager
    {
        private readonly StudentGetway _studentGetway = new StudentGetway();

        public bool IsRegNoExist(string regNo)
        {
            bool isNameExsit = false;
            var aStudent = GetStudentByRegNo(regNo);
            if (aStudent != null)
            {
                isNameExsit = true;
            }
            return isNameExsit;
        }


        public int Save(Student aStudent)
        {
            return _studentGetway.Add(aStudent);
        }

        public Student GetStudentByRegNo(string regNo)
        {
            return _studentGetway.GetStudentByRegNo(regNo);
        }
    }
}
