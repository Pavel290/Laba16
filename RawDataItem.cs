using System;
using System.Collections.Generic;
using System.Text;

namespace Laba16 {
    internal class RawDataItem {
        public String Name { get; set; }
        public int Group {  get; set; }
        public float Price { get; set; }
        public float  Count { get; set; }
        public float Sum {
            get {  return Price * Count; }
        }
    }
}
