using Code.Infrastructure.StateMachine;
using Zenject;

namespace Code.Infrastructure
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
            Container.Bind<IBallFactory>().To<BallFactory>().AsSingle();
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        }
    }
}
