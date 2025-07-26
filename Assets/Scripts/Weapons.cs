using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "Scriptable Objects/Create new weapon")]
public class Weapons : ScriptableObject
{
    [SerializeField] string title, condition;

    public string getCondition { get { return condition; } set { condition = value; } }
    public string getTitle { get { return title; } set { title = value; } }

}
