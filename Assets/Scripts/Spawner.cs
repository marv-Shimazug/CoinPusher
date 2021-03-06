﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject coinPrefabGold;
	public GameObject coinPrefabSilver;

	const int STARTNUM = 50;
	const int INTERVAL = 10;

	int CreateCoinNum;
	int Counter;
	int Interval;

	private int UsersCoins;
	public int UsersCoinCounter{get{return UsersCoins;} set{UsersCoins = value;}}

	void Start()
	{
		UsersCoins = 30;
		CreateCoinNum = STARTNUM;
		Counter = 0;
		Interval = INTERVAL;
	}

	// 更新.
	void Update ()
	{
		Interval ++;
		if (Interval >= INTERVAL) 
		{
			Interval = 0;
			RandomCoinCreater (CreateCoinNum);
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			if(UsersCoins > 0)
			{
				Vector3 offset = new Vector3(Mathf.Sin(Time.time * 16), 0, 0);
				CreateCoin(ChoiceCoin(), offset);
				UsersCoins --;
			}
		}
	}

	// 任意数生成をランダムで行う.
	private void RandomCoinCreater(int count)
	{
		Counter++;
		if (Counter <= count) 
		{
			Vector3 offset = new Vector3 (Mathf.Sin (Time.time * 16), 0, Mathf.Sin (Time.time) - 0.5f);
			CreateCoin(ChoiceCoin(), offset);
		} 
	}

	// コインの選択.
	private bool ChoiceCoin()
	{
		bool choiceCoin = false;
		if (0 == Random.Range (0, 10)) 
		{
			choiceCoin = true;
		} 
		else 
		{
			choiceCoin = false;
		}
		return choiceCoin;
	}

	// コインの生成.
	private void CreateCoin(bool choiceCoin,Vector3 offset)
	{
		GameObject coin;
		if (true == choiceCoin)
		{
			coin = Instantiate (coinPrefabGold, transform.position + offset, transform.rotation) as GameObject;
		}
		else 
		{
			coin = Instantiate (coinPrefabSilver, transform.position + offset, transform.rotation) as GameObject;
		}
		coin.GetComponent<Coin>().SetColor(choiceCoin);
	}

	// コインボーナス取得.
	public void AddBounusCoin(int createNewCoins)
	{
		CreateCoinNum = createNewCoins;
		Counter = 0;
	}


}
