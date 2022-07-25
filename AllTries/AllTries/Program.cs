using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AllTries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtTable = new DataTable();
            dtTable.Columns.Add("index");
            dtTable.Columns.Add("portfoy");
            DataRow firstrow = dtTable.NewRow();
            firstrow["index"] = "1";
            firstrow["portfoy"] = "yatırım";
            dtTable.Rows.Add(firstrow);
            DataRow secondrow = dtTable.NewRow();
            secondrow["index"] = "2";
            secondrow["portfoy"] = "yatırım";
            dtTable.Rows.Add(secondrow);
            DataRow thirdrow = dtTable.NewRow();
            thirdrow["index"] = "3";
            thirdrow["portfoy"] = "emeklilik";
            dtTable.Rows.Add(thirdrow);
            IEnumerable<string> Names = new List<string> {  "yatırım" };


            //var query = (from d in dtTable
            //             where d.portfoy.Equals("yatırım") 
            //             select d.index 


            var query = from d in dtTable.AsEnumerable().Where(d=> Names.Contains(d["portfoy"]))
                        select d["index"]; 
            

            var query1 = dtTable.AsEnumerable().Where(d=> Names.Contains(d["portfoy"])).Select(d=> d["index"]);

            var query2 = dtTable.AsEnumerable().Where(d => Names.Contains(d.ItemArray[1])).Select(d => d.ItemArray[0]);










            bool result =false;

            result = Names.Where(ad => ad.Equals("J")).ToList().Any();
           // Console.WriteLine(result.ToString());
        }
    }
}
