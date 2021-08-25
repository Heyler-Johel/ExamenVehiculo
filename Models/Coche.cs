using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGreivin.Models
{
    class Coche : Vehiculo
    {
        public Coche()
        {

        }
        public Coche(int id, string marca, string modelo, float km, float precio, bool airbag) : base(id, marca, modelo, km, precio)
        {
            this.Airbag = airbag;
        }
        private bool Airbag { get; set; }
        protected override float Precio
        {
            set
            {
                if (this.Airbag)
                {
                    this.Precio += 200;
                }
            }
        }
    }
}
