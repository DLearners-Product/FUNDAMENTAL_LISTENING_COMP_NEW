using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour
{
    public bool B_drag;
   // public GameObject G_C_pos;
   // public Vector2 C_initial;

  //  public GameObject G_fill,G_dash;
    public Vector2 pos_initial;
    public bool B_corret,B_callonce;

    private void Start()
    {
       // G_dash.SetActive(true);
       // C_initial = G_C_pos.transform.position;
        pos_initial = this.transform.position;
       // count = 0;
        B_callonce = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (B_drag)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousepos);
            Debug.Log(mousepos);
        }
        if(!B_drag && !B_corret)
        {
            transform.position = pos_initial;
        }
    }

    void OnMouseDown()
    {
        B_drag = true;
    }
    void OnMouseUp()
    {
        B_drag = false;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("collide");
        if (collision.gameObject.tag == this.tag)
        { 
            //Debug.Log()
            B_corret = true;
            Debug.Log("ans");



            if (!B_drag && B_corret)
            {
                this.transform.position = collision.transform.position;
                collision.GetComponent<Image>().enabled = false;
                this.GetComponent<DragandDrop>().enabled = false;
                if (B_callonce)
                {
                     drag_ques_change.OBJ_drag_ques_change.IncreaseCount();
                    //collision.gameObject.transform.parent.transform.parent.transform.parent.GetComponent<drag_ques_change>().IncreaseCount();
                    B_callonce = false;
                }
            }
        }
       /* else
        {
            wrong.Play();
            B_corret = false;
            if (!B_drag)
            {
                this.transform.position = pos_initial;
                Debug.Log("wrong anser intial posQ");
            }
        }*/
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        B_corret = false;
        this.transform.position = pos_initial;
    }
}
