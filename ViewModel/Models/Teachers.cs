using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        
        public string Qualification { get; set; }
        public string Salary { get; set; }
    }
}