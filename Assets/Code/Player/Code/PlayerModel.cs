using Code.Player.Interface;
using UnityEngine;

namespace Code.Player.Code
{
    public struct PlayerModel : IPlayerModel
    {
        public int HP { get; set; }
        public float Speed { get; set; }

        public PlayerModel(float speed) : this() => Speed = speed;
    }
}