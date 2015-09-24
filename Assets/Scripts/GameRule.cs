using UnityEngine;
using System.Collections;

public class GameRule : MonoBehaviour {

	[SerializeField]GameObject SpawnerObject;
	[SerializeField]GameObject GameRetryButton;
	

	void Awake()
	{
		// ゲーム画面サイズ固定.
		Screen.SetResolution (1024, 768, false);
	}

	void Start()
	{
		GameRetryButton.SetActive (false);
	}

	void Update()
	{
		if (0 == SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter) 
		{
			GameRetryButton.SetActive(true);
		}
	}

	public void OnretryButton()
	{
		Application.LoadLevel ("Main");
	}

	/*
	public void On5Num()
	{
		SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter = 5;
		for (int i = 0; i < NumButton.Length; i++) 
		{
			NumButton [i].SetActive (false);
		}
	}

	public void On10Num()
	{
		SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter = 10;
		for (int i = 0; i < NumButton.Length; i++) 
		{
			NumButton [i].SetActive (false);
		}
	}

	public void On20Num()
	{
		SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter = 20;
		for (int i = 0; i < NumButton.Length; i++) 
		{
			NumButton [i].SetActive (false);
		}
	}

	public void On30Num()
	{
		SpawnerObject.GetComponent<Spawner> ().UsersCoinCounter = 30;
		for (int i = 0; i < NumButton.Length; i++) 
		{
			NumButton [i].SetActive (false);
		}
	}*/

}
