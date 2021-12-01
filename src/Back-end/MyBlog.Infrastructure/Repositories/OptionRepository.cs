using MyBlog.Domain.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Repositories
{
    public class OptionRepository : IOptionRepository
    {
        string OptionsPath = @"D:\source\repos\MyBlog\Database\AppOptions.json";
        public Task<T> GetValue<T>(string key)
        {
            string rawjson = File.ReadAllText(OptionsPath);
            var obj = (JObject)JsonConvert.DeserializeObject(rawjson);
            JToken Token = obj[key];
            var res = Token.ToObject<T>();
            return Task.FromResult(res);
        }

        public Task SetValue(string key, object value)
        {
            string rawjson = File.ReadAllText(OptionsPath);
            dynamic obj = (JObject)JsonConvert.DeserializeObject(rawjson);
            obj[key] = value;
            string Opts = JsonConvert.SerializeObject(obj);
            File.WriteAllText(OptionsPath,Opts);
            return Task.CompletedTask;
        }
    }
}
