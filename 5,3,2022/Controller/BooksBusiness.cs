using _5_3_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_2022.Controller
{
   public class BooksBusiness
    {
        private  booksContext booksContext;
        
        public List<Kniga> GetAll()
        {
            using (booksContext = new booksContext())
            {
                return booksContext.Knigi.ToList();
            }

        }

        public Kniga Get(int Id)
        {
            using (booksContext = new booksContext())
            {
                return booksContext.Knigi.Find(Id);
            }
        }
        public void Add(Kniga kniga)
        {
            using (booksContext = new booksContext())
            {
                booksContext.Knigi.Add(kniga);
                booksContext.SaveChanges();
            }
        }
        public void Update(Kniga kniga)
        {
            using (booksContext = new booksContext())
            {
                var item = booksContext.Knigi.Find(kniga.Id);
                if (item != null)
                {
                    booksContext.Entry(item).CurrentValues.SetValues(kniga);
                    booksContext.SaveChanges();
                }
            }
        }
        public void Delete(int Id)
        {
            using (booksContext = new booksContext())
            {
                var product = booksContext.Knigi.Find(Id);
                if (product != null)
                {
                    booksContext.Knigi.Remove(product);
                    booksContext.SaveChanges();
                }

            }
        }

    }
}
