using App.Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models
{
    public class DevelopmentViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public List<string> Technologies { get; set; }
        public string ImageSourceName { get; set; }
        public ProyectTypeEnum Type { get; set; }
        public string Url{ get; set; }
        public string VideoUrl { get; set; }
    }
}
