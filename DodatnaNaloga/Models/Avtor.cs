using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Models
{
    public class Avtor
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public int Starost { get; set; }
        public string DatumRojstva { get; set; }
        public int Ocena { get; set; }

        public Avtor()
        {

        }

        public Avtor(string name, int age, string date, int rat)
        {
            Ime = name;
            Starost = age;
            DatumRojstva = date;
            Ocena = rat;
        }

    }
}
