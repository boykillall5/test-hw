using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByconton : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		Destroy (gameObject);
}
}
