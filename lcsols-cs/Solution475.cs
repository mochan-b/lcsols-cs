using System;
using System.Collections.Generic;
using System.Text;

namespace lcsols
{
    public class Solution475
    {
        int FindHeater(int house, int[] heaters)
        {
            int left = 0, right = heaters.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (heaters[mid] == house)
                    return mid;
                if (heaters[mid] < house)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }

        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(heaters);
            int radius = 0;
            foreach (var house in houses)
            {
                int heaterIndex = FindHeater(house, heaters);
                Func<int> leftDistFn = () => house - heaters[heaterIndex-1];
                Func<int> rightDistFn = () => heaters[heaterIndex] - house;
                var heaterDist = heaterIndex == 0 ? rightDistFn() : (heaterIndex == heaters.Length ? leftDistFn() : Math.Min(leftDistFn(), rightDistFn()) );
                radius = Math.Max(radius, heaterDist);
            }
            return radius;
        }
    }
}
