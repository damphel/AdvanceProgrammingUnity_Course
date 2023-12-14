using UnityEngine;

namespace Course.Atributos
{
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
    public class RequiredComponent : MonoBehaviour
    {
        private BoxCollider boxCollider;
        private Rigidbody rigidbody;

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            boxCollider.enabled = true;
            rigidbody.isKinematic = false;
        }

    }
}
