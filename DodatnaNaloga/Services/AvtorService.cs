using DodatnaNaloga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Services
{
    public class AvtorService
    {
        public KnjigarnaContext Db = new KnjigarnaContext();

        public Task PostAvtor(string nam, int age, string date, int rating)
        {
            return Task.Run(() =>
            {
                Avtor a1 = new Avtor(nam, age, date, rating);

                Db.avtorji.Add(a1);
                Db.SaveChanges();
            });
        }

        public Task DeleteAvtor(int id)
        {
            return Task.Run(() =>
            {
                Avtor a1 = (Avtor)Db.avtorji.Single(x => x.Id == id);

                Db.avtorji.Remove(a1);
                Db.SaveChanges();
            });
        }

        public Task<Avtor> GetAvtor(int id,Avtor a)
        {
            return (Task<Avtor>)Task.Run(() =>
            {
                    a = (Avtor)Db.avtorji.Single(x => x.Id == id);
            });
        }
    }
}
