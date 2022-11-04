using CheckBookService.Database;
using CheckBookService.Entities;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace CheckBookService.Repository
{
    
    public class CheckbookRepository
    {
        private readonly CheckbookDBContext db;
        public CheckbookRepository()
        {
            db = new CheckbookDBContext();
        }

        public void AddCheckbook(Checkbook checkbook)
        {
            db.Checkbooks.Add(checkbook);
            db.SaveChanges();
        }

        public Checkbook ViewCheckbookDetails(int id)
        {
            Checkbook checkbook = db.Checkbooks.SingleOrDefault(i => i.Id == id);
            return checkbook;
        }

        public void DeleteCheckbookt(int id)
        {
            Checkbook account = db.Checkbooks.SingleOrDefault(i => i.Id == id);
            db.Checkbooks.Remove(account);
            db.SaveChanges();
        }

        public void EditCheckbook(Checkbook account)
        {
            db.Checkbooks.Update(account);
            db.SaveChanges();
        }
    }
}
