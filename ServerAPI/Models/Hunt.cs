using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class Hunt
    {
        public int Id { get; set; }
        public string HuntNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Permits { get; set; }
        public string Hunters { get; set; }
        public string Harvest { get; set; }
        public string AverageDays { get; set; }
        public string Success { get; set; }
    }
}