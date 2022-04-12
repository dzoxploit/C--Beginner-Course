using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pertemuan4
{
    class PegawaiHonorer : Pegawai
    {
        public PegawaiHonorer() : base()
        {

            this.setType("honorer");

            this.setRate(75000.0);

        }

        public ArrayList getGaji()
        {

            int n = 0;

            ArrayList gaji = new ArrayList(); ArrayList kehadiran = this.getKehadiran(); foreach (var pegawai in this.getPegawai())
            {

                gaji.Add(this.getRate() *

                Convert.ToDouble(kehadiran[n]));

                n++;

            }

            return gaji;

        }

    }
}
