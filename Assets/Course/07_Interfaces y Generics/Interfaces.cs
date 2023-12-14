using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public interface IInteractable
    {
        void Interact();
    }

    public class Interfaces : MonoBehaviour
    {
        public GameObject[] myInteractables;

        private void Start()
        {
            for (int i = 0; i < myInteractables.Length; i++)
            {
                IInteractable myInteractable = myInteractables[i].GetComponent<IInteractable>();
                myInteractable?.Interact();
            }
        }
    }
}
