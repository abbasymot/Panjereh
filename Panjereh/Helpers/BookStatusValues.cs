using Panjereh.Models;

namespace Panjereh.Helpers
{
    public static class BookStatusValues
    {
        public static List<BookStatus> Values => new List<BookStatus>((BookStatus[])Enum.GetValues(typeof(BookStatus)));
    }
}