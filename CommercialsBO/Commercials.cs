using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Commercial
    {

        private string code;
        private string identifiant;
        private string mdp;
        private bool verif = false;

        public Commercial(string code, string identifiant, string mdp)
        {
            this.code = code;
            this.identifiant = identifiant;
            this.mdp = mdp;
        }

        public Commercial(string identifiant, string mdp)
        {
            this.identifiant = identifiant;
            this.mdp = mdp;
        }

        public string GetCode()
        {
            return code;
        }
        public void SetCode(string code)
        {
            this.code = code;
        }

        public string GetIdentifiant()
        {
            return identifiant;
        }
        public void SetIdentifiant(string identifiant)
        {
            this.identifiant= identifiant;
        }

        public string GetMdp()
        {
            return mdp;
        }
        public void SetMdp(string mdp)
        {
            this.mdp= mdp;
        }

        public bool GetVerif()
        {
            return verif;
        }
        public void SetVerif(bool verif)
        {
            this.verif = verif;
        }
    }
}
