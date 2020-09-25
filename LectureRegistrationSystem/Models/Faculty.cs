using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LectureRegistrationSystem.Data.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string FacultyName { get; set; }

        public ICollection<Professor> Professors { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<StudyProgram> StudyPrograms { get; set; }
    }
}
