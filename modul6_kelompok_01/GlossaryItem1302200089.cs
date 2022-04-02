using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class GlossaryItem1302200089
    {
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/Panji/Documents/VS Community things/Jurnal6BARU/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_3_1302200089.json");


            dynamic input = JsonConvert.DeserializeObject(jsonString);

            //print
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine(input.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
            //foreach (var item in input.glossary.GlossDiv.GlossList.GlossEntry.GlossDef)
            //{
            //    Console.WriteLine(item.GlossSeeAlso);
            //}
            
        }

    }
}
