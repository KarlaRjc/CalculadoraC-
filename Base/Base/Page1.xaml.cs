using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Base.Models;

namespace Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
         
            Display();
            
        }
        void Display() {
            String nombreArchivo = "Archivo.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);

         
            List<Operaciones> operaciones= new List<Operaciones>();

            using (var lector = new StreamReader(rutaCompleta, true))
            {
                String TextoLeido;
                while ((TextoLeido = lector.ReadLine()) != null)
                {
                    operaciones.Add(new Operaciones() { Resultado = TextoLeido });
                  
                }
             
            }
            listaOperac.ItemsSource = operaciones; //Enlaza los datos a la lista que se establece en XAML
        }
    }
}