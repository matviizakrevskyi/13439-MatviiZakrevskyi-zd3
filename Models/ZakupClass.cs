using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13439_MatviiZakrevskyi_zd3.Models
{
    public class ZakupClass
    {
        [Required]
        public string Nazwa { get; set; }
        [Required]
        [Range(0, 100000000)]
        public int Liczba { get; set; }
        [Required]
        [Range(0, 100000000)]
        public double Cena { get; set; }

        public double SumaTowaru()
        { 
            return Cena * Liczba;
        }
    }
}
