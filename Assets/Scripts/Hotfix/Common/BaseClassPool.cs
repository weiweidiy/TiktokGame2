using MackySoft.XPool;
using System;
using System.Collections.Generic;

namespace JFrame
{
    /// <summary>
    /// 普通类的对象池
    /// </summary>
    public abstract class BaseClassPool
    {
        Dictionary<string, object> factories = new Dictionary<string, object>();

        public abstract void Initialize();

        protected void Regist<T>(Action<T> onRent = null, Action<T> onReturn = null, Action<T> onRelease = null) where T : class, new()
        {
            var pool = new FactoryPool<T>(10, () => new T(), onRent, onReturn, onRelease);
            factories.Add(typeof(T).ToString(), pool);
        }


        public T Rent<T>() where T : class
        {
            var pool = GetPool<T>();
           
            return pool.Rent();
        }

        public void Return<T>(T instance) where T : class
        {
            var pool = GetPool<T>();
            pool.Return(instance);
        }

        private FactoryPool<T> GetPool<T>() where T : class
        {
            return factories[typeof(T).ToString()] as FactoryPool<T>;
        }
    }

}

