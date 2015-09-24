using UnityEngine;
using System.Collections;

public class Scorer : MonoBehaviour {

	// 累計獲得枚数.
	private int ScoreCount;

	void OnTriggerEnter(Collider col)
	{
		ScoreCount += CountUp (col.GetComponent<Coin>().GetMyColor);
		Destroy (col.gameObject);
	}

	int CountUp(bool coin)
	{
		int add = 0;
		if (true == coin) 
		{
			add = 10;
		} 
		else 
		{
			add = 1;
		}
		return add;
	}

}
