using System;
using System.Collections.Generic;
using Code.Services;

namespace Code.Infrastructure.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;

        private IState _activeState;
        
        public GameStateMachine(IBallFactory ballFactory, IScoreService scoreService)
        {
            _states = new Dictionary<Type, IState> 
            {
                [typeof(StartGameState)] = new StartGameState(ballFactory),
                [typeof(RespawnBallState)] = new RespawnBallState(ballFactory, scoreService),
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