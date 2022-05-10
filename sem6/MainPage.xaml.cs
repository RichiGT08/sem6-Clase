using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sem6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://localhost/moviles/post.php";
        private readonly HttpClient cliente = new HttpClient();
        //private ObservableCollection<> _post;
            public MainPage()
        {
            InitializeComponent();
        }

        private void btnGet_Clicked(object sender, EventArgs e)
        {

        }

    }
}
