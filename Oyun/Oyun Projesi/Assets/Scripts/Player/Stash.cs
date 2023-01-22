using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stash : MonoBehaviour
{
    
    public Transform stashParent;
    public List<Stashable> CollectedObjects = new List<Stashable>();
    public int CollectedCount => CollectedObjects.Count;
    public float collectionHeight = 1;
    public int maxCollectableCount = 5;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Obsolete]
    public void AddStash(Collectable collectedObject)
    {
        if (CollectedCount >= maxCollectableCount)
        return;
        if (car.active == true )
        {
            maxCollectableCount = 10;
            var yLocalPosition = CollectedCount * collectionHeight;

            var stashable = collectedObject.Collect();
            stashable.CollectStashable(stashParent, yLocalPosition, CompleteCollection);
            CollectedObjects.Add(stashable);
        }
        else
        {
            var yLocalPosition = CollectedCount * collectionHeight;

        var stashable = collectedObject.Collect(); 
        stashable.CollectStashable(stashParent, yLocalPosition, CompleteCollection);
        CollectedObjects.Add(stashable);
        }
        
         
    }

    private void CompleteCollection()
    {
        
            
    }

    public Stashable RemoveStash()
    {
        if (CollectedCount <= 0)
            return null;

        var stashable = CollectedObjects[CollectedCount - 1];

        CollectedObjects.Remove(stashable);
        stashable.transform.parent = null;

        return stashable;

    }
}
