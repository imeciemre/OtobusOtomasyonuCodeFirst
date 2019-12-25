using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Personel
    {
        public int PersonelId { get; set; }
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelfonNo { get; set; }

        public int GörevId { get; set; }
        public Görev Görevi { get; set; }
    }
}
