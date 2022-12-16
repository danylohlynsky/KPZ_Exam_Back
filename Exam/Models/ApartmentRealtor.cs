namespace Exam.Models
{
    public class ApartmentRealtor
    {
        public ApartmentRealtor(int flatId, int rieltorId)
        {
            FlatId = flatId;
            RieltorId = rieltorId;
        }
        public ApartmentRealtor() { }
        public int Id { get; set; }
        public int FlatId { get; set; }
        public int RieltorId { get; set; }
    }
}
