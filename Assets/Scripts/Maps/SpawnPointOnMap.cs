using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPointOnMap : MonoBehaviour {

	public Color SpawnPointColour;

	public List<SpawnPointOptions> monsters;

	public float wanderDistance = 20f;

	public int maxMonstersResponsibleFor = 5;


	public List<SpawnMonsterOnMap> active = new List<SpawnMonsterOnMap>();
	// Use this for initialization
	void Start () {
	}
	
	public void OnDrawGizmos() {
		Gizmos.color = SpawnPointColour;
		Gizmos.DrawSphere(this.transform.position,1f);
		Gizmos.DrawWireSphere(this.transform.position,wanderDistance);
	}
	public void OnEnable() {
		if(GameTimer.REF!=null)
			GameTimer.REF.OnTimerTick += onSecondPassed;
	}
	public void OnDisable() {
		while(active.Count>0) {
			if(active[0]!=null&&active[0].gameObject!=null)
				Destroy(active[0].gameObject);
			active.Remove(active[0]);
		}
		if(GameTimer.REF!=null)
			GameTimer.REF.OnTimerTick -= onSecondPassed;
	}
	// Update is called once per frame
	void onSecondPassed () {
		if(maxMonstersResponsibleFor>active.Count) {
			for(int i = 0;i<monsters.Count;i++) {
				
				SpawnPointOptions o = monsters[0];
				bool shouldSpawn = false;
				switch(o.rareness) {
					case(ERareity.VeryCommon):shouldSpawn = (Random.Range (0,5) == 0);break;
					case(ERareity.Common):shouldSpawn = (Random.Range(0,10) == 0);break;
					case(ERareity.QuiteCommon):shouldSpawn = (Random.Range(0,30) == 0);break;
					case(ERareity.Rare):shouldSpawn = (Random.Range(0,120) == 0);break;
					case(ERareity.VeryRare):shouldSpawn = (Random.Range(0,300) == 0);break;
					case(ERareity.SuperRare):shouldSpawn = (Random.Range(0,600) == 0);break;
				}

				if(o!=null) {
					GameObject m = GameObject.Instantiate(o.monsterToSpawn);
					m.transform.position = this.transform.position;
					SpawnMonsterOnMap s = m.AddComponent<SpawnMonsterOnMap>();
					s.name = o.monsterToSpawn.name;
					s.level = (byte) UnityEngine.Random.Range(o.levelLow,o.levelHigh);
					active.Add(s);
				} 

			}

		}
	}
}
