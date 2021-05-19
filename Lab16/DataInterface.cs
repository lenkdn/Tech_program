using System.Collections.Generic;

namespace Lab16
{
    interface IDataInterface
    {
        List<RawDataItem> GetRawData();
        List<SummaryDataItem> GetSummaryData();
    }
}