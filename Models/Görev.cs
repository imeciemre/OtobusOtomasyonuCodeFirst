using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public class Görev

    {
        public int GörevId { get; set; }
        public string GörevAd { get; set; }
        public ICollection<Personel> GörevdekiPersoneler { get; set; }
    }
}
