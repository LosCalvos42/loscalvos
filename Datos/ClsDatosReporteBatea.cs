using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class ClsDatosReporteBatea
    {
        public string Btipo { get; set; }
        public string Blote { get; set; }
        public string Btextura { get; set; }
        public int  Nrotextura { get; set; }
        public DateTime Fecha { get; set; }
    }
}

