using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(2.5f, 1.6f, 2.5f); 
       Vector3 newPos = transform.position;
       if(Input.GetKey(KeyCode.D)){
       newPos.x+=0.1f;}
       if(Input.GetKey(KeyCode.A)){
       newPos.x+=-0.1f;}
       if(Input.GetKey(KeyCode.W)){
       newPos.z+=0.1f;}
       if(Input.GetKey(KeyCode.S)){
       newPos.z+=-0.1f;}
       
       transform.position = newPos;
    }
}
