using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timediff;
    // Start is called before the first frame update
    float timer = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > timediff)
        {
            GameObject newpipe=Instantiate(pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-1.7f, 5.7f), 0);

            timer = 0;
        }    
        }

}
