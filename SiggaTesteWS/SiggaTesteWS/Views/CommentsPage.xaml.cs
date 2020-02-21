using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using SiggaTesteWS.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SiggaTesteWS.Views
{
    public partial class CommentsPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/comments";
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<PostDomain> _comments;
        public CommentsPage()
        {
            InitializeComponent();
        }
        async override protected void OnAppearing()
        {
            base.OnAppearing();
            string rescontent = await _client.GetStringAsync(Url);
            List<PostDomain> usuarios = JsonConvert.DeserializeObject<List<PostDomain>>(rescontent);
            _comments = new ObservableCollection<PostDomain>(usuarios);
            lvUsers.ItemsSource = _comments;
            base.OnAppearing();
        }
    }
}
