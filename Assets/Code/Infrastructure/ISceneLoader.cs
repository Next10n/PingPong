using System;

namespace Code.Infrastructure
{
    public interface ISceneLoader
    {
        void Load(string scene, Action onLoaded = null);
    }
}