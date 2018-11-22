using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Capstone_AlphaBuild
{
    class Testing : NM
    {
        public static int NodeDecider = NM.NodeDict.Count + 1;
        public static int GLOBALcounter = 0;

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
            List<double[]> DataTime1 = new List<double[]>();
            List<double[]> DataTime2 = new List<double[]>();
            List<double[]> DataTime3 = new List<double[]>();
            List<double[]> DataTime4 = new List<double[]>();
            List<double[]> DataTime5 = new List<double[]>();

            double[] Temp = new double[2];

            Random random = new Random();
            
            N1 = random.Next(0, 255);
            Thread.Sleep(10);
            N2 = random.Next(0, 255);
            Thread.Sleep(10);
            N3 = random.Next(0, 255);
            Thread.Sleep(10);
            N4 = random.Next(0, 255);
            Thread.Sleep(10);
            N5 = random.Next(0, 255);

            T1 = random.Next(0, 60);
            Thread.Sleep(10);
            T2 = random.Next(0, 60);
            Thread.Sleep(10);
            T3 = random.Next(0, 60);
            Thread.Sleep(10);
            T4 = random.Next(0, 60);
            Thread.Sleep(10);
            T5 = random.Next(0, 60);                        
            
            double[] A1 = new[] { N1, T1 };
            double[] A2 = new[] { N2, T2 };
            double[] A3 = new[] { N3, T3 };
            double[] A4 = new[] { N4, T4 };
            double[] A5 = new[] { N5, T5 };

            switch (GLOBALcounter)
            {
                case 0:
                    DataTime1.Add(A1);
                    DataTime1.Add(A2);
                    DataTime1.Add(A3);
                    DataTime1.Add(A4);
                    DataTime1.Add(A5);
                    GLOBALcounter++;
                    return DataTime1;
                case 1:
                    DataTime2.Add(A1);
                    DataTime2.Add(A2);
                    DataTime2.Add(A3);
                    DataTime2.Add(A4);
                    DataTime2.Add(A5);
                    GLOBALcounter++;
                    return DataTime2;
                case 2:
                    DataTime3.Add(A1);
                    DataTime3.Add(A2);
                    DataTime3.Add(A3);
                    DataTime3.Add(A4);
                    DataTime3.Add(A5);
                    GLOBALcounter++;
                    return DataTime3;
                case 3:
                    DataTime4.Add(A1);
                    DataTime4.Add(A2);
                    DataTime4.Add(A3);
                    DataTime4.Add(A4);
                    DataTime4.Add(A5);
                    GLOBALcounter++;
                    return DataTime4;
                case 4:
                    DataTime5.Add(A1);
                    DataTime5.Add(A2);
                    DataTime5.Add(A3);
                    DataTime5.Add(A4);
                    DataTime5.Add(A5);
                    GLOBALcounter++;
                    return DataTime5;
                default:
                    return null;
            }
        }

        public static string DecodeData(List<double[]> DataTime)
        {
            string DecodedData = string.Empty;

            foreach (double[] array in DataTime)
            {
                DecodedData += array[0] + ", " + array[1] + "\n";
            }

            //for (int i = 0; i < 5)

            return DecodedData;            
        }

        public static void SupplyUniqueNode()
        {
            List<double[]> SampleData = new List<double[]>();
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
