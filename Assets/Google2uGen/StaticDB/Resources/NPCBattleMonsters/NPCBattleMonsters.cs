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
	public class NPCBattleMonstersRow : IGoogle2uRow
	{
		public int _ID;
		public string _BattleName;
		public string _Monster;
		public string _OverrideName;
		public int _Level;
		public string _Item;
		public string _OverrideMove1;
		public string _OverrideMove2;
		public string _OverrideMove3;
		public string _OverrideMove4;
		public string _TreeTendency;
		public NPCBattleMonstersRow(string __GOOGLEFU_ID, string __ID, string __BattleName, string __Monster, string __OverrideName, string __Level, string __Item, string __OverrideMove1, string __OverrideMove2, string __OverrideMove3, string __OverrideMove4, string __TreeTendency) 
		{
			{
			int res;
				if(int.TryParse(__ID, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ID = res;
				else
					Debug.LogError("Failed To Convert _ID string: "+ __ID +" to int");
			}
			_BattleName = __BattleName.Trim();
			_Monster = __Monster.Trim();
			_OverrideName = __OverrideName.Trim();
			{
			int res;
				if(int.TryParse(__Level, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Level = res;
				else
					Debug.LogError("Failed To Convert _Level string: "+ __Level +" to int");
			}
			_Item = __Item.Trim();
			_OverrideMove1 = __OverrideMove1.Trim();
			_OverrideMove2 = __OverrideMove2.Trim();
			_OverrideMove3 = __OverrideMove3.Trim();
			_OverrideMove4 = __OverrideMove4.Trim();
			_TreeTendency = __TreeTendency.Trim();
		}

		public int Length { get { return 11; } }

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
					ret = _Monster.ToString();
					break;
				case 3:
					ret = _OverrideName.ToString();
					break;
				case 4:
					ret = _Level.ToString();
					break;
				case 5:
					ret = _Item.ToString();
					break;
				case 6:
					ret = _OverrideMove1.ToString();
					break;
				case 7:
					ret = _OverrideMove2.ToString();
					break;
				case 8:
					ret = _OverrideMove3.ToString();
					break;
				case 9:
					ret = _OverrideMove4.ToString();
					break;
				case 10:
					ret = _TreeTendency.ToString();
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
				case "Monster":
					ret = _Monster.ToString();
					break;
				case "OverrideName":
					ret = _OverrideName.ToString();
					break;
				case "Level":
					ret = _Level.ToString();
					break;
				case "Item":
					ret = _Item.ToString();
					break;
				case "OverrideMove1":
					ret = _OverrideMove1.ToString();
					break;
				case "OverrideMove2":
					ret = _OverrideMove2.ToString();
					break;
				case "OverrideMove3":
					ret = _OverrideMove3.ToString();
					break;
				case "OverrideMove4":
					ret = _OverrideMove4.ToString();
					break;
				case "TreeTendency":
					ret = _TreeTendency.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "ID" + " : " + _ID.ToString() + "} ";
			ret += "{" + "BattleName" + " : " + _BattleName.ToString() + "} ";
			ret += "{" + "Monster" + " : " + _Monster.ToString() + "} ";
			ret += "{" + "OverrideName" + " : " + _OverrideName.ToString() + "} ";
			ret += "{" + "Level" + " : " + _Level.ToString() + "} ";
			ret += "{" + "Item" + " : " + _Item.ToString() + "} ";
			ret += "{" + "OverrideMove1" + " : " + _OverrideMove1.ToString() + "} ";
			ret += "{" + "OverrideMove2" + " : " + _OverrideMove2.ToString() + "} ";
			ret += "{" + "OverrideMove3" + " : " + _OverrideMove3.ToString() + "} ";
			ret += "{" + "OverrideMove4" + " : " + _OverrideMove4.ToString() + "} ";
			ret += "{" + "TreeTendency" + " : " + _TreeTendency.ToString() + "} ";
			return ret;
		}
	}
	public sealed class NPCBattleMonsters : IGoogle2uDB
	{
		public enum rowIds {
			NPCBM_1, NPCBM_4, NPCBM_5, NPCBM_6, NPCBM_7, NPCBM_8, NPCBM_9, NPCBM_10, NPCBM_11, NPCBM_12, NPCBM_13, NPCBM_14, NPCBM_15, NPCBM_16, NPCBM_17, NPCBM_18, NPCBM_19, NPCBM_20
			, NPCBM_21, NPCBM_22, NPCBM_23, NPCBM_24, NPCBM_25, NPCBM_26, NPCBM_27, NPCBM_28, NPCBM_29, NPCBM_30, NPCBM_31, NPCBM_32, NPCBM_33, NPCBM_34, NPCBM_35, NPCBM_36, NPCBM_37, NPCBM_38, NPCBM_39, NPCBM_40
			, NPCBM_41, NPCBM_42, NPCBM_43, NPCBM_44, NPCBM_45, NPCBM_46, NPCBM_47, NPCBM_48, NPCBM_49, NPCBM_50, NPCBM_51, NPCBM_52, NPCBM_53, NPCBM_54, NPCBM_55, NPCBM_56, NPCBM_57, NPCBM_58, NPCBM_59, NPCBM_60
			, NPCBM_61, NPCBM_62, NPCBM_63, NPCBM_64, NPCBM_65, NPCBM_66, NPCBM_67, NPCBM_68, NPCBM_69, NPCBM_70, NPCBM_71, NPCBM_72, NPCBM_73, NPCBM_74, NPCBM_75, NPCBM_76, NPCBM_77, NPCBM_78, NPCBM_79, NPCBM_80
			, NPCBM_81, NPCBM_82, NPCBM_83, NPCBM_84, NPCBM_85, NPCBM_86, NPCBM_87, NPCBM_88, NPCBM_89, NPCBM_90, NPCBM_91, NPCBM_92, NPCBM_93, NPCBM_94, NPCBM_95, NPCBM_96, NPCBM_97, NPCBM_98, NPCBM_99, NPCBM_100
			, NPCBM_101, NPCBM_102, NPCBM_103, NPCBM_104, NPCBM_105, NPCBM_106, NPCBM_107, NPCBM_108, NPCBM_109, NPCBM_110, NPCBM_111, NPCBM_112, NPCBM_113, NPCBM_114, NPCBM_115, NPCBM_116, NPCBM_117, NPCBM_118, NPCBM_119, NPCBM_120
			, NPCBM_121, NPCBM_122, NPCBM_123, NPCBM_124, NPCBM_125, NPCBM_126, NPCBM_127, NPCBM_128, NPCBM_129, NPCBM_130, NPCBM_131, NPCBM_132, NPCBM_133, NPCBM_134, NPCBM_135, NPCBM_136, NPCBM_137, NPCBM_138, NPCBM_139, NPCBM_140
			, NPCBM_141, NPCBM_142, NPCBM_143, NPCBM_144, NPCBM_145, NPCBM_146, NPCBM_147, NPCBM_148, NPCBM_149, NPCBM_150, NPCBM_151, NPCBM_152, NPCBM_153, NPCBM_154, NPCBM_155, NPCBM_156, NPCBM_157, NPCBM_158, NPCBM_159, NPCBM_160
			, NPCBM_161, NPCBM_162, NPCBM_163, NPCBM_164, NPCBM_165, NPCBM_166, NPCBM_167, NPCBM_168, NPCBM_169, NPCBM_170, NPCBM_171, NPCBM_172, NPCBM_173, NPCBM_174, NPCBM_175, NPCBM_176, NPCBM_177, NPCBM_178, NPCBM_179, NPCBM_180
			, NPCBM_181, NPCBM_182, NPCBM_183, NPCBM_184, NPCBM_185, NPCBM_186, NPCBM_187, NPCBM_188, NPCBM_189, NPCBM_190, NPCBM_191, NPCBM_192, NPCBM_193, NPCBM_194, NPCBM_195, NPCBM_196, NPCBM_197, NPCBM_198, NPCBM_199, NPCBM_200
			, NPCBM_201, NPCBM_202, NPCBM_203, NPCBM_204, NPCBM_205, NPCBM_206, NPCBM_207, NPCBM_208, NPCBM_209, NPCBM_210, NPCBM_211, NPCBM_212, NPCBM_213, NPCBM_214, NPCBM_215, NPCBM_216, NPCBM_217, NPCBM_218, NPCBM_219, NPCBM_220
			, NPCBM_221, NPCBM_222, NPCBM_223, NPCBM_224, NPCBM_225, NPCBM_226, NPCBM_227, NPCBM_228, NPCBM_229, NPCBM_230, NPCBM_231, NPCBM_232, NPCBM_233, NPCBM_234, NPCBM_235, NPCBM_236, NPCBM_237, NPCBM_238, NPCBM_239, NPCBM_240
			, NPCBM_241, NPCBM_242, NPCBM_243, NPCBM_244, NPCBM_245, NPCBM_246, NPCBM_247, NPCBM_248, NPCBM_249, NPCBM_250, NPCBM_251, NPCBM_252, NPCBM_253, NPCBM_254, NPCBM_255, NPCBM_256, NPCBM_257, NPCBM_258, NPCBM_259, NPCBM_260
			, NPCBM_261, NPCBM_262, NPCBM_263, NPCBM_264, NPCBM_265, NPCBM_266, NPCBM_267, NPCBM_268, NPCBM_269, NPCBM_270, NPCBM_271, NPCBM_272, NPCBM_273, NPCBM_274, NPCBM_275, NPCBM_276, NPCBM_277, NPCBM_278, NPCBM_279, NPCBM_280
			, NPCBM_281, NPCBM_282, NPCBM_283, NPCBM_284, NPCBM_285, NPCBM_286, NPCBM_287, NPCBM_288, NPCBM_289, NPCBM_290, NPCBM_291, NPCBM_292, NPCBM_293, NPCBM_294, NPCBM_295, NPCBM_296, NPCBM_297, NPCBM_298, NPCBM_299, NPCBM_300
			, NPCBM_301, NPCBM_302, NPCBM_303, NPCBM_304, NPCBM_305, NPCBM_306, NPCBM_307, NPCBM_308, NPCBM_309, NPCBM_310, NPCBM_311, NPCBM_312, NPCBM_313, NPCBM_314, NPCBM_315, NPCBM_316, NPCBM_317, NPCBM_318, NPCBM_319, NPCBM_320
			, NPCBM_321, NPCBM_322, NPCBM_323, NPCBM_324, NPCBM_325, NPCBM_326, NPCBM_327, NPCBM_328, NPCBM_329, NPCBM_330, NPCBM_331, NPCBM_332, NPCBM_333, NPCBM_334, NPCBM_335, NPCBM_336, NPCBM_337, NPCBM_338, NPCBM_339, NPCBM_340
			, NPCBM_341, NPCBM_342, NPCBM_343, NPCBM_344, NPCBM_345, NPCBM_346, NPCBM_347, NPCBM_348, NPCBM_349, NPCBM_350, NPCBM_351, NPCBM_352, NPCBM_353, NPCBM_354, NPCBM_355, NPCBM_356, NPCBM_357, NPCBM_358, NPCBM_359, NPCBM_360
			, NPCBM_361, NPCBM_362, NPCBM_363, NPCBM_364, NPCBM_365, NPCBM_366, NPCBM_367, NPCBM_368, NPCBM_369, NPCBM_370, NPCBM_371, NPCBM_372, NPCBM_373, NPCBM_374, NPCBM_375, NPCBM_376, NPCBM_377, NPCBM_378, NPCBM_379, NPCBM_380
			, NPCBM_381, NPCBM_382, NPCBM_383, NPCBM_384, NPCBM_385, NPCBM_386, NPCBM_387, NPCBM_388, NPCBM_389, NPCBM_390, NPCBM_391, NPCBM_392, NPCBM_393, NPCBM_394, NPCBM_395, NPCBM_396, NPCBM_397, NPCBM_398, NPCBM_399, NPCBM_400
			, NPCBM_401, NPCBM_402, NPCBM_403, NPCBM_404, NPCBM_405, NPCBM_406, NPCBM_407, NPCBM_408, NPCBM_409, NPCBM_410, NPCBM_411, NPCBM_412, NPCBM_413, NPCBM_414, NPCBM_415, NPCBM_416, NPCBM_417, NPCBM_418, NPCBM_419, NPCBM_420
			, NPCBM_421, NPCBM_422, NPCBM_423, NPCBM_424, NPCBM_425, NPCBM_426, NPCBM_427, NPCBM_428, NPCBM_429, NPCBM_430, NPCBM_431, NPCBM_432, NPCBM_433, NPCBM_434, NPCBM_435, NPCBM_436, NPCBM_437, NPCBM_438, NPCBM_439, NPCBM_440
			, NPCBM_441, NPCBM_442, NPCBM_443, NPCBM_444, NPCBM_445, NPCBM_446, NPCBM_447, NPCBM_448, NPCBM_449, NPCBM_450, NPCBM_451, NPCBM_452, NPCBM_453, NPCBM_454, NPCBM_455, NPCBM_456, NPCBM_457, NPCBM_458, NPCBM_459, NPCBM_460
			, NPCBM_461, NPCBM_462, NPCBM_463, NPCBM_464, NPCBM_465, NPCBM_466, NPCBM_467, NPCBM_468, NPCBM_469, NPCBM_470, NPCBM_471, NPCBM_472, NPCBM_473, NPCBM_474, NPCBM_475, NPCBM_476, NPCBM_477, NPCBM_478, NPCBM_479, NPCBM_480
			, NPCBM_481, NPCBM_482, NPCBM_483, NPCBM_484, NPCBM_485, NPCBM_486, NPCBM_487, NPCBM_488, NPCBM_489, NPCBM_490, NPCBM_491, NPCBM_492, NPCBM_493, NPCBM_494, NPCBM_495, NPCBM_496, NPCBM_497, NPCBM_498, NPCBM_499, NPCBM_500
			, NPCBM_501, NPCBM_502, NPCBM_503, NPCBM_504, NPCBM_505, NPCBM_506, NPCBM_507, NPCBM_508, NPCBM_509, NPCBM_510, NPCBM_511, NPCBM_512, NPCBM_513, NPCBM_514, NPCBM_515, NPCBM_516, NPCBM_517, NPCBM_518, NPCBM_519, NPCBM_520
			, NPCBM_521, NPCBM_522, NPCBM_523, NPCBM_524, NPCBM_525, NPCBM_526, NPCBM_527, NPCBM_528, NPCBM_529, NPCBM_530, NPCBM_531, NPCBM_532, NPCBM_533, NPCBM_534, NPCBM_535, NPCBM_536, NPCBM_537, NPCBM_538, NPCBM_539, NPCBM_540
			, NPCBM_541, NPCBM_542, NPCBM_543, NPCBM_544, NPCBM_545, NPCBM_546, NPCBM_547, NPCBM_548, NPCBM_549, NPCBM_550, NPCBM_551, NPCBM_552, NPCBM_553, NPCBM_554, NPCBM_555, NPCBM_556, NPCBM_557, NPCBM_558, NPCBM_559, NPCBM_560
			, NPCBM_561, NPCBM_562, NPCBM_563, NPCBM_564, NPCBM_565, NPCBM_566, NPCBM_567, NPCBM_568, NPCBM_569, NPCBM_570, NPCBM_571, NPCBM_572, NPCBM_573, NPCBM_574, NPCBM_575, NPCBM_576, NPCBM_577, NPCBM_578, NPCBM_579, NPCBM_580
			, NPCBM_581, NPCBM_582, NPCBM_583, NPCBM_584, NPCBM_585, NPCBM_586, NPCBM_587, NPCBM_588, NPCBM_589, NPCBM_590, NPCBM_591, NPCBM_592, NPCBM_593, NPCBM_594, NPCBM_595, NPCBM_596, NPCBM_597, NPCBM_598, NPCBM_599, NPCBM_600
			, NPCBM_601, NPCBM_602, NPCBM_603, NPCBM_604, NPCBM_605, NPCBM_606, NPCBM_607, NPCBM_608, NPCBM_609, NPCBM_610, NPCBM_611, NPCBM_612, NPCBM_613, NPCBM_614, NPCBM_615, NPCBM_616, NPCBM_617, NPCBM_618, NPCBM_619, NPCBM_620
			, NPCBM_621, NPCBM_622, NPCBM_623, NPCBM_624, NPCBM_625, NPCBM_626, NPCBM_627, NPCBM_628, NPCBM_629, NPCBM_630, NPCBM_631, NPCBM_632, NPCBM_633, NPCBM_634, NPCBM_635, NPCBM_636, NPCBM_637, NPCBM_638, NPCBM_639, NPCBM_640
			, NPCBM_641, NPCBM_642, NPCBM_643, NPCBM_644, NPCBM_645, NPCBM_646, NPCBM_647, NPCBM_648, NPCBM_649, NPCBM_650, NPCBM_651, NPCBM_652, NPCBM_653, NPCBM_654, NPCBM_655, NPCBM_656, NPCBM_657, NPCBM_658, NPCBM_659, NPCBM_660
			, NPCBM_661, NPCBM_662, NPCBM_663, NPCBM_664, NPCBM_665, NPCBM_666, NPCBM_667, NPCBM_668, NPCBM_669, NPCBM_670, NPCBM_671, NPCBM_672, NPCBM_673, NPCBM_674, NPCBM_675, NPCBM_676, NPCBM_677, NPCBM_678, NPCBM_679, NPCBM_680
			, NPCBM_681, NPCBM_682, NPCBM_683, NPCBM_684, NPCBM_685, NPCBM_686, NPCBM_687, NPCBM_688, NPCBM_689, NPCBM_690, NPCBM_691, NPCBM_692, NPCBM_693, NPCBM_694, NPCBM_695, NPCBM_696, NPCBM_697, NPCBM_698, NPCBM_699, NPCBM_700
			, NPCBM_701, NPCBM_702, NPCBM_703, NPCBM_704, NPCBM_705, NPCBM_706, NPCBM_707, NPCBM_708, NPCBM_709, NPCBM_710, NPCBM_711, NPCBM_712, NPCBM_713, NPCBM_714, NPCBM_715, NPCBM_716, NPCBM_717, NPCBM_718, NPCBM_719, NPCBM_720
			, NPCBM_721, NPCBM_722, NPCBM_723, NPCBM_724, NPCBM_725, NPCBM_726, NPCBM_727, NPCBM_728, NPCBM_729, NPCBM_730, NPCBM_731, NPCBM_732, NPCBM_733, NPCBM_734, NPCBM_735, NPCBM_736, NPCBM_737, NPCBM_738, NPCBM_739, NPCBM_740
			, NPCBM_741, NPCBM_742, NPCBM_743, NPCBM_744, NPCBM_745, NPCBM_746, NPCBM_747, NPCBM_748, NPCBM_749, NPCBM_750, NPCBM_751, NPCBM_752, NPCBM_753, NPCBM_754, NPCBM_755, NPCBM_756, NPCBM_757, NPCBM_758, NPCBM_759, NPCBM_760
			, NPCBM_761, NPCBM_762, NPCBM_763, NPCBM_764, NPCBM_765, NPCBM_766, NPCBM_767, NPCBM_768, NPCBM_769, NPCBM_770, NPCBM_771, NPCBM_772, NPCBM_773, NPCBM_774, NPCBM_775, NPCBM_776, NPCBM_777, NPCBM_778, NPCBM_779, NPCBM_780
			, NPCBM_781, NPCBM_782, NPCBM_783, NPCBM_784, NPCBM_785, NPCBM_786, NPCBM_787, NPCBM_788, NPCBM_789, NPCBM_790, NPCBM_791, NPCBM_792, NPCBM_793, NPCBM_794, NPCBM_795, NPCBM_796, NPCBM_797, NPCBM_798, NPCBM_799, NPCBM_800
			, NPCBM_801, NPCBM_802, NPCBM_803, NPCBM_804, NPCBM_805, NPCBM_806, NPCBM_807, NPCBM_808, NPCBM_809, NPCBM_810, NPCBM_811, NPCBM_812, NPCBM_813, NPCBM_814, NPCBM_815, NPCBM_816, NPCBM_817, NPCBM_818, NPCBM_819, NPCBM_820
			, NPCBM_821, NPCBM_822, NPCBM_823, NPCBM_824, NPCBM_825, NPCBM_826, NPCBM_827, NPCBM_828, NPCBM_829, NPCBM_830, NPCBM_831, NPCBM_832, NPCBM_833, NPCBM_834, NPCBM_835, NPCBM_836, NPCBM_837, NPCBM_838, NPCBM_839, NPCBM_840
			, NPCBM_841, NPCBM_842, NPCBM_843, NPCBM_844, NPCBM_845, NPCBM_846, NPCBM_847, NPCBM_848, NPCBM_849, NPCBM_850, NPCBM_851, NPCBM_852, NPCBM_853, NPCBM_854, NPCBM_855, NPCBM_856, NPCBM_857, NPCBM_858, NPCBM_859, NPCBM_860
			, NPCBM_861, NPCBM_862, NPCBM_863, NPCBM_864, NPCBM_865, NPCBM_866, NPCBM_867, NPCBM_868, NPCBM_869, NPCBM_870, NPCBM_871, NPCBM_872, NPCBM_873, NPCBM_874, NPCBM_875, NPCBM_876, NPCBM_877, NPCBM_878, NPCBM_879, NPCBM_880
			, NPCBM_881, NPCBM_882, NPCBM_883, NPCBM_884, NPCBM_885, NPCBM_886, NPCBM_887, NPCBM_888, NPCBM_889, NPCBM_890, NPCBM_891, NPCBM_892, NPCBM_893, NPCBM_894, NPCBM_895, NPCBM_896, NPCBM_897, NPCBM_898, NPCBM_899, NPCBM_900
			, NPCBM_901, NPCBM_902, NPCBM_903, NPCBM_904, NPCBM_905, NPCBM_906, NPCBM_907, NPCBM_908, NPCBM_909, NPCBM_910, NPCBM_911, NPCBM_912, NPCBM_913, NPCBM_914, NPCBM_915, NPCBM_916, NPCBM_917, NPCBM_918, NPCBM_919, NPCBM_920
			, NPCBM_921, NPCBM_922, NPCBM_923, NPCBM_924, NPCBM_925, NPCBM_926, NPCBM_927, NPCBM_928, NPCBM_929, NPCBM_930, NPCBM_931, NPCBM_932, NPCBM_933, NPCBM_934, NPCBM_935, NPCBM_936, NPCBM_937, NPCBM_938, NPCBM_939, NPCBM_940
			, NPCBM_941, NPCBM_942, NPCBM_943, NPCBM_944, NPCBM_945, NPCBM_946, NPCBM_947, NPCBM_948, NPCBM_949, NPCBM_950, NPCBM_951, NPCBM_952, NPCBM_953, NPCBM_954, NPCBM_955, NPCBM_956, NPCBM_957, NPCBM_958, NPCBM_959, NPCBM_960
			, NPCBM_961, NPCBM_962, NPCBM_963, NPCBM_964, NPCBM_965, NPCBM_966, NPCBM_967, NPCBM_968, NPCBM_969, NPCBM_970, NPCBM_971, NPCBM_972, NPCBM_973, NPCBM_974, NPCBM_975, NPCBM_976, NPCBM_977, NPCBM_978, NPCBM_979, NPCBM_980
			, NPCBM_981, NPCBM_982, NPCBM_983, NPCBM_984, NPCBM_985, NPCBM_986, NPCBM_987, NPCBM_988, NPCBM_989, NPCBM_990, NPCBM_991, NPCBM_992, NPCBM_993, NPCBM_994, NPCBM_995, NPCBM_996, NPCBM_997, NPCBM_998, NPCBM_999, NPCBM_1000
			, NPCBM_1001, NPCBM_1002, NPCBM_1003, NPCBM_1004, NPCBM_1005, NPCBM_1006, NPCBM_1007, NPCBM_1008, NPCBM_1009, NPCBM_1010, NPCBM_1011, NPCBM_1012, NPCBM_1013, NPCBM_1014, NPCBM_1015, NPCBM_1016, NPCBM_1017, NPCBM_1018, NPCBM_1019, NPCBM_1020
			, NPCBM_1021, NPCBM_1022, NPCBM_1023, NPCBM_1024, NPCBM_1025, NPCBM_1026, NPCBM_1027, NPCBM_1028, NPCBM_1029, NPCBM_1030, NPCBM_1031, NPCBM_1032, NPCBM_1033, NPCBM_1034, NPCBM_1035, NPCBM_1036, NPCBM_1037, NPCBM_1038, NPCBM_1039, NPCBM_1040
			, NPCBM_1041, NPCBM_1042, NPCBM_1043, NPCBM_1044, NPCBM_1045, NPCBM_1046, NPCBM_1047, NPCBM_1048, NPCBM_1049, NPCBM_1050, NPCBM_1051, NPCBM_1052, NPCBM_1053, NPCBM_1054, NPCBM_1055, NPCBM_1056, NPCBM_1057, NPCBM_1058, NPCBM_1059, NPCBM_1060
			, NPCBM_1061, NPCBM_1062, NPCBM_1063, NPCBM_1064, NPCBM_1065, NPCBM_1066, NPCBM_1067, NPCBM_1068, NPCBM_1069, NPCBM_1070, NPCBM_1071, NPCBM_1072, NPCBM_1073, NPCBM_1074, NPCBM_1075, NPCBM_1076, NPCBM_1077, NPCBM_1078, NPCBM_1079, NPCBM_1080
			, NPCBM_1081, NPCBM_1082, NPCBM_1083, NPCBM_1084, NPCBM_1085, NPCBM_1086, NPCBM_1087, NPCBM_1088, NPCBM_1089, NPCBM_1090, NPCBM_1091, NPCBM_1092, NPCBM_1093, NPCBM_1094
		};
		public string [] rowNames = {
			"NPCBM_1", "NPCBM_4", "NPCBM_5", "NPCBM_6", "NPCBM_7", "NPCBM_8", "NPCBM_9", "NPCBM_10", "NPCBM_11", "NPCBM_12", "NPCBM_13", "NPCBM_14", "NPCBM_15", "NPCBM_16", "NPCBM_17", "NPCBM_18", "NPCBM_19", "NPCBM_20"
			, "NPCBM_21", "NPCBM_22", "NPCBM_23", "NPCBM_24", "NPCBM_25", "NPCBM_26", "NPCBM_27", "NPCBM_28", "NPCBM_29", "NPCBM_30", "NPCBM_31", "NPCBM_32", "NPCBM_33", "NPCBM_34", "NPCBM_35", "NPCBM_36", "NPCBM_37", "NPCBM_38", "NPCBM_39", "NPCBM_40"
			, "NPCBM_41", "NPCBM_42", "NPCBM_43", "NPCBM_44", "NPCBM_45", "NPCBM_46", "NPCBM_47", "NPCBM_48", "NPCBM_49", "NPCBM_50", "NPCBM_51", "NPCBM_52", "NPCBM_53", "NPCBM_54", "NPCBM_55", "NPCBM_56", "NPCBM_57", "NPCBM_58", "NPCBM_59", "NPCBM_60"
			, "NPCBM_61", "NPCBM_62", "NPCBM_63", "NPCBM_64", "NPCBM_65", "NPCBM_66", "NPCBM_67", "NPCBM_68", "NPCBM_69", "NPCBM_70", "NPCBM_71", "NPCBM_72", "NPCBM_73", "NPCBM_74", "NPCBM_75", "NPCBM_76", "NPCBM_77", "NPCBM_78", "NPCBM_79", "NPCBM_80"
			, "NPCBM_81", "NPCBM_82", "NPCBM_83", "NPCBM_84", "NPCBM_85", "NPCBM_86", "NPCBM_87", "NPCBM_88", "NPCBM_89", "NPCBM_90", "NPCBM_91", "NPCBM_92", "NPCBM_93", "NPCBM_94", "NPCBM_95", "NPCBM_96", "NPCBM_97", "NPCBM_98", "NPCBM_99", "NPCBM_100"
			, "NPCBM_101", "NPCBM_102", "NPCBM_103", "NPCBM_104", "NPCBM_105", "NPCBM_106", "NPCBM_107", "NPCBM_108", "NPCBM_109", "NPCBM_110", "NPCBM_111", "NPCBM_112", "NPCBM_113", "NPCBM_114", "NPCBM_115", "NPCBM_116", "NPCBM_117", "NPCBM_118", "NPCBM_119", "NPCBM_120"
			, "NPCBM_121", "NPCBM_122", "NPCBM_123", "NPCBM_124", "NPCBM_125", "NPCBM_126", "NPCBM_127", "NPCBM_128", "NPCBM_129", "NPCBM_130", "NPCBM_131", "NPCBM_132", "NPCBM_133", "NPCBM_134", "NPCBM_135", "NPCBM_136", "NPCBM_137", "NPCBM_138", "NPCBM_139", "NPCBM_140"
			, "NPCBM_141", "NPCBM_142", "NPCBM_143", "NPCBM_144", "NPCBM_145", "NPCBM_146", "NPCBM_147", "NPCBM_148", "NPCBM_149", "NPCBM_150", "NPCBM_151", "NPCBM_152", "NPCBM_153", "NPCBM_154", "NPCBM_155", "NPCBM_156", "NPCBM_157", "NPCBM_158", "NPCBM_159", "NPCBM_160"
			, "NPCBM_161", "NPCBM_162", "NPCBM_163", "NPCBM_164", "NPCBM_165", "NPCBM_166", "NPCBM_167", "NPCBM_168", "NPCBM_169", "NPCBM_170", "NPCBM_171", "NPCBM_172", "NPCBM_173", "NPCBM_174", "NPCBM_175", "NPCBM_176", "NPCBM_177", "NPCBM_178", "NPCBM_179", "NPCBM_180"
			, "NPCBM_181", "NPCBM_182", "NPCBM_183", "NPCBM_184", "NPCBM_185", "NPCBM_186", "NPCBM_187", "NPCBM_188", "NPCBM_189", "NPCBM_190", "NPCBM_191", "NPCBM_192", "NPCBM_193", "NPCBM_194", "NPCBM_195", "NPCBM_196", "NPCBM_197", "NPCBM_198", "NPCBM_199", "NPCBM_200"
			, "NPCBM_201", "NPCBM_202", "NPCBM_203", "NPCBM_204", "NPCBM_205", "NPCBM_206", "NPCBM_207", "NPCBM_208", "NPCBM_209", "NPCBM_210", "NPCBM_211", "NPCBM_212", "NPCBM_213", "NPCBM_214", "NPCBM_215", "NPCBM_216", "NPCBM_217", "NPCBM_218", "NPCBM_219", "NPCBM_220"
			, "NPCBM_221", "NPCBM_222", "NPCBM_223", "NPCBM_224", "NPCBM_225", "NPCBM_226", "NPCBM_227", "NPCBM_228", "NPCBM_229", "NPCBM_230", "NPCBM_231", "NPCBM_232", "NPCBM_233", "NPCBM_234", "NPCBM_235", "NPCBM_236", "NPCBM_237", "NPCBM_238", "NPCBM_239", "NPCBM_240"
			, "NPCBM_241", "NPCBM_242", "NPCBM_243", "NPCBM_244", "NPCBM_245", "NPCBM_246", "NPCBM_247", "NPCBM_248", "NPCBM_249", "NPCBM_250", "NPCBM_251", "NPCBM_252", "NPCBM_253", "NPCBM_254", "NPCBM_255", "NPCBM_256", "NPCBM_257", "NPCBM_258", "NPCBM_259", "NPCBM_260"
			, "NPCBM_261", "NPCBM_262", "NPCBM_263", "NPCBM_264", "NPCBM_265", "NPCBM_266", "NPCBM_267", "NPCBM_268", "NPCBM_269", "NPCBM_270", "NPCBM_271", "NPCBM_272", "NPCBM_273", "NPCBM_274", "NPCBM_275", "NPCBM_276", "NPCBM_277", "NPCBM_278", "NPCBM_279", "NPCBM_280"
			, "NPCBM_281", "NPCBM_282", "NPCBM_283", "NPCBM_284", "NPCBM_285", "NPCBM_286", "NPCBM_287", "NPCBM_288", "NPCBM_289", "NPCBM_290", "NPCBM_291", "NPCBM_292", "NPCBM_293", "NPCBM_294", "NPCBM_295", "NPCBM_296", "NPCBM_297", "NPCBM_298", "NPCBM_299", "NPCBM_300"
			, "NPCBM_301", "NPCBM_302", "NPCBM_303", "NPCBM_304", "NPCBM_305", "NPCBM_306", "NPCBM_307", "NPCBM_308", "NPCBM_309", "NPCBM_310", "NPCBM_311", "NPCBM_312", "NPCBM_313", "NPCBM_314", "NPCBM_315", "NPCBM_316", "NPCBM_317", "NPCBM_318", "NPCBM_319", "NPCBM_320"
			, "NPCBM_321", "NPCBM_322", "NPCBM_323", "NPCBM_324", "NPCBM_325", "NPCBM_326", "NPCBM_327", "NPCBM_328", "NPCBM_329", "NPCBM_330", "NPCBM_331", "NPCBM_332", "NPCBM_333", "NPCBM_334", "NPCBM_335", "NPCBM_336", "NPCBM_337", "NPCBM_338", "NPCBM_339", "NPCBM_340"
			, "NPCBM_341", "NPCBM_342", "NPCBM_343", "NPCBM_344", "NPCBM_345", "NPCBM_346", "NPCBM_347", "NPCBM_348", "NPCBM_349", "NPCBM_350", "NPCBM_351", "NPCBM_352", "NPCBM_353", "NPCBM_354", "NPCBM_355", "NPCBM_356", "NPCBM_357", "NPCBM_358", "NPCBM_359", "NPCBM_360"
			, "NPCBM_361", "NPCBM_362", "NPCBM_363", "NPCBM_364", "NPCBM_365", "NPCBM_366", "NPCBM_367", "NPCBM_368", "NPCBM_369", "NPCBM_370", "NPCBM_371", "NPCBM_372", "NPCBM_373", "NPCBM_374", "NPCBM_375", "NPCBM_376", "NPCBM_377", "NPCBM_378", "NPCBM_379", "NPCBM_380"
			, "NPCBM_381", "NPCBM_382", "NPCBM_383", "NPCBM_384", "NPCBM_385", "NPCBM_386", "NPCBM_387", "NPCBM_388", "NPCBM_389", "NPCBM_390", "NPCBM_391", "NPCBM_392", "NPCBM_393", "NPCBM_394", "NPCBM_395", "NPCBM_396", "NPCBM_397", "NPCBM_398", "NPCBM_399", "NPCBM_400"
			, "NPCBM_401", "NPCBM_402", "NPCBM_403", "NPCBM_404", "NPCBM_405", "NPCBM_406", "NPCBM_407", "NPCBM_408", "NPCBM_409", "NPCBM_410", "NPCBM_411", "NPCBM_412", "NPCBM_413", "NPCBM_414", "NPCBM_415", "NPCBM_416", "NPCBM_417", "NPCBM_418", "NPCBM_419", "NPCBM_420"
			, "NPCBM_421", "NPCBM_422", "NPCBM_423", "NPCBM_424", "NPCBM_425", "NPCBM_426", "NPCBM_427", "NPCBM_428", "NPCBM_429", "NPCBM_430", "NPCBM_431", "NPCBM_432", "NPCBM_433", "NPCBM_434", "NPCBM_435", "NPCBM_436", "NPCBM_437", "NPCBM_438", "NPCBM_439", "NPCBM_440"
			, "NPCBM_441", "NPCBM_442", "NPCBM_443", "NPCBM_444", "NPCBM_445", "NPCBM_446", "NPCBM_447", "NPCBM_448", "NPCBM_449", "NPCBM_450", "NPCBM_451", "NPCBM_452", "NPCBM_453", "NPCBM_454", "NPCBM_455", "NPCBM_456", "NPCBM_457", "NPCBM_458", "NPCBM_459", "NPCBM_460"
			, "NPCBM_461", "NPCBM_462", "NPCBM_463", "NPCBM_464", "NPCBM_465", "NPCBM_466", "NPCBM_467", "NPCBM_468", "NPCBM_469", "NPCBM_470", "NPCBM_471", "NPCBM_472", "NPCBM_473", "NPCBM_474", "NPCBM_475", "NPCBM_476", "NPCBM_477", "NPCBM_478", "NPCBM_479", "NPCBM_480"
			, "NPCBM_481", "NPCBM_482", "NPCBM_483", "NPCBM_484", "NPCBM_485", "NPCBM_486", "NPCBM_487", "NPCBM_488", "NPCBM_489", "NPCBM_490", "NPCBM_491", "NPCBM_492", "NPCBM_493", "NPCBM_494", "NPCBM_495", "NPCBM_496", "NPCBM_497", "NPCBM_498", "NPCBM_499", "NPCBM_500"
			, "NPCBM_501", "NPCBM_502", "NPCBM_503", "NPCBM_504", "NPCBM_505", "NPCBM_506", "NPCBM_507", "NPCBM_508", "NPCBM_509", "NPCBM_510", "NPCBM_511", "NPCBM_512", "NPCBM_513", "NPCBM_514", "NPCBM_515", "NPCBM_516", "NPCBM_517", "NPCBM_518", "NPCBM_519", "NPCBM_520"
			, "NPCBM_521", "NPCBM_522", "NPCBM_523", "NPCBM_524", "NPCBM_525", "NPCBM_526", "NPCBM_527", "NPCBM_528", "NPCBM_529", "NPCBM_530", "NPCBM_531", "NPCBM_532", "NPCBM_533", "NPCBM_534", "NPCBM_535", "NPCBM_536", "NPCBM_537", "NPCBM_538", "NPCBM_539", "NPCBM_540"
			, "NPCBM_541", "NPCBM_542", "NPCBM_543", "NPCBM_544", "NPCBM_545", "NPCBM_546", "NPCBM_547", "NPCBM_548", "NPCBM_549", "NPCBM_550", "NPCBM_551", "NPCBM_552", "NPCBM_553", "NPCBM_554", "NPCBM_555", "NPCBM_556", "NPCBM_557", "NPCBM_558", "NPCBM_559", "NPCBM_560"
			, "NPCBM_561", "NPCBM_562", "NPCBM_563", "NPCBM_564", "NPCBM_565", "NPCBM_566", "NPCBM_567", "NPCBM_568", "NPCBM_569", "NPCBM_570", "NPCBM_571", "NPCBM_572", "NPCBM_573", "NPCBM_574", "NPCBM_575", "NPCBM_576", "NPCBM_577", "NPCBM_578", "NPCBM_579", "NPCBM_580"
			, "NPCBM_581", "NPCBM_582", "NPCBM_583", "NPCBM_584", "NPCBM_585", "NPCBM_586", "NPCBM_587", "NPCBM_588", "NPCBM_589", "NPCBM_590", "NPCBM_591", "NPCBM_592", "NPCBM_593", "NPCBM_594", "NPCBM_595", "NPCBM_596", "NPCBM_597", "NPCBM_598", "NPCBM_599", "NPCBM_600"
			, "NPCBM_601", "NPCBM_602", "NPCBM_603", "NPCBM_604", "NPCBM_605", "NPCBM_606", "NPCBM_607", "NPCBM_608", "NPCBM_609", "NPCBM_610", "NPCBM_611", "NPCBM_612", "NPCBM_613", "NPCBM_614", "NPCBM_615", "NPCBM_616", "NPCBM_617", "NPCBM_618", "NPCBM_619", "NPCBM_620"
			, "NPCBM_621", "NPCBM_622", "NPCBM_623", "NPCBM_624", "NPCBM_625", "NPCBM_626", "NPCBM_627", "NPCBM_628", "NPCBM_629", "NPCBM_630", "NPCBM_631", "NPCBM_632", "NPCBM_633", "NPCBM_634", "NPCBM_635", "NPCBM_636", "NPCBM_637", "NPCBM_638", "NPCBM_639", "NPCBM_640"
			, "NPCBM_641", "NPCBM_642", "NPCBM_643", "NPCBM_644", "NPCBM_645", "NPCBM_646", "NPCBM_647", "NPCBM_648", "NPCBM_649", "NPCBM_650", "NPCBM_651", "NPCBM_652", "NPCBM_653", "NPCBM_654", "NPCBM_655", "NPCBM_656", "NPCBM_657", "NPCBM_658", "NPCBM_659", "NPCBM_660"
			, "NPCBM_661", "NPCBM_662", "NPCBM_663", "NPCBM_664", "NPCBM_665", "NPCBM_666", "NPCBM_667", "NPCBM_668", "NPCBM_669", "NPCBM_670", "NPCBM_671", "NPCBM_672", "NPCBM_673", "NPCBM_674", "NPCBM_675", "NPCBM_676", "NPCBM_677", "NPCBM_678", "NPCBM_679", "NPCBM_680"
			, "NPCBM_681", "NPCBM_682", "NPCBM_683", "NPCBM_684", "NPCBM_685", "NPCBM_686", "NPCBM_687", "NPCBM_688", "NPCBM_689", "NPCBM_690", "NPCBM_691", "NPCBM_692", "NPCBM_693", "NPCBM_694", "NPCBM_695", "NPCBM_696", "NPCBM_697", "NPCBM_698", "NPCBM_699", "NPCBM_700"
			, "NPCBM_701", "NPCBM_702", "NPCBM_703", "NPCBM_704", "NPCBM_705", "NPCBM_706", "NPCBM_707", "NPCBM_708", "NPCBM_709", "NPCBM_710", "NPCBM_711", "NPCBM_712", "NPCBM_713", "NPCBM_714", "NPCBM_715", "NPCBM_716", "NPCBM_717", "NPCBM_718", "NPCBM_719", "NPCBM_720"
			, "NPCBM_721", "NPCBM_722", "NPCBM_723", "NPCBM_724", "NPCBM_725", "NPCBM_726", "NPCBM_727", "NPCBM_728", "NPCBM_729", "NPCBM_730", "NPCBM_731", "NPCBM_732", "NPCBM_733", "NPCBM_734", "NPCBM_735", "NPCBM_736", "NPCBM_737", "NPCBM_738", "NPCBM_739", "NPCBM_740"
			, "NPCBM_741", "NPCBM_742", "NPCBM_743", "NPCBM_744", "NPCBM_745", "NPCBM_746", "NPCBM_747", "NPCBM_748", "NPCBM_749", "NPCBM_750", "NPCBM_751", "NPCBM_752", "NPCBM_753", "NPCBM_754", "NPCBM_755", "NPCBM_756", "NPCBM_757", "NPCBM_758", "NPCBM_759", "NPCBM_760"
			, "NPCBM_761", "NPCBM_762", "NPCBM_763", "NPCBM_764", "NPCBM_765", "NPCBM_766", "NPCBM_767", "NPCBM_768", "NPCBM_769", "NPCBM_770", "NPCBM_771", "NPCBM_772", "NPCBM_773", "NPCBM_774", "NPCBM_775", "NPCBM_776", "NPCBM_777", "NPCBM_778", "NPCBM_779", "NPCBM_780"
			, "NPCBM_781", "NPCBM_782", "NPCBM_783", "NPCBM_784", "NPCBM_785", "NPCBM_786", "NPCBM_787", "NPCBM_788", "NPCBM_789", "NPCBM_790", "NPCBM_791", "NPCBM_792", "NPCBM_793", "NPCBM_794", "NPCBM_795", "NPCBM_796", "NPCBM_797", "NPCBM_798", "NPCBM_799", "NPCBM_800"
			, "NPCBM_801", "NPCBM_802", "NPCBM_803", "NPCBM_804", "NPCBM_805", "NPCBM_806", "NPCBM_807", "NPCBM_808", "NPCBM_809", "NPCBM_810", "NPCBM_811", "NPCBM_812", "NPCBM_813", "NPCBM_814", "NPCBM_815", "NPCBM_816", "NPCBM_817", "NPCBM_818", "NPCBM_819", "NPCBM_820"
			, "NPCBM_821", "NPCBM_822", "NPCBM_823", "NPCBM_824", "NPCBM_825", "NPCBM_826", "NPCBM_827", "NPCBM_828", "NPCBM_829", "NPCBM_830", "NPCBM_831", "NPCBM_832", "NPCBM_833", "NPCBM_834", "NPCBM_835", "NPCBM_836", "NPCBM_837", "NPCBM_838", "NPCBM_839", "NPCBM_840"
			, "NPCBM_841", "NPCBM_842", "NPCBM_843", "NPCBM_844", "NPCBM_845", "NPCBM_846", "NPCBM_847", "NPCBM_848", "NPCBM_849", "NPCBM_850", "NPCBM_851", "NPCBM_852", "NPCBM_853", "NPCBM_854", "NPCBM_855", "NPCBM_856", "NPCBM_857", "NPCBM_858", "NPCBM_859", "NPCBM_860"
			, "NPCBM_861", "NPCBM_862", "NPCBM_863", "NPCBM_864", "NPCBM_865", "NPCBM_866", "NPCBM_867", "NPCBM_868", "NPCBM_869", "NPCBM_870", "NPCBM_871", "NPCBM_872", "NPCBM_873", "NPCBM_874", "NPCBM_875", "NPCBM_876", "NPCBM_877", "NPCBM_878", "NPCBM_879", "NPCBM_880"
			, "NPCBM_881", "NPCBM_882", "NPCBM_883", "NPCBM_884", "NPCBM_885", "NPCBM_886", "NPCBM_887", "NPCBM_888", "NPCBM_889", "NPCBM_890", "NPCBM_891", "NPCBM_892", "NPCBM_893", "NPCBM_894", "NPCBM_895", "NPCBM_896", "NPCBM_897", "NPCBM_898", "NPCBM_899", "NPCBM_900"
			, "NPCBM_901", "NPCBM_902", "NPCBM_903", "NPCBM_904", "NPCBM_905", "NPCBM_906", "NPCBM_907", "NPCBM_908", "NPCBM_909", "NPCBM_910", "NPCBM_911", "NPCBM_912", "NPCBM_913", "NPCBM_914", "NPCBM_915", "NPCBM_916", "NPCBM_917", "NPCBM_918", "NPCBM_919", "NPCBM_920"
			, "NPCBM_921", "NPCBM_922", "NPCBM_923", "NPCBM_924", "NPCBM_925", "NPCBM_926", "NPCBM_927", "NPCBM_928", "NPCBM_929", "NPCBM_930", "NPCBM_931", "NPCBM_932", "NPCBM_933", "NPCBM_934", "NPCBM_935", "NPCBM_936", "NPCBM_937", "NPCBM_938", "NPCBM_939", "NPCBM_940"
			, "NPCBM_941", "NPCBM_942", "NPCBM_943", "NPCBM_944", "NPCBM_945", "NPCBM_946", "NPCBM_947", "NPCBM_948", "NPCBM_949", "NPCBM_950", "NPCBM_951", "NPCBM_952", "NPCBM_953", "NPCBM_954", "NPCBM_955", "NPCBM_956", "NPCBM_957", "NPCBM_958", "NPCBM_959", "NPCBM_960"
			, "NPCBM_961", "NPCBM_962", "NPCBM_963", "NPCBM_964", "NPCBM_965", "NPCBM_966", "NPCBM_967", "NPCBM_968", "NPCBM_969", "NPCBM_970", "NPCBM_971", "NPCBM_972", "NPCBM_973", "NPCBM_974", "NPCBM_975", "NPCBM_976", "NPCBM_977", "NPCBM_978", "NPCBM_979", "NPCBM_980"
			, "NPCBM_981", "NPCBM_982", "NPCBM_983", "NPCBM_984", "NPCBM_985", "NPCBM_986", "NPCBM_987", "NPCBM_988", "NPCBM_989", "NPCBM_990", "NPCBM_991", "NPCBM_992", "NPCBM_993", "NPCBM_994", "NPCBM_995", "NPCBM_996", "NPCBM_997", "NPCBM_998", "NPCBM_999", "NPCBM_1000"
			, "NPCBM_1001", "NPCBM_1002", "NPCBM_1003", "NPCBM_1004", "NPCBM_1005", "NPCBM_1006", "NPCBM_1007", "NPCBM_1008", "NPCBM_1009", "NPCBM_1010", "NPCBM_1011", "NPCBM_1012", "NPCBM_1013", "NPCBM_1014", "NPCBM_1015", "NPCBM_1016", "NPCBM_1017", "NPCBM_1018", "NPCBM_1019", "NPCBM_1020"
			, "NPCBM_1021", "NPCBM_1022", "NPCBM_1023", "NPCBM_1024", "NPCBM_1025", "NPCBM_1026", "NPCBM_1027", "NPCBM_1028", "NPCBM_1029", "NPCBM_1030", "NPCBM_1031", "NPCBM_1032", "NPCBM_1033", "NPCBM_1034", "NPCBM_1035", "NPCBM_1036", "NPCBM_1037", "NPCBM_1038", "NPCBM_1039", "NPCBM_1040"
			, "NPCBM_1041", "NPCBM_1042", "NPCBM_1043", "NPCBM_1044", "NPCBM_1045", "NPCBM_1046", "NPCBM_1047", "NPCBM_1048", "NPCBM_1049", "NPCBM_1050", "NPCBM_1051", "NPCBM_1052", "NPCBM_1053", "NPCBM_1054", "NPCBM_1055", "NPCBM_1056", "NPCBM_1057", "NPCBM_1058", "NPCBM_1059", "NPCBM_1060"
			, "NPCBM_1061", "NPCBM_1062", "NPCBM_1063", "NPCBM_1064", "NPCBM_1065", "NPCBM_1066", "NPCBM_1067", "NPCBM_1068", "NPCBM_1069", "NPCBM_1070", "NPCBM_1071", "NPCBM_1072", "NPCBM_1073", "NPCBM_1074", "NPCBM_1075", "NPCBM_1076", "NPCBM_1077", "NPCBM_1078", "NPCBM_1079", "NPCBM_1080"
			, "NPCBM_1081", "NPCBM_1082", "NPCBM_1083", "NPCBM_1084", "NPCBM_1085", "NPCBM_1086", "NPCBM_1087", "NPCBM_1088", "NPCBM_1089", "NPCBM_1090", "NPCBM_1091", "NPCBM_1092", "NPCBM_1093", "NPCBM_1094"
		};
		public System.Collections.Generic.List<NPCBattleMonstersRow> Rows = new System.Collections.Generic.List<NPCBattleMonstersRow>();

		public static NPCBattleMonsters Instance
		{
			get { return NestedNPCBattleMonsters.instance; }
		}

		private class NestedNPCBattleMonsters
		{
			static NestedNPCBattleMonsters() { }
			internal static readonly NPCBattleMonsters instance = new NPCBattleMonsters();
		}

		private NPCBattleMonsters()
		{
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1", "1", "FirstBattle", "Voltermite", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_4", "4", "SecondBattle", "Flofox", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_5", "5", "SecondBattle", "Aquanine", "Douchemonster", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_6", "6", "SecondBattle", "Urstorm", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_7", "7", "TutorialBattle", "Dragonfry", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_8", "8", "TutorialBattle", "Dragonfry", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_9", "9", "CatchTutorial", "Wolvus", "", "8", "", "Flash", "Hyper", "Surge", "Magnetize", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_10", "10", "CatchUp", "Lothea", "", "0", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_11", "11", "CatchUp", "Chicklit", "", "0", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_12", "12", "FightTheRaptox", "Lothea", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_13", "13", "FightTheRaptox", "Alistinker", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_14", "14", "FightTheRaptox", "Chicklit", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_15", "15", "Survivalist1", "Sappress", "", "2", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_16", "16", "Survivalist1", "Venox", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_17", "17", "LumberyardBaako", "Tuffin", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_18", "18", "LumberyardCayman", "Sappress", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_19", "19", "LumberyardCayman", "Snailix", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_20", "20", "LumberyardClive", "Lotis", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_21", "21", "LumberyardClive", "Racket", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_22", "22", "LumberyardOmarru", "Skullywag", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_23", "23", "LumberyardTree", "Sappress", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_24", "24", "BridgeTroll", "Tomaling", "", "2", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_25", "25", "BridgeTroll", "Clovice", "", "2", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_26", "26", "BridgeTroll", "Bullibee", "", "2", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_27", "27", "ClearPathDidier", "Alistinker", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_28", "28", "ClearPathDidier", "ChibChib", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_29", "29", "ClearPathSeydou", "Mothball", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_30", "30", "ClearPathSeydou", "Alistinker", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_31", "31", "ClearPathAlex", "Equinair", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_32", "32", "ClearPathAlex", "Equinair", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_33", "33", "ClearPathAsamoah", "Tomaling", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_34", "34", "ClearPathAsamoah", "Alistinker", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_35", "35", "ClearPathMichael", "Scuda", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_36", "36", "ClearPathJackie", "Tomaling", "", "8", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_37", "37", "NamanjaScout", "Alistinker", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_38", "38", "NamanjaScout", "Tomaling", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_39", "39", "NamanjaScout", "Racket", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_40", "40", "BackdoorBackTrap1", "Alistinker", "", "8", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_41", "41", "BackdoorBackTrap1", "Tomaling", "", "9", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_42", "42", "BackdoorBackTrap1", "Racket", "", "9", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_43", "43", "BackdoorBackTrap2", "Bullibee", "", "9", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_44", "44", "BackdoorBackTrap2", "Bullibee", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_45", "45", "BackdoorBackTrap2", "ChibChib", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_46", "46", "BackdoorBackTrap3", "Alistinker", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_47", "47", "BackdoorBackTrap3", "Chipmunkey", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_48", "48", "BackdoorBackTrap3", "Fluster", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_49", "49", "Brak", "Brak", "", "11", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_50", "50", "RockSedimentBattle1", "Brak", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_51", "51", "RockSedimentBattle1", "Racket", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_52", "52", "RockSedimentBattle1", "Bullibee", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_53", "53", "RockSedimentBattle2", "Tomaling", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_54", "54", "RockSedimentBattle2", "Racket", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_55", "55", "RockSedimentBattle2", "Brak", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_56", "56", "RockSedimentBattle3", "Alistinker", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_57", "57", "RockSedimentBattle3", "Equinair", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_58", "58", "RockSedimentBattle3", "Brak", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_59", "59", "MahariBattle", "Tortipous", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_60", "60", "MahariBattle", "Snozo", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_61", "61", "MahariBattle", "Hoodwink", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_62", "62", "NamanjaHQ1Battle", "Swinx", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_63", "63", "NamanjaHQ1Battle", "Tortipous", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_64", "64", "NamanjaHQ1Battle", "Snozo", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_65", "65", "NamanjaHQ2Battle", "Alistinker", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_66", "66", "NamanjaHQ2Battle", "Hoodwink", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_67", "67", "NamanjaHQ2Battle", "Oddcat", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_68", "68", "NamanjaHQ3Battle", "Tortipous", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_69", "69", "NamanjaHQ3Battle", "Grynn", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_70", "70", "NamanjaHQ3Battle", "Tuffin", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_71", "71", "NamanjaHQ4Battle", "Octicute", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_72", "72", "NamanjaHQ4Battle", "Flowgo", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_73", "73", "NamanjaHQ4Battle", "Coralpie", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_74", "74", "NamanjaHQ5Battle", "Krabken", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_75", "75", "NamanjaHQ5Battle", "Ratchet", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_76", "76", "NamanjaHQ5Battle", "Dozer", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_77", "77", "OuaddaCave", "Swinx", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_78", "78", "OuaddaCave", "Sootimander", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_79", "79", "OuaddaCave", "Joltermite", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_80", "80", "JoltermiteBattle", "Joltermite", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_81", "81", "FlamooseBattle", "Ignitler", "", "20", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_82", "82", "ZinaKiller1", "Rhiyew", "", "21", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_83", "83", "ZinaKiller1", "Sonax", "", "20", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_84", "84", "ZinaKiller1", "Venox", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_85", "85", "ZinaKiller2", "Tortitank", "", "21", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_86", "86", "ZinaKiller2", "Fouligator", "", "20", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_87", "87", "ZinaKiller2", "Vextail", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_88", "88", "OuaddaGuard1", "Vextail", "", "22", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_89", "89", "OuaddaGuard1", "Flaffee", "", "21", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_90", "90", "OuaddaGuard1", "Dozer", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_91", "91", "OuaddaRevenge1", "Clawbster", "", "22", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_92", "92", "OuaddaRevenge1", "Hytheo", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_93", "93", "OuaddaRevenge1", "Hythea", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_94", "94", "OuaddaRevenge2", "Dozer", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_95", "95", "OuaddaRevenge2", "Fouligator", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_96", "96", "OuaddaRevenge2", "Tidalhorn", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_97", "97", "OuaddaRevenge3", "Soarphin", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_98", "98", "OuaddaRevenge3", "Sonax", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_99", "99", "OuaddaRevenge3", "Shriken", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_100", "100", "OuaddaRevenge4", "Bufflow", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_101", "101", "OuaddaRevenge4", "Celestail", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_102", "102", "OuaddaRevenge4", "Purrpetal", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_103", "103", "OuaddaRevenge5", "Bananivore", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_104", "104", "OuaddaRevenge5", "Exollusk", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_105", "105", "OuaddaRevenge5", "Floatango", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_106", "106", "OuaddaRevenge6", "Cinduck", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_107", "107", "OuaddaRevenge6", "Strutwind", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_108", "108", "OuaddaRevenge6", "Hytheo", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_109", "109", "OuaddaRevenge7", "Clawbster", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_110", "110", "OuaddaRevenge7", "Ratchet", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_111", "111", "OuaddaRevenge7", "Caleaf", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_112", "112", "JumanaBattle", "Bananivore", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_113", "113", "JumanaBattle", "Tortitank", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_114", "114", "JumanaBattle", "Rhiyew", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_115", "115", "PowerRebel1", "Ratchet", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_116", "116", "PowerRebel1", "Mantislash", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_117", "117", "PowerRebel1", "Tortipous", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_118", "118", "PowerRebel2", "Bufflow", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_119", "119", "PowerRebel2", "Wolvus", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_120", "120", "PowerRebel2", "Sonax", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_121", "121", "PowerRebel3", "Volteer", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_122", "122", "PowerRebel3", "Ampint", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_123", "123", "PowerRebel3", "Ampint", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_124", "124", "PowerRebel4", "Gorillamp", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_125", "125", "PowerRebel4", "Gorillamp", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_126", "126", "PowerRebel4", "Gorillamp", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_127", "127", "PowerRebel5", "Tomahawk", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_128", "128", "PowerRebel5", "Wolvus", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_129", "129", "PowerRebel5", "Vextail", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_130", "130", "PowerRebel6", "Fouligator", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_131", "131", "PowerRebel6", "Clawbster", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_132", "132", "PowerRebel6", "Vextail", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_133", "133", "PowerRebel7", "Pranktail", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_134", "134", "PowerRebel7", "Skullywag", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_135", "135", "PowerRebel7", "Tuffin", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_136", "136", "PowerRebel8", "Sprew", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_137", "137", "PowerRebel8", "Manteri", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_138", "138", "PowerRebel8", "Sporkupine", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_139", "139", "PowerRebel9", "Voltermite", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_140", "140", "PowerRebel9", "Octicute", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_141", "141", "PowerRebel9", "Snowyrm", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_142", "142", "PowerRebel10", "Sharpoon", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_143", "143", "PowerRebel10", "Scuda", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_144", "144", "PowerRebel10", "Sootimander", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_145", "145", "PowerRebel11", "Sharkuit", "", "24", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_146", "146", "PowerRebel11", "Celestail", "", "25", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_147", "147", "PowerRebel11", "Heckyll", "", "23", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_148", "148", "PowerRebel12", "Tentapulse", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_149", "149", "PowerRebel12", "Exollusk", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_150", "150", "PowerRebel12", "Firmitaur", "", "30", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_151", "151", "KalomiOuadda", "Ratchet", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_152", "152", "KalomiOuadda", "Tortipous", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_153", "153", "KalomiOuadda", "Voltermite", "", "30", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_154", "154", "JinjaGuard1", "Lumineer", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_155", "155", "JinjaGuard1", "Riffindor", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_156", "156", "JinjaGuard1", "Oarion", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_157", "157", "JinjaGuard2", "Snowyrm", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_158", "158", "JinjaGuard2", "Ursicle", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_159", "159", "JinjaGuard2", "Yeticlaw", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_160", "160", "JinjaGuard3", "Jastrike", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_161", "161", "JinjaGuard3", "Ursicle", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_162", "162", "JinjaGuard3", "Dozer", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_163", "163", "JinjaGuard4", "Yeticlaw", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_164", "164", "JinjaGuard4", "Oarion", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_165", "165", "JinjaGuard4", "Sonax", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_166", "166", "JinjaWarrior1", "Clovice", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_167", "167", "JinjaWarrior1", "Tomahawk", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_168", "168", "JinjaWarrior1", "Oarion", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_169", "169", "JinjaWarrior2", "Halophin", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_170", "170", "JinjaWarrior2", "Ursicle", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_171", "171", "JinjaWarrior2", "Yeticlaw", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_172", "172", "JinjaWarrior3", "Brrizard", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_173", "173", "JinjaWarrior3", "Ursicle", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_174", "174", "JinjaWarrior3", "Dozer", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_175", "175", "JinjaWarrior4", "Yeticlaw", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_176", "176", "JinjaWarrior4", "Oarion", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_177", "177", "JinjaWarrior4", "Sonax", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_178", "178", "JinjaWarrior5", "Brrizard", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_179", "179", "JinjaWarrior5", "Pendrill", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_180", "180", "JinjaWarrior5", "Oarion", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_181", "181", "JinjaWarrior6", "Tentapulse", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_182", "182", "JinjaWarrior6", "Ursicle", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_183", "183", "JinjaWarrior6", "Yeticlaw", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_184", "184", "JinjaWarrior7", "Jastrike", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_185", "185", "JinjaWarrior7", "Ursicle", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_186", "186", "JinjaWarrior7", "Turanom", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_187", "187", "JinjaWarrior8", "Yeticlaw", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_188", "188", "JinjaWarrior8", "Oarion", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_189", "189", "JinjaWarrior8", "Sonax", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_190", "190", "JinjaWarrior9", "Lumineer", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_191", "191", "JinjaWarrior9", "Oaklore", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_192", "192", "JinjaWarrior9", "Oarion", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_193", "193", "MozungiBattle", "Lumineer", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_194", "194", "MozungiBattle", "Slizzard", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_195", "195", "MozungiBattle", "Yetiking", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_196", "196", "AbasiBattle", "Aquanine", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_197", "197", "AbasiBattle", "Oarion", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_198", "198", "AbasiBattle", "Snowyrm", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_199", "199", "JinjaRebel1", "Rhiyew", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_200", "200", "JinjaRebel1", "Sonax", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_201", "201", "JinjaRebel1", "Raptox", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_202", "202", "JinjaRebel2", "Tortitank", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_203", "203", "JinjaRebel2", "Fouligator", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_204", "204", "JinjaRebel2", "Thrashtail", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_205", "205", "HimayaBattle", "Exollusk", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_206", "206", "HimayaBattle", "Missilbee", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_207", "207", "HimayaBattle", "Sharkbyte", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_208", "208", "ZinoBattle", "Werevolt", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_209", "209", "ZinoBattle", "Diamane", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_210", "210", "ZinoBattle", "Jaggoon", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_211", "211", "JinjaRebel3", "Oarion", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_212", "212", "JinjaRebel3", "Snowyrm", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_213", "213", "JinjaRebel3", "Rhiyew", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_214", "214", "JinjaRebel4", "Sonax", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_215", "215", "JinjaRebel4", "Raptox", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_216", "216", "JinjaRebel4", "Tortitank", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_217", "217", "BrakLakeBattle", "Brak", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_218", "218", "JinjaLakeScout1", "Lumineer", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_219", "219", "JinjaLakeScout1", "Riffindor", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_220", "220", "JinjaLakeScout1", "Oarion", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_221", "221", "JinjaLakeScout2", "Snowyrm", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_222", "222", "JinjaLakeScout2", "Ursicle", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_223", "223", "JinjaLakeScout2", "Yeticlaw", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_224", "224", "JinjaLakeScout3", "Jastrike", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_225", "225", "JinjaLakeScout3", "Ursicle", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_226", "226", "JinjaLakeScout3", "Dozer", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_227", "227", "JinjaLakeScout4", "Yeticlaw", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_228", "228", "JinjaLakeScout4", "Oarion", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_229", "229", "JinjaLakeScout4", "Sonax", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_230", "230", "LakeRancher1", "Bananteater", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_231", "231", "LakeRancher1", "Firmitaur", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_232", "232", "LakeRancher1", "Hythea", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_233", "233", "LakeRancher2", "Sporkupine", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_234", "234", "LakeRancher2", "Manteri", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_235", "235", "LakeRancher2", "Sharkbyte", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_236", "236", "LakeRancher3", "Buntis", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_237", "237", "LakeRancher3", "Hootenant", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_238", "238", "LakeRancher3", "Sootiraptor", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_239", "239", "LakeRancher4", "Dandylion", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_240", "240", "LakeRancher4", "Celestail", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_241", "241", "LakeRancher4", "Soarphin", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_242", "242", "BananivoreBattle", "Bananivore", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_243", "243", "AdisaBattle", "Bananivore", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_244", "244", "AdisaBattle", "Predacuda", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_245", "245", "AdisaBattle", "Oceanite", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_246", "246", "VolcanoRancher1", "Vextail", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_247", "247", "VolcanoRancher1", "Monstrosipea", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_248", "248", "VolcanoRancher1", "Jastrike", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_249", "249", "VolcanoRancher2", "Oaklore", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_250", "250", "VolcanoRancher2", "Igniraffe", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_251", "251", "VolcanoRancher2", "Hytheo", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_252", "252", "VolcanoRancher3", "Riffindor", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_253", "253", "VolcanoRancher3", "Gazolt", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_254", "254", "VolcanoRancher3", "Bisoak", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_255", "255", "VolcanoRancher4", "Bananivore", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_256", "256", "VolcanoRancher4", "Bufflow", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_257", "257", "VolcanoRancher4", "Ursicle", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_258", "258", "VolcanoRancher5", "Sharkuit", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_259", "259", "VolcanoRancher5", "Hytheo", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_260", "260", "VolcanoRancher5", "Scorchling", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_261", "261", "VolcanoRancher6", "Igniraffe", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_262", "262", "VolcanoRancher6", "Equiness", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_263", "263", "VolcanoRancher6", "Maulverine", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_264", "264", "VolcanoRancher7", "Ampint", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_265", "265", "VolcanoRancher7", "Joltermite", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_266", "266", "VolcanoRancher7", "Oddcat", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_267", "267", "VolcanoRancher8", "Riffin", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_268", "268", "VolcanoRancher8", "Gorillamp", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_269", "269", "VolcanoRancher8", "Sporkupine", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_270", "270", "OzkanBattle", "Tortipous", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_271", "271", "OzkanBattle", "Voltermite", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_272", "272", "OzkanBattle", "Lumineer", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_273", "273", "KofisMinion1", "Riffindor", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_274", "274", "KofisMinion1", "Flarmian", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_275", "275", "KofisMinion1", "Snowyrm", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_276", "276", "KofisMinion2", "Sootiraptor", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_277", "277", "KofisMinion2", "Yeticlaw", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_278", "278", "KofisMinion2", "Jastrike", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_279", "279", "KofisMinion3", "Motharch", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_280", "280", "KofisMinion3", "Dozer", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_281", "281", "KofisMinion3", "Yeticlaw", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_282", "282", "KofisMinion4", "Lotis", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_283", "283", "KofisMinion4", "Sonax", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_284", "284", "KofisMinion4", "Clovice", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_285", "285", "KofisMinion5", "Tomahawk", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_286", "286", "KofisMinion5", "Magmeleon", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_287", "287", "KofisMinion5", "Halophin", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_288", "288", "KofisMinion6", "Megameleon", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_289", "289", "KofisMinion6", "Mantislash", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_290", "290", "KofisMinion6", "Brrizard", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_291", "291", "KofisMinion7", "Bufflow", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_292", "292", "KofisMinion7", "Dozer", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_293", "293", "KofisMinion7", "Robbinghood", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_294", "294", "KofisMinion8", "Maulverine", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_295", "295", "KofisMinion8", "Sonax", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_296", "296", "KofisMinion8", "Brrizard", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_297", "297", "KofisMinion9", "Pendrill", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_298", "298", "KofisMinion9", "Predacuda", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_299", "299", "KofisMinion9", "Tentapulse", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_300", "300", "KofisMinion10", "Fouligator", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_301", "301", "KofisMinion10", "Celestail", "", "40", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_302", "302", "KofisMinion10", "Jastrike", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_303", "303", "KofisMinion11", "Hythea", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_304", "304", "KofisMinion11", "Turanom", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_305", "305", "KofisMinion11", "Buntis", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_306", "306", "KofisMinion12", "Oarion", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_307", "307", "KofisMinion12", "Sonax", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_308", "308", "KofisMinion12", "Lumineer", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_309", "309", "KofisMinion13", "Oaklore", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_310", "310", "KofisMinion13", "Tidalhorn", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_311", "311", "KofisMinion13", "Volteer", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_312", "312", "KofisMinion14", "Sootiraptor", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_313", "313", "KofisMinion14", "Yetiking", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_314", "314", "KofisMinion14", "Aquanine", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_315", "315", "KofisMinion15", "Heckyll", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_316", "316", "KofisMinion15", "Flamoose", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_317", "317", "KofisMinion15", "Rhiyew", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_318", "318", "KofisMinion16", "Sonax", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_319", "319", "KofisMinion16", "Raptox", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_320", "320", "KofisMinion16", "Tortitank", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_321", "321", "KofisMinion17", "Fouligator", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_322", "322", "KofisMinion17", "Thrashtail", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_323", "323", "KofisMinion17", "Exollusk", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_324", "324", "KofisMinion18", "Missilbee", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_325", "325", "KofisMinion18", "Sharkbyte", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_326", "326", "KofisMinion18", "Magmameleon", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_327", "327", "KofisMinion19", "Pyrodilus", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_328", "328", "KofisMinion19", "Megameleon", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_329", "329", "KofisMinion19", "Oarion", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_330", "330", "KofisMinion20", "Snowyrm", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_331", "331", "KofisMinion20", "Rhiyew", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_332", "332", "KofisMinion20", "Sonax", "", "41", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_333", "333", "KofiBattle", "Sluggernaught", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_334", "334", "KofiBattle", "Villianeard", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_335", "335", "KofiBattle", "Missilbee", "", "47", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_336", "336", "VolcanoRancher9", "Tomahawk", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_337", "337", "VolcanoRancher9", "Wolvus", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_338", "338", "VolcanoRancher9", "Vextail", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_339", "339", "VolcanoRancher10", "Fouligator", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_340", "340", "VolcanoRancher10", "Clawbster", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_341", "341", "VolcanoRancher10", "Vextail", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_342", "342", "VolcanoRancher11", "Pranktail", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_343", "343", "VolcanoRancher11", "Skullywag", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_344", "344", "VolcanoRancher11", "Tuffin", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_345", "345", "VolcanoRancher12", "Sprew", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_346", "346", "VolcanoRancher12", "Manteri", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_347", "347", "VolcanoRancher12", "Sporkupine", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_348", "348", "VolcanoRancher13", "Voltermite", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_349", "349", "VolcanoRancher13", "Octicute", "", "42", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_350", "350", "VolcanoRancher13", "Ragewyrm", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_351", "351", "JungleKeeper", "Ripemare", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_352", "352", "JungleKeeper", "Monstrosipea", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_353", "353", "JungleGoon1", "Oaklore", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_354", "354", "JungleGoon1", "Maulverine", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_355", "355", "JungleGoon1", "Shrozen", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_356", "356", "JungleGoon2", "Yeticlaw", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_357", "357", "JungleGoon2", "Sporkupine", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_358", "358", "JungleGoon2", "Pendrill", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_359", "359", "JungleGoon3", "Rhiyew", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_360", "360", "JungleGoon3", "Sonax", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_361", "361", "JungleGoon3", "Tentapulse", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_362", "362", "DynamiteGoon1", "Sonax", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_363", "363", "DynamiteGoon1", "Sootiraptor", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_364", "364", "DynamiteGoon1", "Leviacuda", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_365", "365", "DynamiteGoon2", "Motharch", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_366", "366", "DynamiteGoon2", "Serpquin", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_367", "367", "DynamiteGoon2", "Tortitank", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_368", "368", "DynamiteGoon3", "Hytheo", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_369", "369", "DynamiteGoon3", "Clawlossal", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_370", "370", "DynamiteGoon3", "Ragewyrm", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_371", "371", "DynamiteGoon4", "Firmitaur", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_372", "372", "DynamiteGoon4", "Floatango", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_373", "373", "DynamiteGoon4", "Bufflow", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_374", "374", "DynamiteGoon5", "Maulverine", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_375", "375", "DynamiteGoon5", "Chicklit", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_376", "376", "DynamiteGoon5", "Bisoak", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_377", "377", "DynamiteGoon6", "Volteer", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_378", "378", "DynamiteGoon6", "Sonax", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_379", "379", "DynamiteGoon6", "Armotide", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_380", "380", "DynamiteGoon7", "Brrizard", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_381", "381", "DynamiteGoon7", "Megameleon", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_382", "382", "DynamiteGoon7", "Celestroah", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_383", "383", "DynamiteGoon8", "Pranktail", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_384", "384", "DynamiteGoon8", "Dozer", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_385", "385", "DynamiteGoon8", "Generowl", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_386", "386", "DynamiteGoon9", "Bufflow", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_387", "387", "DynamiteGoon9", "Tentapulse", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_388", "388", "DynamiteGoon9", "Megameleon", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_389", "389", "DynamiteGoon10", "Hytheo", "", "43", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_390", "390", "DynamiteGoon10", "Sootiraptor", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_391", "391", "DynamiteGoon10", "Tidalhorn", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_392", "392", "Pirate1", "Scuda", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_393", "393", "Pirate1", "Clawbster", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_394", "394", "Pirate1", "Predacuda", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_395", "395", "Pirate2", "Skullywag", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_396", "396", "Pirate2", "Leviacuda", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_397", "397", "Pirate2", "Clovice", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_398", "398", "Pirate3", "Pranktail", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_399", "399", "Pirate3", "Riffindor", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_400", "400", "Pirate3", "Sharpoon", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_401", "401", "Pirate4", "Amperor", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_402", "402", "Pirate4", "Sootiraptor", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_403", "403", "Pirate4", "Hytheo", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_404", "404", "Pirate5", "Hythea", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_405", "405", "Pirate5", "Ignitler", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_406", "406", "Pirate5", "Flamoose", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_407", "407", "Pirate6", "Ragewyrm", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_408", "408", "Pirate6", "Raptox", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_409", "409", "Pirate6", "Megameleon", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_410", "410", "Pirate7", "Gorillamp", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_411", "411", "Pirate7", "Yeticlaw", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_412", "412", "Pirate7", "Sporkupine", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_413", "413", "MineGoon1", "Igniraffe", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_414", "414", "MineGoon1", "Voltermite", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_415", "415", "MineGoon1", "Raptox", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_416", "416", "MineGoon2", "Tidalhorn", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_417", "417", "MineGoon2", "Pendrill", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_418", "418", "MineGoon2", "Sootiraptor", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_419", "419", "MineGoon3", "Tortitank", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_420", "420", "MineGoon3", "Sonax", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_421", "421", "MineGoon3", "Halophin", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_422", "422", "MineGoon4", "Maulverine", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_423", "423", "MineGoon4", "Firenaught", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_424", "424", "MineGoon4", "Heckyll", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_425", "425", "MineGoon5", "Ampint", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_426", "426", "MineGoon5", "Gekowatt", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_427", "427", "MineGoon5", "Cinduck", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_428", "428", "MineGoon6", "Pinclaw", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_429", "429", "MineGoon6", "Quirkat", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_430", "430", "MineGoon6", "Oddcat", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_431", "431", "MineGoon7", "Equiness", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_432", "432", "MineGoon7", "Volteer", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_433", "433", "MineGoon7", "Shadowvolt", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_434", "434", "MineGoon8", "Amperor", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_435", "435", "MineGoon8", "Missilbee", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_436", "436", "MineGoon8", "Cinduck", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_437", "437", "MineGoon9", "Buntis", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_438", "438", "MineGoon9", "Tortitank", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_439", "439", "MineGoon9", "Sootiraptor", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_440", "440", "MineGoon10", "Tuffin", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_441", "441", "MineGoon10", "Exollusk", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_442", "442", "MineGoon10", "Narwhalite", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_443", "443", "GoonHouse1", "Celestail", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_444", "444", "GoonHouse1", "Thrashtail", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_445", "445", "GoonHouse1", "Predacuda", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_446", "446", "GoonHouse2", "Firenaught", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_447", "447", "GoonHouse2", "Sootragon", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_448", "448", "GoonHouse2", "Clawbster", "", "53", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_449", "449", "MombassiGoon1", "Ripemare", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_450", "450", "MombassiGoon1", "Monstrosipea", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_451", "451", "MombassiGoon1", "Oaklore", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_452", "452", "MombassiGoon2", "Maulverine", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_453", "453", "MombassiGoon2", "Shrozen", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_454", "454", "MombassiGoon2", "Yeticlaw", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_455", "455", "MombassiGoon3", "Sporkupine", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_456", "456", "MombassiGoon3", "Pendrill", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_457", "457", "MombassiGoon3", "Rhiyew", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_458", "458", "MombassiGoon4", "Sonax", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_459", "459", "MombassiGoon4", "Tentapulse", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_460", "460", "MombassiGoon4", "Sonax", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_461", "461", "MombassiGoon5", "Sootiraptor", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_462", "462", "MombassiGoon5", "Leviacuda", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_463", "463", "MombassiGoon5", "Motharch", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_464", "464", "MombassiGoon6", "Serpquin", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_465", "465", "MombassiGoon6", "Tortitank", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_466", "466", "MombassiGoon6", "Hytheo", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_467", "467", "MombassiGoon7", "Clawlossal", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_468", "468", "MombassiGoon7", "Ragewyrm", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_469", "469", "MombassiGoon7", "Firmitaur", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_470", "470", "MombassiGoon8", "Floatango", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_471", "471", "MombassiGoon8", "Bufflow", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_472", "472", "MombassiGoon8", "Maulverine", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_473", "473", "MombassiGoon9", "Flamoose", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_474", "474", "MombassiGoon9", "Velocirax", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_475", "475", "MombassiGoon9", "Jastrike", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_476", "476", "MombassiGoon10", "Gorillamp", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_477", "477", "MombassiGoon10", "Yeticlaw", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_478", "478", "MombassiGoon10", "Generowl", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_479", "479", "MombassiGoon11", "Amperor", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_480", "480", "MombassiGoon11", "Bananivore", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_481", "481", "MombassiGoon11", "Halophin", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_482", "482", "HQGoon1", "Urstorm", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_483", "483", "HQGoon1", "Sootiraptor", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_484", "484", "HQGoon1", "Brrizard", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_485", "485", "HQGoon2", "Sporkupine", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_486", "486", "HQGoon2", "Armotide", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_487", "487", "HQGoon2", "Jestar", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_488", "488", "HQGoon3", "Dozer", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_489", "489", "HQGoon3", "Heckyll", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_490", "490", "HQGoon3", "Buntis", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_491", "491", "HQGoon4", "Megameleon", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_492", "492", "HQGoon4", "Celestroah", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_493", "493", "HQGoon4", "Jastrike", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_494", "494", "HQGoon5", "Exollusk", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_495", "495", "HQGoon5", "Chipmunkey", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_496", "496", "HQGoon5", "Magmeleon", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_497", "497", "HQGoon6", "Snailix", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_498", "498", "HQGoon6", "Riffindor", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_499", "499", "HQGoon6", "Voltermite", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_500", "500", "HQGoon7", "Buntis", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_501", "501", "HQGoon7", "Firmitaur", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_502", "502", "HQGoon7", "Sootiraptor", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_503", "503", "HQGoon8", "Igniraffe", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_504", "504", "HQGoon8", "Quirkat", "", "62", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_505", "505", "HQGoon8", "Dozer", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_506", "506", "HQGoon9", "Bananivore", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_507", "507", "HQGoon9", "Tentapulse", "", "62", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_508", "508", "HQGoon9", "Vextail", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_509", "509", "HQGoon10", "Shadowvolt", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_510", "510", "HQGoon10", "Gorillamp", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_511", "511", "HQGoon10", "Rhiyew", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_512", "512", "HQGoon11", "Sharkbyte", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_513", "513", "HQGoon11", "Generowl", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_514", "514", "HQGoon11", "Bufflow", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_515", "515", "HQGoon12", "Racruel", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_516", "516", "HQGoon12", "Thrashtail", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_517", "517", "HQGoon12", "Dragonflare", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_518", "518", "HQGoon13", "Ripemare", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_519", "519", "HQGoon13", "Mantislash", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_520", "520", "HQGoon13", "Chibken", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_521", "521", "HQGoon14", "Bufflow", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_522", "522", "HQGoon14", "Ragewyrm", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_523", "523", "HQGoon14", "Cobrozo", "", "59", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_524", "524", "HQGoon15", "Pranktail", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_525", "525", "HQGoon15", "Cackyll", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_526", "526", "HQGoon15", "Maulverine", "", "63", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_527", "527", "HQGoon16", "Chillbeak", "", "62", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_528", "528", "HQGoon16", "Magmameleon", "", "62", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_529", "529", "HQGoon16", "Flamoose", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_530", "530", "HQGoon17", "Serpquin", "", "62", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_531", "531", "HQGoon17", "Makowatt", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_532", "532", "HQGoon17", "Ragewyrm", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_533", "533", "HQGoon18", "Sootragon", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_534", "534", "HQGoon18", "Sharkbyte", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_535", "535", "HQGoon18", "Urstorm", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_536", "536", "HQGoon19", "Jestar", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_537", "537", "HQGoon19", "Oarion", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_538", "538", "HQGoon19", "Yetiking", "", "61", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_539", "539", "JonahBattle", "Carnivice", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_540", "540", "JonahBattle", "Cyclonine", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_541", "541", "JonahBattle", "Pandorum", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_542", "542", "GoonBoss", "Sluggernaught", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_543", "543", "GoonBoss", "Majestice", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_544", "544", "GoonBoss", "Villianeard", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_545", "545", "DarkDozerBattle", "Dozer", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_546", "546", "EmmettBattle", "Dozer", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_547", "547", "EmmettBattle", "Dozer", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_548", "548", "EmmettBattle", "Dozer", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_549", "549", "JonahDesertBattle", "Carnivice", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_550", "550", "JonahDesertBattle", "Cyclonine", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_551", "551", "JonahDesertBattle", "Pandorum", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_552", "552", "BastionDesertBattle", "Cackyll", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_553", "553", "BastionDesertBattle", "Velocirax", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_554", "554", "BastionDesertBattle", "Missilbee", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_555", "555", "NakatoBattle", "Ursicle", "", "57", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_556", "556", "NakatoBattle", "Gorillamp", "", "60", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_557", "557", "NakatoBattle", "Sootragon", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_558", "558", "PrisonGoon1", "Firenaught", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_559", "559", "PrisonGoon1", "Yetiking", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_560", "560", "PrisonGoon1", "Bananivore", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_561", "561", "PrisonGoon2", "Ampint", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_562", "562", "PrisonGoon2", "Frostsaut", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_563", "563", "PrisonGoon2", "Clawlossal", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_564", "564", "PrisonGoon3", "Chicklit", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_565", "565", "PrisonGoon3", "Igniraffe", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_566", "566", "PrisonGoon3", "Maulverine", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_567", "567", "PrisonGoon4", "Voltermite", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_568", "568", "PrisonGoon4", "Halophin", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_569", "569", "PrisonGoon4", "Buntis", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_570", "570", "PrisonGoon5", "Flairmingo", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_571", "571", "PrisonGoon5", "Dozer", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_572", "572", "PrisonGoon5", "Pyrodilus", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_573", "573", "PrisonGoon6", "Flamoose", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_574", "574", "PrisonGoon6", "Gorillamp", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_575", "575", "PrisonGoon6", "Strutwind", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_576", "576", "PrisonGoon7", "Racruel", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_577", "577", "PrisonGoon7", "Riffindor", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_578", "578", "PrisonGoon7", "Chipmunkey", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_579", "579", "PrisonGoon8", "Magmeleon", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_580", "580", "PrisonGoon8", "Snailix", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_581", "581", "PrisonGoon8", "Riffindor", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_582", "582", "PrisonGoon9", "Voltermite", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_583", "583", "PrisonGoon9", "Buntis", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_584", "584", "PrisonGoon9", "Firmitaur", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_585", "585", "PrisonGoon10", "Sootiraptor", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_586", "586", "PrisonGoon10", "Igniraffe", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_587", "587", "PrisonGoon10", "Quirkat", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_588", "588", "PrisonGoon11", "Dozer", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_589", "589", "PrisonGoon11", "Bananivore", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_590", "590", "PrisonGoon11", "Tentapulse", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_591", "591", "PrisonGoon12", "Vextail", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_592", "592", "PrisonGoon12", "Shadowvolt", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_593", "593", "PrisonGoon12", "Gorillamp", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_594", "594", "PrisonGoon13", "Rhiyew", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_595", "595", "PrisonGoon13", "Sharkbyte", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_596", "596", "PrisonGoon13", "Generowl", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_597", "597", "PrisonGoon14", "Bufflow", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_598", "598", "PrisonGoon14", "Racruel", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_599", "599", "PrisonGoon14", "Thrashtail", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_600", "600", "PrisonGoon15", "Dragonflare", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_601", "601", "PrisonGoon15", "Ripemare", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_602", "602", "PrisonGoon15", "Mantislash", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_603", "603", "PrisonGoon16", "Chibken", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_604", "604", "PrisonGoon16", "Bufflow", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_605", "605", "PrisonGoon16", "Ragewyrm", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_606", "606", "PrisonGoon17", "Cobrozo", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_607", "607", "PrisonGoon17", "Pranktail", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_608", "608", "PrisonGoon17", "Cackyll", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_609", "609", "PrisonGoon18", "Maulverine", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_610", "610", "PrisonGoon18", "Chillbeak", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_611", "611", "PrisonGoon18", "Magmameleon", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_612", "612", "PrisonGoon19", "Shrozen", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_613", "613", "PrisonGoon19", "Strutwind", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_614", "614", "PrisonGoon19", "Jastrike", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_615", "615", "PrisonGoon20", "Sonax", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_616", "616", "PrisonGoon20", "Cackyll", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_617", "617", "PrisonGoon20", "Sootiraptor", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_618", "618", "PrisonGoon21", "Slizzard", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_619", "619", "PrisonGoon21", "Spoompkin", "", "67", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_620", "620", "PrisonGoon21", "Tentapulse", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_621", "621", "NamanjaPrison1", "Raptox", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_622", "622", "NamanjaPrison1", "Sharkbyte", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_623", "623", "NamanjaPrison1", "Bullibee", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_624", "624", "NamanjaPrison2", "Generowl", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_625", "625", "NamanjaPrison2", "Torqupine", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_626", "626", "NamanjaPrison2", "Sharkbyte", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_627", "627", "NamanjaPrison3", "Cackyll", "", "74", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_628", "628", "NamanjaPrison3", "Thrashtail", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_629", "629", "NamanjaPrison3", "Ragewyrm", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_630", "630", "OuaddaPrison1", "Yetiking", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_631", "631", "OuaddaPrison1", "Oarion", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_632", "632", "OuaddaPrison1", "Monstrosipea", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_633", "633", "OuaddaPrison2", "Buntis", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_634", "634", "OuaddaPrison2", "Jestar", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_635", "635", "OuaddaPrison2", "Bufflow", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_636", "636", "OuaddaPrison3", "Clawlossal", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_637", "637", "OuaddaPrison3", "Hythea", "", "74", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_638", "638", "OuaddaPrison3", "Tortitank", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_639", "639", "OuaddaPrison4", "Ignitler", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_640", "640", "OuaddaPrison4", "Igniraffe", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_641", "641", "OuaddaPrison4", "Halophin", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_642", "642", "JinjaPrison1", "Spoompkin", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_643", "643", "JinjaPrison1", "Tidalhorn", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_644", "644", "JinjaPrison1", "Torqupine", "", "69", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_645", "645", "JinjaPrison2", "Raptox", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_646", "646", "JinjaPrison2", "Voltermite", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_647", "647", "JinjaPrison2", "Ripemare", "", "74", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_648", "648", "JinjaPrison3", "Gorillamp", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_649", "649", "JinjaPrison3", "Tentapulse", "", "73", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_650", "650", "JinjaPrison3", "Chillbeak", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_651", "651", "JinjaPrison4", "Maulverine", "", "72", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_652", "652", "JinjaPrison4", "Gorillamp", "", "71", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_653", "653", "JinjaPrison4", "Yetiking", "", "70", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_654", "654", "PrisonBoss", "Galavannis", "", "80", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_655", "655", "PrisonBoss", "Glaciagon", "", "78", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_656", "656", "PrisonBoss", "Makowatt", "", "77", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_657", "657", "MishiGuild1", "Bufflow", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_658", "658", "MishiGuild1", "Dozer", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_659", "659", "MishiGuild1", "Dandylion", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_660", "660", "MishiGuild2", "Brak", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_661", "661", "MishiGuild2", "Bananteater", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_662", "662", "MishiGuild2", "Shino", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_663", "663", "MishiGuild3", "Racket", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_664", "664", "MishiGuild3", "Mothball", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_665", "665", "MishiGuild3", "Chipmunkey", "", "9", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_666", "666", "MishiGuild4", "Jaggoon", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_667", "667", "MishiGuild4", "Oaklore", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_668", "668", "MishiGuild4", "Vioness", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_669", "669", "NamanjaGuild1", "Tortitank", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_670", "670", "NamanjaGuild1", "Clawbster", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_671", "671", "NamanjaGuild1", "Hytheo", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_672", "672", "NamanjaGuild2", "Tortipous", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_673", "673", "NamanjaGuild2", "Niptune", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_674", "674", "NamanjaGuild2", "Krabken", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_675", "675", "NamanjaGuild3", "Scuda", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_676", "676", "NamanjaGuild3", "Lotheo", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_677", "677", "NamanjaGuild3", "Lothea", "", "9", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_678", "678", "NamanjaGuild4", "Aquanine", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_679", "679", "NamanjaGuild4", "Clawlossal", "", "56", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_680", "680", "NamanjaGuild4", "Fouligator", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_681", "681", "OuaddaGuild1", "Ninevolt", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_682", "682", "OuaddaGuild1", "Maulverine", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_683", "683", "OuaddaGuild1", "Gorillamp", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_684", "684", "OuaddaGuild2", "Gekowatt", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_685", "685", "OuaddaGuild2", "Voltermite", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_686", "686", "OuaddaGuild2", "Octicute", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_687", "687", "OuaddaGuild3", "Gazolt", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_688", "688", "OuaddaGuild3", "Ampint", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_689", "689", "OuaddaGuild3", "Sharkuit", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_690", "690", "OuaddaGuild4", "Werevolt", "", "64", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_691", "691", "OuaddaGuild4", "Amperor", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_692", "692", "OuaddaGuild4", "Torqupine", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_693", "693", "ArcaneGuild1", "Spoompkin", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_694", "694", "ArcaneGuild1", "Heckyll", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_695", "695", "ArcaneGuild1", "Foxpaw", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_696", "696", "ArcaneGuild2", "Oddcat", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_697", "697", "ArcaneGuild2", "Staria", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_698", "698", "ArcaneGuild2", "Foxpaw", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_699", "699", "ArcaneGuild3", "Snailix", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_700", "700", "ArcaneGuild3", "Foxpaw", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_701", "701", "ArcaneGuild3", "Grynn", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_702", "702", "ArcaneGuild4", "Cackyll", "", "64", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_703", "703", "ArcaneGuild4", "Jestar", "", "66", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_704", "704", "ArcaneGuild4", "Celestroah", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_705", "705", "JinjaGuild1", "Urstorm", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_706", "706", "JinjaGuild1", "Ragewyrm", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_707", "707", "JinjaGuild1", "Yetiking", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_708", "708", "JinjaGuild2", "Snowyrm", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_709", "709", "JinjaGuild2", "Ursicle", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_710", "710", "JinjaGuild2", "Oarion", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_711", "711", "JinjaGuild3", "Freyon", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_712", "712", "JinjaGuild3", "Turanom", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_713", "713", "JinjaGuild3", "Yeticrab", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_714", "714", "JinjaGuild4", "Carnivice", "", "74", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_715", "715", "JinjaGuild4", "Chillbeak", "", "76", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_716", "716", "JinjaGuild4", "Diamane", "", "78", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_717", "717", "KismayoGuild1", "Pandora", "", "55", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_718", "718", "KismayoGuild1", "Cinduck", "", "54", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_719", "719", "KismayoGuild1", "Firenaught", "", "58", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_720", "720", "KismayoGuild2", "Flamoose", "", "38", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_721", "721", "KismayoGuild2", "Flarmian", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_722", "722", "KismayoGuild2", "Sootiraptor", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_723", "723", "KismayoGuild3", "Viperno", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_724", "724", "KismayoGuild3", "Vextail", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_725", "725", "KismayoGuild3", "Dragonflare", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_726", "726", "KismayoGuild4", "Blazilisk", "", "74", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_727", "727", "KismayoGuild4", "Pandorum", "", "76", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_728", "728", "KismayoGuild4", "Pyrodilus", "", "78", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_729", "729", "MombassiGuild1", "Robbinghood", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_730", "730", "MombassiGuild1", "Jastrike", "", "64", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_731", "731", "MombassiGuild1", "Targabee", "", "68", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_732", "732", "MombassiGuild2", "Flofox", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_733", "733", "MombassiGuild2", "Hootenant", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_734", "734", "MombassiGuild2", "Shriken", "", "47", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_735", "735", "MombassiGuild3", "Lotis", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_736", "736", "MombassiGuild3", "Swinx", "", "37", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_737", "737", "MombassiGuild3", "Riffin", "", "39", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_738", "738", "MombassiGuild4", "Missilbee", "", "84", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_739", "739", "MombassiGuild4", "Cyclonine", "", "86", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_740", "740", "MombassiGuild4", "Vilewing", "", "88", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_741", "741", "NiptuneBattle", "Niptune", "", "10", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_742", "742", "MishiMountain1", "Tortipous", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_743", "743", "MishiMountain1", "Dozer", "", "30", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_744", "744", "MishiMountain1", "Alistinker", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_745", "745", "MishiMountain2", "Hoodwink", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_746", "746", "MishiMountain2", "Oddcat", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_747", "747", "MishiMountain2", "Tortipous", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_748", "748", "JinjaMountain1", "Tomahawk", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_749", "749", "JinjaMountain1", "Oarion", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_750", "750", "JinjaMountain1", "Halophin", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_751", "751", "JinjaMountain2", "Ursicle", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_752", "752", "JinjaMountain2", "Yeticlaw", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_753", "753", "JinjaMountain2", "Brrizard", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_754", "754", "JinjaMountain3", "Ursicle", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_755", "755", "JinjaMountain3", "Dozer", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_756", "756", "JinjaMountain3", "Yeticlaw", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_757", "757", "JinjaMountain4", "Oarion", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_758", "758", "JinjaMountain4", "Sonax", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_759", "759", "JinjaMountain4", "Brrizard", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_760", "760", "JinjaMountain5", "Pendrill", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_761", "761", "JinjaMountain5", "Oarion", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_762", "762", "JinjaMountain5", "Tentapulse", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_763", "763", "JinjaMountain6", "Ursicle", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_764", "764", "JinjaMountain6", "Yeticlaw", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_765", "765", "JinjaMountain6", "Jastrike", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_766", "766", "JinjaMountain7", "Ursicle", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_767", "767", "JinjaMountain7", "Turanom", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_768", "768", "JinjaMountain7", "Yeticlaw", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_769", "769", "JinjaMountain8", "Oarion", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_770", "770", "JinjaMountain8", "Sonax", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_771", "771", "JinjaMountain8", "Lumineer", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_772", "772", "JinjaMountain9", "Oaklore", "", "30", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_773", "773", "JinjaMountain9", "Oarion", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_774", "774", "JinjaMountain9", "Sonax", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_775", "775", "JinjaMountain10", "Brrizard", "", "33", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_776", "776", "JinjaMountain10", "Pendrill", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_777", "777", "JinjaMountain10", "Oarion", "", "30", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_778", "778", "MountainRancher1", "Venox", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_779", "779", "MountainRancher1", "Bananteater", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_780", "780", "MountainRancher1", "Firmitaur", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_781", "781", "MountainRancher2", "Hythea", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_782", "782", "MountainRancher2", "Sporkupine", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_783", "783", "MountainRancher2", "Manteri", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_784", "784", "MountainRancher3", "Sharkbyte", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_785", "785", "MountainRancher3", "Buntis", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_786", "786", "MountainRancher3", "Hootenant", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_787", "787", "MountainRancher4", "Sootiraptor", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_788", "788", "MountainRancher4", "Dandylion", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_789", "789", "MountainRancher4", "Celestail", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_790", "790", "MountainRancher5", "Soarphin", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_791", "791", "MountainRancher5", "Bananivore", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_792", "792", "MountainRancher5", "Bananivore", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_793", "793", "MountainRancher6", "Predacuda", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_794", "794", "MountainRancher6", "Sporkupine", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_795", "795", "MountainRancher6", "Vextail", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_796", "796", "MountainRancher7", "Monstrosipea", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_797", "797", "MountainRancher7", "Jastrike", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_798", "798", "MountainRancher7", "Oaklore", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_799", "799", "MountainRancher8", "Igniraffe", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_800", "800", "MountainRancher8", "Hytheo", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_801", "801", "MountainRancher8", "Riffindor", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_802", "802", "MountainRancher9", "Gazolt", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_803", "803", "MountainRancher9", "Bisoak", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_804", "804", "MountainRancher9", "Bananteater", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_805", "805", "MountainRancher10", "Caleaf", "", "31", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_806", "806", "MountainRancher10", "Motharch", "", "29", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_807", "807", "MountainRancher10", "Vextail", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_808", "808", "StrayNamanjaMishi", "Tortipous", "", "7", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_809", "809", "StrayNamanjaMishi", "Racket", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_810", "810", "StrayNamanjaMishi", "Scuda", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_811", "811", "DozerKalomiBattle", "Dozer", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_812", "812", "BurtBattle", "Venox", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_813", "813", "BurtBattle", "Venox", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_814", "814", "BurtBattle", "Bullibee", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_815", "815", "KalomiBattleNew1", "Bullibee", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_816", "816", "KalomiBattleNew2", "Moxtail", "", "1", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_817", "817", "MishiThief", "Bullibee", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_818", "818", "MishiThief", "Racket", "", "3", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_819", "819", "MishiThief", "Tomaling", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_820", "820", "NamanjaOutcast1", "Oddcat", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_821", "821", "NamanjaOutcast1", "Grynn", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_822", "822", "NamanjaOutcast1", "Snailix", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_823", "823", "NamanjaOutcast2", "Snailix", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_824", "824", "NamanjaOutcast2", "Foxpaw", "", "12", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_825", "825", "NamanjaOutcast2", "Staria", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_826", "826", "NamanjaOutcast3", "Spoompkin", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_827", "827", "NamanjaOutcast3", "Bullibee", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_828", "828", "NamanjaOutcast3", "Oddcat", "", "13", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_829", "829", "OasisJinja1", "Ignitler", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_830", "830", "OasisJinja1", "Sharkuit", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_831", "831", "OasisJinja1", "Manteri", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_832", "832", "OasisJinja2", "Yeticlaw", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_833", "833", "OasisJinja2", "Shino", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_834", "834", "OasisJinja2", "Brak", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_835", "835", "OasisJinja3", "Grynn", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_836", "836", "OasisJinja3", "Swinx", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_837", "837", "OasisJinja3", "Clovice", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_838", "838", "OasisJinja4", "Ursnobal", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_839", "839", "OasisJinja4", "Yantis", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_840", "840", "OasisJinja4", "Shriken", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_841", "841", "OasisJinja5", "Flarmian", "", "27", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_842", "842", "OasisJinja5", "Coralpie", "", "28", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_843", "843", "OasisJinja5", "Yeticrab", "", "26", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_844", "844", "ForestRancher1", "Scuda", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_845", "845", "ForestRancher1", "Snowyrm", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_846", "846", "ForestRancher1", "Scorchling", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_847", "847", "ForestRancher2", "Alistinker", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_848", "848", "ForestRancher2", "Manticub", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_849", "849", "ForestRancher2", "Yantis", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_850", "850", "ForestRancher3", "Shriken", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_851", "851", "ForestRancher3", "Hootenant", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_852", "852", "ForestRancher3", "Sootimander", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_853", "853", "DandylionBattle", "Rhiyew", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_854", "854", "DandylionBattle", "Oaklore", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_855", "855", "DandylionBattle", "Dandylion", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_856", "856", "WaterfallRancher1", "Racket", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_857", "857", "WaterfallRancher1", "Tomatopea", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_858", "858", "WaterfallRancher2", "Lotis", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_859", "859", "WaterfallRancher2", "Mothball", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_860", "860", "WaterfallRancher3", "Fluster", "", "4", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_861", "861", "WaterfallRancher3", "Sootimander", "", "5", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_862", "862", "FlofoxBattle", "Clawlossal", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_863", "863", "FlofoxBattle", "Pyrodilus", "", "65", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_864", "864", "FlofoxBattle", "Flofox", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_865", "865", "JinjaRancher1", "Ursicle", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_866", "866", "JinjaRancher1", "Halophin", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_867", "867", "JinjaRancher1", "Pendrill", "", "32", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_868", "868", "JinjaRancher2", "Ursicle", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_869", "869", "JinjaRancher2", "Yeticlaw", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_870", "870", "JinjaRancher2", "Buntis", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_871", "871", "JinjaRancher3", "Oarion", "", "35", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_872", "872", "JinjaRancher3", "Yeticlaw", "", "36", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_873", "873", "JinjaRancher3", "Robbinghood", "", "34", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_874", "874", "KismayoRancher1", "Voltermite", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_875", "875", "KismayoRancher1", "Volteer", "", "47", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_876", "876", "KismayoRancher1", "Riffindor", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_877", "877", "KismayoRancher2", "Tortitank", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_878", "878", "KismayoRancher2", "Clawbster", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_879", "879", "KismayoRancher2", "Predacuda", "", "47", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_880", "880", "KismayoRancher3", "Bananivore", "", "51", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_881", "881", "KismayoRancher3", "Bufflow", "", "49", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_882", "882", "KismayoRancher3", "Rhiyew", "", "50", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_883", "883", "KismayoRancher4", "Cinduck", "", "48", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_884", "884", "KismayoRancher4", "Flamoose", "", "51", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_885", "885", "KismayoRancher4", "Sootiraptor", "", "52", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_886", "886", "KismayoRancher5", "Shriken", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_887", "887", "KismayoRancher5", "Sonax", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_888", "888", "KismayoRancher5", "Buntis", "", "44", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_889", "889", "KismayoRancher6", "Exollusk", "", "46", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_890", "890", "KismayoRancher6", "Heckyll", "", "45", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_891", "891", "KismayoRancher6", "Serpquin", "", "47", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_892", "892", "PandemiteBattle", "Sootragon", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_893", "893", "PandemiteBattle", "Cackyll", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_894", "894", "PandemiteBattle", "Pandemite", "", "6", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_895", "895", "NiptuneBattle", "Tentapulse", "", "75", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_896", "896", "NiptuneBattle", "Oaklore", "", "75", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_897", "897", "NamanjaRancher1", "Scuda", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_898", "898", "NamanjaRancher1", "Clawbster", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_899", "899", "NamanjaRancher1", "Tortipous", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_900", "900", "NamanjaRancher2", "Coralpie", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_901", "901", "NamanjaRancher2", "Strutwing", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_902", "902", "NamanjaRancher2", "Yantis", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_903", "903", "NamanjaRancher3", "Ignitler", "", "14", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_904", "904", "NamanjaRancher3", "Hoodwink", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_905", "905", "NamanjaRancher3", "Alistinker", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_906", "906", "NamanjaRancher4", "Snowyrm", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_907", "907", "NamanjaRancher4", "Scorchling", "", "15", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_908", "908", "NamanjaRancher4", "Krabken", "", "16", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_909", "909", "CaveRancher1", "Hootenant", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_910", "910", "CaveRancher1", "Flaffee", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_911", "911", "CaveRancher1", "Flarmian", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_912", "912", "CaveRancher2", "Brak", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_913", "913", "CaveRancher2", "Snowyrm", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_914", "914", "CaveRancher2", "Ignitler", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_915", "915", "CaveRancher3", "Caleaf", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_916", "916", "CaveRancher3", "Ursnobal", "", "19", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_917", "917", "CaveRancher3", "Ignitler", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_918", "918", "CaveRancher4", "Ampint", "", "17", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_919", "919", "CaveRancher4", "Riffin", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_920", "920", "CaveRancher4", "Gazolt", "", "18", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_921", "921", "RukuuBattle", "Motharch", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_922", "922", "RukuuBattle", "Vioness", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_923", "923", "RukuuBattle", "Dozer", "", "89", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_924", "924", "MishiCaveBattle1", "Rhiyew", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_925", "925", "MishiCaveBattle1", "Oaklore", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_926", "926", "MishiCaveBattle1", "Strutwind", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_927", "927", "MishiCaveBattle2", "Racruel", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_928", "928", "MishiCaveBattle2", "Bananivore", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_929", "929", "MishiCaveBattle2", "Bisoak", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_930", "930", "MishiCaveBattle3", "Jaggoon", "", "89", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_931", "931", "MishiCaveBattle3", "Motharch", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_932", "932", "MishiCaveBattle3", "Oaklore", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_933", "933", "MishiCaveBattle4", "Strutwind", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_934", "934", "MishiCaveBattle4", "Racruel", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_935", "935", "MishiCaveBattle4", "Bananivore", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_936", "936", "GuildLeaderWater", "Carnivice", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_937", "937", "GuildLeaderWater", "Tortitank", "", "89", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_938", "938", "GuildLeaderWater", "Leviacuda", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_939", "939", "GuildLeaderEarth", "Bisoak", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_940", "940", "GuildLeaderEarth", "Jaggoon", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_941", "941", "GuildLeaderEarth", "Motharch", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_942", "942", "GuildLeaderAir", "Ragewyrm", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_943", "943", "GuildLeaderAir", "Jastrike", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_944", "944", "GuildLeaderAir", "Sonax", "", "89", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_945", "945", "SamotBattle", "Dragonflare", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_946", "946", "SamotBattle", "Hytheo", "", "91", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_947", "947", "SamotBattle", "Bisoak", "", "90", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_948", "948", "DungScientistBattle", "Tomahawk", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_949", "949", "DungScientistBattle", "Chipmunkey", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_950", "950", "DungScientistBattle", "Fouligator", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_951", "951", "DungScientist2", "Shrozen", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_952", "952", "DungScientist2", "Clawlossal", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_953", "953", "DungScientist2", "Fouligator", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_954", "954", "DungScientist3", "Manteri", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_955", "955", "DungScientist3", "Bufflow", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_956", "956", "DungScientist3", "Frostsaut", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_957", "957", "DungScientist4", "Sootiraptor", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_958", "958", "DungScientist4", "Oaklore", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_959", "959", "DungScientist4", "Halophin", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_960", "960", "GuildCaveBattle1", "Tentapulse", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_961", "961", "GuildCaveBattle1", "Galavannis", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_962", "962", "GuildCaveBattle1", "Werevolt", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_963", "963", "GuildCaveBattle2", "Gorillamp", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_964", "964", "GuildCaveBattle2", "Voltermite", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_965", "965", "GuildCaveBattle2", "Shadowvolt", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_966", "966", "GuildCaveBattle3", "Gekowatt", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_967", "967", "GuildCaveBattle3", "Riffindor", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_968", "968", "GuildCaveBattle3", "Gorillamp", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_969", "969", "GuildCaveBattle4", "Amperor", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_970", "970", "GuildCaveBattle4", "Voltermite", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_971", "971", "GuildCaveBattle4", "Torqupine", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_972", "972", "CourierCaveBattle1", "Vextail", "", "92", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_973", "973", "CourierCaveBattle1", "Tomahawk", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_974", "974", "CourierCaveBattle1", "Equiness", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_975", "975", "CourierCaveBattle2", "Bisoak", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_976", "976", "CourierCaveBattle2", "Ripemare", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_977", "977", "CourierCaveBattle2", "Tortitank", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_978", "978", "CourierCaveBattle3", "Halophin", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_979", "979", "CourierCaveBattle3", "Cinduck", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_980", "980", "CourierCaveBattle3", "Clawlossal", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_981", "981", "CourierCaveBattle4", "Tortitank", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_982", "982", "CourierCaveBattle4", "Vilewing", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_983", "983", "CourierCaveBattle4", "Equiness", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_984", "984", "CourierCaveBattle5", "Leviacuda", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_985", "985", "CourierCaveBattle5", "Cobrozo", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_986", "986", "CourierCaveBattle5", "Hythea", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_987", "987", "TaurysosCaveBattle", "Taurysos", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_988", "988", "AirGuildLandBattle1", "Buntis", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_989", "989", "AirGuildLandBattle1", "Generowl", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_990", "990", "AirGuildLandBattle1", "Tomahawk", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_991", "991", "AirGuildLandBattle2", "Dragonflare", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_992", "992", "AirGuildLandBattle2", "Vilewing", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_993", "993", "AirGuildLandBattle2", "Missilbee", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_994", "994", "AirGuildLandBattle3", "Riffindor", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_995", "995", "AirGuildLandBattle3", "Vilewing", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_996", "996", "AirGuildLandBattle3", "Jastrike", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_997", "997", "AirGuildLandBattle4", "Cyclonine", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_998", "998", "AirGuildLandBattle4", "Vilewing", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_999", "999", "AirGuildLandBattle4", "Sonax", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1000", "1000", "FireGuildSavannahBattle1", "Blazilisk", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1001", "1001", "FireGuildSavannahBattle1", "Sootragon", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1002", "1002", "FireGuildSavannahBattle1", "Igniraffe", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1003", "1003", "FireGuildSavannahBattle2", "Pandorum", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1004", "1004", "FireGuildSavannahBattle2", "Firenaught", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1005", "1005", "FireGuildSavannahBattle2", "Pyrodilus", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1006", "1006", "FireGuildSavannahBattle3", "Thrashtail", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1007", "1007", "FireGuildSavannahBattle3", "Dragonflare", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1008", "1008", "FireGuildSavannahBattle3", "Sootragon", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1009", "1009", "FireGuildSavannahBattle4", "Cinduck", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1010", "1010", "FireGuildSavannahBattle4", "Sootragon", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1011", "1011", "FireGuildSavannahBattle4", "Igniraffe", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1012", "1012", "FireGuildSavannahBattle5", "Magmameleon", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1013", "1013", "FireGuildSavannahBattle5", "Sootragon", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1014", "1014", "FireGuildSavannahBattle5", "Cinduck", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1015", "1015", "FireGuildSavannahBattle6", "Sootragon", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1016", "1016", "FireGuildSavannahBattle6", "Igniraffe", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1017", "1017", "FireGuildSavannahBattle6", "Magmameleon", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1018", "1018", "FireGuildLandBattle1", "Sootragon", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1019", "1019", "FireGuildLandBattle1", "Igniraffe", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1020", "1020", "FireGuildLandBattle1", "Pandorum", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1021", "1021", "FireGuildLandBattle2", "Firenaught", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1022", "1022", "FireGuildLandBattle2", "Pyrodilus", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1023", "1023", "FireGuildLandBattle2", "Thrashtail", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1024", "1024", "FireGuildLandBattle3", "Dragonflare", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1025", "1025", "FireGuildLandBattle3", "Sootragon", "", "96", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1026", "1026", "FireGuildLandBattle3", "Cinduck", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1027", "1027", "FireGuildLandBattle4", "Sootragon", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1028", "1028", "FireGuildLandBattle4", "Igniraffe", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1029", "1029", "FireGuildLandBattle4", "Magmameleon", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1030", "1030", "FireGuildLandBattle5", "Blazilisk", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1031", "1031", "FireGuildLandBattle5", "Sootragon", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1032", "1032", "FireGuildLandBattle5", "Igniraffe", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1033", "1033", "FireGuildLandBattle6", "Pandorum", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1034", "1034", "FireGuildLandBattle6", "Firenaught", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1035", "1035", "FireGuildLandBattle6", "Pyrodilus", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1036", "1036", "FireGuildVolcanoBattle1", "Thrashtail", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1037", "1037", "FireGuildVolcanoBattle1", "Dragonflare", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1038", "1038", "FireGuildVolcanoBattle1", "Magmameleon", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1039", "1039", "InferamVolcanoBattle", "Inferram", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1040", "1040", "", "", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1041", "1041", "", "", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1042", "1042", "GuildIceCave1", "Carnivice", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1043", "1043", "GuildIceCave1", "Yetiking", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1044", "1044", "GuildIceCave1", "Oarion", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1045", "1045", "GuildIceCave2", "Ragewyrm", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1046", "1046", "GuildIceCave2", "Urstorm", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1047", "1047", "GuildIceCave2", "Majestice", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1048", "1048", "GuildIceCave3", "Chillbeak", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1049", "1049", "GuildIceCave3", "Diamane", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1050", "1050", "GuildIceCave3", "Yetiking", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1051", "1051", "GuildIceCave4", "Urstorm", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1052", "1052", "GuildIceCave4", "Ragewyrm", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1053", "1053", "GuildIceCave4", "Urstorm", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1054", "1054", "GuildIceCave5", "Majestice", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1055", "1055", "GuildIceCave5", "Chillbeak", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1056", "1056", "GuildIceCave5", "Diamane", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1057", "1057", "GuildIceCave6", "Yetiking", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1058", "1058", "GuildIceCave6", "Urstorm", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1059", "1059", "GuildIceCave6", "Ragewyrm", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1060", "1060", "GuildIceCave7", "Yetiking", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1061", "1061", "GuildIceCave7", "Urstorm", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1062", "1062", "GuildIceCave7", "Ragewyrm", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1063", "1063", "GuildIceCave8", "Urstorm", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1064", "1064", "GuildIceCave8", "Majestice", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1065", "1065", "GuildIceCave8", "Chillbeak", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1066", "1066", "SquallanIceCave", "Squallan", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1067", "1067", "SquallanIceCave", "Skelinoth", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1068", "1068", "SquallanIceCave", "Galaynx", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1069", "1069", "WaterGuildLandBattle1", "Carnivice", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1070", "1070", "WaterGuildLandBattle1", "Tortitank", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1071", "1071", "WaterGuildLandBattle1", "Leviacuda", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1072", "1072", "WaterGuildLandBattle2", "Clawlossal", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1073", "1073", "WaterGuildLandBattle2", "Tortitank", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1074", "1074", "WaterGuildLandBattle2", "Tidalhorn", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1075", "1075", "WaterGuildLandBattle3", "Leviacuda", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1076", "1076", "WaterGuildLandBattle3", "Fouligator", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1077", "1077", "WaterGuildLandBattle3", "Hytheo", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1078", "1078", "WaterGuildLandBattle4", "Hythea", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1079", "1079", "WaterGuildLandBattle4", "Clawlossal", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1080", "1080", "WaterGuildLandBattle4", "Oceanite", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1081", "1081", "WaterGuildLandBattle5", "Villianeard", "", "98", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1082", "1082", "WaterGuildLandBattle5", "Clawlossal", "", "99", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1083", "1083", "WaterGuildLandBattle5", "Tortitank", "", "97", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1084", "1084", "AquarinBattle", "Aquarin", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1085", "1085", "AquarinBattle", "Glaciolin", "", "100", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1086", "1086", "GuildLeaderElectric", "Maulverine", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1087", "1087", "GuildLeaderElectric", "Makowatt", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1088", "1088", "GuildLeaderElectric", "Riffindor", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1089", "1089", "GuildCaveBattle5", "Voltermite", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1090", "1090", "GuildCaveBattle5", "Shadowvolt", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1091", "1091", "GuildCaveBattle5", "Gekowatt", "", "93", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1092", "1092", "GuildCaveBattle6", "Riffindor", "", "94", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1093", "1093", "GuildCaveBattle6", "Gorillamp", "", "95", "", "", "", "", "", ""));
			Rows.Add( new NPCBattleMonstersRow("NPCBM_1094", "1094", "GuildCaveBattle6", "Amperor", "", "95", "", "", "", "", "", ""));
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
		public NPCBattleMonstersRow GetRow(rowIds in_RowID)
		{
			NPCBattleMonstersRow ret = null;
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
		public NPCBattleMonstersRow GetRow(string in_RowString)
		{
			NPCBattleMonstersRow ret = null;
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
