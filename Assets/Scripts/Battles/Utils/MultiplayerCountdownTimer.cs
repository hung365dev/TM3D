using UnityEngine;
using System.Collections;
using Battles;

public class MultiplayerCountdownTimer : MonoBehaviour {

	public int standardCountdownTime = 30;
	public int longCountdownTime = 40;
	public int lowTime = 3;
	
	public delegate void OnTimerExpired();
	public event OnTimerExpired onStandardTimerExpired;
	public event OnTimerExpired onLongTimerExpired;
	
	public Color standardColour;
	public Color timeLowColour;
	
	public string timerExpiredTimer;
	public string preLabel;
	private float _endTime;
	public ETimerType timerType;
	private UILabel _labelComponent;
	// Use this for initialization
	void Start () {
		_labelComponent = this.GetComponent<UILabel>();
	}
	
	public void startStandardTimer() {
		_endTime = Time.time+standardCountdownTime;
		timerType = ETimerType.Standard;
		
	}
	
	
	public void startLongTimer() {
		_endTime = Time.time+longCountdownTime;
		timerType = ETimerType.Long;
		
	}
	public string text {
		set {
			if(this._labelComponent!=null)
				this._labelComponent.text = value;
		}
	}
	public void stop() {
		timerType = ETimerType.Stopped;
		if(_labelComponent!=null)
			_labelComponent.text = "";
	}
	// Update is called once per frame
	void Update () {
		int tType = (int) timerType;
		if((timerType==ETimerType.Standard)||(timerType==ETimerType.Long)) {
			float timeDiff = _endTime-Time.time;
			int displayTime = Mathf.CeilToInt(timeDiff);
			_labelComponent.text = preLabel+displayTime.ToString();
			if(timeDiff<0) {
				switch(timerType) {
					case(ETimerType.Standard):
					//	BattleBase.MultiplayerDebugText("onStandardTimerExpired!!");
						if(onStandardTimerExpired!=null) {
							onStandardTimerExpired();
						stop ();
						} else stop();
					break;
					case(ETimerType.Long):
					
			//		BattleBase.MultiplayerDebugText("onLongTimerExpired!!");
					if(onLongTimerExpired!=null) {
						onLongTimerExpired();
						stop ();
					} else 
						stop ();
					break;
					
				}
			}
			if(displayTime<lowTime) {
				this._labelComponent.color = timeLowColour;
			} else {
				this._labelComponent.color = standardColour;
			}
		}
	}
}
