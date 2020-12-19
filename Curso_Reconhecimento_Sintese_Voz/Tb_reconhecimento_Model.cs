using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Reconhecimento_Sintese_Voz
{
    class Tb_reconhecimento_Model
    {
        public int id { get; set; }
        public string palavra { get; set; }
        public string resposta { get; set; }
        public Tb_reconhecimento_Model()
        {
            id = 0;
            palavra = string.Empty;
            resposta = string.Empty;
        }
    }
}
