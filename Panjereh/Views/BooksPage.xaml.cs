using Panjereh.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace Panjereh.Views
{
    public partial class BooksPage : ContentPage
    {
        public BooksPage()
        {
            InitializeComponent();
        }

        private async void OnSelectThumbnailClicked(object sender, EventArgs e)
        {
            var result = await FilePicker.Default.PickAsync(new PickOptions
            {
                PickerTitle = "Select Book Thumbnail",
                FileTypes = FilePickerFileType.Images
            });

            if (result != null)
            {
                var vm = BindingContext as BooksViewModel;
                vm.ThumbnailPath = result.FullPath;
            }
        }
    }
}
