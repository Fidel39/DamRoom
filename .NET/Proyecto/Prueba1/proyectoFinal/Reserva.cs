using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    class Reserva
    {
        long idReserva;
        DateTime fechaIni;
        DateTime fechaFin;
        float importe;
        String dniCliente;
        long numHabi;
        String estado;

        public Reserva(long idReserva, DateTime fechaIni, DateTime fechaFin, float importe, string dniCliente, long numHabi, string estado)
        {
            this.idReserva = idReserva;
            this.fechaIni = fechaIni;
            this.fechaFin = fechaFin;
            this.importe = importe;
            this.dniCliente = dniCliente;
            this.numHabi = numHabi;
            this.estado = estado;
        }

        public long IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime FechaIni { get => fechaIni; set => fechaIni = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public float Importe { get => importe; set => importe = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public long NumHabi { get => numHabi; set => numHabi = value; }
        public string Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            String toString = "" +
                "idReserva:" + idReserva +
                "dniCliente:" + dniCliente +
                "numHabi:" + numHabi +
                "fechaIni:" + fechaIni +
                "fechaFin:" + fechaIni +
                "importe:" + importe +
                "estado" + estado;
            return toString;
        }

    }
}
