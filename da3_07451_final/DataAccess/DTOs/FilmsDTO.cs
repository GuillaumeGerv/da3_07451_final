using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.DataAccess.DTOs
{
    public class FilmsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Annee { get; set; }
        public byte[] Version { get; set; }

        public FilmsDTO() { }

        public FilmsDTO(int id, string title, int annee, byte[] version) {
            this.Id = id;
            this.Title = title;
            this.Annee = annee;
            this.Version = version;
        
        }
        public const int MAX_TITLE_LENGTH = 128;

        public virtual List<ActeursDTO> ActeursDTO { get; set; }

        public override string ToString()
        {
            return this.Id.ToString() + " - " + this.Title;
        }
    }
}
