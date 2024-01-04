using System;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseno.ServiceLocator
{
    public class GameServiceLocator : MonoBehaviour
    {
        #region Singleton

        private static GameServiceLocator _instance;
        public static GameServiceLocator Instance
        {
            get
            {
                if (!_instance)
                {
                    Debug.LogWarningFormat("Accesing {0} before its Awake phase", typeof(GameServiceLocator).Name);
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null && _instance != this || FindObjectsOfType<GameServiceLocator>().Length > 1)
            {
                Debug.LogWarningFormat("Please make sure there is only one {0} in the scene", typeof(GameServiceLocator).Name);
                Destroy(this);
                return;
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion

        private Dictionary<Type, object> _services;

        public void RegisterService<T> (T service)
        {
            var type = typeof(T);

            if (!_services.ContainsKey(type))
            {
                _services.Add(type, service);
            }
        }

        public T GetService<T>()
        {
            var type = typeof(T);

            if (!_services.TryGetValue(type, out var service))
            {
                throw new Exception($"Service {type} not found");
            }

            return (T)service;
        }


    }
}
