using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class Persona 
    {
		private string nombre;
		private int edad;
		private string apellido;


        public string Apellido
		{
			get { return this.apellido; }
			set { this.apellido = value; }
		}

		public int Edad
		{
			get { return this.edad; }
			set { this.edad = value; }
		}

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		public Persona()
		{

		}

		public Persona(string nombre,string apellido,int edad)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.edad = edad;
		}



        public override string ToString()
        {
            return this.nombre + " - " + this.apellido + " - " + this.edad;
        }



    }
}
