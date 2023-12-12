using da3_07451_final.DataAccess.Context;
using da3_07451_final.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.DataAccess.DAOs
{
    internal class ActeursDAO
    {
        public ContextAppDataBase Context { get; set; }

        public ActeursDAO(ContextAppDataBase context) 
        {
            Context = context;
        }
        public List<ActeursDTO> GetAll()
        {
            return this.Context.Acteurs.ToList();
        }

    }
}
