using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doctor
{
    class SysConstUrl
    {
        //public const string search = "http://mcm3.pc.e-health.org.cn/entity/exam/labExamReport_abstractList.action?start=0&limit=20&search__fname=@!&sort=id&dir=DESC";

        public const string search = "http://mcm3.pc.e-health.org.cn/entity/exam/labExamReport_abstractList.action?start=0&limit=20&search__fidCard=@!&sort=id&dir=DESC";


        public const string sumbitParms = "http://mcm3.pc.e-health.org.cn/entity/exam/editExamResult_abstractList.action?ids=ids11&start=0&limit=20&search__tableType=&search__examineDate=&search__modifyDate=&search__status=&sort=id&dir=DESC";

        public const string submit = "http://mcm3.pc.e-health.org.cn/entity/basic/labExamW_submitWomanClinical.action?labExamId=ids11&psid=ids11";

        public const string submitMen = "http://mcm3.pc.e-health.org.cn/entity/exam/labExamM_submitManClinical.action?labExamId=ids11&psid=ids11";


       // public const string submit = "http://mcm3.pc.e-health.org.cn/entity/basic/labExamW_submitWomanClinical.action?labExamId=ids11&psid=ids11&leuClueCell1=1&leuTrichomonas1=&leuAmineOdor1=0&candidiasis=&leuCleanliness1=&wphValue=&gonorrhoeae1=&chlamydiaT1=&whb=&wrbC=&wpbT=&wwbC=&wn=&we=20&wb=&wl=&wm=&urineRoutineM=&abO1=&rh1=&wbloodSugar=&hbs_Ag=&hbs_Ab=&hbe_Ag=&hbe_Ab=&hbc_Ab=&walT=&wcr=&wtsH=&rvigg1=&cvigg1=&tgigg1=&treponema=&cvigm1=&tgigm1=&custom39=&custom43=&custom40=&custom41=&custom42=&custom44=&custom45=&custom46=&custom135=&custom136=&elseItem=&testerName=%E5%B9%BF%E4%B8%9C%E7%9C%81%E5%B9%BF%E5%B7%9E%E5%B8%82%E7%99%BD%E4%BA%91%E5%8C%BA%E7%9F%B3%E4%BA%95%E8%A1%97%E9%81%93&wcheckDate=2017-05-15";
    }
}
