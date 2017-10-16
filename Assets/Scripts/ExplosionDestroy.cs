using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour {

	public void FixedUpdate(){
		Destroy (gameObject, 1f);
	}
}
