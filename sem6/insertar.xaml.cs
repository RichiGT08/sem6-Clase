using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sem6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class insertar : ContentPage
    {
        public insertar()
        {
            InitializeComponent();
        }

        private async Task BtnIngresar_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
            
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
          
            parametros.Add("codigo", txtcodigo.Text);
            parametros.Add("nombre", txtnombre.Text);
            parametros.Add("apellido", txtapellido.Text);
            parametros.Add("edad", txtedad.Text);
            cliente.UploadValues("http://localhost/moviles/post.php", "POST", parametros);
            await DisplayAlert("alerta", "dato ingresado correctamente", "Aceptar");
            }
            catch(Exception ex) {
                await DisplayAlert("alerta", "error:"+ex.Message, "Aceptar");
            }
        }

        private async Task BtnRegresar_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}