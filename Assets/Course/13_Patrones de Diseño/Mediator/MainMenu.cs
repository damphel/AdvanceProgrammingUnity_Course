using UnityEngine;
using UnityEngine.UI;

namespace Course.PatronesDiseno.Mediator
{
    public class MainMenu : Menu
    {
        public Button playBtn;
        public Button settingsBtn;
        public Button exitBtn;

        public override void Show() { }
        public override void Hide() { }

        private void Start()
        {
            playBtn.onClick.AddListener(() => mediator.GoToPlay());
            settingsBtn.onClick.AddListener(() => mediator.GoToSettings());
            exitBtn.onClick.AddListener(() => mediator.GoToExit());
        }

    }
}
