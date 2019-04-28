using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lindedrawer : MonoBehaviour
{

    public GameObject linePrefab;
    public Rigidbody2D rb;
    public Rigidbody2D rb1;


    Line activeLine;

    void Update()
    {
       
        rb = GetComponent<Rigidbody2D>();
        rb1 = GetComponent<Rigidbody2D>();
       

        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
            rb.gravityScale *= 0;
            rb1.gravityScale *= 0;
        




        }

        if (Input.GetMouseButtonUp(0))
        {
            activeLine = null;
            Time.timeScale = 1f;





        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(mousePos);
            Time.timeScale = 0f;

        }

    }

}
