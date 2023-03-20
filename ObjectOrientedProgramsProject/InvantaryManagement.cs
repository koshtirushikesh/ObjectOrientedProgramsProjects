using System;

namespace ObjectOrientedProgramsProject
{
    public class InvantaryManagement
    {
        public string filePath = "C:\\Users\\Rushi\\source\\repos\\ObjectOrientedProgramsProjects\\ObjectOrientedProgramsProject\\Files\\InventaryDetails.json";
        FeatchInventryDetail featchInventryDetail = new FeatchInventryDetail();

        public void OfRice()
        {
            InvantaryData invantaryData = featchInventryDetail.ReadData(filePath);

            for (int i = 0; i < invantaryData.typesOfRice.Count; i++)
            {
                Console.WriteLine(invantaryData.typesOfRice[i].name);
                Console.WriteLine(invantaryData.typesOfRice[i].weight);
                Console.WriteLine(invantaryData.typesOfRice[i].price + "\n");
            }
        }

        public void OfWheet()
        {
            InvantaryData invantaryData = featchInventryDetail.ReadData(filePath);

            for (int i = 0; i < invantaryData.typesOfWheet.Count; i++)
            {
                Console.WriteLine(invantaryData.typesOfWheet[i].name);
                Console.WriteLine(invantaryData.typesOfWheet[i].weight);
                Console.WriteLine(invantaryData.typesOfWheet[i].price + "\n");
            }
        }

        public void OfPulse()
        {
            InvantaryData invantaryData = featchInventryDetail.ReadData(filePath);

            for (int i = 0; i < invantaryData.typesOfPulse.Count; i++)
            {
                Console.WriteLine(invantaryData.typesOfPulse[i].name);
                Console.WriteLine(invantaryData.typesOfPulse[i].weight);
                Console.WriteLine(invantaryData.typesOfPulse[i].price + "\n");
            }
        }
    }
}
