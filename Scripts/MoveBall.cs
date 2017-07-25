using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {
	/// <summary>
	/// 小球发射时的力大小
	/// </summary>
	public float startForce = 0.05f;

	/// <summary>
	/// 定义一个数组代表发射时的力以及方向
	/// </summary>
	public  Vector2[] vectorForce;

	private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();

		//两秒后调用一个方法
		Invoke("PlayBall", 2f);

		//力的大小相同，方向不同的四个方向
		vectorForce = new Vector2[] {
			new Vector2 (startForce, startForce), 
			new Vector2 (startForce, -startForce),
			new Vector2 (-startForce, startForce), 
			new Vector2 (-startForce, -startForce)
		};
	}

	/// <summary>
	/// 给小球添加一个力，让小球运动
	/// </summary>
	public void PlayBall(){
		 
		//随机取一个 0~4 之间的数整数，不包含4
		int index = Random.Range (0, 4);

		//相当于给小球随机添加一个方向的力
		rb2D.AddForce (vectorForce [index]);
	}

	/// <summary>
	/// 进入触发器时
	/// </summary>
	/// <param name="other">触发器这个物体.</param>
	void OnTriggerEnter2D(Collider2D other){

		//如果碰撞到的物体的tag是leftScore右边玩家得分
		if (other.tag == "leftScore") {
			GameManager.Instance.SetRightScore();
			GameManager.Instance.GameOver();
		}
		else if (other.tag == "rightScore"){
			GameManager.Instance.SetLeftScore ();
			GameManager.Instance.GameOver ();
		}
	}


}
