/*
 * Created by SharpDevelop.
 * User: shibu
 * Date: 5/29/2017
 *
 * 
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace LoginValidation.Infrastructure.Utils
{
	/// <summary>
	/// Description of CustomSerializer.
	/// </summary>
	 public static class CustomSerializer<T>
    {
	 	
      /*  public static void Write(T package, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(package.GetType());
            using (StreamWriter writer = new StreamWriter(folderName))
            {
                serializer.Serialize(writer.BaseStream, package);
            }
        }

        public static void WriteGeneral(object myClass, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(myClass.GetType());
            using (StreamWriter writer = new StreamWriter(folderName))
            {
                serializer.Serialize(writer.BaseStream, myClass);
            }
        }

        public static  T Read(T package, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(package.GetType());
            using (StreamReader reader = new StreamReader(folderName))
            {
                object deserialized = serializer.Deserialize(reader.BaseStream);
                package = (T)deserialized;
            }
            return package;
        }
        */
        
         public static void Save(List<T> dataList, string fileNameWithPath)
        {
            XmlSerializer serializer = new XmlSerializer(dataList.GetType());
            using (StreamWriter writer = new StreamWriter(fileNameWithPath))
            {
                serializer.Serialize(writer.BaseStream, dataList);
            }
        }
        
        public static List<T> Read( string fileNameWithPath)
        {
        	List<T> dataList=new List<T>();
        	XmlSerializer serializer = new XmlSerializer(dataList.GetType());
            using (StreamReader reader = new StreamReader(fileNameWithPath))
            {
                object deserialized = serializer.Deserialize(reader.BaseStream);
                dataList = (List<T>)deserialized;
            }
            return dataList;
        }
        
	}
}
