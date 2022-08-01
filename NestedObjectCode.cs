using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var list = new KeyValuePair<string, KeyValuePair<string, KeyValuePair<string,string>>>(
						"a",new KeyValuePair<string, KeyValuePair<string,string>>(
						"b",new KeyValuePair<string, string>("c","d")));
		
		string key = "a";
		string mapValue = NestedKeyValue(list, key, false);
		if(mapValue != "")
		{
		    Console.WriteLine("Key Found! Value : {0}",mapValue);
		}
		else
		{
			Console.WriteLine("Key Not Found!");
		}
	  }
	
	public static string NestedKeyValue(dynamic map, string key, bool flag) 
	
	{
		if (map.Key == key)
		{
			flag = true;
		}
		Type t = map.Value.GetType();

		if (t != typeof(string))
		{   
			string mapValue = NestedKeyValue(map.Value, key, flag);
			return mapValue;
		}
		else
		{
			if(flag)
			{
			return map.Value;
			}
			return "";
		}
	}                         
}
