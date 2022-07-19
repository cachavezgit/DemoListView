using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoListView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoListView
{
    [Activity(Label = "EmpleadosActivity", MainLauncher = true)]
    public class EmpleadosActivity : Activity
    {
        private List<Empleado> empleados;
        private ListView empleadoListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_empleados);

            empleadoListView = FindViewById<ListView>(Resource.Id.listEmpleados);
            empleadoListView.ChoiceMode = ChoiceMode.Multiple;
            empleados = GetEmpleados();
            empleadoListView.Adapter = new EmpleadoListAdapter(this, empleados);
            empleadoListView.ItemClick += OnListItemClick;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var empleado = empleados[e.Position];

            Android.Widget.Toast.MakeText
                (this, $"Seleccion: {empleado.Nombre}", Android.Widget.ToastLength.Short).Show();

            Intent intent = new Intent(this, typeof(EmpleadosDetalleActivity));
            intent.PutExtra("nombre", empleado.Nombre);
            StartActivity(intent);
        }

        private List<Empleado> GetEmpleados()
        {
            List<Empleado> list = new List<Empleado>(); 

            list.Add(new Empleado("Carlos Ivan", "Chavez Fuentes"));
            list.Add(new Empleado("Magda", "Armenta Rivera"));
            list.Add(new Empleado("Ricardo", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo2", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo3", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo4", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo5", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo6", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo7", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo8", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo9", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo10", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo11", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo12", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo13", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo14", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo15", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo16", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo17", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo18", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo19", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo20", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo21", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo22", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo23", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo24", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo25", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo26", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo27", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo28", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo29", "Rojas Orozo"));
            list.Add(new Empleado("Ricardo30", "Rojas Orozo"));

            return list;    
        }


    }
}