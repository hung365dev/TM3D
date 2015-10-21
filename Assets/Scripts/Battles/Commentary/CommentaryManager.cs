using System;
using UnityEngine;


namespace Battles
{
	public class CommentaryManager : MonoBehaviour
	{
		public float fadeSpeed;
		public float moveSpeed;
		public float damageFadeSpeed;
		public float damageMoveSpeed;
		public int yDistance;
		public float minimumTime = 1.5f;
		private BetterList<CommentaryMessageSettings> _messages = new BetterList<CommentaryMessageSettings>();
		private float _nextAllowedMessage = 0.0f;
		public UILabel mainLabel;
		public UILabel responsiblePassiveEffect;
		
		public UIRoot root;
		public GameObject commentaryDamageMessage;
		public GameObject commentaryStandardMessage;
		public GameObject commentaryBoostMessage;
		public GameObject commentaryEffective;
		public GameObject commentaryInEffective;
		public GameObject commentaryDecisiveBlow;
		public PassiveEffect passiveEffect;
		public BattleMonster battleMonster;
		
		
		public PassiveEffect defendersPassiveEffect;
		public BattleMonster defenderMonster;
		
		
		public static CommentaryManager REF;
		public bool fadedOut = false;
		public CommentaryManager ()
		{
		}
		
		public int messagesSize = 0;
		
		public void Start() {
			REF = this;
		}
		
		public void OnDestroy() {
			REF = null;
		}
		public void addCommentaryMessage(string aMessage,ECommentaryMessageType aType,ECommentaryMessagePosition aMessagePosition) {
			_messages.Add(new CommentaryMessageSettings(aMessage,aType,aMessagePosition,passiveEffect,battleMonster));
			 

		}
		
		public void addCommentaryInEffectiveMessage(string aMessage,GameObject aMonster) {
			GameObject prefab = NGUITools.AddChild(this.gameObject.transform.parent.gameObject,this.commentaryInEffective);
			UILabel label = prefab.GetComponent<UILabel>();
			label.text = aMessage;
/*			UIFollowTarget followTarget = (UIFollowTarget) prefab.AddComponent<UIFollowTarget>();
			followTarget.initTarget(aMonster.gameObject.transform);;
			followTarget.heightOffset = 0f;
			followTarget.heightToAddPerFrame = 0f;*/
			prefab.transform.localScale = new Vector3(1f,1f,1f);
			
			TweenAlpha.Begin(prefab,damageFadeSpeed,0.0f);
			Destroy(prefab,damageFadeSpeed);
			
		}
		public void addCommentaryEffectiveMessage(string aMessage,GameObject aMonster) {
			GameObject prefab = NGUITools.AddChild(this.gameObject.transform.parent.gameObject,this.commentaryEffective);
			UILabel label = prefab.GetComponent<UILabel>();
			label.text = aMessage;
	/*		UIFollowTarget followTarget = (UIFollowTarget) prefab.AddComponent<UIFollowTarget>();
			followTarget.initTarget(aMonster.gameObject.transform);;
			followTarget.heightOffset = 0;
			followTarget.heightToAddPerFrame = 0f;*/
			prefab.transform.localScale = new Vector3(1f,1f,1f);
			
			TweenAlpha.Begin(prefab,damageFadeSpeed,0.0f);
			Destroy(prefab,damageFadeSpeed);
			
		}
		public void addCommentaryMessage(string aMessage,ECommentaryMessageType aType,ETeamPosition aTeamPosition,EMonsterPos aMonsterPosition,GameObject aMonster) {
			GameObject prefab;
			if(aType!=ECommentaryMessageType.DmgCritical) {
				prefab = NGUITools.AddChild(this.gameObject.transform.parent.gameObject,commentaryDamageMessage);
				
			} else {
				prefab = NGUITools.AddChild(this.gameObject.transform.parent.gameObject,this.commentaryDecisiveBlow);
				
			}
				UILabel label = prefab.GetComponent<UILabel>();
			label.text = aMessage;
		//	UIFollowTarget followTarget = prefab.GetComponent("UIFollowTarget") as UIFollowTarget;
			//UIFollowTarget followTarget = (UIFollowTarget) prefab.AddComponent<UIFollowTarget>();
			/*followTarget.initTarget(aMonster.gameObject.transform);;
			if(aType==ECommentaryMessageType.DmgCritical) {
				
				followTarget.heightToAddPerFrame = 0f;
				followTarget.heightOffset = 30;
				
			} else {
				followTarget.heightToAddPerFrame = 2f;
				followTarget.heightOffset = 10;
			}*/
			prefab.transform.localScale = new Vector3(1f,1f,1f);
			
			TweenAlpha.Begin(prefab,damageFadeSpeed,0.0f);
			
			//TweenPosition.Begin(prefab,damageMoveSpeed,new Vector3(prefab.transform.position.x,prefab.transform.position.y+yDistance,prefab.transform.position.z));
			Destroy(prefab,damageFadeSpeed);
		}
		
		public void Update() {
			messagesSize = _messages.size;
			if(Time.time>_nextAllowedMessage&&_messages.size>0) {
				
				if(fadedOut) {
					TweenAlpha.Begin(this.gameObject,0.5f,1f);
					fadedOut = false;
				}
				_nextAllowedMessage = Time.time+minimumTime;
				CommentaryMessageSettings message = _messages[0];
				_messages.RemoveAt(0);
				
		//		mainLabel.transform.localScale = new Vector3(1f,1f,1f);
				mainLabel.text = message.message;
				if(message.passiveEffect!=null) {
					Debug.Log (message.monster);
					Debug.Log (responsiblePassiveEffect);
					
					responsiblePassiveEffect.text = message.monster.name+" Passive Effect: "+message.passiveEffect.name;
				} else {
					responsiblePassiveEffect.text = "";
				}
				TweenAlpha.Begin(mainLabel.gameObject,fadeSpeed,1.0f);
				
			//	TweenAlpha.Begin(mainLabel.gameObject,fadeSpeed,0.0f);
			//	TweenPosition.Begin(newItem,moveSpeed,new Vector3(newItem.transform.position.x,newItem.transform.position.y+yDistance,newItem.transform.position.z));
				
			//	Destroy(newItem,fadeSpeed);
			} else
			if(_messages.size==0&&Time.time>_nextAllowedMessage) {
				TweenAlpha.Begin(this.gameObject,0.5f,0.01f);
				fadedOut = true;
			}
			

		}
	}
}

