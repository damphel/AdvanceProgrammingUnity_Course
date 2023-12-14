using UnityEngine;

namespace Course.InterfacesYGenerics
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Chest");
        }
    }
}
