using Code.Player;
using Code.Player.Code;
using Code.Player.Interface;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
     //   UnitClass.CreatePlayer(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
        IUnitFactory unitFactory = new UnitFactory();
        unitFactory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);

        UnitClass.Factory = unitFactory;
        UnitClass.Factory.Create(new Health(100.0f, 100.0f),FindObjectOfType<PlayerSpawn>().transform.position);
       
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
