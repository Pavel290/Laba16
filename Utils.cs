using System;
using System.Collections.Generic;
using System.Text;

namespace Laba16 {
    internal class Utils {
        private static Dictionary<int, string> dict;
        static Utils() {
            if (dict == null) {
                dict = new Dictionary<int, string>(2);
                dict.Add(0, "Продукты");
                dict.Add(1, "Химия");
            }
        }
        public static String GetGroupByNumber(int number) {
            if (dict.ContainsKey(number)) {
                return dict[number];
            } else {
                return "???";
            }
        }
    }
}
