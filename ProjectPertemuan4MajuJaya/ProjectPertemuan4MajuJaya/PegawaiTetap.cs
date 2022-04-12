using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ProjectPertemuan4MajuJaya
{
    class PegawaiTetap : Pegawai
    {
        private double tunjangan = 0.15;

        private double gajipokok = 2000000;

        private double denda = 50000;

        public PegawaiTetap()
            : base()
        {//tambahkan sebuah constructor dengan nama "PegawaiTetap" modifer = public
            this.setType("Pegawai Tetap");
        }

        public ArrayList getGaji()
        {

            int n = 0;

            ArrayList gaji = new ArrayList(); ArrayList kehadiran = this.getKehadiran(); foreach (var pegawai in this.getPegawai())
            {

                int totalBolos = (Convert.ToUInt16(kehadiran[n]) < 20) ? 20 - Convert.ToUInt16(kehadiran[n]) : 0;

                double totalDenda = this.denda * totalBolos; gaji.Add(this.gajipokok + (this.gajipokok * this.tunjangan) - totalDenda);

                n++;

            }

            return gaji;

        }

    }
}
