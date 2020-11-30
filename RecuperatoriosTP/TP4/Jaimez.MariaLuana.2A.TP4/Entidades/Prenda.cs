using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Entidades
{
    public class Prenda : Producto, Serializar, Deserializar
    {
        #region Enumerados
        public enum ETipoPrenda
        {
            Remera, Pantalon, Zapato, SinDato
        }
        #endregion

        #region Atributos
        public int idProducto;
        public ETipoPrenda tipo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Prenda () : base () { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        public Prenda(int id, ETipoPrenda tipo, string marca, float precio, int cantidad)
            : base(id, marca, precio, cantidad)
        {
            this.idProducto = id;
            this.tipo = tipo;
        }
        #endregion

        #region Serializacion
        /// <summary>
        /// Serializa prenda
        /// </summary>
        /// <returns></returns>
        bool Serializar.Xml()
        {
            bool retorno = false;
            XmlSerializer serializa = new XmlSerializer(typeof(Prenda));
            try
            {
                using (TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "PrendaSerializa.xml"))
                {
                    serializa.Serialize(writer, this);
                    retorno = true;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message + "Error");
            }

            return retorno;
        }

        /// <summary>
        /// Deserializa prenda
        /// </summary>
        /// <param name="prenda"></param>
        /// <returns></returns>
        bool Deserializar.Xml(out Prenda prenda)
        {
            bool retorno = false;
            prenda = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Prenda));

            try
            {
                using (TextReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "PrendaSerializa.xml"))
                {
                    prenda = (Prenda)serializer.Deserialize(reader);
                    retorno = true;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message + "Error");
            }

            return retorno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Devuelve los datos de la prenda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(((string)(this)));
            retorno.AppendFormat("Tipo: {0}\n", this.tipo.ToString());

            return retorno.ToString();
        }

        /// <summary>
        /// comparacion de prendas
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Prenda && (Prenda)obj == this;
        }
        #endregion

        #region Operadores
        /// <summary>
        /// dos prendas seran iguales si son del mismo tipo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Prenda p1, Prenda p2)
        {
            return p1.tipo == p2.tipo;
        }

        /// <summary>
        /// dos prendas seran distintas si no soy del mismo tipo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Prenda p1, Prenda p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// precio prendas
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Single(Prenda p)
        {
            return p.precio;
        }
        #endregion
    }
}
