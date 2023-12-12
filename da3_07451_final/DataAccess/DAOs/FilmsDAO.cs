using da3_07451_final.DataAccess.Context;
using da3_07451_final.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da3_07451_final.DataAccess.DAOs
{
    internal class FilmsDAO
    {
        private ContextAppDataBase Context { get; set; }

        public FilmsDAO(ContextAppDataBase context)
        {
            Context = context;
        }

        public FilmsDTO? GetById(int id)
        {
            return this.Context?.Films.Include(film => film.ActeursDTO).FirstOrDefault(x => x.Id == id);
        }
        public List<FilmsDTO> GetAll()
        {
            return this.Context.Films.Include(film => film.ActeursDTO).ToList();
        }
        public FilmsDTO Create(FilmsDTO film)
        {
            this.Context.Films.Add(film);
            this.Context.SaveChanges();
            return film;
        }
        public FilmsDTO Update(FilmsDTO film)
        {
            this.Context.Films.Update(film);
            this.Context.SaveChanges();
            return film;
        }
        public FilmsDTO Delete(FilmsDTO film)
        {
            this.Context.Films.Remove(film);
            this.Context.SaveChanges();
            return film;
        }
    }
}
