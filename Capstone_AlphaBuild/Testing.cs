using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_AlphaBuild
{
    class Testing : NM
    {
        public static int NodeDecider = NM.NodeDict.Count + 1;               

        public static void DecodeArduinoData(RichTextBox RTB, string RawStrData)
        {

        }

        public static void ProvideRandDataSet(RichTextBox RTB)
        {
            int N1, N2, N3, N4, N5;
            Random random = new Random();

            N1 = random.Next(0, 255);
            N2 = random.Next(0, 255);
            N3 = random.Next(0, 255);
            N4 = random.Next(0, 255);
            N5 = random.Next(0, 255);
            RTB.Text = N1.ToString() + ", " + N2.ToString() + ", " + N3.ToString() + ", " + N4.ToString() + ", " + N5.ToString();
        }

        public static List<double[]> ProvideDataTime()
        {
            double N1, N2, N3, N4, N5;
            double T1, T2, T3, T4, T5;
            List<double[]> DataTime = new List<double[]>();
            double[] Temp = new double[2];

            Random random = new Random();
            
            N1 = random.Next(0, 255);
            N2 = random.Next(0, 255);
            N3 = random.Next(0, 255);
            N4 = random.Next(0, 255);
            N5 = random.Next(0, 255);

            T1 = random.Next(0, 60);
            T2 = random.Next(0, 60);
            T3 = random.Next(0, 60);
            T4 = random.Next(0, 60);
            T5 = random.Next(0, 60);                        
            
            double[] A1 = new[] { N1, T1 };
            double[] A2 = new[] { N2, T2 };
            double[] A3 = new[] { N3, T3 };
            double[] A4 = new[] { N4, T4 };
            double[] A5 = new[] { N5, T5 };

            DataTime.Add(A1);
            DataTime.Add(A2);
            DataTime.Add(A3);
            DataTime.Add(A4);
            DataTime.Add(A5);

            return DataTime;
        }

        public static string DecodeData()
        {
            List<double[]> DataTime = new List<double[]>();
            string DecodedData = string.Empty;

            DataTime = Testing.ProvideDataTime();
            DataTime = Testing.ProvideDataTime();
            DataTime = Testing.ProvideDataTime();
            DataTime = Testing.ProvideDataTime();
            DataTime = Testing.ProvideDataTime();
            DataTime = Testing.ProvideDataTime();

            foreach (double[] array in DataTime)
            {
                DecodedData += array[0] + ", " + array[1] + "\n";
            }

            //for (int i = 0; i < 5)

            return DecodedData;            
        }

        public static void SupplyUniqueNode()
        {
            List<double> SampleData = new List<double>();
            List<DataType> SampleDataTypes = new List<DataType>();
            List<ErrorMsg> SampleErrorMsgs = new List<ErrorMsg>();

            switch (NodeDecider)
            {
                case 1:
                    addNewNode(000001);
                    updateNode(000001, "Jimmy", 100, SampleData, SampleErrorMsgs, SampleDataTypes, false, false, 99, 1);
                    NodeDecider++;
                    break;
                case 2:
                    addNewNode(000002);
                    updateNode(000002, "Betty", 87, SampleData, SampleErrorMsgs, SampleDataTypes, false, false, 90, 10);
                    NodeDecider++;
                    break;
                case 3:
                    addNewNode(000055);
                    updateNode(0000055, "Harvath", 68, SampleData, SampleErrorMsgs, SampleDataTypes, false, false, 80, 30);                    
                    NodeDecider++;
                    break;
                case 4:
                    addNewNode(000008);
                    updateNode(000008, "Flipper", 44, SampleData, SampleErrorMsgs, SampleDataTypes, false, false, 5, -35);
                    NodeDecider++;
                    break;
                case 5:
                    addNewNode(186745);
                    updateNode(186745, "Roberta", 19, SampleData, SampleErrorMsgs, SampleDataTypes, false, false, 0,-10);
                    NodeDecider++;
                    break;
            }            
        }        
    }
}
