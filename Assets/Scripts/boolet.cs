using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class boolet : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float waitTime;

    void Awake(){
        Random.value.;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator RandomStart(){
        yield return new WaitForSeconds(waitTime);
    }
    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}
