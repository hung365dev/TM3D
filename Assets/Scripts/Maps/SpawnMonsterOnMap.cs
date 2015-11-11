using UnityEngine;
using System.Collections;
using Apex;
using Apex.Steering;
using Battles;
using Apex.Units;
using Apex.Steering.Behaviours;

public class SpawnMonsterOnMap : MonoBehaviour {

	// If player is further than this away, I'll destroy myself
	public IMovingObject apexMain;
	public Animator anim; 
	public SteerableUnitComponent steerable;
	public IUnitFacade unit;
	public const int MAX_DISTANCE_TO_PLAYER = 100;
	public const int MAX_CHASE_DISTANCE = 40;
	public const int MAX_DISTANCE_TO_START_BATTLE = 3;
	public GameObject player;
	public bool chasePlayer = false;
	public WanderBehaviour wander;
	public MonsterLibraryRecord monster;
	// Use this for initialization
	public string name;
	public byte level; 
	void Start () {
		apexMain = this.GetComponent<IMovingObject> ();
		anim = this.GetComponentInChildren<Animator> ();
		steerable = this.GetComponent<SteerableUnitComponent> ();
		unit = this.GetUnitFacade (true);
		BattleMonster m = this.GetComponentInChildren<BattleMonster> ();
		if (m != null) {
			Destroy (m);
		}
		player = GameObject.FindGameObjectWithTag ("Player");
		wander = GetComponent<WanderBehaviour> ();
	} 
	
	// Update is called once per frame
	void Update () {
		float s = steerable.speed;
		if (s < 0.1f) {
			anim.SetInteger ("AnimState", 0);
		} else if (s < 20f) {
			anim.SetInteger ("AnimState", 2);
		} else {
			anim.SetInteger("AnimState",3);
		}
		float distanceToPlayer = Vector3.Distance (player.gameObject.transform.position, this.gameObject.transform.position);
		if(distanceToPlayer<MAX_DISTANCE_TO_START_BATTLE) {
			WorldExplorer.REF.StartBattle(this);
			Destroy(this.gameObject);
		}

		if (chasePlayer) {
			if (distanceToPlayer > MAX_CHASE_DISTANCE) {
				wander.enabled = true;
				chasePlayer = false;
			} else {
				if(this.unit.hasArrivedAtDestination) {
					chasePlayer = false;
				}
			}
		} else {
			if(distanceToPlayer < MAX_CHASE_DISTANCE) {
				
					wander.enabled = false;
					unit.MoveTo(player.transform.position,false); 

					chasePlayer = true;
				
			}
		}

	}
}
