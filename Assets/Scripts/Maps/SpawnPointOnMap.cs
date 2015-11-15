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
	// Update is called once per frame
	void Update () {
		if(maxMonstersResponsibleFor>active.Count) {
			GameObject m = GameObject.Instantiate(monsters[0].monsterToSpawn);
			m.transform.position = this.transform.position;
			SpawnMonsterOnMap s = m.AddComponent<SpawnMonsterOnMap>();
			active.Add(s);
		}
	}
}
