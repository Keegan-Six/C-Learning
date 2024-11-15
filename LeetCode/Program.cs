// https://leetcode.com/problems/two-sum/
using System;
public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        for ( int i = 0; i < nums.Length; i++) {
            for ( int j = 0; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    Console.WriteLine("[" + i + "],[" + j + "]");
                    return nums;
                }
            }
        }
        Console.WriteLine("No values add up to target");
        return nums;
    }
    public static void main() {
        int[] numbers = [2,7,11,15];
        int number = 9;
        TwoSum(numbers,number);
    }


}