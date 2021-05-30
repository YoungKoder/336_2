using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using SPS_Lab1;
using System.Data;
using MySql.Data.MySqlClient;
using System.Xml.Serialization;

namespace SPS_Lab2_Server
{
    class ClientObject
    {
        const int port = 8888;
        string connectStr = String.Format("server=localhost;port=3306;username=root;password=Qwerty2122;database=clients;allowuservariables=True");
        Repository rep;
        MySqlDataAdapter adapter;
        public TcpClient client;
        MySqlCommandBuilder commandBuilder;
        DataSet ds = null;
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
            rep = new Repository(connectStr);
            //rep.connect();
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                rep.connect();
                stream = client.GetStream();
                ds = new DataSet();
                while (true)
                {
                    BinaryReader reader = new BinaryReader(stream);
                    string message = reader.ReadString();
                    string data = null;
                    Console.WriteLine("Получено: " + message);
                    Query query = new Query();
                    query.QueryString = Helper.deserializeQuery(message).QueryString;
                    query.Data = Helper.deserializeQuery(message).Data;
                    if (query.Data != null)
                    {
                        ds = query.Data;
                    }
                    
                    switch (query.QueryString)
                    {
                        case "SELECT * FROM Events":
                            adapter = rep.getFullTable(0, "Events");
                            adapter.Fill(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        case "SELECT * FROM Venus":
                            adapter = rep.getFullTable(0, "Venus");
                            adapter.Fill(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        case "SELECT * FROM Country":
                            adapter = rep.getFullTable(0, "Country");
                            adapter.Fill(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        case "save Events":
                            adapter = rep.InsertEvent(commandBuilder);
                            adapter.Update(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        case "save Venus":
                            adapter = rep.InsertVenue(commandBuilder);
                            adapter.Update(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        case "save Country":
                            adapter = rep.InsertCountry(commandBuilder);
                            adapter.Update(ds);
                            data = Helper.convertToJson(ds);
                            break;
                        default:
                            break;
                    }

                    // отправляем ответ
                    BinaryWriter writer = new BinaryWriter(stream);
                    message = data;
                    Console.WriteLine("Отправлено: " + message);
                    writer.Write(message);
                    writer.Flush();

                    writer.Close();
                    reader.Close();
                    stream.Close();
                    client.Close();
                    rep.closeConnection();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
    public static class Extensions { 
        public static string ToXml(this DataSet ds)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (TextWriter streamWriter = new StreamWriter(memoryStream))
                {
                    var xmlSerializer = new XmlSerializer(typeof(DataSet));
                    xmlSerializer.Serialize(streamWriter, ds);
                    return Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }
    }
    
}
