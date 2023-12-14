using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Door : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Door");
        }
    }
}
