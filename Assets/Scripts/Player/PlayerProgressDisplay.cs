using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProgressDisplay : MonoBehaviour
{
    [SerializeField] private Image ProgressImage;
    [SerializeField] private TextMeshProUGUI LevelNametxt;
    [SerializeField] private TextMeshProUGUI MoneyText;

    [SerializeField] private MoneySettingsSO moneySettings;
    [SerializeField] private PlayerMoneyController moneyController;

    private float moneySize;

    private void OnEnable()
    {
        EventManager.OnMoneyChanged += MoneyChanged;
        EventManager.OnLevelUp += LevelUp;
        EventManager.OnLevelDown += LevelDown;
    }
    private void OnDisable()
    {
        EventManager.OnMoneyChanged -= MoneyChanged;
        EventManager.OnLevelUp -= LevelUp;
        EventManager.OnLevelDown -= LevelDown;
    }

    private void Awake()
    {
        MoneyChanged();
        LevelNametxt.text = moneySettings.MoneyLevels[0].LevelName;
        moneySize= moneySettings.MoneyLevels.Last().Cost;
    }
    void MoneyChanged()
    {
        ProgressImage.fillAmount = (float)moneyController.CurrentMoney / (float)moneySize;
        MoneyText.text= moneyController.CurrentMoney.ToString();
    }

    void LevelUp() { LevelNametxt.text = moneySettings.MoneyLevels[moneyController.CurrentLevel].LevelName; }
    void LevelDown() { LevelNametxt.text = moneySettings.MoneyLevels[moneyController.CurrentLevel].LevelName; }
}
