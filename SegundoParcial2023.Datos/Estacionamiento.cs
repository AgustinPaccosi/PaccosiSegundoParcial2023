using SegundoParcial2023.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Datos
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible): this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        public List<Vehiculo> GetVehiculos() 
        {
            return vehiculos;
        }

        public static explicit operator string(Estacionamiento estacionamiento)
        {
            return $"Estacionamiento con {estacionamiento.espacioDisponible} lugares disponibles ";
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            return e.vehiculos.Contains(v);
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != null && v != null)
            {
                if (!e.vehiculos.Contains(v) && !string.IsNullOrEmpty(v.Patente) && e.vehiculos.Count < e.espacioDisponible)
                {
                    e.vehiculos.Add(v);
                    e.espacioDisponible=e.espacioDisponible-1;
                } 
            }
            return e;
        }
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string s= "vacio";
            if (estacionamiento.vehiculos.Contains(vehiculo))
            {
                s=vehiculo.ImprimirTicket();
                estacionamiento.vehiculos.Remove(vehiculo);
                estacionamiento.espacioDisponible += 1;
                
            }
            return s;
        }
    }
}
