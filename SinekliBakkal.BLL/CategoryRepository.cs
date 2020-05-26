using SinekliBakkal.BLL.Core;
using SinekliBakkal.DAL;
using SinekliBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinekliBakkal.BLL
{
    public class CategoryRepository : IRepository<Category>
    {
        SinekliBakkalEntities db = new SinekliBakkalEntities();
        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            db.Categories.Remove(entity);
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int Id)
        {
            return db.Categories.FirstOrDefault(z => z.Id == Id);
        }

        public void Update(Category entity)
        {
            Category c = db.Categories.FirstOrDefault(z => z.Id == entity.Id);
            c.Name = entity.Name;
            c.Description = entity.Description;
            db.SaveChanges();
        }
    }
}
