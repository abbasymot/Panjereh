using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Panjereh.Models;
using Panjereh.Services;
using System.Collections.ObjectModel;

namespace Panjereh.ViewModels
{
    public partial class BooksViewModel : ObservableObject
    {
        private readonly DbService db;

        public ObservableCollection<Book> Books { get; set; }

        public List<BookCategory> Categories { get; } = new List<BookCategory>((BookCategory[])Enum.GetValues(typeof(BookCategory)));
        public List<BookStatus> Statuses { get; } = new List<BookStatus>((BookStatus[])Enum.GetValues(typeof(BookStatus)));

        [ObservableProperty]
        private string newBookTitle;

        [ObservableProperty]
        private BookCategory selectedCategory = BookCategory.General;

        [ObservableProperty]
        private BookStatus selectedStatus = BookStatus.ToRead;

        [ObservableProperty]
        private string personalNote;

        [ObservableProperty]
        private string thumbnailPath;

        public BooksViewModel()
        {
            db = new DbService();
            Books = new ObservableCollection<Book>(db.Books.ToList());
        }

        [RelayCommand]
        public void AddBook()
        {
            if (string.IsNullOrWhiteSpace(NewBookTitle))
                return;

            var book = new Book
            {
                Title = NewBookTitle,
                Category = SelectedCategory,
                Status = SelectedStatus,
                PersonalNote = PersonalNote,
                Thumbnail = ThumbnailPath
            };

            db.Books.Add(book);
            db.SaveChanges();
            Books.Add(book);

            // ریست فیلدها
            NewBookTitle = string.Empty;
            PersonalNote = string.Empty;
            ThumbnailPath = string.Empty;
            SelectedCategory = BookCategory.General;
            SelectedStatus = BookStatus.ToRead;
        }

        [RelayCommand]
        public void DeleteBook(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
            Books.Remove(book);
        }
    }
}
