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

namespace DemoListView
{
    [Activity(Label = "EmpleadosDetalleActivity")]
    public class EmpleadosDetalleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_empleados_detalle);

            Android.Widget.TextView txtNombre =
                FindViewById<Android.Widget.TextView>(Resource.Id.textNombreEmpleado);
            string nombreDelEmpleado = Intent.GetStringExtra("nombre");
            txtNombre.Text = $"Empleado seleccionado {nombreDelEmpleado}"; //interpolando valores
        }
    }
}