using System.Collections;
using UnityEngine;

namespace Code.Player.Interface
{
    public interface IPlayerView
    {
        Transform Transform { get; }
        Vector3 MoveDirection { get; set; }
        CharacterController MovementControl { get; set; }
        void ChildCourutine(IEnumerator enumerator);
    }
}