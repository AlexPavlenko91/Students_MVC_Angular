using Entities;
using System;

namespace BL
{
    public class MarksModel
    {
        public MarksModel(Marks marks) {
            //TeacherFirstName = marks.TSTeacher.Teacher.FirstName;
            //TeacherLastName = marks.TSTeacher.Teacher.LastName;
            //IdTeacher = marks.
        }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public Guid IdTeacher { get; set; }

        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public Guid IdStudent { get; set; }

        public string SubjectName { get; set; }
        public Guid IdSubject { get; set; }

        public Guid Id { get; set; }
        public int Value { get; set; }
        public DateTime DateTimeMark { get; set; }

    }
}
