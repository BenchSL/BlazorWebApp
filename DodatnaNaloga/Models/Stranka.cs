using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Models
{
    public class Stranka
    {
        [Key]
        public int Id { get; set; }
        public string ImeStranke { get; set; }
        public int Starost { get; set; }


        public Stranka()
        {

        }

        public Stranka(string name, int age)
        {
            ImeStranke = name;
            Starost = age;
        }

    }
}
