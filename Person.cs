using Personenliste2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenliste2
{
    public class Person
    {
        private string _vorname = "";

        public string Vorname
        {
            get { return _vorname; }
            set
            {
                if (_vorname != value)
                {
                    _vorname = value;
                }
            }
        }
        private string _nachname = "";

        public string Nachname
        {
            get { return _nachname; }
            set
            {
               _nachname = value;
            }
        }
        private string _geschlecht = "";

        public string Geschlecht
        {
            get { return _geschlecht; }

            set
            {
                if (value == "m" || value == "w")
                {
                    _geschlecht = value;
                }
            }
        }


        public Person(string vorname, string nachname, string geschlecht)
        {
            this.Nachname = nachname;
            this.Vorname = vorname;
            this.Geschlecht = geschlecht;
        }

    }
}
