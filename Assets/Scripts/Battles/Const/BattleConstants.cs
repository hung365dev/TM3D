using UnityEngine;
using Battles;
namespace Battles {
	public class BattleConstants : MonoBehaviour{
		public const int MAX_MONSTERS_PER_TEAM = 3;
		public const float floor = 0f;
		
		public const float zPosition = 6.75f;
		public const float zPositionMiddle = 3.75f; 
		public const float topXPosition = -4f;
		public const float middleXPosition = 0f;
		public static Vector3 POSITION_TEAM1_1 = new Vector3(topXPosition,floor,zPosition);
		public static Vector3 POSITION_TEAM1_MIDDLE = new Vector3(middleXPosition,floor,zPositionMiddle);
		public static Vector3 POSITION_TEAM1_2 = new Vector3(topXPosition*-1,floor,zPosition);
		
		
		public static Vector2 POSITION_PREVIEW = new Vector2(-1.8f,-1.2f);
		public static Vector2 POSITION_PREVIEW_RIGHT = new Vector2(2.42f,-0.3f);

		public static Vector3 POSITION_TEAM2_1 = new Vector3(topXPosition,floor,zPosition*-1);
		public static Vector3 POSITION_TEAM2_MIDDLE = new Vector3(middleXPosition,floor,zPositionMiddle*-1);
		public static Vector3 POSITION_TEAM2_2 = new Vector3(topXPosition*-1,floor,zPosition*-1);

		
		public static Vector3 MONSTER_SCALE = new Vector3(1f,1f,1f);
		/*
		public static Vector2 POSITION_LEFT_TOP = new Vector2(-2.44f,-0.25f);
		public static Vector2 POSITION_LEFT_MIDDLE = new Vector2(-1.2f,-1.0f);
		public static Vector2 POSITION_LEFT_BOTTOM = new Vector2(-3.5f,-1.5f);
		
		
		public static Vector2 POSITION_PREVIEW = new Vector2(-1.8f,-1.2f);
		public static Vector2 POSITION_PREVIEW_RIGHT = new Vector2(2.42f,-0.3f);
		
		public static Vector2 POSITION_RIGHT_TOP = new Vector2(2.44f,-0.25f);
		public static Vector2 POSITION_RIGHT_MIDDLE = new Vector2(1.2f,-1.0f);
		public static Vector2 POSITION_RIGHT_BOTTOM = new Vector2(3.5f,-1.5f);
		
		public static Vector2 TEXT_POSITION_LEFT_TOP = new Vector2(-310f,0f);
		public static Vector2 TEXT_POSITION_LEFT_MIDDLE = new Vector2(-200.0f,-100.0f);
		public static Vector2 TEXT_POSITION_LEFT_BOTTOM = new Vector2(-310f,-140f);
		
		
		public static Vector2 TEXT_POSITION_RIGHT_TOP = new Vector2(310f,0f);
		public static Vector2 TEXT_POSITION_RIGHT_MIDDLE = new Vector2(200.0f,-100.0f);
		public static Vector2 TEXT_POSITION_RIGHT_BOTTOM = new Vector2(310f,-140f);
		*/
		public static BattleControllerMain controllerRef;
		
		
		public const int FRONT_INDEX = 0;
		public const int TOP_INDEX = 2;
		public const int BOTTOM_INDEX = 1;
		public static BattleMonster gameObjectToBattleMonster(GameObject aObject) {
			BattleMonster monster = aObject.GetComponent(typeof(BattleMonster)) as BattleMonster;
			return monster;
		}
		
