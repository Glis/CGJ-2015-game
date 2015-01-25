using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : Singleton<GameState> {

	public int points;
	public int Factor_Damage;
	private float acumulador;
	private bool onlyone_register = false;
	public playerScript _global_player;
	public HUDModifiers _global_hud;
	public bool iSDead;
	public bool levelFinished;
	// Use this for initialization
	void Start () {
		acumulador = 0.0f;
		GameResetState();
		levelFinished = false;
	}

	public void AddDamage()
	{
		var convert_unit = Mathf.FloorToInt(_global_hud.maxMareo / Factor_Damage);
			_global_hud.CurrentMareo += convert_unit;
	}

	public void Dead()
	{

	}

	// Update is called once per frame
	void Update () {
		//showing all time what RPM is the player 
		_global_hud.RPMStatus.text = (_global_player.rigidbody2D.angularVelocity ).ToString()+" RPM";
	}

	public void setPlayerHitPoints()
	{	iSDead = false;
		_global_hud.maxMareo = 100;
		_global_hud.RPMStatus.text = " RPM";
	}

	/// <summary>
	/// Games the reset.
	/// </summary>
	public void GameResetState()
	{
		setPlayerHitPoints();
	}
}
