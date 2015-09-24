using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scorer : MonoBehaviour {

	// 累計獲得枚数.
	private int ScoreCount;

	[SerializeField]GameObject SpawnerObject;

	[SerializeField]Text AllCounter;

	void Update()
	{
		TextIndicator ();
	}

	void OnTriggerEnter(Collider col)
	{
		int addCount = CountUp (col.GetComponent<Coin>().GetMyColor);
		ScoreCount += addCount;
		SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter += addCount;
		SpawnerObject.GetComponent<Spawner>().AddBounusCoin(BounusCounter());
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

	// ボーナス発生枚数.
	int BounusCounter()
	{
		int retCoinNum = 0;
		if(0 == ScoreCount % 10)
		{
			retCoinNum = Random.Range(30, 200);
		}
		return retCoinNum;
	}

	void TextIndicator()
	{
		AllCounter.text = "累計獲得枚数：" + ScoreCount.ToString() + "\n"
			+"所持枚数：" + SpawnerObject.GetComponent<Spawner>().UsersCoinCounter + "\n";
	}

}
