using UnityEngine;
using System.Collections;

public class GameRule : MonoBehaviour {

	void Awake()
	{
		// ゲーム画面サイズ固定.
		Screen.SetResolution (1024, 768, false);
	}

}
