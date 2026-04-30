using Microsoft.AspNetCore.Mvc;

namespace UrbsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrbsController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            // Isso simula o que o banco de dados devolveria
            return new 
            { 
                Id = 1,
                Titular = "Raffael Guideti", 
                Saldo = 150.00,
                Status = "Ativo"
            };
        }
    }
}