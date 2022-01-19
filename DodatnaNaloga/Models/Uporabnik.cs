using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Models
{
    public partial class Uporabnik : ComponentBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [RegularExpression(@"^(([A-Za-z]+)|([A-Za-z]+\s{1}[A-Za-z]+))$", ErrorMessage = "Dovoljene so samo črke")]
        public string UporabniskoIme { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [RegularExpression(@"^(([A-Za-z]+)|([A-Za-z]+\s{1}[A-Za-z]+))$", ErrorMessage = "Dovoljene so samo črke")]
        public string Priimek { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public DateTime DatumRojstva { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [DataType(DataType.Password)]
        public string Geslo { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [DataType(DataType.Password)]
        public string PonovnoGeslo { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Neveljaven email naslov!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        [RegularExpression(@"^(\d{13})$", ErrorMessage = "Dovoljene so samo številke")]
        public string EMSO { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public int Starost { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public string Naslov { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public string Posta { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public string Drzava { get; set; }

        [Required(ErrorMessage = "Polje je zahtevano!")]
        public KrajRojstva Kraj { get; set; }

    }

    public enum KrajRojstva
    {
        Žalec,
        Celje,
        Maribor,
        Ljubljana,
        Koper
    }
}
