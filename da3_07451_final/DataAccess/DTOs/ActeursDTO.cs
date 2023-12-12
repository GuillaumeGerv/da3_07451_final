using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.DataAccess.DTOs
{
    public class ActeursDTO
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public byte[] Version { get; set; }

        public ActeursDTO() { }
        public ActeursDTO(int id, string prenom, string nom, byte[] version)
        {
            this.Id = id;
            this.Prenom = prenom;
            this.Nom = nom;
            this.Version = version;
        }
        public const int MAX_PRENOM_LENGTH = 48;
        public const int MAX_NOM_LENGTH = 48;

        public virtual List<FilmsDTO> FilmsDTO { get; set; }

        public override string ToString()
        {
            return this.Id.ToString() + " - " + this.Prenom;
        }
    }
}
