using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float waitTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine(){
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Timer Finished!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
