using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MoneySettings",menuName ="MoneySettings")]
public class MoneySettingsSO : ScriptableObject
{
    public List<MoneyLevel> MoneyLevels=new List<MoneyLevel>();
}

[System.Serializable]
public class MoneyLevel
{ 
    public string LevelName;
    public int Cost;
}