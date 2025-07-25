using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*
    [SerializeField] static GameManager instance;
    [SerializeField] EnemySpawn EnemySpawn;
    [SerializeField] GameObject EnemySpawnLoaction;
    */
    [SerializeField] Camera battleCam, inventoryCam;
    [SerializeField] GameObject nametag;
    void Start()
    {
        //GameObject enemySpace = EnemySpawn.GetComponent<GameObject>();
        battleCam.enabled = true; inventoryCam.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.I)) { enterInventory(); }


    }

    private void enterInventory() 
    {
        battleCam.enabled = false; inventoryCam.enabled = true;
        nametag.SetActive(false);

    }
}
