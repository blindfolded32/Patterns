using System.Collections;
using UnityEngine;

namespace Code.Player.Interface
{
    public interface IPlayerView
    {
        Transform Transform { get; set; }
        Vector3 MoveDirection { get; set; }
        CharacterController MovementControl { get; set; }

        void Movement();
        void ChildCourutine(IEnumerator enumerator);
    }
}