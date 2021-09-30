using Code.Player.Code;
using Code.Player.Interface;
using UnityEngine;

namespace Code.Player
{
    public abstract class UnitClass:MonoBehaviour
    {
        public static IUnitFactory Factory;
        public static PlayerController PlayerController;
        
        private static float _playerSpeed = 2.0f;
        public Health Health { get; private set; }

        public static PlayerController CreatePlayer(Health HP, Vector3 position)
        {
            Debug.Log($"in {position} and {HP.MaxHP} with {HP.CurrentHP}");
            
            var player = (Resources.Load<PlayerController>("Prefab/PlayerPrefab"));
           
        //    player.Health = HP;
       //     PlayerController = new PlayerController(FindObjectOfType<PlayerView>(),new PlayerModel(_playerSpeed), position);
            
           
            return player;
        }

        public void DependencyHP(Health hp) => Health = hp;
    }
}