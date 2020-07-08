using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        public abstract string Nota {get; set;}
        public abstract string Tanggal {get; set;}
        public abstract string Costumer {get; set;}
        public abstract string Pembayaran {get; set;}
        public abstract double TotalNota ();
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
    }
}
