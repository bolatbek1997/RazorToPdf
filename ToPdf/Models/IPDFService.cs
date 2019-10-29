using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToPdf.Models
{
   public   interface IPDFService
    {
        Task<byte[]> Create();
    }
}
