using System;

namespace Projeto.Services
{
    public class ServiceResponse<T> where T : class
    {
        private T _value;

        public ServiceResponse(T value)
        {
            _value = value;
        }

        public T Get()
        {
            return _value;
        }

        public ServiceResponse<TOut> Transform<TOut>(Func<T, TOut> transformation) where TOut : class
        {
            return new ServiceResponse<TOut>(transformation(_value));
        }
    }
}