using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByconton : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter (Collider other)
	{
		Destroy (gameObject);


   }
}
