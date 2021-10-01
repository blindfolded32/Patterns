using Code.Player.Code;
using UnityEngine;

namespace Code.Player
{
    public abstract class UnitClass : MonoBehaviour
    {
        public static IUnitFactory Factory;
        public static PlayerView PlayerView;
        private Health Health { get; set; }

        public static PlayerView CreatePlayer(Health hp, Vector3 position)
        {
            var player = (Resources.Load<PlayerView>("Prefab/PlayerPrefab"));
            player.Health = hp;
            return player;
        }
        public void DependencyHp(Health hp) => Health = hp;
    }
}