using DodatnaNaloga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Services
{
    public class StrankaService
    {
        public KnjigarnaContext Db = new KnjigarnaContext();
        public Task PostStranka(string nam, int age)
        {
            return Task.Run(() =>
            {
                Stranka s1 = new Stranka(nam, age);

                Db.stranke.Add(s1);
                Db.SaveChanges();
            });
        }

        public Task DeleteStranka(int id)
        {
            return Task.Run(() =>
            {
                Stranka s1 = (Stranka)Db.stranke.Single(x => x.Id == id);

                Db.stranke.Remove(s1);
                Db.SaveChanges();
            });
        }

    }
}
