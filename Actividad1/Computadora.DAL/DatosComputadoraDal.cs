using Actividad1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad1.BSS;

namespace Computadora.DAL
{
    public class DatosComputadoraDal
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarComputadorasDal(DatosComputadora datoscomputadora)
        {
            string consulta = "insert into datoscomputadora values('" + persona.Nombre + "'," +
                                                          "'" + persona.Apellido + "'," +
                                                          "'" + persona.Telefono + "'," +
                                                          "'" + persona.Ci + "'," +
                                                          "'" + persona.Correo + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
