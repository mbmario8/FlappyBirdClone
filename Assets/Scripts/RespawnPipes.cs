using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPipes : MonoBehaviour
{


    public GameObject Pipes;
    //variavel height define a variação de altura para os pipes.
    public float height;
    private float timer = 0f;
    public float maxTime = 1f;



    void Start()
    {

        GameObject newPipe = Instantiate(Pipes);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);


    }


    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(Pipes);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f);
            timer = 0;

        }

        timer += Time.deltaTime;

    }
}