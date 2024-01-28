using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void PlayButton() { GameSceneManager.Instance.ChangeScene(1); }
}
