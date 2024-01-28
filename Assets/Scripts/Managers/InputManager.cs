using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour, IDragHandler
{
    [SerializeField] private PlayerMovementController player;


    public void OnDrag(PointerEventData eventData)
    {
        player.HorizontalMovement(eventData.delta.x);
        
    }


    private void OnEnable()
    {
        EventManager.OnLevelFailed += LevelFinished;
        EventManager.OnLevelCompleted += LevelFinished;
    }
    private void OnDisable()
    {
        EventManager.OnLevelFailed -= LevelFinished;
        EventManager.OnLevelCompleted -= LevelFinished;
    }

    void LevelFinished()
    {
        this.enabled = false;
    }
}