using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Lever");
        }
    }
}
