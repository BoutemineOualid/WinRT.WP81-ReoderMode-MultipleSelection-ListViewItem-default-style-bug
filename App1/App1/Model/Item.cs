using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public class Item
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public string AvatarUrl { get { return "/Assets/Square71x71Logo.scale-240.png"; }}
    }
}
