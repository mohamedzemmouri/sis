using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.API.DTO
{
    public class InfoDTO
    {
        [MaxLength(200)]
        public string Data { get; set; } = string.Empty;
    }
}
