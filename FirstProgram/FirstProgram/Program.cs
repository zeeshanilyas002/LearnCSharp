// See https://aka.ms/new-console-template for more information

string str1 = "Kacs";
string str2 = "Learnings";
string str3 = string.Concat(str1,str2);


Console.WriteLine(str1 +" "+ str2);
Console.WriteLine("prebuild method : "+ str3);
Console.WriteLine(str3.ToUpper());
Console.WriteLine(str3.ToLower());
Console.WriteLine(str2[0]);
Console.WriteLine(str2.IndexOf("r"));


