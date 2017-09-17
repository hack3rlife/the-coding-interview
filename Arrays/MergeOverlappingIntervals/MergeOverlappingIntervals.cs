using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace MergeOverlappingIntervals
{
    public static class MergeOverlappingIntervals
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="intervals"></param>
        public static List<Interval> Merge( List<Interval> intervals )
        {
            var stack = new Stack<Interval> ();
            var output = new List<Interval> ();

            stack.Push (intervals[0]);

            for (int i = 0 ; i < intervals.Count ; i++)
            {
                var curr = stack.Peek ();

                if (curr.Max < intervals[i].Min)
                {
                    stack.Push (intervals[i]);
                }
                else
                {
                    curr.Max = intervals[i].Max;
                    stack.Pop ();
                    stack.Push (curr);
                }
            }

            while (stack.Count > 0)
            {
                output.Add (stack.Pop ());
            }

            return output;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public static List<Interval> Merge( List<Interval> intervals, Interval interval )
        {
            var stack = new Stack<Interval> ();
            bool IsMerged = false;

            stack.Push (intervals[0]);

            var curr = stack.Peek ();

            // special case when the interval is dealing with the first position
            if (curr.Min > interval.Min && curr.Min > interval.Max)
            {
                stack.Pop ();
                stack.Push (interval);
                stack.Push (curr);
                IsMerged = true;
            }
            else if (curr.Min > interval.Min)
            {
                curr.Min = interval.Min;
                curr.Max = Math.Max (curr.Max, interval.Max);

                stack.Pop ();
                stack.Push (curr);
                IsMerged = true;
            }

            int length = intervals.Count;
            for (int i = 1 ; i < length ; i++)
            {
                curr = stack.Peek ();

                if (IsMerged == false)
                {
                    if (curr.Min <= interval.Min && intervals[i].Min > interval.Max)
                    {
                        if (curr.Max < interval.Max)
                            curr.Max = interval.Max;
                        else
                            curr.Max = intervals[i].Max;

                        stack.Pop ();
                        stack.Push (curr);
                        curr = stack.Peek ();
                        IsMerged = true;
                    }
                }

                if (curr.Max < intervals[i].Min)
                {
                    stack.Push (intervals[i]);
                }
                else
                {
                    curr.Max = Math.Max (curr.Max, intervals[i].Max);
                    stack.Pop ();
                    stack.Push (curr);
                }
            }

            // case when interval is greater than the last value in the list
            if (intervals[length - 1].Max < interval.Min)
            {
                stack.Push (interval);
            }

            var output = new List<Interval> (stack);
            output.Reverse ();

            Print (output);

            return output;
        }

        public static void Print( List<Interval> intervals )
        {
            foreach (var interval in intervals)
            {
                Debug.Write ($" {{ {interval.Min}, {interval.Max} }} ");
            }

            Debug.WriteLine ("");
        }
    }

    /// <summary>
    ///
    /// </summary>
    public struct Interval
    {
        public int Min;
        public int Max;

        public Interval( int min, int max )
        {
            Min = min;
            Max = max;
        }
    }
}