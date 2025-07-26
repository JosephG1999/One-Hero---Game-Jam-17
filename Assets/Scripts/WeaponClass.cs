using UnityEngine;

public class WeaponClass : MonoBehaviour
{
    [SerializeField] Weapons weaponStats;
    [SerializeField] string weaponName, condition;
    void Start()
    {
        weaponStats.getTitle = weaponName;
        weaponStats.getCondition = condition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
