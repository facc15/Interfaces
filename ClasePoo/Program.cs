using System.Runtime.CompilerServices;
using Entidades;

namespace ClasePoo
{
    public class Program
    {
        public static void Main(string[] arg)
        {

            /*
            MiOtraClase clase = new MiOtraClase();

            Console.WriteLine(clase[0]);

            Console.WriteLine(clase.MiMetodo());

            Console.WriteLine(clase.MiPropiedad);


            Console.WriteLine(((ImiOtraInterface)clase).MiMetodo());

            */



            #region Ejemplitos con archivos
            /*
            Serializadora<Auto> serializadora = new Serializadora<Auto>();
            Auto auto = new Auto();

            auto.Marca = "Volkswagen";
            auto.Modelo = "Suran";
            auto.Precio = 4000000f;

            if(serializadora.Serializar(auto,"//Autos.Xml"))
            {
                Console.WriteLine("Se serializó auto en XML");
            }


            if (((JSON<Auto>)serializadora).Serializar(auto, "//Autos.json"))
            {
                Console.WriteLine("Se serializó auto en JSON");
            }

            Auto nuevo = serializadora.Deserializar("//Autos.Xml");

            Console.WriteLine("Desde XML: "+nuevo.ToString());

            nuevo = ((JSON<Auto>)serializadora).Deserializar("//Autos.json");

            Console.WriteLine("Desde JSON: "+nuevo.ToString());




            Serializadora<Guitarra> serializadora2 = new Serializadora<Guitarra>();

            Guitarra guitarra = new Guitarra("Les Paul","Electrica",200000);

            if (serializadora2.Serializar(guitarra, "//Guitarras.Xml"))
            {
                Console.WriteLine("Se serializó guitarra en XML");
            }

            if (((JSON<Guitarra>)serializadora2).Serializar(guitarra,"//Guitarras.json"))
            {
                Console.WriteLine("Se serializó guitarra en JSON");
            }

            Guitarra nueva = serializadora2.Deserializar("//Guitarras.Xml");

            Console.WriteLine("Desde XML: " + nueva.ToString());

            nueva = ((JSON<Guitarra>)serializadora2).Deserializar("//Guitarras.json");

            Console.WriteLine("Desde JSON: " + nueva.ToString());


            Serializadora<Persona> serializadora3 = new Serializadora<Persona>();

            Persona persona = new Persona("Mariano", "Moreno", 245);

            if (serializadora3.Serializar(persona,"//personas.Xml"))
            {
                Console.WriteLine("Se serializó persona en XML");
            }

            if (((JSON<Persona>)serializadora3).Serializar(persona,"//personas.json"))
            {
                Console.WriteLine("Se serializó persona en JSON");
            }

            Persona nuevaPersona = serializadora3.Deserializar("//personas.Xml");

            Console.WriteLine("Desde XML: " + nuevaPersona.ToString());

            nuevaPersona = ((JSON<Persona>)serializadora3).Deserializar("//personas.json");

            Console.WriteLine("Desde JSON: " + nuevaPersona.ToString());

           
            */
            #endregion

            Console.ReadKey();


        }
    }
}