using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMenuMasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    class MasterPageItem
    {
        public string Titulo { get; set; }

        public string Icono { get; set; }

        public Type TipoPagina { get; set; }
    }
}
