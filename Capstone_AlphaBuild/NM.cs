using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_AlphaBuild
{
    public enum DataType { Temperature, Humidity }
    public enum ErrorMsg { TestError }

    public class NM
    {
        public static Dictionary<int, Node> NodeDict = new Dictionary<int, Node>();

        public static void addNewNode(int NodeSN)
        {
            Node newNode = new Node(NodeSN);

            if (!NodeDict.ContainsKey(newNode.SN))
            {
                NodeDict.Add(newNode.SN, newNode);
            }
        }

        public static void deleteNode(int NodeSN)
        {
            NodeDict[NodeSN] = null;
            NodeDict.Remove(NodeSN);
        }

        public static void updateNode(int NodeSN, string newNodeName, int? newBatteryLevel, List<double[]> newData, List<ErrorMsg> newErrorMessages,
                                      List<DataType> newDataTypes, bool newInternalErrorFlag, bool newInactiveFlag, int newHighLimit,
                                      int newLowLimit)
        {
            NodeDict[NodeSN].NodeName = newNodeName;
            NodeDict[NodeSN].BatteryLevel = newBatteryLevel;
            NodeDict[NodeSN].Data = newData;
            NodeDict[NodeSN].ErrorMessages = newErrorMessages;
            if (NodeDict[NodeSN].ErrorMessages.Count > 0) NodeDict[NodeSN].WarningFlag = true;
            else NodeDict[NodeSN].WarningFlag = false;
            NodeDict[NodeSN].DataTypes = newDataTypes;
            NodeDict[NodeSN].InternalErrorFlag = newInternalErrorFlag;
            NodeDict[NodeSN].InactiveFlag = newInactiveFlag;
            NodeDict[NodeSN].HighLimit = newHighLimit;
            NodeDict[NodeSN].LowLimit = newLowLimit;
        }

        public static void  updateNodeData(List<double[]> Data, int NodeSN)
        {
            NodeDict[NodeSN].Data = Data;
        }

        public class Node
        {
            public int SN { get; }

            public string NodeName { get; set; }
            public int? BatteryLevel { get; set; }

            public List<double[]> Data { get; set; }
            public List<ErrorMsg> ErrorMessages { get; set; }
            public List<DataType> DataTypes { get; set; }

            public bool InternalErrorFlag { get; set; }
            public bool InactiveFlag { get; set; }
            public bool WarningFlag { get; set; }

            public int HighLimit { get; set; }
            public int LowLimit { get; set; }            

            public Node(int InitSN)
            {
                SN = InitSN;

                NodeName = "Blank";
                BatteryLevel = 0;

                Data = new List<double[]>();
                ErrorMessages = new List<ErrorMsg>();
                DataTypes = new List<DataType>();

                InternalErrorFlag = true;
                InactiveFlag = true;
                WarningFlag = true;

                HighLimit = 100;
                LowLimit = -100;
            }
        }
    }
}
