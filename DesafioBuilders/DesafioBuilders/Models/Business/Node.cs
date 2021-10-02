using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DesafioBuilders.Models.Business
{
    public class Node
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int Value { get; set; }

    }
}
