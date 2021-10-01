using UnityEngine;
using System.Collections;
using UnityEngine.AI;

namespace Code.Ememy.Interfaces
{
    public interface IRangedEnemyView
    {
        Transform Transform { get; }
        Vector3 Destination { set; }
        
        void ChildCourutine(IEnumerator enumerator);
    }
}