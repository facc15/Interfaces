using System.Text.Json;
using System.Xml.Serialization;
using System.Xml;


namespace Entidades
{
    public class Serializadora<T>   :   XML<T>, JSON<T>
    {

        private static string path;

        static Serializadora()
        {
           
            Serializadora<T>.path = "..//..//..//Archivos";


        }

        public bool Serializar(T dato,string path)
        {
            bool seSerializo = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Serializadora<T>.path + path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    ser.Serialize(writer, dato);
                    seSerializo = true;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return seSerializo;
        }

        public T Deserializar(string path)
        {
            T aux=default(T);
            try
            {
                using (XmlTextReader reader = new XmlTextReader(Serializadora<T>.path + path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    aux = (T)ser.Deserialize(reader);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return aux;
        }


        bool JSON<T>.Serializar(T dato, string path)
        {
            bool seGuardo = false;

            using (StreamWriter sw = new StreamWriter(Serializadora<T>.path + path))
            {
                string jsonString = JsonSerializer.Serialize(dato);

                sw.WriteLine(jsonString);
                seGuardo = true;
            }

            return seGuardo;

        }

        T JSON<T>.Deserializar(string path)
        {
            T obj=default(T);

            using (StreamReader sr = new StreamReader(Serializadora<T>.path + path))
            {
                string json_str = sr.ReadToEnd();


                obj = (T)JsonSerializer.Deserialize(json_str, typeof(T));

            }

            return obj;
        }







    }
}
