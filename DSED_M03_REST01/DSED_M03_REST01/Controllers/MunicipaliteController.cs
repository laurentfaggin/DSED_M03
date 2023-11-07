
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using srvm;

namespace apim
{
    [Route("api/municipalites")]
    [ApiController]
    public class MunicipaliteController : ControllerBase
    {
        private ManipulationMunicipalites m_manipulationMunicipalites;

        public MunicipaliteController(ManipulationMunicipalites p_manipulationMunicipalites)
        {
          this.m_manipulationMunicipalites = p_manipulationMunicipalites;
        }

        // GET: api/municipalites
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult <IEnumerable<MunicipaliteModel>> Get()
        {
            return Ok(m_manipulationMunicipalites.ListerMunicipalitesActives());
        }

        // GET: api/municipalites/municipaliteId
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult <MunicipaliteModel> Get(int id)
        {
            MunicipaliteModel municipalite = new MunicipaliteModel(m_manipulationMunicipalites.ChercherMunicipaliteParCodeGeographique(id));
            if (municipalite != null)
            {
                return Ok(municipalite);
            }
            return NotFound();
        }

       
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult Post([FromBody]MunicipaliteModel p_municipaliteModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            m_manipulationMunicipalites.AjouterMunicipalite(p_municipaliteModel.VersEntite());
            return CreatedAtAction(nameof(Get), new { id = p_municipaliteModel.CodeGeographique }, p_municipaliteModel);
        }

        [HttpPut ("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult Put (int id, [FromBody] MunicipaliteModel p_municipalitemodel)
        {
            if(!ModelState.IsValid || p_municipalitemodel.CodeGeographique != id)
            {
                return BadRequest();
            }
            MunicipaliteModel munAModifier = new MunicipaliteModel(m_manipulationMunicipalites.ChercherMunicipaliteParCodeGeographique(id));
            if(munAModifier == null)
            {
                return NotFound();
            }
            m_manipulationMunicipalites.MAJMunicipalite(p_municipalitemodel.VersEntite());
            return NoContent();
        }

        // POST: MunicipaliteController/Edit/5
        [HttpDelete]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public ActionResult Delete(int p_id)
        {
            Municipalite mun = new MunicipaliteModel(m_manipulationMunicipalites.ChercherMunicipaliteParCodeGeographique(p_id)).VersEntite();
            if (mun == null)
            {
                return NotFound();
            }
            m_manipulationMunicipalites.DesactiverMunicipalite(mun);             
            return NoContent();
        }

       
    }
}
