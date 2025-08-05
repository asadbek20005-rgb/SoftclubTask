using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftclubTask.Domain.Entities
{
    public class File
    {
       
            public int Id { get; set; }
            public string Filename { get; set; }
            public long FileSize { get; set; }
            public string FileType { get; set; }
        
    }
}
