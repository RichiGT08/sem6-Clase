using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sem6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datos : ContentPage
    {
        public Datos()
        {
            InitializeComponent();
        }
        public int codigo{get; set;}
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
    }
}