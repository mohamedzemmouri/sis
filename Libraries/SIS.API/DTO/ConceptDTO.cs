using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SIS.API.DTO
{
    public class ConceptDTO
    {
        [MaxLength(50)]
        public string TableName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
