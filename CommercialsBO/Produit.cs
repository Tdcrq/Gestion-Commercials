using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialsBO
{
    public class Produit
    {
        private int id;
        private string label;
        private float prix;
        private int idCateg;

        public Produit(int id, string label, float prix, int idCateg)
        {
            this.id = id;
            this.label = label;
            this.prix = prix;
            this.idCateg = idCateg;
        }

        public string Label { get => label; set => label = value; }
        public float Prix { get => prix; set => prix = value; }
        public int IdCateg { get => idCateg; set => idCateg = value; }
        public int Id { get => id; set => id = value; }
    }
}
