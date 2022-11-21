using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    internal class Client
    {
        private string nom_cli, rueFac, rueLivr, villeFac, villeLivr, cpFac, cpLivr, tel, fax ,email;
        private Int32 numFac, numLivr;

        public Client(string nom_cli, string rueFac, string rueLivr, string villeFac, string villeLivr, string cpFac, string cpLivr, string tel, string fax, string email, int numFac, int numLivr)
        {
            this.nom_cli = nom_cli;
            this.rueFac = rueFac;
            this.rueLivr = rueLivr;
            this.villeFac = villeFac;
            this.villeLivr = villeLivr;
            this.cpFac = cpFac;
            this.cpLivr = cpLivr;
            this.tel = tel;
            this.fax = fax;
            this.email = email;
            this.numFac = numFac;
            this.numLivr = numLivr;
        }

        public string Nom_cli { get => nom_cli; set => nom_cli = value; }
        public string RueFac { get => rueFac; set => rueFac = value; }
        public string RueLivr { get => rueLivr; set => rueLivr = value; }
        public string VilleFac { get => villeFac; set => villeFac = value; }
        public string VilleLivr { get => villeLivr; set => villeLivr = value; }
        public string CpFac { get => cpFac; set => cpFac = value; }
        public string CpLivr { get => cpLivr; set => cpLivr = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public int NumFac { get => numFac; set => numFac = value; }
        public int NumLivr { get => numLivr; set => numLivr = value; }
    }
}
