using UnityEngine;

namespace Course.PatronesDiseno.ServiceLocator
{
    public class GameServiceInstaller : MonoBehaviour
    {
        public PlayerPrefsAdapter saveSystem;

        private void Awake()
        {
            GameServiceLocator.Instance.RegisterService<IDataSaver>(saveSystem);
        }
    }
}
