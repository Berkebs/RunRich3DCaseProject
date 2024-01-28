using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public static Action<int> OnCollectItem;
    public static Action OnLevelUp;
    public static Action OnLevelDown;
    public static Action OnMoneyChanged;

    public static Action OnLevelCompleted;
    public static Action OnLevelFailed;
    public static Action OnLevelPaused;
    public static Action OnLevelStarted;
}
