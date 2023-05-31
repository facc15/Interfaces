using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public class Guitarra
    {
		private string marca;
		private string tipo;
        private float precio;

        public Guitarra()
        {
        }

        public Guitarra(string marca, string tipo, float precio)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.precio = precio;
        }

		public float Precio
		{
			get { return this.precio; }
			set { this.precio = value; }
		}

		public string Tipo
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}

		public string Marca
		{
			get { return this.marca; }
			set { this.marca = value; }
		}

        public override string ToString()
        {
            return this.marca + " - " + this.tipo + " - $" + this.precio;
        }

    }
}
