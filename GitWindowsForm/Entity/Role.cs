using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWindowsForm.Entity
{
    public class Role
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual User User { get; set; }
    }
}
