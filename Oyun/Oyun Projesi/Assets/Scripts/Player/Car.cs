using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
  public List<GameObject> ObjectsToUnlock = new List<GameObject>();
    // Start is called before the first frame update
    
     public GameObject car;
    void Start()
    {
        car.SetActive(true);
      
      
     //gameObject.GetComponent<Toggle>().enabled = false;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        
       
    }
}
