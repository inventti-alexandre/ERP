using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace FrameWork.MVC.Utilite
{
    public static class JsonConvertion
    {


        public static string ToJson<T> (this T Obj,bool IncludeNull=true)
        {
            var setting=new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new JsonConverter[] {new StringEnumConverter()},
                NullValueHandling = IncludeNull? NullValueHandling.Include : NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(Obj, setting);

        }

    }
}
