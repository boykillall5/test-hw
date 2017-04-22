using System.Collections;
using UnityEngine;

public class BoundaryDestory : MonoBehaviour {

	void OntriggerExit(Collider Other){
		Destroy(Other.gameObject);
	}
}
