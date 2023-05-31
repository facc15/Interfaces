using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Auto
    {
		private string marca;
        private string modelo;
        private float precio;


        public string Marca
		{
			get { return this.marca; }
			set { this.marca = value; }
		}
		public string Modelo
		{
			get { return this.modelo; }
			set { this.modelo = value; }
		}
		public float Precio
		{
			get { return this.precio; }
			set { this.precio = value; }
		}


        public override string ToString()
        {
			return this.marca + " - " + this.modelo + " - $" + this.precio;
        }



    }
}