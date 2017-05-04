//文件名称（File Name）                 JsonTool.cs
//作者(Author)                          yjq
//日期（Create Date）                   2017.5.4
//修改记录(Revision History)
//    R1:
//        修改作者:
//        修改日期:
//        修改原因:
//    R2:
//        修改作者:
//        修改日期:
//        修改原因:
//**************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonTool
{
    /// <summary>
    /// json工具类
    /// </summary>
    public class JsonTool
    {
        #region  其他转json
        /// <summary>
        /// list转json字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="jsonName"></param>
        /// <returns></returns>
        public static string ListToJson<T>(IList<T> list,string jsonName)
        {
            string json = string.Empty;

            return json;
        }

        /// <summary>
        /// list转json字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ListToJson<T>(IList<T> list)
        {
            string json = string.Empty;

            return json;
        }

        /// <summary>
        /// 对象转json字符串
        /// </summary>
        /// <returns></returns>
        public static string ObjectToJson(object jsonObject)
        {
            string json = string.Empty;

            return json;
        }

        /// <summary>
        /// 对象集合转json字符串
        /// </summary>
        /// <param name="objectArray">需要转换成json字符串的对象集合</param>
        /// <returns></returns>
        public static string IEnumerableToJson(IEnumerable objectArray)
        {
            string json = string.Empty;
            return json;
        }

        /// <summary>
        /// DataTable转json字符串
        /// </summary>
        /// <param name="objectArray"></param>
        /// <returns></returns>
        public static string DataTableToJson(IEnumerable objectArray)
        {
            string json = string.Empty;
            return json;
        }

        /// <summary>
        /// DataReader转json字符串
        /// </summary>
        /// <param name="objectArray"></param>
        /// <returns></returns>
        public static string DataReaderToJson(IEnumerable objectArray)
        {
            string json = string.Empty;
            return json;
        }

        /// <summary>
        /// DataSet转json字符串
        /// </summary>
        /// <param name="objectArray"></param>
        /// <returns></returns>
        public static string DataSetToJson(IEnumerable objectArray)
        {
            string json = string.Empty;
            return json;
        }
        #endregion

        #region  序列化和反序列化
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T">需要序列化的类型对象</typeparam>
        /// <param name="obj">需要序列化的对象</param>
        /// <returns></returns>
        public static string JsonSerializer<T>(T obj)
        {
            string json = string.Empty;
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

                using (MemoryStream ms = new MemoryStream())
                {
                    serializer.WriteObject(ms, obj);
                    json = Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return json;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">需要序列化的类型对象</typeparam>
        /// <param name="json">需要反序列化的字符串</param>
        /// <returns></returns>
        public static T JsonDeserializer<T>(string json)
        {
            T t = default(T);
            try
            {             
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(Activator.CreateInstance<T>().GetType());
                    t = (T)serializer.ReadObject(ms);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return t;
        }

        #endregion
    }
}
