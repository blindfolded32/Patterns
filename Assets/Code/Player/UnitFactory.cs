using Code.Player.Code;
using UnityEngine;
using Code.Player.Interface;


namespace Code.Player
{
    public sealed class UnitFactory : IUnitFactory
    {
        public UnitClass Create(Health hp, Vector3 position)
        {
            if(!Resources.Load<PlayerController>("C:/Users/1/Documents/Unity Rep/HW_Terrain/Patterns/Assets/Resources/Prefab/PlayerPrefab.prefab")) Debug.Log("NOOOO");
            
            var player = Object.Instantiate(Resources.Load<PlayerController>("Prefab/PlayerPrefab"));
            player.transform.position = position;

            player.DependencyHP(hp);

            return player;
        }
    }
}