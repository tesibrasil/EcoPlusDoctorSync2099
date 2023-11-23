using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoplusDoctorSync.Models
{
    public  class Medico
    {
        public string sUserName { get; set; }
        public string sNome { get; set; }
        public string sSobrenome { get; set; }
        public string sCRM { get; set; }
        public string sTratamento { get; set; }
        public string sAssinatura { get; set; }        
        public string s3L3N { get; set; }
        public string sRubricaB64 { get; set; }
    }
}
