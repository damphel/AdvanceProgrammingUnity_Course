using System.Collections.Generic;
using UnityEngine;

namespace Course.Colecciones
{
    public class ClassQueue : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;
        

        private void Start()
        {
            // Init
            playerQueue = new Queue<GameObject>();

            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]);
            }

            // Remove
            GameObject myGameObject = playerQueue.Dequeue();

            // Contains
            bool contains = playerQueue.Contains(myGameObject);

            // Amount
            int amount = playerQueue.Count;

            // Clear
            playerQueue.Clear();
        }
    }
}
