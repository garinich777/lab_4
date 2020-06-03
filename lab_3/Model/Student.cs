using System.Collections.Generic;

namespace lab_4.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNum { get; set; }
        public string TrainingFormat { get; set; }
        public int Grant { get; set; }
        public int CostEducation { get; set; }

        public virtual ICollection<Grades> Grades { get; set; }

        public override string ToString()
        {
            return $"{Id}, {FirstName}, {LastName}, {GroupNum}, {TrainingFormat}, {Grant}, {CostEducation}";
        }
    }
}
