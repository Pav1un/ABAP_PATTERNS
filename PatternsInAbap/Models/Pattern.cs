using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatternsInAbap.Models
{
    public class Pattern
    {
        [Key]
        [Display(Name = "Имя")]
        public String Name { get; set; }

        [Display(Name = "Короткое описание")]
        public String ShortDescription { get; set; }

        [Display(Name = "Длинное описание")]
        public String LongDescription { get; set; }

        [Display(Name = "Реализация")]
        public String Code { get; set; }

        [Display(Name = "Тип")]
        public String Type { get; set; }

        [Column(TypeName = "image")]
        public byte[] Diagramme { get; set; }

        [Display(Name = "Ссылки")]
        public virtual List<Link> Links { get; set; }
    }

    public class Link
    {
        [Key]
        public String Url { get; set; }
        public List<Pattern> Pattern { get; set; }
    }
}