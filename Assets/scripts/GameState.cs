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
	public string [] niveles = {"wayra_level","cat_level","haunted_level"};
	public int ActualLevel = 0;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
		Factor_Damage = 20;
		_global_player = GameObject.Find("player").GetComponent<playerScript>();
		_global_hud = GameObject.Find ("HUD").GetComponent<HUDModifiers>();
		acumulador = 0.0f;
		GameResetState();
		levelFinished = false;
	}

	public void NextLevel ()
	{
		ActualLevel += 1;
		if(ActualLevel >= 3)
		{
			Application.LoadLevel("creditsscene");
			Destroy(gameObject);
		}
		else
		{
			Application.LoadLevel(niveles[ActualLevel]);
			GameResetState();
		}
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
		Factor_Damage = 20;
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
