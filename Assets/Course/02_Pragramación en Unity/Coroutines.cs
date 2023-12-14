using System.Collections;
using UnityEngine;

namespace Course.ProgramacionUnity
{
    public class Coroutines : MonoBehaviour
    {
        private void Start()
        {
            #region Start

            StartCoroutine(CallCorroutine());

            StartCoroutine("CallCoroutine");

            Coroutine myCoroutine;
            myCoroutine = StartCoroutine(CallCorroutine());

            #endregion

            #region Stop

            StopCoroutine(CallCorroutine());

            StopCoroutine("CallCoroutine");

            StopCoroutine(myCoroutine);

            StopAllCoroutines();

            #endregion

            #region Parameters

            StartCoroutine(CallCorroutineWithParams(2.5f, 100, "test"));

            Coroutine myNewCoroutine;
            myCoroutine = StartCoroutine(CallCorroutineWithParams(2.5f, 100, "test"));

            #endregion

        }

        private IEnumerator CallCorroutine()
        {
            yield return null;
        }

        private IEnumerator CallCorroutineWithParams(float myFloat, int myInt, string myString)
        {
            yield return null;
        }
    }
}
