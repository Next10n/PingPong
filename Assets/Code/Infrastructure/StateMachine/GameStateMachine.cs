using System;
using System.Collections.Generic;
using Code.Core;
using Code.Progress;
using Code.SaveLoad;
using Code.Services;
using Code.Services.Score;

namespace Code.Infrastructure.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;

        private IState _activeState;
        
        public GameStateMachine(
            IGameFactory gameFactory,
            IScoreService scoreService,
            IPlayerProgressService progressService,
            ISaveLoadService saveLoadService,
            ISceneLoader sceneLoader)
        {
            _states = new Dictionary<Type, IState> 
            {
                [typeof(BootstrapState)] = new BootstrapState(progressService, saveLoadService, sceneLoader),
                [typeof(StartGameState)] = new StartGameState(gameFactory, sceneLoader),
                [typeof(RespawnBallState)] = new RespawnBallState(gameFactory, scoreService),
                [typeof(QuitGameState)] = new QuitGameState(saveLoadService)
            };
        }

        public void Enter<TState>() where TState : IState
        {
            _activeState = _states[typeof(TState)];
            _activeState.Enter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadState<TPayload>
        {
            TState payloadState = _states[typeof(TState)] as TState;
            payloadState.Enter(payload);
            _activeState = payloadState;
        }
    }
}