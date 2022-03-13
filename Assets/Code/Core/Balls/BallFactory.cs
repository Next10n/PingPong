using Code.AssetManagement;
using UnityEngine;

namespace Code.Core.Balls
{
    public class BallFactory : IBallFactory
    {
        private readonly IAssetProvider _assetProvider;

        public BallFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public Ball Ball { get; private set; }

        public Ball Create()
        {
            Ball asset = _assetProvider.Load<Ball>(AssetPaths.BallPath);
            Ball = Object.Instantiate(asset);
            return Ball;
        }
    }
}