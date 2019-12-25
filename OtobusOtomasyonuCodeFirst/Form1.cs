using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonuCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int personelid = 0;
        private void eKLE_Click(object sender, EventArgs e)
        {



            PersonelBL pbl = new PersonelBL();
           
                Personel p = new Personel();
                p.Ad = txtAd.Text.Trim();
                p.Soyad = txtSoyad.Text.Trim();
                p.TelfonNo = txtNo.Text.Trim();
                p.PersonelId = personelid;
            
        }

    }
}