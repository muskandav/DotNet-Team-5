using AccountService.Database;
using AccountService.Entities;

namespace AccountService.Repository
{
    public class AccountRepository
    {
        private readonly AccountDBContext _dbContext;
        public AccountRepository()
        {
            _dbContext = new AccountDBContext();
        }

        public void AddAccount(Account account)
        {
            _dbContext.accounts.Add(account);
            _dbContext.SaveChanges();
        }

        public Account GetAccountType(int id)
        {
            Account account = _dbContext.accounts.SingleOrDefault(i => i.AccTypeID == id);
            return account;
        }

        public void DeleteAccount(int id)
        {
            Account account = _dbContext.accounts.SingleOrDefault(i => i.AccTypeID == id);
            _dbContext.accounts.Remove(account);
            _dbContext.SaveChanges();
        }

        public void EditAccount(Account account)
        {
            _dbContext.accounts.Update(account);
            _dbContext.SaveChanges();
        }
    }
}
