using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Upah { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Upah;
        }
    }
}
