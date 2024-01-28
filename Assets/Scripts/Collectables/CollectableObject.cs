using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObject : MonoBehaviour, ICollactableObject
{
    [SerializeField] private CollectableObjectSO collectableSO;

    public void CollectItem()
    {
        transform.DOScale(0, 0.2f);
        int _money = Random.Range(collectableSO.MinMoney, collectableSO.MaxMoney);
        EventManager.OnCollectItem?.Invoke(_money);
    }
}
