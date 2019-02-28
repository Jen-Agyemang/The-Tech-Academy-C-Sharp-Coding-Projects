using NanaUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanaUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
        {
            new Student{FirstMidName="Bo", LastName="Agyemang",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Molly", LastName="Jen",EnrollmentDate=DateTime.Parse("2002-09-01")}
        };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1324, Title="Calculus", Credits=4,},
                new Course{CourseID=4569, Title="Biology", Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1324,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4569,Grade=Grade.B}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

        }
    }
}