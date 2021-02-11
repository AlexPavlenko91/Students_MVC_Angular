using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Marks : DbEntity
    {
        [Column("dateOf")]
        public DateTime DateOf { get; set; }


        [Column("value")]
        public int Value { get; set; }


        [Column("subjectId")]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }


        [Column("teacherId")]
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        [Column("studentId")]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }



        //[Column("teacher_subject_Id")]
        //public Guid TeacherSubjectId { get; set; }
        //public TeacherSubject TeacherSubject { get; set; }


        //[Column("ts_teacher_Id")]
        //public Guid TSTeacherId { get; set; }
        //public TeacherSubject TSTeacher { get; set; }

        //[Column("ts_subject_Id")]
        //public Guid TSSubjectId { get; set; }
        //public TeacherSubject TSSubject { get; set; }

    }
}