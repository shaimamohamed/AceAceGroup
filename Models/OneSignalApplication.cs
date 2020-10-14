using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AceAceGroupTestApplication.Models
{
    public class OneSignalApplication
    {
       
       //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string name { get; set; }

    }

    public class OneSignalApplicationModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    //public class Rootobject
    //{
    //    public Class1[] Property1 { get; set; }
    //}

    //public class Class1
    //{
    //    public string id { get; set; }
    //    public string name { get; set; }
    //    public string gcm_key { get; set; }
    //    public object chrome_key { get; set; }
    //    public object chrome_web_key { get; set; }
    //    public object chrome_web_origin { get; set; }
    //    public object chrome_web_gcm_sender_id { get; set; }
    //    public object chrome_web_default_notification_icon { get; set; }
    //    public object chrome_web_sub_domain { get; set; }
    //    public object apns_env { get; set; }
    //    public object apns_certificates { get; set; }
    //    public object safari_apns_certificate { get; set; }
    //    public object safari_site_origin { get; set; }
    //    public object safari_push_id { get; set; }
    //    public string safari_icon_16_16 { get; set; }
    //    public string safari_icon_32_32 { get; set; }
    //    public string safari_icon_64_64 { get; set; }
    //    public string safari_icon_128_128 { get; set; }
    //    public string safari_icon_256_256 { get; set; }
    //    public object site_name { get; set; }
    //    public DateTime created_at { get; set; }
    //    public DateTime updated_at { get; set; }
    //    public int players { get; set; }
    //    public int messageable_players { get; set; }
    //    public string basic_auth_key { get; set; }
    //    public bool additional_data_is_root_payload { get; set; }
    //}

}