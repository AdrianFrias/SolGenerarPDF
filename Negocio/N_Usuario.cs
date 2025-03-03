using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entidades;
using System;

namespace Negocio
{
    public class N_Usuario
    {
        public void Imprimir(E_Usuario user)
        {

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos", "Prueba.pdf");

            Document archivo = new Document();
            PdfWriter.GetInstance(archivo, new FileStream(ruta, FileMode.Create));
            try
            {
                archivo.Open();
                archivo.Add(new Paragraph($"Inicio"));
                archivo.Add(new Paragraph($"Hola mi nombre es {user.nombre} {user.apPaterno} {user.apMaterno}"));
                archivo.Add(new Paragraph($"Tengo {user.edad} años"));
                archivo.Add(new Paragraph($"Mi correo es {user.correo}"));
                archivo.Add(new Paragraph($""));
                archivo.Add(new Paragraph($"El Fin"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                archivo.Close();
            }
        }
    }
}
