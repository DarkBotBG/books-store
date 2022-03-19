using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _5_3_2022.Models
{
    public partial class Kniga
    {
        public double count;

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }
        public Kniga()
        {

        }
        public Kniga(int id, string name,string autor,string publisher,int price)
        {
            this.Id = id;
            this.Name = name;
            this.Author = autor;
            this.Publisher = publisher;
            this.Price = price;

        }
        
           
    }
}
