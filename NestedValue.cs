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
		dynamic mapValue = NestedKeyValue(list, key, false);
		if (!String.IsNullOrEmpty(Convert.ToString(mapValue)))
		{
		    Console.WriteLine("Key Found! Value : {0}",mapValue);
		}
		else
		{
			Console.WriteLine("Key Not Found");
		}
	  }
	
	public static dynamic NestedKeyValue(dynamic map, string key, bool flag) 
	
	{
		if (map.Key == key)
		{
			return map.Value;
			
			
		}
		Type t = map.Value.GetType();

		if (t != typeof(string))
		{   
			dynamic mapValue = NestedKeyValue(map.Value, key, flag);
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
