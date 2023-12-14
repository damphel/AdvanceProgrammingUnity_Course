using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class UpdateLateAndFixed : MonoBehaviour
    {
        private void FixedUpdate()
        {
            Debug.Log("FixedUpdate");
        }

        private void Update()
        {
            Debug.Log("Update");
        }

        private void LateUpdate()
        {
            Debug.Log("LateUpdate");
        }
    }
}
