using Code.Player.Code;
using UnityEngine;
using Code.Player.Interface;


namespace Code.Player
{
    public sealed class UnitFactory : IUnitFactory
    {
        private float _playerSpeed = 2.0f;
        private IPlayerController _controller;
        public UnitClass Create(Health hp, Vector3 position)
        {
            var player = Object.Instantiate(Resources.Load<PlayerView>("Prefab/PlayerPrefab"));
            player.transform.position = position;
            player.DependencyHp(hp);
            _controller = new PlayerController(player,new PlayerModel(_playerSpeed));
            return player;
        }

        public void OnUpdate()
        {
            _controller.Move();
        }
    }
}