using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectableObject", menuName = "New Collectable Object")]
public class CollectableObjectSO : ScriptableObject
{
    public int MaxMoney;
    public int MinMoney;
}
