using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	/// <summary>
	/// 得到左边的玩家
	/// </summary>
	public Transform leftPlayer;

	/// <summary>
	/// 得到右边的玩家
	/// </summary>
	public Transform rightPlayer;

	/// <summary>
	/// 玩家的移动速度
	/// </summary>
	public float speed = 20f;

	
	// Update is called once per frame
	void Update () {
	
		//如果按下W
		if (Input.GetKey (KeyCode.W)) {
			//调用左边玩家的移动方法
			LeftPlayerMove (leftPlayer, KeyCode.W);
		}	

		//如果按下S
		if (Input.GetKey (KeyCode.S)) {
			//调用左边玩家的移动方法
			LeftPlayerMove (leftPlayer, KeyCode.S);
		}

		//如果按下上箭头
		if (Input.GetKey (KeyCode.UpArrow)) {
			//调用右边玩家的移动方法
			RightPlayerMove (rightPlayer, KeyCode.UpArrow);
		}

		//如果按下下剪头
		if (Input.GetKey (KeyCode.DownArrow)) {
			//调用右边玩家的移动方法
			RightPlayerMove (rightPlayer, KeyCode.DownArrow);
		}
	}

	/// <summary>
	/// 左边玩家移动方法
	/// </summary>
	/// <param name="playerTranstorm">移动的对象.</param>
	/// <param name="key">传入键盘按键名称.</param>
	void LeftPlayerMove (Transform playerTranstorm, KeyCode key){

		//定义一个数代表方向，正为上，负为下
		float v = 0;

		//如果传过来的按键是W
		if (key == KeyCode.W) {
			//随机获取0~1之间的数
			v = Random.Range (0f, 1f);

			//如果传过来的按键是S
		} else if (key == KeyCode.S) {
			v = Random.Range (-1f, 0f);
		}

		//物体沿某个方向移动，乘上方向就可以改变移动的方向了
		playerTranstorm.Translate (Vector3.up * v * speed * Time.deltaTime);

		//玩家只改变y轴，Mathf.Clamp(value,min,max), value小于最小值时等于最小值，大于最大值时等于最大值
		playerTranstorm.position = new Vector3 (playerTranstorm.position.x,
			Mathf.Clamp (playerTranstorm.position.y, -3.31f, 3.31f), playerTranstorm.position.z);
	}

	/// <summary>
	/// 右边玩家移动的方法
	/// </summary>
	/// <param name="playerTranstorm">Player transtorm.</param>
	/// <param name="key">Key.</param>
	void RightPlayerMove (Transform playerTranstorm, KeyCode key){

		//定义一个数代表方向，正为上，负为下
		float v = 0;

		//如果传过来的按键是 上
		if (key == KeyCode.UpArrow) {
			//随机获取0~1之间的数
			v = Random.Range (0f, 1f);

			//如果传过来的按键是S
		} else if (key == KeyCode.DownArrow) {
			v = Random.Range (-1f, 0f);
		}

		//物体沿某个方向移动，乘上方向就可以改变移动的方向了
		playerTranstorm.Translate (Vector3.up * v * speed * Time.deltaTime);

		//玩家只改变y轴，Mathf.Clamp(value,min,max), value小于最小值时等于最小值，大于最大值时等于最大值
		playerTranstorm.position = new Vector3 (playerTranstorm.position.x,
			Mathf.Clamp (playerTranstorm.position.y, -3.31f, 3.31f), playerTranstorm.position.z);
	}
}
