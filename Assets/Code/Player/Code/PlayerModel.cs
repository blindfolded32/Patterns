using Code.Player.Interface;
using UnityEngine;

namespace Code.Player.Code
{
    public struct PlayerModel : IPlayerModel
    {
        public float Speed { get; private set; }
        public PlayerModel(float speed) : this() => Speed = speed;
    }
}