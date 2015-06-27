using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
   public class EmailConfiguracoes
   {
       public bool UsarSsl = false;

       public string ServidorSmtp = "smtp.kenio.com.br";

       public int ServidorPorta = 587;

       public string Usuario = "kenioroberto";

       public bool EscreverArquivo = false;

       public string PastaArquivo = @"C:\envioemail";

       public string De = "kenioroberto@gmail.com.br";

       public string Para = "kenioroberto@gmail.com.br";
    }
}
