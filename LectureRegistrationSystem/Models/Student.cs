using System;
using System.Collections.Generic;
using System.Text;

namespace LectureRegistrationSystem.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int StudyProgramId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        public StudyProgram StudyProgram { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}
