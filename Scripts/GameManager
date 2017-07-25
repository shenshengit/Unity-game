using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	//把这个类写成单例模式
	private static GameManager _instance;
	public static GameManager Instance{
		get{ 
			return _instance;
		}
	}

	/// <summary>
	/// 左边分数text
	/// </summary>
	public Text leftScore;
	/// <summary>
	/// 左边的分数
	/// </summary>
	private int leftScoreInt = 0;

	/// <summary>
	/// 右边的分数text
	/// </summary>
	public Text rightScore;
	/// <summary>
	/// 右边分数
	/// </summary>
	private int rightScoreInt = 0;

	/// <summary>
	/// 得到小球
	/// </summary>
	public Transform ball;

	/// <summary>
	/// 小球的初始位置
	/// </summary>
	public Vector3 startBallPos;

	public Transform leftPlayer;

	private Vector3 startLeftPos;

	public Transform rightPlayer;

	private Vector3 startRightPos;

	void Awake () {
		if (_instance == null) {
			_instance = this;
		}

		//设置分数
		leftScore.text = "Score:" + leftScoreInt;
		rightScore.text = "Score:" + rightScoreInt;

		//得到初始位置
		startBallPos = ball.position;
		startLeftPos = leftPlayer.position;
		startRightPos = rightPlayer.position;
	}

	/// <summary>
	/// 设置左边的分数
	/// </summary>
	public void SetLeftScore(){
		leftScoreInt++;
		leftScore.text = "Score:" + leftScoreInt;
	}

	/// <summary>
	/// 设置右边的分数
	/// </summary>
	public void SetRightScore(){
		rightScoreInt++;
		rightScore.text = "Score:" + rightScoreInt;
	}

	/// <summary>
	/// 游戏结束
	/// </summary>
	public void GameOver(){
		//放慢游戏速度
		Time.timeScale = 0.25f;
		//1秒后调用Reset方法
		Invoke ("Reset", 1);
	}

	/// <summary>
	/// 重新加载场景
	/// </summary>
	void Reset(){

		//回复游戏速度
		Time.timeScale = 1f;
		//设置成初始位置
		ball.position = startBallPos;
		leftPlayer.position = startLeftPos;
		rightPlayer.position = startRightPos;
		//得到小球身上的刚体组件，设置速率为0，因为一开始是添加了力，有速率，再添加力时会叠加，所以设置为0
		ball.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		//得到小球身上的脚本，调用发射小球的方法
		ball.GetComponent<MoveBall> ().PlayBall ();
	}
 
}
