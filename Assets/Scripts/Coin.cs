using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	/// <summary>
	/// 色.
	/// true:金  false:銀
	/// </summary>
	private bool MyColor;
	public bool GetMyColor{get{return MyColor;}}

	/// <summary>
	/// 色の設定.
	/// </summary>
	/// <param name="color">If set to <c>true</c> color.</param>
	public void SetColor(bool color)
	{
		MyColor = color;
	}
}
