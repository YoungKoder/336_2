using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Lab1
{
    class ApiHelper
    {
        static TcpClient client = null;
        const int port = 8888;
        static IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAd = ipHostInfo.AddressList[0];
        NetworkStream stream = null;
        public ApiHelper()
        {
            client = new TcpClient(ipAd.ToString(), port);
            stream = client.GetStream();
        }

        public DataSet tableAction(string commandType, string tableName,DataSet ds = null)
        {
            try
            {
                string sqlCommand = String.Format("SELECT * FROM {0}", tableName);
                if(commandType == "save")
                {
                    sqlCommand = String.Format("save {0}", tableName);
                }

                Query query = new Query();
                query.QueryString = sqlCommand;
                query.Data = ds;
                string queryJson = Helper.parseQueryToJson(query);

                BinaryWriter writer =new BinaryWriter(stream);
                writer.Write(queryJson);
                writer.Flush();
                BinaryReader reader = new BinaryReader(stream);
                string dataSetJson = reader.ReadString();

                DataSet dataSet = Helper.getDataSetFromJson(dataSetJson);
                reader.Close();
                writer.Close();
                stream.Close();
                return dataSet;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
