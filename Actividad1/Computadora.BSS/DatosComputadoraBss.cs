using Computadora.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.BSS
{
    public class DatosComputadoraBss
    {
        DatosComputadoraDal dal=new DatosComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadorasDal();
        }
    }
}
