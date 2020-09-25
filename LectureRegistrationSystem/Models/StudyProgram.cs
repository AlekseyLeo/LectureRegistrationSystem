using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LectureRegistrationSystem.Data.Models
{
    public class StudyProgram
    {
        [Key]
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string FacultyId { get; set; }
        public string StudyDegreeLevel { get; set; }
        public int DurationOfStudies { get; set; }

        public Faculty Faculty { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
