using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinal
{
    class Cliente
    {
        String dni;
        String nombre;
        String apellidos;
        String direccion;
        int telefono;

        public Cliente(string dni, string nombre, string apellidos, string direccion, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public String Dni { get => dni; set => dni = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellidos { get => apellidos; set => apellidos = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            String toString = "" +
                "dni: " + dni +
                "nombre: " + nombre +
                "apellidos: " + apellidos +
                "direccion: " + direccion +
                "telefono: " + telefono;
            return toString;
        }

    }
}
