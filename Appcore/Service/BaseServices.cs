using Appcore.IServices;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Service
{
    public abstract class BaseServices<T> : IServices<T>
    {
        private IModel<T> Model;

        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }


        public void Add(T t, T g)
        {
            Model.Add(t, g);
        }

        public string Read(T t)
        {
            
            return Model.Read(t);
        }
    }
}
