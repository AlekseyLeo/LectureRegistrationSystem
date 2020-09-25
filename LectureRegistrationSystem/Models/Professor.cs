using System;
using System.Collections;
using System.Collections.Generic;

namespace LectureRegistrationSystem.Data.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DegreeLevel { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}