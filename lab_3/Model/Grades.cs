﻿namespace lab_4.Model
{
    public class Grades
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public virtual Student Student { get; set; }

        public override string ToString() 
        {
            return $"{Id}, {StudentId}, {SubjectName}, {Score}";
        }
    }
}
