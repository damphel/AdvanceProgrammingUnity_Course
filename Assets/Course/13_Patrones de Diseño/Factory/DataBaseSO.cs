using System;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseno.Factory
{
    [CreateAssetMenu(fileName = "New DataBase", menuName = "ScriptableObjects/DataBase", order = 0)]
    public class DataBaseSO : ScriptableObject
    {
        public DataSO[] dataArray;

        private Dictionary<string, DataSO> dataDictionary;

        private void Awake()
        {
            dataDictionary = new Dictionary<string, DataSO>(dataArray.Length);

            //Debug.Log($"DataBase '{name}' Awake!");

            if (dataArray.Length == 0) return;

            foreach (var data in dataArray)
            {
                dataDictionary.Add(data.id, data);
            }
        }

        public DataSO GetData(string id)
        {
            if (!dataDictionary.TryGetValue(id, out var data))
            {
                throw new Exception($"Can't find Data with id {id}");
            }

            return data;
        }

        public T GetData<T>(string id)
        {
            if (!dataDictionary.TryGetValue(id, out var data))
            {
                throw new Exception($"Can't find Data with id {id}");
            }

            T dataGeneric = (T)Convert.ChangeType(data, typeof(T));

            if (dataGeneric == null)
            {
                throw new Exception($"Can't convert Data to type {typeof(T)}");
            }

            return dataGeneric;
        }
    }
}
