using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

	public int points;
	public int Factor_Damage;
	private float acumulador;
	public playerScript _global_player;
	public HUDModifiers _global_hud;
	public bool iSDead;
	// Use this for initialization
	void Start () {
		acumulador = 0.0f;
		GameResetState();
	}
	
	// Update is called once per frame
	void Update () {

		if(!iSDead && _global_hud.CurrentMareo >0)
		{
			//showing all time what RPM is the player 
			_global_hud.RPMStatus.text = (Mathf.Rad2Deg*_global_player.angularSpeed).ToString()+" RPM";

			//if whe use the bumpCounter
			{
				var convert_unit = Mathf.FloorToInt(_global_hud.maxMareo / Factor_Damage);
				
				if(_global_player.bumpCounter <= Factor_Damage)
					_global_hud.CurrentMareo = convert_unit;
			}
			
			//if whe use AngularSpeed to calculate spins
			{
				var Frecuency = _global_player.angularSpeed / Mathf.Deg2Rad*(2.0f*Mathf.PI);
				acumulador += ( _global_hud.maxMareo / ( _global_player.angularSpeed * Mathf.Rad2Deg ));
				_global_hud.CurrentMareo += Mathf.FloorToInt(acumulador);
			}

		}
		else if (_global_hud.CurrentMareo <=0)
		{
			iSDead = true;
		}


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
