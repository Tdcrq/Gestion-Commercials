using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Client
    {
        private string nom_cli, rueFac, rueLiv, villeFac, villeLiv, cpFac, cpLiv, tel, fax ,email, addresseFac, addresseLiv;
        private Int32 code, numFac, numLiv;

        
        public Client(int code, string nom_cli, int numFac, string rueFac, string villeFac, string cpFac, int numLiv, string rueLiv, string villeLiv, string cpLiv, string tel, string fax, string email)
        {
            this.code = code;
            this.nom_cli = nom_cli;
            this.numFac = numFac;
            this.rueFac = rueFac;
            this.villeFac = villeFac;
            this.cpFac = cpFac;
            this.numLiv = numLiv;
            this.rueLiv = rueLiv;
            this.villeLiv = villeLiv;
            this.cpLiv = cpLiv;
            this.tel = tel;
            this.fax = fax;
            this.email = email;
            this.addresseLiv = numLiv.ToString() + "," +
                               rueLiv + "," +
                               villeLiv + "," +
                               cpLiv;
            this.addresseFac = NumFac.ToString() + "," +
                               rueFac + "," +
                               villeFac + "," +
                               cpFac;
        }

        public Client(string nom_cli, int numFac, string rueFac, string villeFac, string cpFac, int numLiv, string rueLiv, string villeLiv, string cpLiv, string tel, string fax, string email)
        {
            this.nom_cli = nom_cli;
            this.numFac = numFac;
            this.rueFac = rueFac;
            this.villeFac = villeFac;
            this.cpFac = cpFac;
            this.numLiv = numLiv;
            this.rueLiv = rueLiv;
            this.villeLiv = villeLiv;
            this.cpLiv = cpLiv;
            this.tel = tel;
            this.fax = fax;
            this.email = email;
            this.addresseLiv = numLiv.ToString() +" "+ rueLiv.ToString() +","+ villeLiv.ToString() +","+ cpLiv.ToString();
            this.addresseFac = numFac.ToString() +" "+ rueFac.ToString() +","+ villeFac.ToString() +","+ cpFac.ToString();
        }

        public Client(int code, string nom_cli)
        {
            this.code = code;
            this.nom_cli = nom_cli;
        }



        public int Code { get => code; set => code = value; }
        public string Nom_cli { get => nom_cli; set => nom_cli = value; }
        public int NumFac { get => numFac; }
        public string RueFac { get => rueFac; }
        public string VilleFac { get => villeFac; }
        public string CpFac { get => cpFac; }
        public int NumLiv { get => numLiv; }
        public string RueLiv { get => rueLiv; }
        public string VilleLiv { get => villeLiv; }
        public string CpLiv { get => cpLiv; }
        public string Tel { get => tel; set => tel = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public string AddresseFac { get => addresseFac; set => addresseFac = value;}
        public string AddresseLiv { get => addresseLiv; set => addresseLiv = value; }

        public void setNumFac(int numFac)
        {
            this.numFac = numFac;
            this.addresseFac = this.numFac.ToString() + "," + this.RueFac + ", " + this.villeFac + ", " + this.CpFac;
        }
        public void setNumLiv(int numLiv)
        {
            this.numLiv = numLiv;
            this.addresseLiv = this.numLiv.ToString() + "," + this.RueLiv + ", " + this.villeLiv + ", " + this.CpLiv;
        }
        public void setRueFac(string rueFac)
        {
            this.rueFac = rueFac;
            this.addresseFac = this.numFac.ToString() + "," + this.RueFac + ", " + this.villeFac + ", " + this.CpFac;
        }
        public void setRueLiv(string rueLiv)
        {
            this.rueLiv = rueLiv;
            this.addresseLiv = this.numLiv.ToString() + "," + this.RueLiv + ", " + this.villeLiv + ", " + this.CpLiv;
        }
        public void setVilleFac(string villeFac)
        {
            this.villeFac = rueFac;
            this.addresseFac = this.numFac.ToString() + "," + this.RueFac + ", " + this.villeFac + ", " + this.CpFac;
        }
        public void setVilleLiv(string villeLiv)
        {
            this.villeLiv = villeLiv;
            this.addresseLiv = this.numLiv.ToString() + "," + this.RueLiv + ", " + this.villeLiv + ", " + this.CpLiv;
        }
        public void setCpFac(string cpFac)
        {
            this.cpFac = cpFac;
            this.addresseFac = this.numFac.ToString() + "," + this.RueFac + ", " + this.villeFac + ", " + this.CpFac;
        }
        public void setCpLiv(string cpLiv)
        {
            this.cpLiv = cpLiv;
            this.addresseLiv = this.numLiv.ToString() + "," + this.RueLiv + ", " + this.villeLiv + ", " + this.CpLiv;
        }
    }
}
