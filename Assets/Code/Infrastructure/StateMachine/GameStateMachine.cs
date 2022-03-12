using System;
using System.Collections.Generic;

namespace Code.Infrastructure.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly Dictionary<Type, IState> _states;

        private IState _activeState;
        
        public GameStateMachine()
        {
            _states = new Dictionary<Type, IState> 
            {
                [typeof(StartGameState)] = new StartGameState(new AssetProvider())
            };
        }

        public void Enter<TState>() where TState : IState
        {
            _activeState?.Exit();
            _activeState = _states[typeof(TState)];
            _activeState.Enter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadState<TPayload>
        {
            _activeState?.Exit();
            TState payloadState = _states[typeof(TState)] as TState;
            payloadState.Enter(payload);
            _activeState = payloadState;
        }
    }
}