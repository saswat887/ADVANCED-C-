using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    [Table("pizzabl")]
    public class Pizza
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pid { get; set; }
        [Column(TypeName ="varchar(20)")]
        public string pizzanames { get; set; }
        public int price { get; set; }
        [Column("pizzatype",TypeName = "varchar(20)")]
        public string ptype { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string description { get; set; }
    }
}
