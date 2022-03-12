using _5_3_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_2022.Controller
{
    class BooksBusiness
    {
        private  booksContext booksContext;
        public List<Kniga> GetAll()
        {
            using (booksContext = new booksContext())
            {
                return booksContext.Kniga.ToList();
            }

        }

        public Kniga Get(int Id)
        {
            using (booksContext = new booksContext())
            {
                return booksContext.Kniga.Find(Id);
            }
        }
        public void Add(Kniga kniga)
        {
            using (booksContext = new booksContext())
            {
                booksContext.Kniga.Add(kniga);
                booksContext.SaveChanges();
            }
        }
        public void Update(Kniga kniga)
        {
            using (booksContext = new booksContext())
            {
                var item = booksContext.Kniga.Find(kniga.Id);
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
                var product = booksContext.Kniga.Find(Id);
                if (product != null)
                {
                    booksContext.Kniga.Remove(product);
                    booksContext.SaveChanges();
                }

            }
        }

    }
}
