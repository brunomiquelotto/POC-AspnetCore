using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Services
{
    public class Pagination<T> where T : class
    {
        private IList<T> _list;
        public Pagination(IList<T> list)
        {
            _list = list;
        }

        public Pagination<TOut> Transform<TOut>(Func<T, TOut> transform) where TOut : class
        {
            IList<TOut> results = _list.Select(transform).ToList();
            return new Pagination<TOut>(results);
        }

        public IList<T> Value()
        {
            return _list;
        }
    }
}