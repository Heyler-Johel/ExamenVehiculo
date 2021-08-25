using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGreivin.Models
{
    public class Vehiculo
    {
        public Vehiculo()
        {

        }
        public Vehiculo(int id, string marca, string modelo, float km, float precio)
        {
            this.ID = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.KM = km;
            this.Precio = precio;
        }
        private int ID { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private float KM { get; set; }
        protected virtual float Precio { get; set; }

    }
}
