using UnityEngine;
using System.Collections;
using UMA;

using System.IO;

public class UMAMaker : MonoBehaviour {
	public UMAGeneratorBase generator;
	public SlotLibrary slotLibrary;
	public OverlayLibrary overlayLibrary;
	public RaceLibrary raceLibrary;


	public RuntimeAnimatorController animController;
	private UMADynamicAvatar umaDynamicAvatar;
	private UMAData umaData;
	private UMADnaHumanoid umaDna;

	
	private int numberOfSlots = 20;
	

	[Range (0.0f, 1.0f)]
	public float bodyMass = 0.5f;


	public bool vestState = false;
	private bool lastVestState = false;


	public Color vestColor = Color.blue;
	private Color lastVestColor = Color.blue;


	public bool hairState = false;
	private bool lastHairState = false;
		
	public Color hairColor = Color.black;
	private Color lastHairColor;

	public string SaveString = "";
	public bool save;
	public bool load;

	private float _height = 1.0f;
	void Start() {
		GenerateUMA();
	}
	void findUMAStuff() {
		this.slotLibrary = GameObject.Find ("SlotLibrary").GetComponent<SlotLibrary>();
		this.generator = GameObject.Find ("UMAGenerator").GetComponent<UMAGenerator>();
		this.overlayLibrary = GameObject.Find("OverlayLibrary").GetComponent<OverlayLibrary>();
		this.raceLibrary = GameObject.Find ("RaceLibrary").GetComponent<RaceLibrary>();
		
	}

	public float height {
		set {
			if(_height!=value) {
				_height = value;
				umaDna.height = value;
				umaData.isShapeDirty = true;
				umaData.Dirty();
			}
		}
		get {
			return _height;
		}
	}
	void Update() {
		if(bodyMass!=umaDna.upperMuscle) {
			SetBodyMass(bodyMass);
			umaData.isShapeDirty = true;
			umaData.Dirty();
		}

		if(vestState && !lastVestState) {
			lastVestState = vestState;
			AddOverlay(3,"SA_Tee",vestColor);
			AddOverlay(3,"SA_Logo");

			umaData.isTextureDirty = true;
			umaData.Dirty();
		} else if(!vestState && lastVestState) {
			lastVestState = vestState;
			this.RemoveOverlay(3,"SA_Tee");
			this.RemoveOverlay(3,"SA_Logo");
			umaData.isTextureDirty = true;
			umaData.Dirty();
		}

		if(vestColor != lastVestColor && vestState) {
			ColorOverlay(3,"SA_Tee",vestColor);
			lastVestColor = vestColor;
			umaData.isTextureDirty = true;
			umaData.Dirty();
		}

		if(hairState && !lastHairState) {
			lastHairState = hairState;
			SetSlot(7,"M_Hair_Shaggy");
			AddOverlay(7,"M_Hair_Shaggy",hairColor);
			umaData.isMeshDirty = true;
			umaData.isTextureDirty = true;
			umaData.isShapeDirty = true;
			umaData.Dirty();
		}
		if(!hairState && lastHairState) {
			lastHairState = hairState;
			this.RemoveSlot(7);
			umaData.isMeshDirty = true;
			umaData.isTextureDirty = true;
			umaData.isShapeDirty = true;
			umaData.Dirty();
			
		}

		if(hairColor != lastHairColor && hairState) {
			lastHairColor = hairColor;
			ColorOverlay(7,"M_Hair_Shaggy",hairColor);
			umaData.isTextureDirty = true;
			umaData.Dirty();
		}

		if(this.save) {
			save = false;
			Save();
		}
		if(this.load) {
			load = false;
			this.Load();
		}		
	}

	void GenerateUMA() {
		if(this.slotLibrary==null) {
			findUMAStuff();
		}
		GameObject GO = new GameObject("MyUMA");
		umaDynamicAvatar = GO.AddComponent<UMADynamicAvatar>();
	
		this.umaDynamicAvatar.Initialize();
		umaData = this.umaDynamicAvatar.umaData;

		umaDynamicAvatar.umaGenerator = generator;
		umaData.umaGenerator = generator;

		umaData.umaRecipe.slotDataList = new SlotData[numberOfSlots];

		umaDna = new UMADnaHumanoid();
		umaData.umaRecipe.AddDna(umaDna);
		

		CreateMale();

		umaDynamicAvatar.animationController = this.animController;
		umaDynamicAvatar.UpdateNewRace();
	 
		GO.transform.parent = this.gameObject.transform;
		GO.transform.localPosition = Vector3.zero;
		GO.transform.localRotation = Quaternion.identity;
	} 

