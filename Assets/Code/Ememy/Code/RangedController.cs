using Code.Ememy.Interfaces;
using Code.Markers;
using UnityEngine;


namespace Code.Ememy.Code
{
    public class RangedController : Component,IRangedController
    {
        private readonly IEnemyModel _enemyModel;
        private readonly IRangedEnemyView _rangedEnemyView;

        public RangedController(IEnemyModel enemyModel, IRangedEnemyView rangedEnemyView)
        {
            _enemyModel = enemyModel;
            _rangedEnemyView = rangedEnemyView;
        }

        public void Move()
        {
            _rangedEnemyView.Destination = FindObjectOfType<CoreMarker>().transform.position;
        }
    }
}