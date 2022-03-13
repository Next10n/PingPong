using UnityEngine;

namespace Code.Core.Balls
{
    public interface IGameFactory
    {
        Ball Ball { get; }
        Ball CreateBall();
        GameObject CreateHud();
    }
}