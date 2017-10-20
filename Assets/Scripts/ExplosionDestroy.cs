/*	
 * File : ExplosionDestroy.cs
 * Author : Dhruti Parekh
 * Last Modified By : Dhruti Parekh
 * Date Last Modified :
 * Program Description : This script is used to destroy explosion prefab.
 * Revision History : v1.0
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour {

	// destorys the explosion prefab with allocated speed
	public void FixedUpdate(){
		Destroy (gameObject, 1f);
	}
}
