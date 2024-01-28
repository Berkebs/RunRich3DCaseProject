using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI FinishStateText;
    [SerializeField] private TextMeshProUGUI FinishMoneyText;
    [SerializeField] private GameObject FinishPanel;
    [SerializeField] private PlayerMoneyController moneyController;




    private void OnEnable()
    {
        EventManager.OnLevelFailed += LevelFailed;
        EventManager.OnLevelCompleted += LevelCompleted;
    }
    private void OnDisable()
    {
        EventManager.OnLevelFailed -= LevelFailed;
        EventManager.OnLevelCompleted -= LevelCompleted;
    }

    void LevelFailed()
    {
        FinishStateText.text = "Defeat";
        FinishMoneyText.text=moneyController.CurrentMoney.ToString();
        FinishPanel.SetActive(true);
    }
    void LevelCompleted()
    {
        FinishStateText.text = "Victory";
        FinishMoneyText.text = moneyController.CurrentMoney.ToString();
        FinishPanel.SetActive(true);
    }

    public void RetryButton() { GameSceneManager.Instance.ChangeScene(); }
    public void MainMenuButton() { GameSceneManager.Instance.ChangeScene(0); }

}
