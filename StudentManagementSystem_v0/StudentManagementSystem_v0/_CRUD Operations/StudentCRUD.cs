using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class StudentCRUD
    {
        static StudentCRUD studentCRUD = null;
        SMSDbContext context;

        private StudentCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static StudentCRUD getStudentCRUD
        {
            get
            {
                if (studentCRUD == null)
                    studentCRUD = new StudentCRUD();
                return studentCRUD;
            }

        }
        public bool AddStudent(MorningShift _morningStudent)
        {
            context.MorningShift.Add(_morningStudent);
            context.SaveChanges();
            return true;
        }
        public bool AddStudent(EveningShift _EveningShift)
        {
            context.EveningShift.Add(_EveningShift);
            context.SaveChanges();
            return true;
        }
        public bool AddStudent(WeekendShift _weeklyStudent)
        {
            context.WeekendShift.Add(_weeklyStudent);
            context.SaveChanges();
            return true;
        }
        public object GetAllStudents()
        {
            var morningStudents = context.MorningShift
                .OrderBy(s => s.StudentId)
                .Select(s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time

                });

            var EveningShifts = context.EveningShift
                .OrderBy(s => s.StudentId)
                .Select( s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time
                });

            var weeklyStudents = context.WeekendShift
                .OrderBy(s => s.StudentId)
                .Select(s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time                   
                });

            var allStudents = morningStudents.Union(EveningShifts).Union(weeklyStudents);
            return allStudents.ToList();
           
                       
        }

        public bool UpdateStudent(MorningShift _student)
        {
            var students = context.MorningShift.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.MorningShift.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();
                    return true;
                }
            }
            AddStudent(_student);
            return true;

        }
        public bool UpdateStudent(EveningShift _student)
        {
            var students = context.EveningShift.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.EveningShift.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();
                    return true;
                }
            }
            AddStudent(_student);
            return true;

        }
        public bool UpdateStudent(WeekendShift _student)
        {
            var students = context.WeekendShift.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.WeekendShift.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();                    
                    return true;
                }
            }             
            AddStudent(_student);           
            return true;

        }
        public bool DeleteStudent(int _classScheduleId,int _Sid)
        {
            if (_classScheduleId == 1)
            {
                if (context.MorningShift.Any(s => s.StudentId == _Sid))
                {
                    var student = context.MorningShift.Single(s => s.StudentId == _Sid);
                    context.MorningShift.Remove(student);
                }
                else
                {
                    return false;
                }
                
            }
            else if (_classScheduleId == 2)
            {
                if (context.EveningShift.Any(s => s.StudentId == _Sid))
                {
                    var student = context.EveningShift.Single(s => s.StudentId == _Sid);
                    context.EveningShift.Remove(student);
                }
                else
                {
                    return false;
                }
            }
            else if (_classScheduleId == 3)
            {
                if (context.WeekendShift.Any(s => s.StudentId == _Sid))
                {
                    var student = context.WeekendShift.Single(s => s.StudentId == _Sid);
                    context.WeekendShift.Remove(student);
                }
                else
                {
                    return false;
                }
            }
            context.SaveChanges();
            return true;
        }

        public bool FindStudent(int _sid)
        {
            IChian chianMorStd = new FindMorningStudent();
            IChian chainEveStd = new FindEveningStudent();
            IChian chainWeekStd = new FindWeekendStudent();

            chianMorStd.SetNextChain(chainEveStd);
            chainEveStd.SetNextChain(chainWeekStd);

            var found = chianMorStd.Find(_sid);
            return found;
        }
      
    }
}
