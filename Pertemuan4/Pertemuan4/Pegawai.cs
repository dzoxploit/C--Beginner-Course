using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pertemuan4
{
    class Pegawai
    {
        private string type;

        private double rate;

        private string notification;

        private string username;

        private ArrayList dataKehadiran;

        private ArrayList dataPegawai;

        private ArrayList dataStatus;

        public Pegawai()

        {

        dataPegawai = new ArrayList();

        dataStatus = new ArrayList();

        dataKehadiran = new ArrayList();

        }

        public class PegawaiTetap {}

        public class PegawaiHonorer {}



        public void InitializeData(string[] _dataNama, string[] _dataStatus)

        {

        ArrayList collectionNama = new ArrayList(); ArrayList collectionStatus = new ArrayList();

        int n = 0;

        foreach (string element in _dataNama)
        {

            collectionNama.Add(element); collectionStatus.Add(_dataStatus[n]); 
            n++;
        }

        dataPegawai.AddRange(collectionNama);

        dataStatus.AddRange(collectionStatus);

        }
 
        public void setUsername(string _username)

        {

        this.username = _username;

        }

        public void setRate(double _rate)

        {

        this.rate = _rate;

        }


        public void setType(string _type)

        {

        this.type = _type;

        }

        public void setKehadiran(ArrayList _kehadiran)

        {

        this.dataKehadiran = _kehadiran;

        }

        public double getRate() { return this.rate; } public string getType() { return this.type; }

        public string getUsername() { 
            return username == null ? null : this.username; 
        }

        public string getNotification() { 
            return this.notification;
        }

        public ArrayList getPegawai() { return this.dataPegawai; } public ArrayList getStatus() { return this.dataStatus; } public ArrayList getKehadiran() { return this.dataKehadiran;
        }

        public bool Login(string username, string password)

        {

        // Validation

        if (username != password)

        this.notification = "Error: username dan password tidak cocok!";

        else if (dataPegawai.IndexOf(username) == -1) this.notification = "Error: username dan password tidak ada di sistem!";

        else if (username == null)

        this.notification = "Error: username tidak boleh kosong!";

        else if (password == null)

        this.notification = "Error: password tidak boleh kosong!";

        if (this.notification == null)
 
        {

        this.username = username;

        this.notification = "Notifikasi: Login sukses."; return true;

        }

        else

        {

        return false;

        }


        }

    }
}
