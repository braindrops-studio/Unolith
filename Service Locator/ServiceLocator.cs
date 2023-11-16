using System;
using System.Collections.Generic;
using UnityEngine;

namespace Braindrops.Unolith.ServiceLocator
{
    public class ServiceLocator
    {
        private ServiceLocator() {}

        private readonly Dictionary<string, GameService> services = new Dictionary<string, GameService>();
        
        public static ServiceLocator Instance { get; private set; }

        public static void Initialize()
        {
            Instance = new ServiceLocator();
        }

        public T GetService<T>() where T : GameService
        {
            string key = typeof(T).Name;

            if (services.ContainsKey(key) == false)
            {
                Debug.LogError($"{key} not registered with {GetType().Name}");
                throw new InvalidOperationException();
            }

            return (T)services[key];
        }

        public void Register<T>(T service) where T : GameService
        {
            var key = typeof(T).Name;

            if (services.TryAdd(key, service))
                Debug.Log($"Registering Service: Service {key} added!");
            else
                Debug.LogWarning($"Registering Service: Service {key} already exists!");
        }

        public void Unregister<T>() where T : GameService
        {
            string key = typeof(T).Name;
            if (services.ContainsKey(key) == false)
                Debug.LogError($"Could not unregister service {key} since it's not registered!");

            services.Remove(key);
        }
    }
}