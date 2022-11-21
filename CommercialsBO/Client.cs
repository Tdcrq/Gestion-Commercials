using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Client
    {
        private string nom_cli, rueFac, rueLiv, villeFac, villeLiv, cpFac, cpLiv, tel, fax ,email;
        private Int32 code, numFac, numLiv;

        
        public Client(int code, string nom_cli, int numFac, string rueFac, string villeFac, string cpFac, string villeLiv, string cpLiv, string tel, string fax, string email)
        {
            this.code = code;
            this.nom_cli = nom_cli;
            this.numFac = numFac;
            this.rueFac = rueFac;
            this.villeFac = villeFac;
            this.cpFac = cpFac;
            this.numFac = numLiv;
            this.rueFac = rueLiv;
            this.villeFac = villeLiv;
            this.cpLiv = cpLiv;
            this.tel = tel;
            this.fax = fax;
            this.email = email;
        }

        public Client(string nom_cli, int numFac, string rueFac, string villeFac, string cpFac, string villeLiv, string cpLiv, string tel, string fax, string email)
        {
            this.nom_cli = nom_cli;
            this.numFac = numFac;
            this.rueFac = rueFac;
            this.villeFac = villeFac;
            this.cpFac = cpFac;
            this.numFac = numLiv;
            this.rueFac = rueLiv;
            this.villeFac = villeLiv;
            this.cpLiv = cpLiv;
            this.tel = tel;
            this.fax = fax;
            this.email = email;
        }

        public string Nom_cli { get => nom_cli; set => nom_cli = value; }
        public string RueFac { get => rueFac; set => rueFac = value; }
        public string RueLivr { get => rueLiv; set => rueLiv = value; }
        public string VilleFac { get => villeFac; set => villeFac = value; }
        public string VilleLivr { get => villeLiv; set => villeLiv = value; }
        public string CpFac { get => cpFac; set => cpFac = value; }
        public string CpLivr { get => cpLiv; set => cpLiv = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public int Code { get => code; set => code = value; }
        public int NumFac { get => numFac; set => numFac = value; }
        public int NumLivr { get => numLiv; set => numLiv = value; }
    }
}
