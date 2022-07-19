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
    internal class EmpleadoListAdapter : BaseAdapter<Empleado>
    {

        Activity context;
        private readonly List<Empleado> empleados;

        public EmpleadoListAdapter(Activity context, List<Empleado> empleados)
        {
            this.context = context;
            this.empleados = empleados;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var empleado = empleados[position];

            var empleadoBitmap = ImageHelper.GetImageBitMapFromUrl("https://picsum.photos/500/300");

            if (convertView == null)
            {
                convertView = context.LayoutInflater
                    .Inflate(Resource.Layout.listview_empleados_row, null);
            }

            convertView.FindViewById<TextView>(Resource.Id.textNombre).Text =
                $"Nombre: {empleado.Nombre}";

            convertView.FindViewById<TextView>(Resource.Id.textApellidos).Text =
                $"Apellidos: {empleado.Apellidos}";

            convertView.FindViewById<ImageView>(Resource.Id.imageEmpleado).SetImageBitmap(empleadoBitmap);

            return convertView;
            

        }

        public override int Count
        {
            get
            {
                return empleados.Count;
            }
        }

        public override Empleado this[int position] => empleados[position];
    }

    internal class EmpleadoListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}