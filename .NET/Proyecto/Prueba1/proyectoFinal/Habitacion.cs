using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    class Habitacion
    {
        long idRoom;
        String caracteristicas;
        float importeNoche;
        String tipo;
        String estado;

        public Habitacion(long idRoom, string caracteristicas, float importeNoche, string tipo)
        {
            this.idRoom = idRoom;
            this.caracteristicas = caracteristicas;
            this.importeNoche = importeNoche;
            this.tipo = tipo;
        }

        public long IdRoom { get => idRoom; set => idRoom = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public float ImporteNoche { get => importeNoche; set => importeNoche = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Estado { get => estado; set => estado = value; }

        public override string ToString()
        {
            String toString = "" +
                "Id: "+idRoom+
                "Tipo: "+Tipo+
                "Carateristicas: "+Caracteristicas+
                "Importe por noche: "+importeNoche;
            return toString;
        }


    }
}
