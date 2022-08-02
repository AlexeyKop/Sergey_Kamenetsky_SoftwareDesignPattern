using System;
using System.Collections.Generic;

namespace ContainerInstances
{
    class Container
    {
        private static Container instance;
        Dictionary<Type, Object> dic;

        public static Container Instance
            => instance ??= new Container();

        private Container() => dic = new();
        public void Register<T>(T obj) => dic.Add(typeof(T), obj);
        public T Extract<T>() => (T)dic[typeof(T)];
        public bool Unregister<T>() => dic.Remove(typeof(T));
    }
}
