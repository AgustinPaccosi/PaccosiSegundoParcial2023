using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        private Automovil(string patente) : base(patente)
        {
            valorHora = 50;
        }
        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            this.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            return $"Color:{color}, Patente: {Patente}, Tipo: Automovil";
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