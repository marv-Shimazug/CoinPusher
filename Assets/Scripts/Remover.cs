using UnityEngine;
using System.Collections;

public class Remover : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		Destroy (col.gameObject);
	}
}
