using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update

    int j = 0;
    int i = 0;
    public Renderer rend;
    
    void Start()
    {
       i = Random.Range(200,251);

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag=="Red"&&j==100){
            gameObject.SetActive(false);
        }
        if(gameObject.tag=="Blue"&&j==i){
            rend.enabled=false;

        }
        Debug.Log(gameObject.name + ": " +  j);
        j++;
    }
}
