using UnityEngine;

namespace Course.PatronesDiseno.Singleton
{
    public class PlayerPrefsAdapter : MonoBehaviour, IDataSaver
    {
        #region Singleton

        private static PlayerPrefsAdapter _instance;
        public static PlayerPrefsAdapter Instance
        {
            get
            {
                if (!_instance)
                {
                    Debug.LogWarningFormat("Accesing {0} before its Awake phase", typeof(PlayerPrefsAdapter).Name);
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null && _instance != this || FindObjectsOfType<PlayerPrefsAdapter>().Length > 1)
            {
                Debug.LogWarningFormat("Please make sure there is only one {0} in the scene", typeof(PlayerPrefsAdapter).Name);
                Destroy(this);
                return;
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion

        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        public string GetString(string key, string defaultValue)
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }

        public int GetInt(string key, int defaultValue)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }

    }
}
