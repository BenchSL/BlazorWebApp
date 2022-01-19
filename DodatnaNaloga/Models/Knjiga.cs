using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Models
{
    public class Knjiga
    {
        [Key]
        public int Id { get; set; } 
        public string Naslov { get; set; }
        public string LetoIzdaje { get; set; }


        public Knjiga()
        {

        }

        public Knjiga(string nasl, string leto)
        {
            Naslov = nasl;
            LetoIzdaje = leto;
        }

    }
}
