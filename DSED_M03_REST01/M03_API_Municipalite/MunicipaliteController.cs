using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using srvm;

namespace DSED_M03_REST01.Controllers
{
    [Route("api/municipalites")]
    [ApiController]
    public class MunicipaliteController : Controller
    {
        // GET: api/municipalites
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult <Municipalite> Get()
        {
            return Ok();
        }

        // GET: api/muncipalites/municipaliteId
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult <Municipalite> Get(int id)
        {
            Municipalite municipalite = null;
            if (municipalite != null)
            {
                return Ok();
            }
            return NotFound();
        }

        // GET: MunicipaliteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MunicipaliteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MunicipaliteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MunicipaliteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MunicipaliteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MunicipaliteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
