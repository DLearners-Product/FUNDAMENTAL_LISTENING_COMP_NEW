﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Draw_and : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    public GameObject F1;
    public GameObject[] letter;
    public GameObject[] number;
    //public int count;
    public  bool B_restart;
    // public bool first,second;

    public AudioSource sound,empty;
    public AudioClip phonic;



    void Start()
    {
        for (int i = 0; i < number.Length; i++)
        {
            number[i].SetActive(false);
        }
        for (int i = 0; i < letter.Length; i++)
        {
            letter[i].SetActive(false);
        }
        rb = GetComponent<Rigidbody2D>();
        number[0].SetActive(true);
        number[1].SetActive(true);
        //count = 1;
       // Debug.Log("start");
        B_restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            F1.transform.position = (mousePosition);
            B_restart = false;
        }  
        if(Input.GetMouseButtonUp(0))
        {
            //mistake();
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "C_letter")
        {
            //mistake();
            
        }
    }
 /*   public void restart_J_tracing()
    {
        for(int i=0;i<number.Length;i++)
        {
            number[i].SetActive(false);
            number[i].GetComponent<CircleCollider2D>().enabled = true;
        }
        for (int i = 0; i < letter.Length; i++)
        {
            letter[i].SetActive(false);
        }
        number[0].SetActive(true);
        number[1].SetActive(true);
    }*/

    /*public void mistake()
    {
        B_restart = true;
        if (count==1)
        {
            number[1].SetActive(true);
            number[0].GetComponent<CircleCollider2D>().enabled = true;
            Debug.Log(" restrt coout = " + count);
        }
        if (count == 2)
        {
            //number[3].SetActive(false);
            number[2].GetComponent<CircleCollider2D>().enabled = true;
        }
        if (count == 3)
        {
           // number[4].SetActive(false);
            if(count>3)
            count = count - 1;
            number[3].GetComponent<CircleCollider2D>().enabled = true;
        }
        if (count == 4)
        {
            //number[5].SetActive(false);
            if (count > 4)
                count = count - 1;
            number[4].GetComponent<CircleCollider2D>().enabled = true; 
        }

    }*/
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!B_restart)
        {

            if (collision.gameObject.name == "1")
            {
                sound.Play();
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }

            if (collision.gameObject.name == "2")
            {
                sound.Play();
                letter[0].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
                number[2].SetActive(true);
            }
            if (collision.gameObject.name == "3")
            {
                sound.Play();
                number[3].SetActive(true);
                letter[1].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "4")
            {
                sound.Play();
                letter[2].SetActive(true);
                number[4].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "5")
            {
                sound.Play();
                number[5].SetActive(true);
                letter[3].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            //n
            if (collision.gameObject.name == "6")
            {
                sound.Play();
                //letter[1].SetActive(true);
                number[6].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "7")
            {
                sound.Play();
                letter[4].SetActive(true);
                number[7].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "8")
            {
                sound.Play();
                number[8].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }

            if (collision.gameObject.name == "9")
            {
                sound.Play();
                letter[5].SetActive(true);
                number[9].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }

            if (collision.gameObject.name == "10")
            {
                sound.Play();
                letter[6].SetActive(true);
                number[10].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            //d
            if (collision.gameObject.name == "11")
            {
                sound.Play();
                number[11].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }

            if (collision.gameObject.name == "12")
            {
                sound.Play();
                letter[7].SetActive(true);
                number[12].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "13")
            {
                sound.Play();
                letter[8].SetActive(true);
                number[13].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "14")
            {
                sound.Play();
                letter[9].SetActive(true);
                number[14].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (collision.gameObject.name == "15")
            {
                sound.Play();
                letter[10].SetActive(true);
                number[14].SetActive(true);
                collision.GetComponent<CircleCollider2D>().enabled = false;
                empty.clip = phonic;
                empty.Play();
                for (int i = 0; i < number.Length; i++)
                {
                    number[i].SetActive(false);
                }
            }

        }
    }
}
