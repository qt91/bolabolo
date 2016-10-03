using UnityEngine;
using System.Collections;

public class MyController : MonoBehaviour {

    public GameObject myCamera;
    public GameObject myBall;

    public float xOffset = 0;
    public float yOffset = 0;
    public float zOffset = 0;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    //Camera follow ball

	}
    
    

    void LateUpdate()
    {
        myCamera.transform.position = new Vector3(myBall.transform.position.x + xOffset,
                                              myBall.transform.position.y + yOffset,
                                              myBall.transform.position.z + zOffset);
    }
}
