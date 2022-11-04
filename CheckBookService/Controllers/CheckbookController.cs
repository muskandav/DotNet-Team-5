using CheckBookService.Entities;
using CheckBookService.Repository;
using Microsoft.AspNetCore.Mvc;


namespace CheckBookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckbookController: ControllerBase
    {
        private readonly CheckbookRepository repo;

        public CheckbookController()
        {
            repo = new CheckbookRepository();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Checkbook checkbook = repo.ViewCheckbookDetails(id);
            return StatusCode(200, checkbook);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Checkbook checkbook)
        {
            repo.AddCheckbook(checkbook);
            return StatusCode(200, checkbook);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteCheckbookt(id);
            return StatusCode(200, "Checkbook with id " + id + " Deleted");
        }

        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Checkbook checkbook)
        {
            repo.EditCheckbook(checkbook);
            return StatusCode(200, checkbook);
        }

    }
}
