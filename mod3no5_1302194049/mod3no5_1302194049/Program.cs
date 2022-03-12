using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3no5_1302194049
{
    public class PosisiKarakterGame {
        private String state = "Berdiri";
        public void posisi (String perintah)
        {
            perintah = perintah.ToLowerCase();
            switch (perintah) {
                case "berdiri":
                    this.state = "posisi standby";
                    break;
                case "Tengkurap":
                    this.state = "posisi istirahat";
                    break ;

        }

    }
        public String getState ()
        {
            return this.state;
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
