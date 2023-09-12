using Microsoft.AspNetCore.Mvc;
using XJSCC20230901.Models;


namespace XJSCC20230901.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        static List<Materias> materias = new List<Materias>();

        [HttpGet]
        public IEnumerable<Materias> Get()
        {
            return materias;
        }

        [HttpPost]
        public IActionResult Put([FromBody] Materias materia)
        {
            materias.Add(materia);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingMaterias = materias.FirstOrDefault(c => c.Id == id);
            if (existingMaterias != null)
            {
                materias.Remove(existingMaterias);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}
