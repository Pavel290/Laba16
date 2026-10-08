using System;
using System.Collections.Generic;
using System.Text;

namespace Laba16 {
    interface DataInterface {
        List<RawDataItem> GetRawData();
        List<SummaryDataItem> GetSummaryData();
    }
}
