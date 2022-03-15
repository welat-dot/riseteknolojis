using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserBusiness;
using UserEntity.DTO;

namespace UserApi.Controllers
{
    [Route("kisi")]
    [ApiController]
    public class KisiController : ControllerBase
    {
        private IKisiManager kisiManager;
        public KisiController(IKisiManager kisiManager)
        {
            this.kisiManager = kisiManager; 
        }
       
        [Route(""), HttpGet]
        public IActionResult getAll()
        {
            return Ok(kisiManager.getAll());
        }
        [Route(""), HttpPost]
        public IActionResult add(KisiDTO kisi)
        {
            return Ok(kisiManager.add(kisi));
        }        
        [Route(""), HttpPut]
        public IActionResult update(KisiDTO kisi)
        {
            return Ok(kisiManager.update(kisi));
        }

        [Route("deletebyid/{id}"), HttpDelete]
        public IActionResult deleteById(int id)
        {
            return Ok(kisiManager.delete(id));
        }
        [Route("getbyid/{id}"), HttpGet]
        public IActionResult getById(int id)
        {
            return Ok(kisiManager.getById(id));
        }
    }
}
