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

        
           
    }
}
