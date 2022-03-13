using System;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure
{
    public class SceneLoader : ISceneLoader
    {
        public void Load(string scene, Action onLoaded)
        {
            SceneManager.LoadScene(scene);
            onLoaded?.Invoke();
        }
    }
}