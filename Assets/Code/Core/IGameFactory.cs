using UnityEngine;

namespace Code.Core
{
    public interface IGameFactory
    {
        Ball Ball { get; }
        Ball CreateBall();
        GameObject CreateHud();
    }
}