// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;


namespace Utils
{
	public class AlertQuestionWindow : MonoBehaviour
	{
		
		public UILabel title;
		public UILabel description;
		public UILabel yesLabel;
		public UILabel noLabel;
		
		public delegate void OnAnswer();
		public event OnAnswer onAnswered;
		
		public delegate void OnLeftAnswer();
		public event OnLeftAnswer onLeftAnswer;
		public AlertQuestionWindow ()
		{
		}
		public void onClose() {
			if(onLeftAnswer!=null) {
				onLeftAnswer();
			}
			Destroy (this.gameObject);
		}
		public void onAcceptanceResponseClick() {
			if(onAnswered!=null) {
				onAnswered();
			}
			Destroy(this.gameObject);
		}
		public void init(string aTitle,string aDescription,string aYesLabel,string aNoLabel) {
			title.text = aTitle;
			description.text = aDescription;
			yesLabel.text = aYesLabel;
			noLabel.text = aNoLabel;
		}
		
	}
}

