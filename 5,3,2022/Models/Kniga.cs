using System;
using System.Collections.Generic;

namespace _5_3_2022.Models
{
    public partial class Kniga
    {
        public int Id { get; set; }
        public string Име { get; set; }
        public string Автор { get; set; }
        public string Издател { get; set; }
        public int? Цена { get; set; }
        public Kniga()
        {

        }
        public Kniga(int id,string name,string autor,string publisher,int price)
        {
            this.Id = id;
            this.Име = name;
            this.Автор = autor;
            this.Издател = publisher;
            this.Цена = price;

        }
        
           
    }
}
