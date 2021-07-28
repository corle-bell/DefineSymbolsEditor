using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public static class BmTools
{
	public static T DeepCopyByBinary<T>(T obj)
	{
		object obj2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, obj);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			obj2 = binaryFormatter.Deserialize(memoryStream);
			memoryStream.Close();
		}
		return (T)((object)obj2);
	}
}
