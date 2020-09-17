using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rig;



    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //movimento para o jump (vector2 possui eixo Y = 1)
            rig.velocity = Vector2.up * speed;

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameOver.SetActive(true);
        //Pausar game
        Time.timeScale = 0;

    }



}
