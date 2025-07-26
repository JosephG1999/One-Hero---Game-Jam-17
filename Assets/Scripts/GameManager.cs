using UnityEngine;
using UnityEngine.UIElements.Experimental;

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
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) 
        { 
            fireRay(); 
            Debug.Log("Mouse input."); 
        }

        if (Input.GetKeyDown(KeyCode.I)) { enterInventory(); }


    }

    private void enterInventory() 
    {
        if (!inventoryCam.enabled)
        {
            battleCam.enabled = false; inventoryCam.enabled = true;
            nametag.SetActive(false);
        }
        else 
        {
            battleCam.enabled = true; inventoryCam.enabled = false;
            nametag.SetActive(true);
        }

    }

    public void fireRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(inventoryCam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider.tag == "Weapon")
        {
            Debug.Log("Clicked on a weapon.");
        }
    }
}
