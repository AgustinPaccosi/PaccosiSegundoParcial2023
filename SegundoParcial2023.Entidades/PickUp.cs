using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public class PickUp:Vehiculo
    {
        private string modelo;
        private int valorHora;

        private PickUp(string patente) : base(patente)
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : this(patente)
        {
            this.modelo = modelo;

        }
        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            return $"Modelo:{modelo}, Patente: {Patente}, Tipo: PickUp";
        }
        
        public override string ImprimirTicket()
        {
            string baseResult = base.ImprimirTicket();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(baseResult);
            sb.AppendLine(ToString());
            sb.AppendLine($"Fecha y hora de ingreso: {ingreso}");
            DateTime horaSalida = DateTime.Now;
            TimeSpan estadia = horaSalida.Subtract(ingreso);
            int horas = estadia.Hours;
            int minutos = estadia.Minutes;
            int segundos = estadia.Seconds;
            sb.AppendLine($"Hora Egreso: {horas}:{minutos}");
            sb.AppendLine($"Estadia : {estadia}");
            sb.AppendLine($"Costo : {estadia * valorHora}");

            return sb.ToString();
        }
    }
}
