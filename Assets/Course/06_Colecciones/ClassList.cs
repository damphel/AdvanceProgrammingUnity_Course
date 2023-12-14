using System.Collections.Generic;
using UnityEngine;

namespace Course.Colecciones
{
    public class ClassList : MonoBehaviour
    {
        [Header("Content")]
        public int[] myContent;

        [Header("List")]
        public List<int> weaponsList;

        private void Start()
        {
            // Init
            weaponsList = new List<int>();

            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                weaponsList.Add(myContent[i]);
            }

            weaponsList.AddRange(myContent);

            // Remove
            weaponsList.Remove(myContent[2]);

            // Read
            int tempValue = weaponsList[2];

            // Amount
            int amount = weaponsList.Count;

            // Clear
            weaponsList.Clear();
        }

    }
}
