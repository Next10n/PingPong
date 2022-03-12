using System;
using Code.Infrastructure.StateMachine;
using UnityEngine;

namespace Code.Core
{
    public class Gate : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            _gameStateMachine.Enter<StartGameState>();
        }
    }
}
