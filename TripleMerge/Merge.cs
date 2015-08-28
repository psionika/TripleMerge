using System.Collections.Generic;
using System.Linq;

namespace TripleMerge
{
    public static class TripleMerger
    {
        /// <summary>
        /// Performs the three way merge operation upon lists of strings.
        /// </summary>
        /// <param name="originalList">The original list.</param>
        /// <param name="leftList">First version.</param>
        /// <param name="rightList">Second version.</param>
        /// <returns>The merged list.</returns>
        public static List<string> Merge(IEnumerable<string> originalList, IEnumerable<string> leftList, IEnumerable<string> rightList)
        {
            var result = new List<string>();

            var source = new Version(originalList.ToList());
            var one = new Version(leftList.ToList());
            var two = new Version(rightList.ToList());

            while (!one.Ended || !two.Ended)
            {
                if (one.Ended || two.Ended)
                {
                    var whatNotEnded = one.Ended ? two : one;

                    if (source.Ended)
                    {
                        whatNotEnded.AcceptUntilEnd(result);
                        break;
                    }
                    else
                    {
                        ResolveSingleVersion(result, source, whatNotEnded);
                        break;
                    }
                }
                else if (source.Ended)
                {
                    ResolveTwoWayLine(one, two, result);
                    continue;
                }

                if (CompareStrings(source.CurrentLine, one.CurrentLine) && CompareStrings(source.CurrentLine, two.CurrentLine))
                {
                    one.AcceptLine(result);
                    source.SkipLine();
                    two.SkipLine();
                }
                else if (!CompareStrings(source.CurrentLine, one.CurrentLine) || !CompareStrings(source.CurrentLine, two.CurrentLine))
                {
                    var whichIsMaybeEqual = source.CurrentLine != one.CurrentLine ? two : one;
                    var whichIsNotEqual = source.CurrentLine != one.CurrentLine ? one : two;

                    if (CompareStrings(source.CurrentLine, whichIsMaybeEqual.CurrentLine))
                    {
                        if (!whichIsNotEqual.FastForward(result, source.CurrentLine))
                        {
                            source.SkipLine();
                            whichIsMaybeEqual.SkipLine();
                        }
                    }
                    else if (CompareStrings(one.CurrentLine, two.CurrentLine))
                    {
                        one.AcceptLine(result);
                        two.SkipLine();
                    }
                    else
                    {
                        ResolveThreeWayConflict(one, two, source, result);
                    }
                }
            }

            return result;
        }

        static string CheckForConflict(string left, string right)
        {
            if (CompareStrings(left, right))
            {
                return left;
            }
            return "CONFLICT: " + left + " " + right;
        }

        static bool CompareStrings(string first, string second)
        {
            return first.Trim() == second.Trim();
        }

        static void ResolveSingleVersion(List<string> result, Version original, Version version)
        {
            while (!version.Ended || !version.Ended)
            {
                if (CompareStrings(original.CurrentLine, version.CurrentLine))
                {
                    original.SkipLine();
                    version.SkipLine();
                }
                else
                {
                    version.AcceptLine(result);
                }
            }
        }

        static void ResolveThreeWayConflict(Version left, Version right, Version original, List<string> result)
        {
            var leftIndex = left.FindAnchor(original.CurrentLine);
            var rightIndex = right.FindAnchor(original.CurrentLine);

            if (!left.IndexFound(leftIndex) && !right.IndexFound(rightIndex))
            {
                result.Add(CheckForConflict(left.CurrentLine, right.CurrentLine));
                left.SkipLine();
                right.SkipLine();
                original.SkipLine();
            }
            else if (!left.IndexFound(leftIndex))
            {
                right.AcceptLines(result, rightIndex);
            }
            else if (!right.IndexFound(rightIndex))
            {
                left.AcceptLines(result, leftIndex);
            }
            else
            {
                result.AddRange(ResolveTwoWayList(left.Slice(leftIndex), right.Slice(rightIndex)));

                left.SkipLines(leftIndex);
                right.SkipLines(rightIndex);
            }
        }

        static void ResolveTwoWayLine(Version left, Version right, List<string> result)
        {
            result.Add(CheckForConflict(left.CurrentLine, right.CurrentLine));
            left.SkipLine();
            right.SkipLine();
            return;
        }

        static List<string> ResolveTwoWayList(List<string> left, List<string> right)
        {
            return left.Count > right.Count ?
                left.Zip(right, (x, y) => CheckForConflict(x, y)).Concat(left.Skip(right.Count)).ToList() :
                right.Zip(left, (x, y) => CheckForConflict(y, x)).Concat(right.Skip(left.Count)).ToList();
        }
    }

    public class Version
    {
        readonly List<string> lines;

        int index;

        public bool Ended
        {
            get
            {
                return index >= lines.Count;
            }
        }

        public string CurrentLine
        {
            get
            {
                return lines[index];
            }
        }

        public Version(List<string> lines)
        {
            this.lines = lines;
        }

        public void SkipLine()
        {
            ++index;
        }

        public void SkipLines(int untilIndex)
        {
            index = untilIndex;
        }

        public void AcceptLine(List<string> result)
        {
            result.Add(CurrentLine);
            ++index;
        }

        public void AcceptLines(List<string> result, int untilIndex)
        {
            while (!Ended && index < untilIndex)
            {
                AcceptLine(result);
            }
        }

        public bool FastForward(List<string> result, string untilString)
        {
            var untilIndex = index + lines.Skip(index).ToList().IndexOf(untilString);

            if (untilIndex < index)
            {
                return false;
            }
            else
            {
                AcceptLines(result, untilIndex);
                return true;
            }
        }

        public void AcceptUntilEnd(List<string> result)
        {
            AcceptLines(result, lines.Count);
        }

        public int FindAnchor(string anchor)
        {
            return index + lines.Skip(index).ToList().IndexOf(anchor);
        }

        public bool IndexFound(int anchorIndex)
        {
            return anchorIndex >= index;
        }

        public List<string> Slice(int untilIndex)
        {
            return lines.Skip(index).Take(untilIndex - index).ToList();
        }
    }
}
