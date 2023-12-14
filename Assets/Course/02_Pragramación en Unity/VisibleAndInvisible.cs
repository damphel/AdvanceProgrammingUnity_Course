 using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class VisibleAndInvisible : MonoBehaviour
    {
        private void OnBecameVisible()
        {
            Debug.Log("VISIBLE");
        }

        private void OnBecameInvisible()
        {
            Debug.Log("INVISIBLE");
        }

    }
}
