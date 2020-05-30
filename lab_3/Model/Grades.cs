namespace lab_3.Model
{
    public class Grades
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int Score { get; set; }

        public virtual Student Student { get; set; }
    }
}
