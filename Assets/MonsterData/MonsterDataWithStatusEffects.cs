using System;
using utils;
using Items;

public class MonsterDataWithStatusEffects : MonsterDataWithEVs
{
	public delegate void OnStatusEffectAdded(EStatusEffects aEffect);
	public event OnStatusEffectAdded onStatusEffectAdded;
	
	public delegate void OnStatusEffectRemoved(EStatusEffects aEffect);
	public event OnStatusEffectRemoved onStatusEffectRemoved;
	
	public delegate void OnStatusEffectsHPWithMove(int aPowerOfMove);
	public event OnStatusEffectsHPWithMove onStatusEffectsHPWithMove;
	
	public delegate void OnStatusEffectsHPByPercentage(float aPercentageOfHP);
	public event OnStatusEffectsHPByPercentage onStatusEffectsHPByPercentage;
	
	
	
	private LingeringEffects _lingering;
	public MonsterDataWithStatusEffects ()
	{
	}
	public byte modifiedCatchRate(ItemBait aItem) {
		//(3 × HPmax - 2 × HPcurrent) × (rate × bonusball) / (3 × HPmax) + bonusstatus
		float bonusValues = 0f;
		if((this.StatusEffects&EStatusEffects.Burn)==EStatusEffects.Burn) bonusValues += 5f;
		if((this.StatusEffects&EStatusEffects.Confusion)==EStatusEffects.Confusion) bonusValues += 2.5f;
		if((this.StatusEffects&EStatusEffects.Freeze)==EStatusEffects.Freeze) bonusValues += 10f;
		if((this.StatusEffects&EStatusEffects.Paralyze)==EStatusEffects.Paralyze) bonusValues += 10f;
		if((this.StatusEffects&EStatusEffects.Poison)==EStatusEffects.Poison) bonusValues += 2.5f;
		if((this.StatusEffects&EStatusEffects.Sleep)==EStatusEffects.Sleep) bonusValues += 10f;
		int catchRate = monsterBreedRef.catchRate;
		float ballStrength = aItem.ballStrength;
		float catchRateAsFloat = catchRate;
		float dividedBallStrength = ballStrength;
		float mulitpliedCatchBall = catchRateAsFloat*dividedBallStrength;
		if(mulitpliedCatchBall<1f) {
			mulitpliedCatchBall = 1f;
		} else if(mulitpliedCatchBall>1000f) {
			mulitpliedCatchBall = 1000f;
		}
		float rate = (3 * MaxHP - 2 * hp) * (mulitpliedCatchBall) / (3 * MaxHP) + bonusValues;
		if(rate>255) {
			return byte.MaxValue;
		}
		if(rate<0) {
			return 0;
		}
		return Convert.ToByte(rate);
	}
	 
	public override ERestingStatus restingStatus {
		get {
			return base._resting;
		}
		set {
			this.lingeringEffects.removeAllEffects();
			base._resting = value;
		}
	}
	public override void FromString(string aString) {
		string decode1 = Base64Compressor.Base64Decode(aString);
		string[] split = decode1.Split(new char[] {'|'});
		
		base.FromString(split[0]);
		if(split.Length>1) {
			string decode = Base64Compressor.Base64Decode(split[1]);
			lingeringEffects.FromString (decode);
		}
	}
	
	public override string ToString ()
	{
		string s = lingeringEffects.ToString();
		string r = base.ToString()+"|"+Base64Compressor.Base64Encode(s);
		return Base64Compressor.Base64Encode(r);
	}
	public void healAllStatusEffects()
	{
		this.lingeringEffects.removeAllEffects();
	}
	
	public EStatusEffects StatusEffects
	{
		set {
			if(this.lingeringEffects.StatusEffects!=value) {
				this.lingeringEffects.StatusEffects = value;
				OnStatusChanged();
			}
		}
		get {
			return this.lingeringEffects.StatusEffects;
		}
	}
	public BetterList<EStatusEffects> StatusEffectsAsList() {
		return this._lingering.StatusEffectsAsList();
	}
	
	
	
	
	public void addLingeringEffect(EStatusEffects aEffect,MoveLibItem aCause) {
		lingeringEffects.addEffect(aEffect,aCause);
	}
	public void removeLingeringEffect(EStatusEffects aEffect) {
		lingeringEffects.removeEffect(aEffect);
	}
	private void onEffectAdded(EStatusEffects aEffect) {
		if(this.onStatusEffectAdded!=null) {
			this.onStatusEffectAdded(aEffect);
		}
	}
	private void onEffectRemoved(EStatusEffects aEffect) {
		if(this.onStatusEffectRemoved!=null) {
			this.onStatusEffectRemoved(aEffect);
		}
		
	}
	private void onEffectsHPByPercentage(float aPercent) {
		
		if(this.onStatusEffectsHPByPercentage!=null) {
			this.onStatusEffectsHPByPercentage(aPercent);
		}
	}
	private void onEffectsHPByMovePower(int aPower) {
		if(this.onStatusEffectsHPWithMove!=null) {
			this.onStatusEffectsHPWithMove(aPower);
		}
	}
	
	public bool hasStatusEffect(EStatusEffects aEffect) {
		if(lingeringEffects.hasEffect(aEffect)) {
			return true;
		} else return false;
	}
	/*
	public override void initFromSFSObject(SFSObject aInitObject) {
		base.initFromSFSObject (aInitObject);
		string statusEffects = aInitObject.GetUtfString("statusEffects");
		this.lingeringEffects.FromString (statusEffects);
	}
	public override SFSObject toSFSObject(SFSObject aAddToThis) {
		aAddToThis = base.toSFSObject (aAddToThis);
		aAddToThis.PutUtfString("statusEffects",this.lingeringEffects.ToString());
		return aAddToThis;
	}*/

	public LingeringEffects lingeringEffects {
		get {
			if(_lingering==null) {
				_lingering = new LingeringEffects();
				_lingering.onStatusEffectAdded += onEffectAdded;
				_lingering.onStatusEffectRemoved += onEffectRemoved;
				_lingering.onStatusEffectsHPByPercentage += onEffectsHPByPercentage;
				_lingering.onStatusEffectsHPWithMove += onEffectsHPByMovePower;
			}
			return _lingering;
		}
	}
	
}

