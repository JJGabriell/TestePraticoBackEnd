using Microsoft.AspNetCore.Mvc;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecomposicaoController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Numero>> PostNumero([FromBody]int numero)
        {
            try
            {

                Numero num = await Task.Run(() => new Numero().Decomposicao(numero));

                return Ok(num);

            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        } 

    }
}
