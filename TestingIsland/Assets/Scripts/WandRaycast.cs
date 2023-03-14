using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandRaycast : MonoBehaviour



{
   public LineRenderer wandBeam;

   private void Update(){

    wandBeam.enabled = true;
    wandBeam.SetPosition(0, transform.position);
    Vector3 endPosition = transform.position + transform.up * 10f;
    wandBeam.SetPosition(1, endPosition);
  }
   
   
   public void Interact(){

    RaycastHit hit;

    if(Physics.Raycast(transform.position, transform.forward, out hit)){
       
    }
    
   }

}
