using System.ComponentModel.DataAnnotations;

namespace Panjereh.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        public BookStatus Status { get; set; }
        public BookCategory Category { get; set; }
        public DateTime CreatedAtUTC { get; set; }
        public DateTime? UpdatedAtUTC { get; set; }
        public string? Thumbnail { get; set; }
        [MaxLength(1000)]
        public string? PersonalNote { get; set; }
    }

    public enum BookStatus
    {
        Reading,
        Done,
        ToRead
    }

    public enum BookCategory
    {
        SoftwareEngineering,
        Philosophy,
        Math,
        General,
        Novel
    }
}