using Enacom_Api.Data;
using Enacom_Api.Entity;
using Enacom_Api.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enacom_Api.Services
{
    public class NoticiasServices
    {
        NoticiasData noticiasData = new NoticiasData();
        NoticiasValidation noticiasValidation = new NoticiasValidation();

        public List<Noticias> getNoticias ()
        {
            List<Noticias> noticias = new List<Noticias>();
            noticias = noticiasData.getNoticias();


            return noticias ;
        }
    }
}
