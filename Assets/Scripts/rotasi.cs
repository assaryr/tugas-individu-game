using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasi : MonoBehaviour {
	
	public int kecepatanX,kecepatanY,kecepatanZ;
    // Use this for initalization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		transform.Rotate (kecepatanX,kecepatanY,kecepatanZ);
        
    }
}
