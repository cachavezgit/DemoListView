using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoListView.Models
{
    internal class Empleado
    {
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Foto { get; set; }

        public Empleado(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}