using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckAllObjects : MonoBehaviour
{
    public UnityEvent OnAllObjectsCollected;

    public List<GameObject> objects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckObjects() {
        int collected = 0;
        foreach (GameObject obj in objects) {
            if (obj.active) {
                Debug.Log("Object in LWK " + obj.name);
                collected++;
            }
        }

        Debug.Log("Results " + collected);
        if(collected == objects.Count) {
            OnAllObjectsCollected.Invoke();
        }
    }
}
