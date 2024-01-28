using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;

    private void OnEnable()
    {
        EventManager.OnLevelFailed += LevelFailed;
        EventManager.OnLevelCompleted += LevelCompleted;
        EventManager.OnLevelUp += LevelUp;
    }
    private void OnDisable()
    {
        EventManager.OnLevelFailed -= LevelFailed;
        EventManager.OnLevelCompleted -= LevelCompleted;
        EventManager.OnLevelUp -= LevelUp;

    }
    private void Start(){ playerAnimator.SetTrigger("Run"); }
    void LevelUp() { playerAnimator.SetTrigger("Jump"); }
    void LevelFailed() { playerAnimator.SetTrigger("Die"); }
    void LevelCompleted(){ playerAnimator.SetTrigger("Dance"); }
}
