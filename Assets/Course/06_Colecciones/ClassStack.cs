using System.Collections.Generic;
using UnityEngine;

namespace Course.Colecciones
{
    public class ClassStack : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardsStack;

        private void Start()
        {
            // Init
            cardsStack = new Stack<GameObject>();

            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                cardsStack.Push(myContent[i]);
            }

            // Return First and Remove
            GameObject myGameObjectPop = cardsStack.Pop();

            // Return First
            GameObject myGameObjectPeek = cardsStack.Peek();

            // Contains
            bool contains = cardsStack.Contains(myGameObjectPeek);

            // Amount
            int amount = cardsStack.Count;

            // Clear
            cardsStack.Clear();
        }
    }
}
