
using UnityEngine;

public class rope : MonoBehaviour {

    public Rigidbody2D hook;

    public GameObject linkprefab;

    public wight weigth;



    public int links = 7;
	// Use this for initializationf
	void Start () {
        GenerateRope();
		
	}

    void GenerateRope() { 

        Rigidbody2D previousRB = hook;
    
        for (int i =0; i < links; i++)
        {
            GameObject link = Instantiate(linkprefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;
            if (i < links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weigth.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
            
        }
    }
	
	
}
