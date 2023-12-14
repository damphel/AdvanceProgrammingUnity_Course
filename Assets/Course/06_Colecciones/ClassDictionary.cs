using System.Collections.Generic;
using UnityEngine;

namespace Course.Colecciones
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")]
        public Dictionary<string, GameObject> characterDictionary;

        private void Start()
        {
            // Init
            characterDictionary = new Dictionary<string, GameObject>();

            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]);
            }

            // Remove
            characterDictionary.Remove("Orc");

            // Contains
            bool contains = characterDictionary.ContainsKey("Orc");

            // Read
            GameObject myValue = characterDictionary["Orc"];

            // Amount
            int amount = characterDictionary.Count;

            // Clear
            characterDictionary.Clear();
        }

    }
}
