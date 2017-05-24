using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doctor
{
    class MainService
    {

        private static MainService mainService = null;

        
        private MainService() { }

        public static MainService getInstance() {
            if (mainService == null)
            {
                mainService = new MainService();
            }
            return mainService;
        }


      

        public void work() {
            HttpLoad http = HttpLoad.getInstance();

            //查询表数据，遍历每条记录

            //查询人名获取model
            String name = "张新新";
            name = System.Web.HttpUtility.UrlEncode(name, Encoding.GetEncoding("utf-8"));
            Console.WriteLine(name);
            string url = SysConstUrl.search;
            url = url.Replace("@!",name);
            JObject search = http.httpForJson(url);
            Console.WriteLine(search.ToString()); 
            Console.WriteLine(search["models"]);
            string ids = search["models"][0]["id"].ToString();
            //TODO 解析model获取相关信息 

            //完善结果获取表单类型 提交action
            url = SysConstUrl.sumbitParms;
            url = url.Replace("ids11", ids);
            JObject parms = http.httpForJson(url);
            Console.WriteLine(parms.ToString());


            url = SysConstUrl.submit;
            url = url.Replace("ids11", ids);
            JObject result = http.httpForJson(url);
            Console.WriteLine(result.ToString()); 
            //组装数据

            //提交
        
        }

        public void work(string sfz, Dictionary<string, string> map)
        {
            HttpLoad http = HttpLoad.getInstance();

            //查询表数据，遍历每条记录

            //查询人名获取model
            String name = "张新新";
            name = System.Web.HttpUtility.UrlEncode(name, Encoding.GetEncoding("utf-8"));
            Console.WriteLine(name);
            string url = SysConstUrl.search;
            url = url.Replace("@!", name);
            JObject search = http.httpForJson(url);
            Console.WriteLine(search.ToString());
            Console.WriteLine(search["models"]);
            string ids = search["models"][0]["id"].ToString();
            //TODO 解析model获取相关信息 

            //完善结果获取表单类型 提交action
            //url = SysConstUrl.sumbitParms;
            //url = url.Replace("ids11", ids);
            //JObject parms = http.httpForJson(url);
            //Console.WriteLine(parms.ToString());
            
            url = DataConvertWomen.getInstance().ConvertDataForWomen(map, ids);
            //url = SysConstUrl.submit;
            //url = url.Replace("ids11", ids);
            JObject result = http.httpForJson(url);
            Console.WriteLine(result.ToString()); 
        }

        public void work(string sfz, Dictionary<string, string> map, Dictionary<string, string> menMap)
        {
            HttpLoad http = HttpLoad.getInstance();

            //查询表数据，遍历每条记录

            //查询人名获取model
            String name = "张新新";
            name = System.Web.HttpUtility.UrlEncode(name, Encoding.GetEncoding("utf-8"));
            //Console.WriteLine(name);
            string url = SysConstUrl.search;
            url = url.Replace("@!", sfz);
            JObject search = http.httpForJson(url);
            Console.WriteLine(search.ToString());
            Console.WriteLine(search["models"]);
            string ids = search["models"][0]["id"].ToString();
            //TODO 解析model获取相关信息 

            //完善结果获取表单类型 提交action
            //url = SysConstUrl.sumbitParms;
            //url = url.Replace("ids11", ids);
            //JObject parms = http.httpForJson(url);
            //Console.WriteLine(parms.ToString());

            url = DataConvertWomen.getInstance().ConvertDataForWomen(map, ids);
            //url = SysConstUrl.submit;
            //url = url.Replace("ids11", ids);
            JObject result = http.httpForJson(url);
            if (result["success"].ToString()== "True")
            {
                Console.WriteLine("更新女成功");
            }

            url = DataConvertMen.getInstance().ConvertDataForMen(menMap, ids);
            //url = SysConstUrl.submit;
            //url = url.Replace("ids11", ids);
            result = http.httpForJson(url);
            if (result["success"].ToString()=="True") {
                Console.WriteLine("更新男成功"); 
            }
            
        }
    }
}
