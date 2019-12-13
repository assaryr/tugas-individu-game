using UnityEngine;
using System.Collections;

public class belajargame : MonoBehaviour {
    
	public string pesan;
	public int kecepatan;
	public float waktu;
	public bool aktif;
	
	
	void Start () {
		
	}



    // Update is called once per frame
    void Update() {
		waktu += Time.deltaTime;
		
		if(waktu>3) {
			aktif=true;
		}
		
		if (aktif == true) {
			print (pesan);
			kecepatan=5;
		}
	}
}
