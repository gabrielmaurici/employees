using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository <T> where T : Base
    {
        public virtual void Create(T model)
        {
            using (var context = new EmployeesContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<T> Read()
        {
            List<T> Lista = new List<T>();
            using (var context = new EmployeesContext())
            {
                Lista = context.Set<T>().ToList();
            }
            return Lista;
        }
        public virtual T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new EmployeesContext())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public virtual void Update(T model)
        {
            using (var context = new EmployeesContext())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new EmployeesContext())
            {
                context.Entry<T>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
