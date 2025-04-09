using System.ComponentModel.DataAnnotations;

namespace DeveloperAssesment.Models
{
    public class Book
    {
        [Key]
        public Int64 BookId {  get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int PublicationYear { get; set; }
        public decimal Price { get; set; }



        public string MLACitation =>
     $"{AuthorLastName}, {AuthorFirstName}. {Title}. {Publisher}, {PublicationYear}.";

        public string ChicagoCitation =>
            $"{AuthorFirstName} {AuthorLastName}. {Title}. {Publisher}, {PublicationYear}.";


    }
}