	void CreateMale() {    
		UMA.UMAData.UMARecipe umaRecipe = umaDynamicAvatar.umaData.umaRecipe;
		umaRecipe.SetRace(raceLibrary.GetRace("BoyRace"));
		  

		SetSlot(0,"Torso");
		this.AddOverlay(0,"DefaultOverlay");
		SetSlot(1,"Arms");
		SetSlot(2,"Feet");
		SetSlot(3,"Head");
		SetSlot(4,"Legs");
		SetSlot(5,"Pelvis");
		SetSlot(6,"ChibiBody_Head");
		this.LinkOverlay(1,0);
		this.LinkOverlay(2,0);
		this.LinkOverlay(3,0);
		this.LinkOverlay(4,0);
		this.LinkOverlay(5,0);
		this.LinkOverlay(6,0);
		SetSlot(7,"Eyes");
		
		SetSlot(8,"Jeans");
		this.AddOverlay(7,"EyesOverlay");
		this.AddOverlay(8,"JeansOverlay");
	//	this.AddOverlay(0,"DefaultOverlay");
				

/*
		colin mcdonald
		all 4 games - publisher

		umaData.umaRecipe.slotDataList[2] = slotLibrary.InstantiateSlot("GirlHead");
		umaData.umaRecipe.slotDataList[2].AddOverlay(overlayLibrary.InstantiateOverlay("HeadOverlay"));
		
		umaData.umaRecipe.slotDataList[3] = slotLibrary.InstantiateSlot("GirlLegs");
		umaData.umaRecipe.slotDataList[4] = slotLibrary.InstantiateSlot("GirlPelvis");
		

		
		umaData.umaRecipe.slotDataList[5] = slotLibrary.InstantiateSlot("GirlScalp");
		

		
		umaData.umaRecipe.slotDataList[6] = slotLibrary.InstantiateSlot("GirlTorso");
		
		umaData.umaRecipe.slotDataList[7] = slotLibrary.InstantiateSlot("Hands");
		umaData.umaRecipe.slotDataList[8] = slotLibrary.InstantiateSlot("GirlArms");
		
		
		umaData.umaRecipe.slotDataList[1].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
//		umaData.umaRecipe.slotDataList[2].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[3].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[4].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[5].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[6].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[7].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());
		umaData.umaRecipe.slotDataList[8].SetOverlayList(umaData.umaRecipe.slotDataList[0].GetOverlayList());

*/

	}

	///////// UMA MORPH ROUTINES

	private void SetBodyMass(float aMass) {
		umaDna.upperMuscle = aMass;
		umaDna.upperWeight = aMass;
		umaDna.lowerMuscle = aMass;
		umaDna.lowerWeight = aMass;
		umaDna.armWidth = aMass;
		umaDna.forearmWidth = aMass;

	}

	private void AddOverlay(int aSlot,string aOverlayName) {
		
		umaData.umaRecipe.slotDataList[aSlot].AddOverlay(overlayLibrary.InstantiateOverlay(aOverlayName));
	}

	private void AddOverlay(int aSlot,string aOverlayName,Color aColor) {
		umaData.umaRecipe.slotDataList[aSlot].AddOverlay(overlayLibrary.InstantiateOverlay(aOverlayName,aColor));
	}
	private void LinkOverlay(int aSlotNumber,int aSlotLink) {
		
		umaData.umaRecipe.slotDataList[aSlotNumber].SetOverlayList(umaData.umaRecipe.slotDataList[aSlotLink].GetOverlayList());
	}

	private void RemoveOverlay(int aSlotNumber,string aOverlayName) {
		umaData.umaRecipe.slotDataList[aSlotNumber].RemoveOverlay(aOverlayName);
	}

	private void ColorOverlay(int aSlotNumber,string aOverlayName,Color aColor) {
		umaData.umaRecipe.slotDataList[aSlotNumber].SetOverlayColor(aColor,aOverlayName);
	}

	private void SetSlot(int aSlotNumber,string aSlotName) {
		umaData.umaRecipe.slotDataList[aSlotNumber] = slotLibrary.InstantiateSlot(aSlotName);
	}

	private void RemoveSlot(int aSlotNumber) {
		umaData.umaRecipe.slotDataList[aSlotNumber] = null;
	}

	private void Save() {
		UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
		recipe.Save(umaDynamicAvatar.umaData.umaRecipe,umaDynamicAvatar.context);
		
		SaveString = recipe.recipeString;

		Destroy(recipe);

		string filename = "Assets/Test.txt";
		StreamWriter stream = File.CreateText(filename);

		stream.WriteLine(SaveString);
		stream.Close();
	}
	
	private void Load() {
		string filename = "Assets/Test.txt";
		StreamReader stream = File.OpenText(filename);
		SaveString = stream.ReadLine();
		stream.Close();

		UMATextRecipe recipe = ScriptableObject.CreateInstance<UMATextRecipe>();
		recipe.recipeString = SaveString;
		umaDynamicAvatar.Load(recipe);
		Destroy(recipe);
	}
}
