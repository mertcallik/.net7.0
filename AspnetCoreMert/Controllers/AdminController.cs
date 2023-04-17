using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreMert.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("Save")]
        [Route("~/Save")]
        public string Save()
        {
            return "Saved";
        }

        [Route("Delete/{id?}")]
        public string Delete(int id = 0)
        {
            return string.Format("Deleted {0}", id);
        }

        [Route("Update")]
        public string Update()
        {
            return "Updated";
        }
    }
}