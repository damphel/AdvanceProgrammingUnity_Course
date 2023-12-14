using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class CollisionVsTrigger : MonoBehaviour
    {
        #region Collision

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Collision ENTER");
        }

        private void OnCollisionStay(Collision collision)
        {
            Debug.Log("Collision STAY");
        }

        private void OnCollisionExit(Collision collision)
        {
            Debug.Log("Collision EXIT");
        }

        #endregion

        #region Trigger

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger ENTER");
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Trigger STAY");
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Trigger EXIT");
        }

        #endregion

    }
}
