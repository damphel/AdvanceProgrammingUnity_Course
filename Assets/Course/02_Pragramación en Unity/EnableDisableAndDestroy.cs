using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class EnableDisableAndDestroy : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable");
        }

        private void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
    }
}
