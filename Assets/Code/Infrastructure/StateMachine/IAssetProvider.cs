using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public interface IAssetProvider
    {
        T Load<T>(string path) where T : MonoBehaviour;
        GameObject Load(string path);
    }
}