using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.DataAccess.Pivots
{
    public class ActeurFilm
    {
        public int ActeursId { get; set; }
        public int FilmsId { get; set; }

        public ActeurFilm() {}

        public ActeurFilm(int acteurId, int filmId) { 
            this.ActeursId = acteurId;
            this.FilmsId = filmId;        
        }
    }
}
