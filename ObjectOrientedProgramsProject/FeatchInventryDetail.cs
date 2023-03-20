using Newtonsoft.Json;
using System;
using System.IO;

namespace ObjectOrientedProgramsProject
{
    public class FeatchInventryDetail
    {
        public InvantaryData ReadData(string path)
        {
            try
            {
                string jsonFileData = File.ReadAllText(path);
                var data = JsonConvert.DeserializeObject<InvantaryData>(jsonFileData);
                return data;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
