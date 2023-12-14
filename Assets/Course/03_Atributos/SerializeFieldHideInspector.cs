 using UnityEngine;

namespace Course.Atributos
{
    public class SerializeFieldHideInspector : MonoBehaviour
    {
        [SerializeField]
        private bool canShoot;

        [HideInInspector]
        public bool canRun;
    }
}
