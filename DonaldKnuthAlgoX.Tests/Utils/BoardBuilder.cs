using DonaldKnuthAlgoX.Algorithm;
using System.Collections.Generic;

namespace DonaldKnuthAlgoX.Tests.Utils
{
    public class BoardBuilder
    {
        Dance __instance;
        int __rowCounter;

        public BoardBuilder()
        {
            __rowCounter = 0;
        }

        public BoardBuilder WithSize(int boardSize)
        {
            __instance = new Dance(boardSize);
            return this;
        }

        public BoardBuilder WithRow(int[] row)
        {
            __instance.AddRow(__rowCounter, row);
            __rowCounter++;
            return this;
        }

        public HashSet<int> CalculateResultingStackContent(out int columnsInBoard)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (var answer in __instance.Go(0))
                if (__instance.AnswerFound)
                    result.UnionWith(answer);

            columnsInBoard = __instance.ActualColumns;
            return result;
        }
    }
}
