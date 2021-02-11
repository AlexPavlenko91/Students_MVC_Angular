using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Teacher: DbEntity
    {
        [Column("firstName")]
        [MaxLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [MaxLength(64)]
        public string LastName { get; set; }


        [Column("departmentId")]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Schedule> Schedules{ get; set; }
        public List<Subject> Subjects{ get; set; }
        public List<Marks> Marks{ get; set; }
        public List<TeacherSubject> TeacherSubjects{ get; set; }
    }
}