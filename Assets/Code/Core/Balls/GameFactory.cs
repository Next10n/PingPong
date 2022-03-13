using Code.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Core.Balls
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly DiContainer _container;
        
        public GameFactory(IAssetProvider assetProvider, DiContainer container)
        {
            _assetProvider = assetProvider;
            _container = container;
        }

        public Ball Ball { get; private set; }

        public Ball CreateBall()
        {
            Ball asset = _assetProvider.Load<Ball>(AssetPaths.BallPath);
            Ball = _container.InstantiatePrefab(asset).GetComponent<Ball>();
            return Ball;
        }
        
        public GameObject CreateHud()
        {
            GameObject asset = _assetProvider.Load(AssetPaths.HudPath);
            return _container.InstantiatePrefab(asset);
        }

    }
}