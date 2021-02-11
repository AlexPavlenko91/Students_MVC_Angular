using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class TeacherSubject : DbEntity
    {
        [Column("teacherId")]
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }


        [Column("subjectId")]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}