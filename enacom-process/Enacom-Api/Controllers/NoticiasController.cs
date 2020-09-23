using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enacom_Api.DBContext;
using Enacom_Api.Entity;
using Enacom_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enacom_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoticiasController : ControllerBase
    {
        NoticiasServices noticiasServicies = new NoticiasServices();

        private readonly ContextNoticias context;

        public NoticiasController(ContextNoticias context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/obtenerNoticias")]
        public  ActionResult<List<Noticias>> GetNoticias()
        {
            List<Noticias> noticias = noticiasServicies.getNoticias();

            return context.noticias.ToList();
        }




    }
}
