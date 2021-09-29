using Code.Player.Interface;
using UnityEngine;

namespace Code.Player.Code
{
    public class PlayerController : IPlayerController
    {
        private IPlayerModel _playerModel;
        private IPlayerView _playerView;

        public PlayerController(IPlayerView playerView, IPlayerModel playerModel)
        {
            _playerModel = playerModel;
            _playerView = playerView;
        }
        public void OnUpdate()
        {
            Move();
        }

        private void Move()
        {
            _playerView.MoveDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
            _playerView.MoveDirection = _playerView.Transform.TransformDirection(_playerView.MoveDirection);
            _playerView.MoveDirection *= _playerModel.Speed;
            _playerView.MovementControl.Move(_playerView.MoveDirection * Time.deltaTime);
            _playerView.Transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        }
    }
}