using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{


    public float speed = 2.0f;  public float xPos; public float yPos; float desiredPos;

   // public float timeTo$$anonymous$$ove;
    void Start()
    {

        //Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //Vector2 newPos = Camera.main.ScreenToWorldPoint(mousePos);
        //transform.position = newPos;

    }

    void Update()
    {
        float randnum = Random.Range(-0.1f, 0.1f);
        transform.position += new Vector3(randnum, randnum, 0f);
            
          
        
    }

    private void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }


}

