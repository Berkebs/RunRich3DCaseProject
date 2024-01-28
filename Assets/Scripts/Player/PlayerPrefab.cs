using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.TryGetComponent(out ICollactableObject collectableObject))
        {
            collectableObject.CollectItem();
        }

        if (other.TryGetComponent(out IInterectableObject interectableObject))
        {
            transform.DORotate(new Vector3(0, transform.rotation.eulerAngles.y + interectableObject.GetRotate(), 0), .7f);
        }

        if (other.CompareTag("Finish"))
        {
            EventManager.OnLevelCompleted?.Invoke();
        }
    }
}
