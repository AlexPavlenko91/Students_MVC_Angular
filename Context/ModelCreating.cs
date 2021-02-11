using Entities;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public partial class AppDbContext : KeyApiAuthorizationDbContext<AppUser, AppRole, Guid>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>()
                .HasOne(g => g.Faculty)
                .WithMany(f => f.Groups)
                .HasForeignKey(g => g.FacultyId);


            builder.Entity<Student>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);


            builder.Entity<Schedule>()
                .HasOne(s => s.Lesson)
                .WithMany(l => l.Schedules)
                .HasForeignKey(s => s.LessonId);
            builder.Entity<Schedule>()
                .HasOne(s => s.ClassRoom)
                .WithMany(cr => cr.Schedules)
                .HasForeignKey(s => s.ClassRoomId);
            builder.Entity<Schedule>()
                .HasOne(s => s.Subject)
                .WithMany(sub => sub.Schedules)
                .HasForeignKey(s => s.SubjectId);
            builder.Entity<Schedule>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Schedules)
                .HasForeignKey(s => s.Teacherd);
            builder.Entity<Schedule>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Schedules)
                .HasForeignKey(s => s.GroupId);


            builder.Entity<Teacher>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Teachers)
                .HasForeignKey(t => t.DepartmentId);


            builder.Entity<Marks>()
               .HasOne(m => m.Subject)
               .WithMany(s => s.Marks)
               .HasForeignKey(m => m.SubjectId);
            builder.Entity<Marks>()
              .HasOne(m => m.Teacher)
              .WithMany(t => t.Marks)
              .HasForeignKey(m => m.TeacherId);
            builder.Entity<Marks>()
              .HasOne(m => m.Student)
              .WithMany(s => s.Marks)
              .HasForeignKey(m => m.StudentId);


            builder.Entity<Subject>()
            .HasMany(s => s.Teachers)
            .WithMany(s => s.Subjects)
            .UsingEntity<TeacherSubject>(
                j => j
                    .HasOne(ts => ts.Teacher)
                    .WithMany(t => t.TeacherSubjects)
                    .HasForeignKey(ts => ts.TeacherId),
                j => j
                    .HasOne(ts => ts.Subject)
                    .WithMany(s => s.TeacherSubjects)
                    .HasForeignKey(ts => ts.SubjectId),
                j =>
                {
                    j.HasKey(t => new { t.SubjectId, t.TeacherId });
                });


            builder.Entity<IdentityRole>()
                .HasData(new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrators",
                    NormalizedName = "ADMINISTRATORS",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }, new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Moderators",
                    NormalizedName = "MODERATORS",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                });

            //builder.Entity<TeacherSubject>()
            //   .HasKey(ts => new { ts.SubjectId, ts.TeacherId });

            //builder.Entity<Marks>()
            //   .HasOne(m => m.TSTeacher)
            //   .WithMany(ts => ts.Marks)
            //   .HasForeignKey(m => new { m.TSTeacherId, m.TSSubjectId });

            builder.Entity<Faculty>()
               .HasData(
                new Faculty { Id = Guid.NewGuid(), Name = "Программирования" },
                new Faculty { Id = Guid.NewGuid(), Name = "Администрирования" },
                new Faculty { Id = Guid.NewGuid(), Name = "Дизайна и графики" },
                new Faculty { Id = Guid.NewGuid(), Name = "Базовый" });


            builder.Entity<ClassRoom>()
            .HasData(
                 new ClassRoom { Id = Guid.NewGuid(), Name = "5-A" },
                 new ClassRoom { Id = Guid.NewGuid(), Name = "29-B" },
                 new ClassRoom { Id = Guid.NewGuid(), Name = "10" },
                 new ClassRoom { Id = Guid.NewGuid(), Name = "22-C" });


            base.OnModelCreating(builder);
        }
    }
}
