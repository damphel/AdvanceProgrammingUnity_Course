using UnityEngine;
using Course.PatronesDiseno.Adapter;

namespace Course.PatronesDiseno
{
    public class GameManager : MonoBehaviour
    {
        private SaveSystem saveSystem;

        private void Start()
        {
            saveSystem = new SaveSystem( new PlayerPrefsAdapter() );
        }
    }
}
