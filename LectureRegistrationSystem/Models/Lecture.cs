using System;
using System.Collections.Generic;
using System.Text;

namespace LectureRegistrationSystem.Data.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string LectureName { get; set; }
        public ICollection<StudyProgram> StudyPrograms { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
