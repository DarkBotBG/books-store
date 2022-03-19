using _5_3_2022.Models;
using System;

namespace test1
{
    internal class BooksBusiness
    {
        private booksContext context;

        public BooksBusiness(booksContext context)
        {
            this.context = context;
        }

        internal void Add(Kniga product)
        {
            throw new NotImplementedException();
        }

        internal Kniga Get(int v)
        {
            throw new NotImplementedException();
        }

        internal Kniga GetAll()
        {
            throw new NotImplementedException();
        }
    }
}