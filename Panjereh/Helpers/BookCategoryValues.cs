using Panjereh.Models;

namespace Panjereh.Helpers
{
    public static class BookCategoryValues
    {
        public static List<BookCategory> Values => new List<BookCategory>((BookCategory[])Enum.GetValues(typeof(BookCategory)));
    }
}