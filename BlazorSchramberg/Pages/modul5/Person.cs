using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchramberg.Pages.modul5
{
    public class Person
    {
        public int ID { get; set; }

        [Range(100,200,ErrorMessage ="Keine Achterbahn")]
        [Required(ErrorMessage = "da muss was rein")]
        public int Gross { get; set; }
        [StringLength(10,ErrorMessage ="max 10")]
        [Required(ErrorMessage ="da muss was rein")]
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
    }
}
