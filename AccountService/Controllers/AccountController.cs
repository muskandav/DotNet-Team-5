using AccountService.Entities;
using AccountService.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController:ControllerBase
    {
        private readonly AccountRepository repo;

        public AccountController()
        {
            repo = new AccountRepository();
        }

        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult GetAccountType(int id)
        {
            Account account = repo.GetAccountType(id);
            return StatusCode(200, account);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Account account)
        {
            repo.AddAccount(account);
            return StatusCode(200, account);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repo.DeleteAccount(id);
            return StatusCode(200, "Account with id " + id + " Deleted");
        }

        [HttpPut]
        [Route("Edit")]
        public IActionResult EditAccount(Account account)
        {
            repo.EditAccount(account);
            return StatusCode(200, account);
        }

    }
}
