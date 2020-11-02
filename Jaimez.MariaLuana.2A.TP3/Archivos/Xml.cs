using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region Metodos
        /// <summary>
        /// Guarda el objeto xml en la ruta indicada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                using (XmlTextWriter write = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(write, datos);
                }
                return true;
            }
            catch (Exception exception)
            {

                throw new ArchivosException(exception);
            }
        }


        /// <summary>
        /// Lee los datos de la ruta indicada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                }
                return true;
            }
            catch (Exception exception)
            {

                throw new ArchivosException(exception);
            }
        }
        #endregion
    }
}
