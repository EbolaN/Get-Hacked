using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public GameObject itemBeingDragged;
    bool drageble;
    RaycastHit hit;
    

    void Start () {
	
	}
	
	
	void Update () {
        
        Ray rayHit = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(rayHit.origin,hit.point);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if(Physics.Raycast(rayHit, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject)
                    drageble = true;
                    //blyat
            }
        }
        if(drageble)
        {
            itemBeingDragged.transform.position = new Vector3(Input.mousePosition.x + transform.position.x, Input.mousePosition.y + transform.position.y, 0);
        }
	}
}
