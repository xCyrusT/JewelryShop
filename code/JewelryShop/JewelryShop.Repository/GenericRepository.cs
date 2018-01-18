using JewelryShop.IRepository;
using JewelryShop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryShop.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected JewelryShopDbContext db { get; set; }
        protected DbSet<T> table = null;

        public GenericRepository()
        {
            db = new JewelryShopDbContext();
            table = db.Set<T>();
        }
        public GenericRepository(JewelryShopDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public int Create(T item)
        {
            table.Add(item);
            return db.SaveChanges();
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public int Update(T item)
        {
            table.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            return db.SaveChanges();
        }
    }
}
