using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softclub.Application.Models
{
    public class CreateNewModel
    {
        public int Id { get; set; }
        [MinLength(10)]
        public string Title { get; set; }
        [MinLength(100)]
        public string Content { get; set; }

    }
}
