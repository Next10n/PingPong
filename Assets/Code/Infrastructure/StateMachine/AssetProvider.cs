using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class AssetProvider : IAssetProvider
    {
        public T Load<T>(string path) where T : MonoBehaviour =>
            Resources.Load<T>(path);

        public GameObject Load(string path) =>
            Resources.Load<GameObject>(path);
    }
}