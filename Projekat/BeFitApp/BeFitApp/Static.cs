using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace BeFitApp
{
    public class Static
    {
        public static int ProgramId { get; set; }
        public Static()
        {
            ProgramId = -1;
        }
    }
}