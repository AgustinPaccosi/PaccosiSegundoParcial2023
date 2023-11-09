using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private int ruedas;
        private int valorHora;

        private Moto(string patente) : base(patente)
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : this(patente)
        {
            this.cilindrada = cilindrada;

        }

        public Moto(string patente, int cilindrada, int ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;

        }

        public Moto(string patente, int cilindrada, int ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            this.valorHora = valorHora;

        }

        public override string ConsultarDatos()
        {
            return $"Tipo: Moto, Cilindrada: {cilindrada}, Patente: {Patente}";
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
            sb.AppendLine($"Costo : {estadia*valorHora}");


            return sb.ToString();
        }
    }
}
