using System.Collections.Generic;
using Xamarin.Forms;

namespace CarouselEntryTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Carousel.ItemsSource = new List<string> { "0", "1", "2" };
        }
    }
}