﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region Metodos
        /// <summary>
        /// Guarda el dato en formato .txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine(datos);
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
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    datos = reader.ReadToEnd();
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
