using UnityEngine;
using System.Collections;
using Apex;
using Apex.Steering;
using Battles;
using Apex.Units;
using Apex.Steering.Behaviours;
using UnityEditor;
using Apex.Steering.Components;
using Apex.PathFinding;
using Apex.Steering.HeightNavigation;
using Apex.Debugging;


[ExecuteInEditMode]
public class SpawnMonsterOnMap : MonoBehaviour {

	// If player is further than this away, I'll destroy myself
	public IMovingObject apexMain;
	public Animator anim; 
	public AnimationClip defaultClip;
	public GameObject childToAnimate;
	public SteerableUnitComponent steerable;
	public IUnitFacade unit;
	public const int MAX_DISTANCE_TO_PLAYER = 100;
	public const int MAX_CHASE_DISTANCE = 40;
	public const int MAX_DISTANCE_TO_START_BATTLE = 5;
	public GameObject player;
	public bool chasePlayer = false;
	public WanderBehaviour wander;
	public MonsterLibraryRecord monster;
	// Use this for initialization
	public string name;
	public byte level; 
	void Start () {
		
		if(!EditorApplication.isPlaying) {
		} else {
			var go = this.gameObject;
			ApexComponentMaster master;
			Rigidbody rb;
			
			//Add the required components
		/*	go.AddIfMissing<Rigidbody>(go, false, out rb);
			bool toggleAll = go.AddIfMissing<ApexComponentMaster>(false, out master);
			go.AddIfMissing<HumanoidSpeedComponent>(false);
			go.AddIfMissing<UnitComponent>(false);
			go.AddIfMissing<SteerableUnitComponent>(go, false);
			go.AddIfMissing<DefaultHeightNavigator>(go, false);
			go.AddIfMissing<PathOptionsComponent>(go, false);
			go.AddIfMissing<SteerToAlignWithVelocity>(go, false);
			go.AddIfMissing<SteerForPathComponent>(go, 5);
			go.AddIfMissing<PathVisualizer>(go, false);
			
*/
			
			Rigidbody r;
			this.gameObject.AddIfMissing<Rigidbody>(out r);

			ApexComponentMaster apexM; 
			HumanoidSpeedComponent hsc;
			PathOptionsComponent poc;
			UnitComponent uni;
			SteerToAlignWithVelocity steer;
			SteerForPathComponent sfp;
			WanderBehaviour wand;
			DefaultHeightNavigator dfn;
			SteerableUnitComponent suc;
			SpeedComponent sc;
			this.gameObject.AddIfMissing<ApexComponentMaster>(out apexM);
			
			this.gameObject.AddIfMissing<HumanoidSpeedComponent>(out hsc);
			
			this.gameObject.AddIfMissing<UnitComponent>(out uni);
			this.gameObject.AddIfMissing<SteerForPathComponent>(out sfp);
			this.gameObject.AddIfMissing<SteerableUnitComponent>(out suc);
			
			this.gameObject.AddIfMissing<DefaultHeightNavigator>(out dfn);
			this.gameObject.AddIfMissing<PathOptionsComponent>(out poc);
			this.gameObject.AddIfMissing<SteerToAlignWithVelocity>(out steer);
			
			this.gameObject.AddIfMissing<SpeedComponent>(out sc);
			apexMain = this.GetComponent<IMovingObject> ();
			if(apexMain==null) {
				apexMain = gameObject.AddComponent<SteerableUnitComponent>();
			}
			apexM.ToggleAll();
			
			unit = this.GetUnitFacade (true);
			this.gameObject.AddIfMissing<WanderBehaviour>(out wand);
			anim = this.GetComponentInChildren<Animator> ();
			steerable = (SteerableUnitComponent) apexMain;
			
			suc.enabled = true;
			sc.enabled = true;
			uni.enabled = true;
			poc.enabled = true;
			dfn.enabled = true;
			sfp.enabled = true;
			steer.enabled = true;
			apexM.enabled = true;

			
			BattleMonster m = this.GetComponentInChildren<BattleMonster> ();
			if (m != null) {
				Destroy (m);
			}
		}
		player = GameObject.FindGameObjectWithTag ("Player");
		wander = GetComponent<WanderBehaviour> ();

		
	} 
	
	// Update is called once per frame
	void Update () {
		if(!EditorApplication.isPlaying) {
			if(anim!=null) {
				AnimationMode.BeginSampling();
				AnimationMode.SampleAnimationClip(childToAnimate, this.defaultClip,1f);
				AnimationMode.EndSampling();
				
				SceneView.RepaintAll();
			}
			Debug.Log ("Animator is: "+anim);
		} else {
			anim.enabled = true;
		}
		if(steerable==null) {
			return;
		}
		float s = steerable.actualVelocity.magnitude;
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
					wander.enabled = true;
				} else if(s<=0.1f) {
					wander.enabled = true;
					chasePlayer = false;
				}
			}
		} else {
			if(distanceToPlayer < MAX_CHASE_DISTANCE) {
				
					wander.enabled = false;
					unit.MoveTo(player.transform.position,false); 

					chasePlayer = true;
				
			} else {
				if(!wander.isActiveAndEnabled) {
					wander.enabled = true;
					chasePlayer = false;
					wander.MoveNext(false);
				}
			}
		}

	}
}
