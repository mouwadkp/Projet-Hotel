using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hotel
    {
        //les proprietes de la classe hotel

        private string nom;
        private ArrayList clientsHotel;

        //les ascensseur de la classe hotel
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public ArrayList ClientsHotel
        {
            get { return clientsHotel; }
            set { clientsHotel = value; }
        }

        //les constructeur de la classe hotel
        public Hotel(string nom)
        {
            Nom = nom;
            clientsHotel = new ArrayList();
        }
    }
}
