using UnityEngine.SceneManagement;

namespace Code.Infrastructure
{
    public class SceneLoader : ISceneLoader
    {
        public void Load(string scene) =>
            SceneManager.LoadScene(scene);
    }
}