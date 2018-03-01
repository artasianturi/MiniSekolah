using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekolahApp.DataModel
{
    public class BaseTable
    {
        [Column(TypeName = "varchar"), MaxLength(30)]
        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        [Column(TypeName = "varchar"), MaxLength(30)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }
    }
}