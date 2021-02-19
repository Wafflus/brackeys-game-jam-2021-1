using UnityEngine;
using UnityEngine.SceneManagement;

namespace Artistas
{
    [CreateAssetMenu(fileName = "New Main Menu Actions", menuName = "Artistas/Main Menu/New Main Menu Actions")]
    public class MainMenuActionsSO : ScriptableObject
    {
        public void Play()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}