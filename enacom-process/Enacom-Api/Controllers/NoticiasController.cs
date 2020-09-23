using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enacom_Api.Entity;
using Enacom_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enacom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasController : ControllerBase
    {
        NoticiasServices noticiasServicies = new NoticiasServices();

        [HttpGet]
        [Route("obtenerNoticias")]
        public List<Noticias> GetNoticias()
        {
            List<Noticias> noticias = noticiasServicies.getNoticias();


            return noticias;
        }



        [HttpGet]
        [Route("obtenerNoticia")]
        public void GetNoticia()
        {

        }

        [HttpPost]
        [Route("insertarNoticia")]
        public void SetNotcia()
        {

        }

        [HttpPut]
        [Route("modificarNoticia")]
        public void UpdateNoticia()
        {

        }

        [HttpDelete]
        [Route("borrarNoticia")]
        public void DeleteNoticia()
        {

        }

    }
}
