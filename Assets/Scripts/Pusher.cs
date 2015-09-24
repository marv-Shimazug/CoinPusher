using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	private Vector3 origin;

	void Awake()
	{
		// 初期位置の保存.
		origin = this.transform.position;
	}

	// 0.02秒のインターバルで更新.
	void FixedUpdate()
	{
		Vector3 offset = new Vector3 (0, 0, Mathf.Sin(Time.time) * 0.5f);
		GetComponent<Rigidbody>().MovePosition(origin + offset);
	}

}
