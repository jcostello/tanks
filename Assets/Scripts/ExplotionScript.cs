using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotionScript : MonoBehaviour {

private ParticleSystem ps;
 
 
     public void Start() 
     {
         ps = GetComponent<ParticleSystem>();
     }
 
}
