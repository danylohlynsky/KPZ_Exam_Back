namespace Exam.Models
{
    public class Apartment
    {
        public Apartment(string? name, string? place, double? square, decimal? price, string? imagePath)
        {
            Name = name;
            Place = place;
            Square = square;
            Price = price;
            ImagePath = imagePath;
        }

        public Apartment() { }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Place { get; set; }
        public double? Square { get; set; }
        public decimal? Price { get; set; }
        public string? ImagePath { get; set; }
    }
}
