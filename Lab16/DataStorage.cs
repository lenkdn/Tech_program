using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab16
{
    class DataStorage : IDataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }
        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '\\';
        private DataStorage() { }

        private void BuildSummary()
        {
            var tmp = new Dictionary<String, float>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                {
                    tmp[item.Group] += item.FinalPrice;
                }
                else
                    tmp[item.Group] = item.FinalPrice;

            }

            sumdata = new List<SummaryDataItem>();
            foreach (var item in tmp)
            {
                sumdata.Add(new SummaryDataItem()
                {
                    GroupName = item.Key,
                    GroupSum_FinalPrice = item.Value
                });
            }
        }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Name = items[0].Trim(),
                        Group = items[1].Trim(),
                        Price = Convert.ToSingle(items[2].Trim()),
                        Discount = Convert.ToSingle(items[3].Trim())
                    };
                    rawdata.Add(item);
                }

                sr.Close();
                BuildSummary();

            }
            catch (IOException ex)
            {
                return false;
            }

            return true;
        }

        public static DataStorage DataCreator(String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else
                return null;
        }

        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}