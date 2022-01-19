using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DodatnaNaloga.Models;

namespace DodatnaNaloga.Services
{
    public class KnjigaService
    {
        public KnjigarnaContext Db = new KnjigarnaContext();

        public Task PostKnjiga(string tit, string date)
        {
            return Task.Run(() =>
            {
                Knjiga k1 = new Knjiga(tit, date);

                Db.knjige.Add(k1);
                Db.SaveChanges();
            });
        }

        public Task DeleteKnjiga(int Id)
        {
            return Task.Run(() =>
            {
                Knjiga a1 = (Knjiga)Db.knjige.Single(x => x.Id == Id);

                Db.knjige.Remove(a1);
                Db.SaveChanges();
            });
        }


    }
}
