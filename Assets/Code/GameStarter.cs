using Code.Ememy;
using Code.Player;
using Code.Markers;
using UnityEngine;

namespace Code
{
    public class GameStarter : MonoBehaviour
    {
        private IUnitFactory _unitFactory;
        private IEnemyFactory _enemyFactory;

        private EnemySpawn _spawnPointArray;
        // Start is called before the first frame update
        private void Start()
        {
            _spawnPointArray = FindObjectOfType<EnemySpawn>();
            _unitFactory = new UnitFactory();
            _enemyFactory = new  EnemyFactory();
            UnitClass.Factory = _unitFactory;
            UnitClass.Factory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
            EnemyClass.Factory = _enemyFactory;
            EnemyClass.Factory.Create(new Health(100.0f, 100.0f), _spawnPointArray);


        }

        // Update is called once per frame
        private void Update()
        {
            _unitFactory.OnUpdate();
        }
    }
}
