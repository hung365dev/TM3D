//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class NPCBattlesRow : IGoogle2uRow
	{
		public int _ID;
		public string _BattleName;
		public string _Map;
		public string _NPCName;
		public string _NPCInBattleName;
		public string _BattleBG;
		public string _ForcedConversation;
		public string _IncludedNPCActor;
		public string _ConversationMainActor;
		public int _CashReward;
		public string _ItemsReward;
		public string _BattleMusic;
		public NPCBattlesRow(string __v, string __ID, string __BattleName, string __Map, string __NPCName, string __NPCInBattleName, string __BattleBG, string __ForcedConversation, string __IncludedNPCActor, string __ConversationMainActor, string __CashReward, string __ItemsReward, string __BattleMusic) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_BattleName = __BattleName.Trim();
			_Map = __Map.Trim();
			_NPCName = __NPCName.Trim();
			_NPCInBattleName = __NPCInBattleName.Trim();
			_BattleBG = __BattleBG.Trim();
			_ForcedConversation = __ForcedConversation.Trim();
			_IncludedNPCActor = __IncludedNPCActor.Trim();
			_ConversationMainActor = __ConversationMainActor.Trim();
			{
			int res;
				if(int.TryParse(__CashReward, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_CashReward = res;
				else
					Debug.LogError("Failed To Convert _CashReward string: "+ __CashReward +" to int");
			}
			_ItemsReward = __ItemsReward.Trim();
			_BattleMusic = __BattleMusic.Trim();
		}

		public int Length { get { return 12; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _ID.ToString();
					break;
				case 1:
					ret = _BattleName.ToString();
					break;
				case 2:
					ret = _Map.ToString();
					break;
				case 3:
					ret = _NPCName.ToString();
					break;
				case 4:
					ret = _NPCInBattleName.ToString();
					break;
				case 5:
					ret = _BattleBG.ToString();
					break;
				case 6:
					ret = _ForcedConversation.ToString();
					break;
				case 7:
					ret = _IncludedNPCActor.ToString();
					break;
				case 8:
					ret = _ConversationMainActor.ToString();
					break;
				case 9:
					ret = _CashReward.ToString();
					break;
				case 10:
					ret = _ItemsReward.ToString();
					break;
				case 11:
					ret = _BattleMusic.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "ID":
					ret = _ID.ToString();
					break;
				case "BattleName":
					ret = _BattleName.ToString();
					break;
				case "Map":
					ret = _Map.ToString();
					break;
				case "NPCName":
					ret = _NPCName.ToString();
					break;
				case "NPCInBattleName":
					ret = _NPCInBattleName.ToString();
					break;
				case "BattleBG":
					ret = _BattleBG.ToString();
					break;
				case "ForcedConversation":
					ret = _ForcedConversation.ToString();
					break;
				case "IncludedNPCActor":
					ret = _IncludedNPCActor.ToString();
					break;
				case "ConversationMainActor":
					ret = _ConversationMainActor.ToString();
					break;
				case "CashReward":
					ret = _CashReward.ToString();
					break;
				case "ItemsReward":
					ret = _ItemsReward.ToString();
					break;
				case "BattleMusic":
					ret = _BattleMusic.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "BattleName" + " : " + _BattleName.ToString() + "} ";
			ret += "{" + "Map" + " : " + _Map.ToString() + "} ";
			ret += "{" + "NPCName" + " : " + _NPCName.ToString() + "} ";
			ret += "{" + "NPCInBattleName" + " : " + _NPCInBattleName.ToString() + "} ";
			ret += "{" + "BattleBG" + " : " + _BattleBG.ToString() + "} ";
			ret += "{" + "ForcedConversation" + " : " + _ForcedConversation.ToString() + "} ";
			ret += "{" + "IncludedNPCActor" + " : " + _IncludedNPCActor.ToString() + "} ";
			ret += "{" + "ConversationMainActor" + " : " + _ConversationMainActor.ToString() + "} ";
			ret += "{" + "CashReward" + " : " + _CashReward.ToString() + "} ";
			ret += "{" + "ItemsReward" + " : " + _ItemsReward.ToString() + "} ";
			ret += "{" + "BattleMusic" + " : " + _BattleMusic.ToString() + "} ";
			return ret;
		}
	}
	public sealed class NPCBattles : IGoogle2uDB
	{
		public enum rowIds {
			BBG_1, BBG_2, BBG_3, BBG_4, BBG_5, BBG_6, BBG_7, BBG_8, BBG_9, BBG_10, BBG_11, BBG_12, BBG_13, BBG_14, BBG_15, BBG_16, BBG_17, BBG_18
			, BBG_19, BBG_20, BBG_21, BBG_22, BBG_23, BBG_24, BBG_25, BBG_26, BBG_27, BBG_28, BBG_29, BBG_30, BBG_31, BBG_32, BBG_33, BBG_34, BBG_35, BBG_36, BBG_37, BBG_38
			, BBG_39, BBG_40, BBG_41, BBG_42, BBG_43, BBG_44, BBG_45, BBG_46, BBG_47, BBG_48, BBG_49, BBG_50, BBG_51, BBG_52, BBG_53, BBG_54, BBG_55, BBG_56, BBG_57, BBG_58
			, BBG_59, BBG_60, BBG_61, BBG_62, BBG_63, BBG_64, BBG_65, BBG_66, BBG_67, BBG_68, BBG_69, BBG_70, BBG_71, BBG_72, BBG_73, BBG_74, BBG_75, BBG_76, BBG_77, BBG_78
			, BBG_79, BBG_80, BBG_81, BBG_82, BBG_83, BBG_84, BBG_85, BBG_86, BBG_87, BBG_88, BBG_89, BBG_90, BBG_91, BBG_92, BBG_93, BBG_94, BBG_95, BBG_96, BBG_97, BBG_98
			, BBG_99, BBG_100, BBG_101, BBG_102, BBG_103, BBG_104, BBG_105, BBG_106, BBG_107, BBG_108, BBG_109, BBG_110, BBG_111, BBG_112, BBG_113, BBG_114, BBG_115, BBG_116, BBG_117, BBG_118
			, BBG_119, BBG_120, BBG_121, BBG_122, BBG_123, BBG_124, BBG_125, BBG_126, BBG_127, BBG_128, BBG_129, BBG_130, BBG_131, BBG_132, BBG_133, BBG_134, BBG_135, BBG_136, BBG_137, BBG_138
			, BBG_139, BBG_140, BBG_141, BBG_142, BBG_143, BBG_144, BBG_145, BBG_146, BBG_147, BBG_148, BBG_149, BBG_150, BBG_151, BBG_152, BBG_153, BBG_154, BBG_155, BBG_156, BBG_157, BBG_158
			, BBG_159, BBG_160, BBG_161, BBG_162, BBG_163, BBG_164, BBG_165, BBG_166, BBG_167, BBG_168, BBG_169, BBG_170, BBG_171, BBG_172, BBG_173, BBG_174, BBG_175, BBG_176, BBG_177, BBG_178
			, BBG_179, BBG_180, BBG_181, BBG_182, BBG_183, BBG_184, BBG_185, BBG_186, BBG_187, BBG_188, BBG_189, BBG_190, BBG_191, BBG_192, BBG_193, BBG_194, BBG_195, BBG_196, BBG_197, BBG_198
			, BBG_199, BBG_200, BBG_201, BBG_202, BBG_203, BBG_204, BBG_205, BBG_206, BBG_207, BBG_208, BBG_209, BBG_210, BBG_211, BBG_212, BBG_213, BBG_214, BBG_215, BBG_216, BBG_217, BBG_218
			, BBG_219, BBG_220, BBG_221, BBG_222, BBG_223, BBG_224, BBG_225, BBG_226, BBG_227, BBG_228, BBG_229, BBG_230, BBG_231, BBG_232, BBG_233, BBG_234, BBG_235, BBG_236, BBG_237, BBG_238
			, BBG_239, BBG_240, BBG_241, BBG_242, BBG_243, BBG_244, BBG_245, BBG_246, BBG_247, BBG_248, BBG_249, BBG_250, BBG_251, BBG_252, BBG_253, BBG_254, BBG_255, BBG_256, BBG_257, BBG_258
			, BBG_259, BBG_260, BBG_261, BBG_262, BBG_263, BBG_264, BBG_265, BBG_266, BBG_267, BBG_268, BBG_269, BBG_270, BBG_271, BBG_272, BBG_273, BBG_274, BBG_275, BBG_276, BBG_277, BBG_278
			, BBG_279, BBG_280, BBG_281, BBG_282, BBG_283, BBG_284, BBG_285, BBG_286, BBG_287, BBG_288, BBG_289, BBG_290, BBG_291, BBG_292, BBG_293, BBG_294, BBG_295, BBG_296, BBG_297, BBG_298
			, BBG_299, BBG_300, BBG_301, BBG_302, BBG_303, BBG_304, BBG_305, BBG_306, BBG_307, BBG_308, BBG_309, BBG_310, BBG_311, BBG_312, BBG_313, BBG_314, BBG_315, BBG_316, BBG_317, BBG_318
			, BBG_319, BBG_320, BBG_321, BBG_322, BBG_323, BBG_324, BBG_325, BBG_326, BBG_327, BBG_328, BBG_329, BBG_330, BBG_331, BBG_332, BBG_333, BBG_334, BBG_335, BBG_336, BBG_337, BBG_338
			, BBG_339, BBG_340, BBG_341, BBG_342, BBG_343, BBG_344, BBG_345, BBG_346, BBG_347, BBG_348, BBG_349, BBG_350, BBG_351, BBG_352, BBG_353, BBG_354, BBG_355, BBG_356, BBG_357, BBG_358
			, BBG_359, BBG_360, BBG_361, BBG_362, BBG_363, BBG_364, BBG_365, BBG_366, BBG_367, BBG_368, BBG_369, BBG_370, BBG_371, BBG_372, BBG_373, BBG_374, BBG_375, BBG_376, BBG_377, BBG_378
			, BBG_379, BBG_380
		};
		public string [] rowNames = {
			"BBG_1", "BBG_2", "BBG_3", "BBG_4", "BBG_5", "BBG_6", "BBG_7", "BBG_8", "BBG_9", "BBG_10", "BBG_11", "BBG_12", "BBG_13", "BBG_14", "BBG_15", "BBG_16", "BBG_17", "BBG_18"
			, "BBG_19", "BBG_20", "BBG_21", "BBG_22", "BBG_23", "BBG_24", "BBG_25", "BBG_26", "BBG_27", "BBG_28", "BBG_29", "BBG_30", "BBG_31", "BBG_32", "BBG_33", "BBG_34", "BBG_35", "BBG_36", "BBG_37", "BBG_38"
			, "BBG_39", "BBG_40", "BBG_41", "BBG_42", "BBG_43", "BBG_44", "BBG_45", "BBG_46", "BBG_47", "BBG_48", "BBG_49", "BBG_50", "BBG_51", "BBG_52", "BBG_53", "BBG_54", "BBG_55", "BBG_56", "BBG_57", "BBG_58"
			, "BBG_59", "BBG_60", "BBG_61", "BBG_62", "BBG_63", "BBG_64", "BBG_65", "BBG_66", "BBG_67", "BBG_68", "BBG_69", "BBG_70", "BBG_71", "BBG_72", "BBG_73", "BBG_74", "BBG_75", "BBG_76", "BBG_77", "BBG_78"
			, "BBG_79", "BBG_80", "BBG_81", "BBG_82", "BBG_83", "BBG_84", "BBG_85", "BBG_86", "BBG_87", "BBG_88", "BBG_89", "BBG_90", "BBG_91", "BBG_92", "BBG_93", "BBG_94", "BBG_95", "BBG_96", "BBG_97", "BBG_98"
			, "BBG_99", "BBG_100", "BBG_101", "BBG_102", "BBG_103", "BBG_104", "BBG_105", "BBG_106", "BBG_107", "BBG_108", "BBG_109", "BBG_110", "BBG_111", "BBG_112", "BBG_113", "BBG_114", "BBG_115", "BBG_116", "BBG_117", "BBG_118"
			, "BBG_119", "BBG_120", "BBG_121", "BBG_122", "BBG_123", "BBG_124", "BBG_125", "BBG_126", "BBG_127", "BBG_128", "BBG_129", "BBG_130", "BBG_131", "BBG_132", "BBG_133", "BBG_134", "BBG_135", "BBG_136", "BBG_137", "BBG_138"
			, "BBG_139", "BBG_140", "BBG_141", "BBG_142", "BBG_143", "BBG_144", "BBG_145", "BBG_146", "BBG_147", "BBG_148", "BBG_149", "BBG_150", "BBG_151", "BBG_152", "BBG_153", "BBG_154", "BBG_155", "BBG_156", "BBG_157", "BBG_158"
			, "BBG_159", "BBG_160", "BBG_161", "BBG_162", "BBG_163", "BBG_164", "BBG_165", "BBG_166", "BBG_167", "BBG_168", "BBG_169", "BBG_170", "BBG_171", "BBG_172", "BBG_173", "BBG_174", "BBG_175", "BBG_176", "BBG_177", "BBG_178"
			, "BBG_179", "BBG_180", "BBG_181", "BBG_182", "BBG_183", "BBG_184", "BBG_185", "BBG_186", "BBG_187", "BBG_188", "BBG_189", "BBG_190", "BBG_191", "BBG_192", "BBG_193", "BBG_194", "BBG_195", "BBG_196", "BBG_197", "BBG_198"
			, "BBG_199", "BBG_200", "BBG_201", "BBG_202", "BBG_203", "BBG_204", "BBG_205", "BBG_206", "BBG_207", "BBG_208", "BBG_209", "BBG_210", "BBG_211", "BBG_212", "BBG_213", "BBG_214", "BBG_215", "BBG_216", "BBG_217", "BBG_218"
			, "BBG_219", "BBG_220", "BBG_221", "BBG_222", "BBG_223", "BBG_224", "BBG_225", "BBG_226", "BBG_227", "BBG_228", "BBG_229", "BBG_230", "BBG_231", "BBG_232", "BBG_233", "BBG_234", "BBG_235", "BBG_236", "BBG_237", "BBG_238"
			, "BBG_239", "BBG_240", "BBG_241", "BBG_242", "BBG_243", "BBG_244", "BBG_245", "BBG_246", "BBG_247", "BBG_248", "BBG_249", "BBG_250", "BBG_251", "BBG_252", "BBG_253", "BBG_254", "BBG_255", "BBG_256", "BBG_257", "BBG_258"
			, "BBG_259", "BBG_260", "BBG_261", "BBG_262", "BBG_263", "BBG_264", "BBG_265", "BBG_266", "BBG_267", "BBG_268", "BBG_269", "BBG_270", "BBG_271", "BBG_272", "BBG_273", "BBG_274", "BBG_275", "BBG_276", "BBG_277", "BBG_278"
			, "BBG_279", "BBG_280", "BBG_281", "BBG_282", "BBG_283", "BBG_284", "BBG_285", "BBG_286", "BBG_287", "BBG_288", "BBG_289", "BBG_290", "BBG_291", "BBG_292", "BBG_293", "BBG_294", "BBG_295", "BBG_296", "BBG_297", "BBG_298"
			, "BBG_299", "BBG_300", "BBG_301", "BBG_302", "BBG_303", "BBG_304", "BBG_305", "BBG_306", "BBG_307", "BBG_308", "BBG_309", "BBG_310", "BBG_311", "BBG_312", "BBG_313", "BBG_314", "BBG_315", "BBG_316", "BBG_317", "BBG_318"
			, "BBG_319", "BBG_320", "BBG_321", "BBG_322", "BBG_323", "BBG_324", "BBG_325", "BBG_326", "BBG_327", "BBG_328", "BBG_329", "BBG_330", "BBG_331", "BBG_332", "BBG_333", "BBG_334", "BBG_335", "BBG_336", "BBG_337", "BBG_338"
			, "BBG_339", "BBG_340", "BBG_341", "BBG_342", "BBG_343", "BBG_344", "BBG_345", "BBG_346", "BBG_347", "BBG_348", "BBG_349", "BBG_350", "BBG_351", "BBG_352", "BBG_353", "BBG_354", "BBG_355", "BBG_356", "BBG_357", "BBG_358"
			, "BBG_359", "BBG_360", "BBG_361", "BBG_362", "BBG_363", "BBG_364", "BBG_365", "BBG_366", "BBG_367", "BBG_368", "BBG_369", "BBG_370", "BBG_371", "BBG_372", "BBG_373", "BBG_374", "BBG_375", "BBG_376", "BBG_377", "BBG_378"
			, "BBG_379", "BBG_380"
		};
		public System.Collections.Generic.List<NPCBattlesRow> Rows = new System.Collections.Generic.List<NPCBattlesRow>();

		public static NPCBattles Instance
		{
			get { return NestedNPCBattles.instance; }
		}

		private class NestedNPCBattles
		{
			static NestedNPCBattles() { }
			internal static readonly NPCBattles instance = new NPCBattles();
		}

		private NPCBattles()
		{
			Rows.Add( new NPCBattlesRow("BBG_1", "1", "FirstBattle", "Game Test Map", "Dave", "", "Town 1", "", "", "", "0", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_2", "2", "SecondBattle", "Game Test Map", "John", "", "Office 1", "", "", "", "0", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_3", "3", "TutorialBattle", "Kalomi", "Namanja Raider", "Namanja Raider", "Town 1", "TutorialA", "Zina", "Zina", "30", "Medium Potion,Basic Potion", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_4", "4", "CatchTutorial", "Kalomi", "Kofi", "Wild", "Town 1", "CatchTutorial", "", "Kofi", "30", "Ultra Bait, Ultra Bait, Ultra Bait", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_5", "5", "CatchUp", "Kalomi", "ZinaWithVenox", "Wild", "Town 1", "ZinaVenoxInBattle", "", "Zina", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_6", "6", "FightTheRaptox", "Kalomi", "ZinaWithRapox", "Wild", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_7", "7", "Survivalist1", "Mishi", "Brennan", "Brennan", "Town 1", "", "", "Survivalist", "30", "Basic Potion,Basic Potion", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_8", "8", "LumberyardBaako", "Mishi", "Baako", "Baako", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_9", "9", "LumberyardCayman", "Mishi", "Cayman", "Cayman", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_10", "10", "LumberyardClive", "Mishi", "Clive", "Clive", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_11", "11", "LumberyardOmarru", "Mishi", "Omarru", "Omarru", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_12", "12", "LumberyardTree", "Mishi", "LumberyardTree", "Angry", "Town 1", "GetLumberFromBattle", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_13", "13", "BridgeTroll", "Mishi", "Flower Hoarder Jones", "Flower Hoarder Jones", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_14", "14", "ClearPathDidier", "Trail 1", "Rancher Didier", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_15", "15", "ClearPathSeydou", "Trail 1", "Rancher Seydou", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_16", "16", "ClearPathAlex", "Trail 1", "Rancher Alex", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_17", "17", "ClearPathAsamoah", "Trail 1", "Rancher Asamoah", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_18", "18", "ClearPathMichael", "Trail 1", "Rancher Michael", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_19", "19", "ClearPathJackie", "Trail 1", "Rancher Jackie", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_20", "20", "NamanjaScout", "Trail 1", "Namanja Scout", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_21", "21", "BackdoorBackTrap1", "Trail 1", "Namanja Raider", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_22", "22", "BackdoorBackTrap2", "Trail 1", "Namanja Raider", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_23", "23", "BackdoorBackTrap3", "Trail 1", "Namanja Raider", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_24", "24", "RockSedimentBattle1", "Namanja", "Rock Collector", "", "Town 1", "GetRockSediment", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_25", "25", "RockSedimentBattle2", "Namanja", "Rock Collector", "", "Town 1", "GetRockSediment", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_26", "26", "RockSedimentBattle3", "Namanja", "Rock Collector", "", "Town 1", "GetRockSediment", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_27", "27", "Brak", "Namanja", "Brak", "", "Grass 1 ", "WoolFromBrakBattle", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_28", "28", "MahariBattle", "Namanja", "Mahari", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_29", "29", "BurtBattle", "Namanja", "Namanjan Guard Burt", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_30", "30", "NamanjaHQ1Battle", "Namanja HQ", "Namanja Guard", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_31", "31", "NamanjaHQ2Battle", "Namanja HQ", "Namanja Guard", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_32", "32", "NamanjaHQ3Battle", "Namanja HQ", "Namanja Elder", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_33", "33", "NamanjaHQ4Battle", "Namanja HQ", "Namanja Elder", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_34", "34", "NamanjaHQ5Battle", "Namanja HQ", "Elder Kaleg", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_35", "35", "OuaddaCave", "Namanja Cave", "Ouadda Scout", "", "Cave", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_36", "36", "JoltermiteBattle", "Namanja Cave", "Joltermite", "", "Cave", "ApplyCream", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_37", "37", "FlamooseBattle", "Cave Clearing", "Ignitler", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_38", "38", "ZinaKiller1", "Cave Clearing", "Ouadda Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_39", "39", "ZinaKiller2", "Cave Clearing", "Ouadda Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_40", "40", "OuaddaGuard1", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "OuaddaGuard1Defeat", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_41", "41", "OuaddaRevenge1", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_42", "42", "OuaddaRevenge2", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_43", "43", "OuaddaRevenge3", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_44", "44", "OuaddaRevenge4", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_45", "45", "OuaddaRevenge5", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_46", "46", "OuaddaRevenge6", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_47", "47", "OuaddaRevenge7", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_48", "48", "JumanaBattle", "Ouadda ", "Ouadda Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_49", "49", "PowerRebel1", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_50", "50", "PowerRebel2", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_51", "51", "PowerRebel3", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_52", "52", "PowerRebel4", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_53", "53", "PowerRebel5", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_54", "54", "PowerRebel6", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_55", "55", "PowerRebel7", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_56", "56", "PowerRebel8", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_57", "57", "PowerRebel9", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_58", "58", "PowerRebel10", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_59", "59", "PowerRebel11", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_60", "60", "PowerRebel12", "Power Plant", "Rebel", "", "Power Plant", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_61", "61", "KalomiOuadda", "Ouadda ", "Kalomi Guard", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_62", "62", "JinjaGuard1", "Jinja ", "Jinja Guard", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_63", "63", "JinjaGuard2", "Jinja ", "Jinja Guard", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_64", "64", "JinjaGuard3", "Jinja ", "Jinja Guard", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_65", "65", "JinjaGuard4", "Jinja ", "Jinja Guard", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_66", "66", "AbasiBattle", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_67", "67", "JinjaWarrior1", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_68", "68", "JinjaWarrior2", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_69", "69", "JinjaWarrior3", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_70", "70", "JinjaWarrior4", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_71", "71", "JinjaWarrior5", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_72", "72", "JinjaWarrior6", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_73", "73", "JinjaWarrior7", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_74", "74", "JinjaWarrior8", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_75", "75", "JinjaWarrior9", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_76", "76", "MozungiBattle", "Jinja HQ", "Jinja Warrior", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_77", "77", "JinjaRebel1", "Rebel Base", "Jinja Rebel", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_78", "78", "JinjaRebel2", "Rebel Base", "Jinja Rebel", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_79", "79", "HimayaBattle", "Rebel Base", "Himaya", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_80", "80", "ZinoBattle", "Rebel Base", "Zino", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_81", "81", "JinjaRebel3", "Jinja", "Jinja Rebel", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_82", "82", "JinjaRebel4", "Jinja", "Jinja Rebel", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_83", "83", "BrakLakeBattle", "Lake Nyaza", "Brak", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_84", "84", "JinjaLakeScout1", "Lake Nyaza", "Jinja Scout", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_85", "85", "JinjaLakeScout2", "Lake Nyaza", "Jinja Scout", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_86", "86", "JinjaLakeScout3", "Lake Nyaza", "Jinja Scout", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_87", "87", "JinjaLakeScout4", "Lake Nyaza", "Jinja Scout", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_88", "88", "LakeRancher1", "Lake Nyaza", "Terra Rancher", "", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_89", "89", "LakeRancher2", "Lake Nyaza", "Terra Rancher", "", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_90", "90", "LakeRancher3", "Lake Nyaza", "Terra Rancher", "", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_91", "91", "LakeRancher4", "Lake Nyaza", "Terra Rancher", "", "Town 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_92", "92", "AdisaBattle", "Lake Nyaza", "Adisa", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_93", "93", "BananivoreBattle", "Lake Nyaza", "Wild", "", "Savannah", "CaughtBananivore", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_94", "94", "VolcanoRancher1", "Trail 5", "Terra Rancher", "", "Fire 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_95", "95", "VolcanoRancher2", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_96", "96", "VolcanoRancher3", "Trail 5", "Terra Rancher", "", "Fire 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_97", "97", "VolcanoRancher4", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_98", "98", "VolcanoRancher5", "Trail 5", "Terra Rancher", "", "Fire 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_99", "99", "VolcanoRancher6", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_100", "100", "VolcanoRancher7", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_101", "101", "VolcanoRancher8", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_102", "102", "OzkanBattle", "Volcano Erta", "Ozkan", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_103", "103", "KofisMinion1", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_104", "104", "KofisMinion2", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_105", "105", "KofisMinion3", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_106", "106", "KofisMinion4", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_107", "107", "KofisMinion5", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_108", "108", "KofisMinion6", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_109", "109", "KofisMinion7", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_110", "110", "KofisMinion8", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_111", "111", "KofisMinion9", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_112", "112", "KofisMinion10", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_113", "113", "KofisMinion11", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_114", "114", "KofisMinion12", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_115", "115", "KofisMinion13", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_116", "116", "KofisMinion14", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_117", "117", "KofisMinion15", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_118", "118", "KofisMinion16", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_119", "119", "KofisMinion17", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_120", "120", "KofisMinion18", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_121", "121", "KofisMinion19", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_122", "122", "KofisMinion20", "Volcano Erta", "Kofi's Minion", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_123", "123", "KofiBattle", "Volcano Erta", "Kofi", "", "Volcano 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_124", "124", "VolcanoRancher9", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_125", "125", "VolcanoRancher10", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_126", "126", "VolcanoRancher11", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_127", "127", "VolcanoRancher12", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_128", "128", "VolcanoRancher13", "Trail 5", "Terra Rancher", "", "Fire 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_129", "129", "JungleKeeper", "Trail 5 ", "Ripemare", "", "Jungle", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_130", "130", "JungleGoon1", "Trail 5", "Crystal Corp Goon", "", "Jungle", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_131", "131", "JungleGoon2", "Trail 5", "Crystal Corp Goon", "", "Jungle", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_132", "132", "JungleGoon3", "Trail 5", "Crystal Corp Goon", "", "Jungle", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_133", "133", "DynamiteGoon1", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_134", "134", "DynamiteGoon2", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_135", "135", "DynamiteGoon3", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_136", "136", "DynamiteGoon4", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_137", "137", "DynamiteGoon5", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_138", "138", "DynamiteGoon6", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_139", "139", "DynamiteGoon7", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_140", "140", "DynamiteGoon8", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_141", "141", "DynamiteGoon9", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_142", "142", "DynamiteGoon10", "Trail 5", "Crystal Corp Goon", "", "Jungle", "TakeDynamite", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_143", "143", "Pirate1", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_144", "144", "Pirate2", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_145", "145", "Pirate3", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_146", "146", "Pirate4", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_147", "147", "Pirate5", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_148", "148", "Pirate6", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_149", "149", "Pirate7", "Kismayo", "Pirate", "", "Oasis", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_150", "150", "MineGoon1", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_151", "151", "MineGoon2", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_152", "152", "MineGoon3", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_153", "153", "MineGoon4", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_154", "154", "MineGoon5", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_155", "155", "MineGoon6", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_156", "156", "MineGoon7", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_157", "157", "MineGoon8", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_158", "158", "MineGoon9", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_159", "159", "MineGoon10", "Kismayo", "Crystal Corp Goon", "", "Waste 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_160", "160", "GoonHouse1", "Kismayo House", "Crystal Corp Goon", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_161", "161", "GoonHouse2", "Kismayo House", "Crystal Corp Goon", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_162", "162", "MombassiGoon1", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_163", "163", "MombassiGoon2", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_164", "164", "MombassiGoon3", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_165", "165", "MombassiGoon4", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_166", "166", "MombassiGoon5", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_167", "167", "MombassiGoon6", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_168", "168", "MombassiGoon7", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_169", "169", "MombassiGoon8", "Mombassi", "Crystal Corp Goon", "", "Town 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_170", "170", "MombassiGoon9", "Mombassi", "Crystal Corp Goon", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_171", "171", "MombassiGoon10", "Mombassi", "Crystal Corp Goon", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_172", "172", "MombassiGoon11", "Mombassi", "Crystal Corp Goon", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_173", "173", "HQGoon1", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_174", "174", "HQGoon2", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_175", "175", "HQGoon3", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_176", "176", "HQGoon4", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_177", "177", "HQGoon5", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_178", "178", "HQGoon6", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_179", "179", "HQGoon7", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_180", "180", "HQGoon8", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_181", "181", "HQGoon9", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_182", "182", "HQGoon10", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_183", "183", "HQGoon11", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_184", "184", "HQGoon12", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_185", "185", "HQGoon13", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_186", "186", "HQGoon14", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_187", "187", "HQGoon15", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_188", "188", "HQGoon16", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_189", "189", "HQGoon17", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_190", "190", "HQGoon18", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_191", "191", "HQGoon19", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_192", "192", "JonahBattle", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_193", "193", "GoonBoss", "CC HQ", "Crystal Corp Goon", "", "Office 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_194", "194", "DarkDozerBattle", "Al Kubra Cave", "Emmett", "", "Cave", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_195", "195", "EmmettBattle", "Al Kubra Cave", "Emmett", "", "Cave", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_196", "196", "JonahDesertBattle", "Al Kubra", "Jonah", "", "Sand 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_197", "197", "BastionDesertBattle", "Al Kubra", "Bastion", "", "Sand 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_198", "198", "NakatoBattle", "Kyeroh", "Nakato", "", "Sand 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_199", "199", "PrisonGoon1", "Kyeroh Prison", "Prison Guard", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_200", "200", "PrisonGoon2", "Kyeroh Prison", "Prison Guard", "", "Dojo 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_201", "201", "PrisonGoon3", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_202", "202", "PrisonGoon4", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_203", "203", "PrisonGoon5", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_204", "204", "PrisonGoon6", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_205", "205", "PrisonGoon7", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_206", "206", "PrisonGoon8", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_207", "207", "PrisonGoon9", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_208", "208", "PrisonGoon10", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_209", "209", "PrisonGoon11", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_210", "210", "PrisonGoon12", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_211", "211", "PrisonGoon13", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_212", "212", "PrisonGoon14", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_213", "213", "PrisonGoon15", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_214", "214", "PrisonGoon16", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_215", "215", "PrisonGoon17", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_216", "216", "PrisonGoon18", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_217", "217", "PrisonGoon19", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_218", "218", "PrisonGoon20", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_219", "219", "PrisonGoon21", "Kyeroh Prison", "Prison Guard", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_220", "220", "NamanjaPrison1", "Kyeroh Prison", "Namanja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_221", "221", "NamanjaPrison2", "Kyeroh Prison", "Namanja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_222", "222", "NamanjaPrison3", "Kyeroh Prison", "Namanja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_223", "223", "OuaddaPrison1", "Kyeroh Prison", "Ouadda Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_224", "224", "OuaddaPrison2", "Kyeroh Prison", "Ouadda Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_225", "225", "OuaddaPrison3", "Kyeroh Prison", "Ouadda Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_226", "226", "OuaddaPrison4", "Kyeroh Prison", "Ouadda Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_227", "227", "JinjaPrison1", "Kyeroh Prison", "Jinja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_228", "228", "JinjaPrison2", "Kyeroh Prison", "Jinja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_229", "229", "JinjaPrison3", "Kyeroh Prison", "Jinja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_230", "230", "JinjaPrison4", "Kyeroh Prison", "Jinja Prisoner", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_231", "231", "PrisonBoss", "Kyeroh Prison", "Prison Boss", "", "Dojo 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_232", "232", "MishiGuild1", "Mishi Guild", "Mishi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_233", "233", "MishiGuild2", "Mishi Guild", "Mishi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_234", "234", "MishiGuild3", "Mishi Guild", "Mishi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_235", "235", "MishiGuild4", "Mishi Guild", "Mishi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_236", "236", "NamanjaGuild1", "Namanja Guild", "Namanja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_237", "237", "NamanjaGuild2", "Namanja Guild", "Namanja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_238", "238", "NamanjaGuild3", "Namanja Guild", "Namanja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_239", "239", "NamanjaGuild4", "Namanja Guild", "Namanja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_240", "240", "OuaddaGuild1", "Ouadda Guild", "Ouadda Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_241", "241", "OuaddaGuild2", "Ouadda Guild", "Ouadda Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_242", "242", "OuaddaGuild3", "Ouadda Guild", "Ouadda Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_243", "243", "OuaddaGuild4", "Ouadda Guild", "Ouadda Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_244", "244", "ArcaneGuild1", "Arcane Guild", "Arcane Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_245", "245", "ArcaneGuild2", "Arcane Guild", "Arcane Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_246", "246", "ArcaneGuild3", "Arcane Guild", "Arcane Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_247", "247", "ArcaneGuild4", "Arcane Guild", "Arcane Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_248", "248", "JinjaGuild1", "Jinja Guild", "Jinja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_249", "249", "JinjaGuild2", "Jinja Guild", "Jinja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_250", "250", "JinjaGuild3", "Jinja Guild", "Jinja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_251", "251", "JinjaGuild4", "Jinja Guild", "Jinja Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_252", "252", "KismayoGuild1", "Kismayo Guild", "Kismayo Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_253", "253", "KismayoGuild2", "Kismayo Guild", "Kismayo Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_254", "254", "KismayoGuild3", "Kismayo Guild", "Kismayo Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_255", "255", "KismayoGuild4", "Kismayo Guild", "Kismayo Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_256", "256", "MombassiGuild1", "Mombassi Guild", "Mombassi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_257", "257", "MombassiGuild2", "Mombassi Guild", "Mombassi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_258", "258", "MombassiGuild3", "Mombassi Guild", "Mombassi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_259", "259", "MombassiGuild4", "Mombassi Guild", "Mombassi Guild Member", "", "Dojo 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_260", "260", "NiptuneBattle", "Trail 4", "Niptune", "Wild", "Snow 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_261", "261", "MishiMountain1", "Trail 4", "Mishi Guard", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_262", "262", "MishiMountain2", "Trail 4", "Mishi Guard", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_263", "263", "JinjaMountain1", "Trail 4", "Jinja Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_264", "264", "JinjaMountain2", "Trail 4", "Jinja Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_265", "265", "JinjaMountain3", "Trail 4", "Jinja Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_266", "266", "JinjaMountain4", "Trail 4", "Jinja Scout", "", "Savannah", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_267", "267", "JinjaMountain5", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_268", "268", "JinjaMountain6", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_269", "269", "JinjaMountain7", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_270", "270", "JinjaMountain8", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_271", "271", "JinjaMountain9", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_272", "272", "JinjaMountain10", "Trail 4", "Jinja Scout", "", "Snow 1", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_273", "273", "MountainRancher1", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_274", "274", "MountainRancher2", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_275", "275", "MountainRancher3", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_276", "276", "MountainRancher4", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_277", "277", "MountainRancher5", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_278", "278", "MountainRancher6", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_279", "279", "MountainRancher7", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_280", "280", "MountainRancher8", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_281", "281", "MountainRancher9", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_282", "282", "MountainRancher10", "Trail 4", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_283", "283", "StrayNamanjaMishi", "Mishi", "Namanja Scout", "", "Grass 1 ", "", "", "", "30", "Weak Potion,Energy Restore", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_284", "284", "DozerKalomiBattle", "Kalomi", "Dozer", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_285", "285", "KalomiBattleNew1", "Kalomi", "Namanja Raider", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_286", "286", "KalomiBattleNew2", "Kalomi", "Namanja Raider", "", "Grass 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_287", "287", "MishiThief", "Mishi", "Thief", "", "Lake 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_288", "288", "NamanjaOutcast1", "Namanja", "Namanja Rebel", "", "Arcane 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_289", "289", "NamanjaOutcast2", "Namanja", "Namanja Rebel", "", "Arcane 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_290", "290", "NamanjaOutcast3", "Namanja", "Namanja Rebel", "", "Arcane 1 ", "", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_291", "291", "OasisJinja1", "Ouadda", "Jinja Scout", "", "Oasis", "OasisNaked1", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_292", "292", "OasisJinja2", "Ouadda", "Jinja Scout", "", "Oasis", "OasisNaked2", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_293", "293", "OasisJinja3", "Ouadda", "Jinja Scout", "", "Oasis", "OasisNaked3", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_294", "294", "OasisJinja4", "Ouadda", "Jinja Scout", "", "Oasis", "OasisNaked4", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_295", "295", "OasisJinja5", "Ouadda", "Jinja Scout", "", "Oasis", "OasisNaked5", "", "", "30", "", "POL-escape-the-reactor-long"));
			Rows.Add( new NPCBattlesRow("BBG_296", "296", "ForestRancher1", "Namanja", "Terra Rancher", "", "Arcane 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_297", "297", "ForestRancher2", "Namanja", "Terra Rancher", "", "Arcane 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_298", "298", "ForestRancher3", "Namanja", "Terra Rancher", "", "Arcane 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_299", "299", "DandylionBattle", "Namanja House", "Dennis", "", "Colosseum 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_300", "300", "WaterfallRancher1", "Mishi", "Terra Rancher", "", "Lake 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_301", "301", "WaterfallRancher2", "Mishi", "Terra Rancher", "", "Lake 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_302", "302", "WaterfallRancher3", "Mishi", "Terra Rancher", "", "Lake 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_303", "303", "FlofoxBattle", "Ouadda House", "Ouadda Resident", "", "Colosseum 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_304", "304", "JinjaRancher1", "Jinja", "Terra Rancher", "", "Snow 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_305", "305", "JinjaRancher2", "Jinja", "Terra Rancher", "", "Snow 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_306", "306", "JinjaRancher3", "Jinja", "Terra Rancher", "", "Snow 1", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_307", "307", "KismayoRancher1", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_308", "308", "KismayoRancher2", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_309", "309", "KismayoRancher3", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_310", "310", "KismayoRancher4", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_311", "311", "KismayoRancher5", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_312", "312", "KismayoRancher6", "Kismayo", "Terra Rancher", "", "Grass 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_313", "313", "PandemiteBattle", "MombassiHomes", "Terra Rancher", "", "Colosseum 1 ", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_314", "314", "NamanjaRancher1", "Namanja", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_315", "315", "NamanjaRancher2", "Namanja", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_316", "316", "NamanjaRancher3", "Namanja", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_317", "317", "NamanjaRancher4", "Namanja", "Terra Rancher", "", "Savannah", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_318", "318", "CaveRancher1", "Cave", "Terra Rancher", "", "Cave", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_319", "319", "CaveRancher2", "Cave", "Terra Rancher", "", "Cave", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_320", "320", "CaveRancher3", "Cave", "Terra Rancher", "", "Cave", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_321", "321", "CaveRancher4", "Cave", "Terra Rancher", "", "Cave", "", "", "", "30", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_322", "322", "RukuuBattle", "Mishi", "Rukuu", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_323", "323", "MishiCaveBattle1", "Guild Land", "Mishi Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_324", "324", "MishiCaveBattle2", "Guild Land", "Mishi Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_325", "325", "MishiCaveBattle3", "Guild Land", "Mishi Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_326", "326", "MishiCaveBattle4", "Guild Land", "Mishi Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_327", "327", "GuildLeaderWater", "Guild Land", "Kat", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_328", "328", "GuildLeaderEarth", "Guild Land", "Modie", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_329", "329", "GuildLeaderAir", "Guild Land", "Kith", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_330", "330", "SamotBattle", "Trail 5", "Samot", "", "Savannah", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_331", "331", "DungScientistBattle", "Trail 5", "Dung Collector", "", "Savannah", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_332", "332", "DungScientist2", "Trail 5", "Dung Collector", "", "Savannah", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_333", "333", "DungScientist3", "Trail 5", "Dung Collector", "", "Savannah", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_334", "334", "DungScientist4", "Trail 5", "Dung Collector", "", "Savannah", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_335", "335", "GuildCaveBattle1", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_336", "336", "GuildCaveBattle2", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_337", "337", "GuildCaveBattle3", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_338", "338", "GuildCaveBattle4", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_339", "339", "CourierCaveBattle1", "Mountain Cave", "CC Courier", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_340", "340", "CourierCaveBattle2", "Mountain Cave", "CC Courier", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_341", "341", "CourierCaveBattle3", "Mountain Cave", "CC Courier", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_342", "342", "CourierCaveBattle4", "Mountain Cave", "CC Courier", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_343", "343", "CourierCaveBattle5", "Mountain Cave", "CC Courier", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_344", "344", "TaurysosCaveBattle", "Mountain Cave", "Wild", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_345", "345", "AirGuildLandBattle1", "Guild Land", "Guild Member", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_346", "346", "AirGuildLandBattle2", "Guild Land", "Guild Member", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_347", "347", "AirGuildLandBattle3", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_348", "348", "AirGuildLandBattle4", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_349", "349", "FireGuildSavannahBattle1", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_350", "350", "FireGuildSavannahBattle2", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_351", "351", "FireGuildSavannahBattle3", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_352", "352", "FireGuildSavannahBattle4", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_353", "353", "FireGuildSavannahBattle5", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_354", "354", "FireGuildSavannahBattle6", "Trail 3", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_355", "355", "FireGuildLandBattle1", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_356", "356", "FireGuildLandBattle2", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_357", "357", "FireGuildLandBattle3", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_358", "358", "FireGuildLandBattle4", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_359", "359", "FireGuildLandBattle5", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_360", "360", "FireGuildLandBattle6", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_361", "361", "FireGuildVolcanoBattle1", "Volcano Erta", "Guild Member", "", "Volcano 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_362", "362", "InferamVolcanoBattle", "Volcano Erta", "Wild", "", "Volcano 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_363", "363", "GuildIceCave1", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_364", "364", "GuildIceCave2", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_365", "365", "GuildIceCave3", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_366", "366", "GuildIceCave4", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_367", "367", "GuildIceCave5", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_368", "368", "GuildIceCave6", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_369", "369", "GuildIceCave7", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_370", "370", "GuildIceCave8", "Ice Cave", "Guild Member", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_371", "371", "SquallanIceCave", "Ice Cave", "Wild", "", "Ice Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_372", "372", "WaterGuildLandBattle1", "Guild Land", "Guild Member", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_373", "373", "WaterGuildLandBattle2", "Guild Land", "Guild Member", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_374", "374", "WaterGuildLandBattle3", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_375", "375", "WaterGuildLandBattle4", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_376", "376", "WaterGuildLandBattle5", "Guild Land", "Guild Member", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_377", "377", "AquarinBattle", "Guild Land", "Wild", "", "Grass 1", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_378", "378", "GuildLeaderElectric", "Guild Land", "Mose", "", "Grass 1 ", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_379", "379", "GuildCaveBattle5", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
			Rows.Add( new NPCBattlesRow("BBG_380", "380", "GuildCaveBattle6", "Mountain Cave", "Guild Member", "", "Cave", "", "", "", "50", "", "Battle"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public NPCBattlesRow GetRow(rowIds in_RowID)
		{
			NPCBattlesRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public NPCBattlesRow GetRow(string in_RowString)
		{
			NPCBattlesRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
