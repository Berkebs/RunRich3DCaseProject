using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoneyController : MonoBehaviour
{
    [SerializeField] private MoneySettingsSO moneySettings;

    private int currentMoney=0;
    public int CurrentMoney 
    { 
        get { return currentMoney; }
        private set
        {
            currentMoney= value;
            EventManager.OnMoneyChanged?.Invoke();
        }
    }

    private int currentLevel = 0;
    public int CurrentLevel { get { return currentLevel; }}
    private int levelUpCost;
    private int levelDownCost=-1;



    private void OnEnable()
    {
        EventManager.OnCollectItem += CollectedItem;
        EventManager.OnLevelUp += LevelUp;
        EventManager.OnLevelDown += LevelDown;

    }
    private void OnDisable()
    {
        EventManager.OnCollectItem -= CollectedItem;
        EventManager.OnLevelUp -= LevelUp;
        EventManager.OnLevelDown -= LevelDown;
    }

    private void Awake()
    {
        levelUpCost = moneySettings.MoneyLevels[0].Cost;
    }
    void CollectedItem(int collectSize)
    {
        CurrentMoney += collectSize;

        if (currentMoney < 0)
        {
            EventManager.OnLevelFailed?.Invoke();
            return;
        }

        if (currentMoney < levelDownCost)
            EventManager.OnLevelDown?.Invoke();

        if (currentMoney >= levelUpCost && currentLevel<moneySettings.MoneyLevels.Count)
            EventManager.OnLevelUp?.Invoke();


    }
    void LevelUp() { 
        currentLevel++;
        levelUpCost = moneySettings.MoneyLevels[currentLevel].Cost;
    }
    void LevelDown() { currentLevel--;
        levelUpCost = moneySettings.MoneyLevels[currentLevel-1].Cost;
    }



}
