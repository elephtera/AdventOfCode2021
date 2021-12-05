﻿namespace AdventOfCode2021.Assignments
{
    public static class InputHandler
    {
        public static IList<int> ConvertInputToIntList(string input)
        {
            var lines = input.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);

            var result = lines.Select(line => int.Parse(line)).ToList();
            return result;
        }
        public static IList<int[][]> ConvertInputToBingoCards(string input)
        {
            var lines = input.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);

            var bingoCards = new List<int[][]>();
            var bingoLines = new List<int[]>();
            foreach (var line in lines)
            {
                bingoLines.Add(line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(item => Int32.Parse(item)).ToArray());
            }

            var lineCount = 0;
            var bingoCard = new int[5][];

            foreach (var line in bingoLines)
            {
                bingoCard[lineCount] = line;

                lineCount++;


                if (lineCount == 5)
                {
                    bingoCards.Add(bingoCard);
                    bingoCard = new int[5][];
                    lineCount = 0;
                }
            }

            return bingoCards;
        }

        internal static List<Line> ConvertInputToLines(string input)
        {
            var result = new List<Line>();
            var inputLines = input.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.None);
            foreach(var inputLine in inputLines)
            {
                var numbers = inputLine.Split(new String[] { ",", " -> " }, StringSplitOptions.None).Select(number => Int32.Parse(number)).ToArray();
                result.Add(new Line() { x1 = numbers[0], y1 = numbers[1], x2 = numbers[2], y2 = numbers[3] });
            }

            return result;

        }
    }
}