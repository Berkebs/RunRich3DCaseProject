using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float maxHorizontalValue, minHorizontalValue;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private Transform centerPoint;



    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);
        //GetComponent<Rigidbody>().velocity = (Vector3.forward * Time.deltaTime * verticalSpeed);

        //centerPoint.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);
    }
    public void HorizontalMovement(float movement)
    {
       
       movement= Mathf.Clamp(movement,minHorizontalValue,maxHorizontalValue);

       Vector3 newPos= Vector3.right * Time.deltaTime * (horizontalSpeed * movement);
       transform.Translate(newPos,Space.Self);
        //transform.position =centerPoint.position+ Vector3.ClampMagnitude(centerPoint.position,15f);
       // GetComponent<Rigidbody>().velocity=Vector3.right * Time.deltaTime * (horizontalSpeed * movement);
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

    public float GetVerticalSpeed() { return verticalSpeed; }
}
