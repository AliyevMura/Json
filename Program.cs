#region Task1

using Newtonsoft.Json;

//string Path = "C:\\Users\\lenovo\\source\\repos\\Json\\Json\\Models\\test.cs";
//Directory.CreateDirectory(Path);
//File.Create(Path);
//string DataPath = "C:\\Users\\lenovo\\source\\repos\\Json\\Json\\Data\\jjson.json";
//Directory.CreateDirectory(DataPath);
//File.Create(DataPath);


#endregion


//Task2
var url = @"https://jsonplaceholder.typicode.com/posts";

HttpClient client = new HttpClient();
var poster = await client.GetStringAsync(url);


//Console.WriteLine(JsonConvert.SerializeObject(poster));


using(StreamWriter sw = new StreamWriter(poster))
{
    sw.WriteLine(JsonConvert.SerializeObject(poster));
}