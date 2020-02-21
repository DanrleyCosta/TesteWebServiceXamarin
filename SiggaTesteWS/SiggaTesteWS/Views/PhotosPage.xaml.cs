using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using SiggaTesteWS.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SiggaTesteWS.Views
{
    public partial class PhotosPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/photos";
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<PostDomain> _photos;
        public PhotosPage()
        {
            InitializeComponent();
        }
        async override protected void OnAppearing()
        {
            base.OnAppearing();
            string rescontent = await _client.GetStringAsync(Url);
            List<PostDomain> usuarios = JsonConvert.DeserializeObject<List<PostDomain>>(rescontent);
            _photos = new ObservableCollection<PostDomain>(usuarios);
            lvUsers.ItemsSource = _photos;
            base.OnAppearing();
        }
    }
}
