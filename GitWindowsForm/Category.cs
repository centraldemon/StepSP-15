using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWindowsForm
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual Product categoty { get; set; }
    }
}
