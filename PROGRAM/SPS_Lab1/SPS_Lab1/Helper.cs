using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

namespace SPS_Lab1
{
    public static class Helper
    {
        public static string convertToJson(DataSet ds)
        {
            string json = JsonConvert.SerializeObject(ds, Formatting.Indented);
            return json;
        }

        public static DataSet getDataSetFromJson(string jsonDs)
        {
            DataSet ds = JsonConvert.DeserializeObject<DataSet>(jsonDs);
            return ds;
        }

        public static string parseQueryToJson(Query query)
        {
            string res = JsonConvert.SerializeObject(query, Formatting.Indented);
            return res;
        }

        public static Query deserializeQuery(string query)
        {
            Query res = JsonConvert.DeserializeObject<Query>(query);
            return res;
        }

        //Обработка изменения языка отображения в заголовке колонки 
        public static string sourceColumnTextName(string engValue)
        {
            string val = "";
            switch (engValue)
            {
                case "Id":
                    val = "Id";
                    break;
                case "Name":
                    val = "Имя";
                    break;
                case "IsFree":
                    val = "Бесплатно?";
                    break;
                case "Photo":
                    val = "Фото";
                    break;
                case "StartDate":
                    val = "Дата начала";
                    break;
                case "Sponsor":
                    return "Организатор";
                case "Cost":
                    val = "Стоимость";
                    break;
                case "Logo":
                    val = "Логотип";
                    break;
                case "VenueId":
                    val = "ID Сооружения";
                    break;
                case "VenueName":
                    val = "Название сооружения";
                    break;
                case "Population":
                    val = "Население";
                    break;
                case "Language":
                    val = "Язык";
                    break;
                case "Latitude":
                    val = "Широта";
                    break;
                case "Longitude":
                    val = "Долгота";
                    break;
                case "Flag":
                    val = "Флаг";
                    break;
                default:
                    break;
            }
            return val;
        }
    }
}