		public static Vector3 getFaceOffPosition(ETeamPosition aPosition,EMonsterPos aMonster,Vector3 aOffset) {
			float faceOffNegator = -1.5f;
			switch(aPosition) {
				case(ETeamPosition.LeftTeam):default: 
					switch(aMonster) {
						case(EMonsterPos.Top):
					return new Vector3(POSITION_TEAM1_1.x+aOffset.x,POSITION_TEAM1_1.y+aOffset.y,POSITION_TEAM1_1.z+faceOffNegator+aOffset.z);
						break;
					case(EMonsterPos.Front):default:
					return new Vector3(POSITION_TEAM1_MIDDLE.x+aOffset.x,POSITION_TEAM1_MIDDLE.y+aOffset.y,POSITION_TEAM1_MIDDLE.z+faceOffNegator+aOffset.z);
						break;
						case(EMonsterPos.Bottom):
					return new Vector3(POSITION_TEAM1_2.x+aOffset.x,POSITION_TEAM1_2.y+aOffset.y,POSITION_TEAM1_2.z+faceOffNegator+aOffset.z);
						break;
					
					}
					break;
			case(ETeamPosition.RightTeam):
				switch(aMonster) {
				case(EMonsterPos.Top):
					return new Vector3(POSITION_TEAM2_1.x+aOffset.x,POSITION_TEAM2_1.y+aOffset.y,POSITION_TEAM2_MIDDLE.z-faceOffNegator+aOffset.z);
					break;
				case(EMonsterPos.Front):default:
					return new Vector3(POSITION_TEAM2_MIDDLE.x+aOffset.x,POSITION_TEAM2_MIDDLE.y+aOffset.y,POSITION_TEAM2_MIDDLE.z-faceOffNegator+aOffset.z);
					break;
				case(EMonsterPos.Bottom):
					return new Vector3(POSITION_TEAM2_2.x+aOffset.x,POSITION_TEAM2_2.y+aOffset.y,POSITION_TEAM2_2.z-faceOffNegator+aOffset.z);
					break;
					
				}
				break; 
			}
		}
		public static Vector3 getMyPosition(ETeamPosition aPosition,EMonsterPos aMonster,Vector3 aOffset) {
			float faceOffNegator = 1.5f;
			switch(aPosition) {
			case(ETeamPosition.LeftTeam):default:
				switch(aMonster) {
				case(EMonsterPos.Top):
					return new Vector3(POSITION_TEAM1_1.x+aOffset.x,POSITION_TEAM1_1.y+aOffset.y,POSITION_TEAM1_1.z+aOffset.z);
					break;
				case(EMonsterPos.Front):default:
					return new Vector3(POSITION_TEAM1_MIDDLE.x+aOffset.x,POSITION_TEAM1_MIDDLE.y+aOffset.y,POSITION_TEAM1_MIDDLE.z+aOffset.z);
					break;
				case(EMonsterPos.Bottom):
					return new Vector3(POSITION_TEAM1_2.x+aOffset.x,POSITION_TEAM1_2.y+aOffset.y,POSITION_TEAM1_2.z+aOffset.z);
					break;
					
				}
				break;
			case(ETeamPosition.RightTeam):
				switch(aMonster) {
				case(EMonsterPos.Top):
					return new Vector3(POSITION_TEAM2_1.x+aOffset.x,POSITION_TEAM2_1.y+aOffset.y,POSITION_TEAM2_1.z+aOffset.z);
					break;
				case(EMonsterPos.Front):default:
					return new Vector3(POSITION_TEAM2_MIDDLE.x+aOffset.x,POSITION_TEAM2_MIDDLE.y+aOffset.y,POSITION_TEAM2_MIDDLE.z+aOffset.z);
					break;
				case(EMonsterPos.Bottom):
					return new Vector3(POSITION_TEAM2_2.x+aOffset.x,POSITION_TEAM2_2.y+aOffset.y,POSITION_TEAM2_2.z+aOffset.z);
					break;
					
				}
				break;
			}
		}
		public static void positionMonster(GameObject aMonsterObject,ETeamPosition aTeam,EMonsterPos aMonsterPosition,Vector3 aOffset) {
		
			Vector3 useVec = POSITION_TEAM1_MIDDLE;
			Quaternion useQ = new Quaternion(0,0,0,0);
			int layer = 8;
			switch(aTeam) {
				case(ETeamPosition.RightTeam): {
				
					switch(aMonsterPosition) {
						case(EMonsterPos.Top): useVec = POSITION_TEAM2_1;useQ = Quaternion.Euler(0,12,0);break;
						case(EMonsterPos.Front): useVec = POSITION_TEAM2_MIDDLE;useQ = Quaternion.Euler(0,0,0);break;
						case(EMonsterPos.Bottom): useVec = POSITION_TEAM2_2;useQ = Quaternion.Euler(0,-10,0);break;
					}
				}
				break;
				case(ETeamPosition.LeftTeam): {
					switch(aMonsterPosition) {
						case(EMonsterPos.Top): useVec = POSITION_TEAM1_1;useQ = Quaternion.Euler(0,170,0);;break;
						case(EMonsterPos.Front): useVec = POSITION_TEAM1_MIDDLE;useQ = Quaternion.Euler(0,180,0);break;
						case(EMonsterPos.Bottom): useVec = POSITION_TEAM1_2;useQ =useQ = Quaternion.Euler(0,-170,0);break;
					}
				}
				break;
				case(ETeamPosition.MonsterPreview): {
					useVec = POSITION_PREVIEW;useQ = Quaternion.Euler(0,0,0);break;
				}
				case(ETeamPosition.MonsterPreviewRight): {
					useVec = POSITION_PREVIEW_RIGHT;useQ = Quaternion.Euler(0,180,0);break;
				}
			}
			if(aMonsterObject!=null) {
				BattleMonster monster = aMonsterObject.GetComponent("BattleMonster") as BattleMonster;
				monster.initTargetDefaults (aTeam, aMonsterPosition); 
				Vector3 tempvect = new Vector3(useVec.x+aOffset.x, useVec.y+aOffset.y, useVec.z+aOffset.z);
				aMonsterObject.transform.position = tempvect;
				aMonsterObject.transform.rotation =useQ;
				aMonsterObject.transform.localScale = MONSTER_SCALE;
				aMonsterObject.layer = layer;
				Renderer[] allRenderers = aMonsterObject.GetComponentsInChildren<Renderer>();
				byte offset = 0;
				string monsterLayer = "MonsterLayer1";
				switch(aMonsterPosition) {
					case(EMonsterPos.Top):
					break;
					case(EMonsterPos.Front):
					offset = 50;
					monsterLayer = "MonsterLayer2";
					break;
					case(EMonsterPos.Bottom):
					offset = 100;
					monsterLayer = "MonsterLayer3";
					break;
				}
				if(allRenderers.Length==1) {
					Debug.Log("1");
				}
				for(int i = 0;i<allRenderers.Length;i++) {
					allRenderers[i].sortingLayerName = monsterLayer;
			//		SortingOrderUpdate sortOrder = allRenderers[i].GetComponent<SortingOrderUpdate>();
				//	sortOrder.sortOffset = offset;
					allRenderers[i].sortingOrder += offset;
					if(allRenderers[i].gameObject.name.ToLower().Contains("shadow")) {
						allRenderers[i].sortingLayerName = "BackgroundLayer";
						allRenderers[i].sortingOrder = 2;
					}
				}
				
			}
			
		}
	}
}