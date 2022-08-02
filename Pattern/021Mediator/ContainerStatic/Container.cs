using System;
using System.Collections.Generic;

namespace ContainerStatic
{
    class Container
    {
        Dictionary<Type, Object> dic;
        private static Container instance;
        public static Container Instance
            => instance ??= new Container();
                  
        private Container() => dic = new();

        public void Register<T, U>()
            where U : T, new() => dic.Add(typeof(T), new U());
         
        public T Extract<T>() => (T)dic[typeof(T)];
        public void Unregister<T>() => dic.Remove(typeof(T));
    }
}
