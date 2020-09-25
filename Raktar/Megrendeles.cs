using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktar
{
    class Megrendeles
    {
        private string sortipus;
        public string SORTIPUS
        {
            get { return sortipus; }
            set { sortipus = value; }
        }
        private string datum;
        public string DATUM
        {
                get { return datum; }
                set { datum = value; }
        }

        private string rendelesszam;
        public string RENDELESSZAM
        {
            get { return rendelesszam; }
            set { rendelesszam = value; }
        }

        private string email;
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        public List<string> termekek;

        public Megrendeles(string datum, string rendelesszam, string email)
        {
            this.datum = datum;
            this.rendelesszam = rendelesszam;
            this.email = email;
            termekek = new List<string>();
        }
    }
}
