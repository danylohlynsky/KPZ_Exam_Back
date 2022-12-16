namespace Exam.Models
{
    public class Realtor
    {
        public Realtor(string? fullName)
        {
            FullName = fullName;
        }
        
        public Realtor() { }

        public int Id { get; set; }
        public string? FullName { get; set; }
    }
}
