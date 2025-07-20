using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Create new enemy")]
public class Enemies : ScriptableObject
{

    [SerializeField] string name;
    [SerializeField] Sprite idle;
    [SerializeField] Type type1, type2, type3, type4;

    public enum Type { None, WeakToSlash, WeakToPierce, WeakToBludgeon, Distractable, Sleepy }

    
}
