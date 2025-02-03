using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G1720252401.Entities
{
    internal class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public ICollection<Book>? Books { get; set; }
    }

    internal class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; } = null!;

        public ICollection<Author>? Authors { get; set; }
    }

    internal class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public DateTime CreatedAt { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}