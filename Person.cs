using Personenliste2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenliste2
{
    /// <summary>
    /// Creates a person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Sets and gets the firstname
        /// </summary>
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
        /// <summary>
        /// sets and gets the surname
        /// </summary>
        private string _nachname = "";

        public string Nachname
        {
            get { return _nachname; }
            set
            {
               _nachname = value;
            }
        }
        /// <summary>
        /// gets and sets the sex
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vorname">sets the firstname of the person</param>
        /// <param name="nachname">sets the surname of the person</param>
        /// <param name="geschlecht">sets the sex of the person</param>
        public Person(string vorname, string nachname, string geschlecht)
        {
            this.Nachname = nachname;
            this.Vorname = vorname;
            this.Geschlecht = geschlecht;
        }

    }
}
