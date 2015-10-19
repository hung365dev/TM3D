using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
class MovePointsComparison : IComparer<MoveTreeCompletionDataRow>
{
	public int Compare(MoveTreeCompletionDataRow aMove1, MoveTreeCompletionDataRow aMove2)
	{
		if(aMove1.pointsToUnlock<aMove2.pointsToUnlock) {
			return -1;
		} else return 1;
	}

}