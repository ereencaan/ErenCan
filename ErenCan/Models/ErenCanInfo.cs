using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ErenCan.Models
{
    public class ErenCanInfo
    {
        public IList<ContactInfo> contactInfos { get; set; }
        public IList<PrivateInfo> privateInfos { get; set; }
        public IList<Summary> summaries { get; set; }
        public IList<SeminarsCoursesCertificates> seminars { get; set; }
        public IList<Experiences> experiences { get; set; }
        public IList<Education> educations { get; set; }
        public IList<Languages> languages { get; set; }
        public IList<Skills> skills { get; set; }
        public IList<References> references { get; set; }
        public IList<Cv> cvs { get; set; }
        public IList<CoverLetters> coverLetters { get; set; }
        public IList<DevelopedProjects> developedProjects { get; set; }

        ErenCanInfo productObj = new ErenCanInfo();

        IList<ErenCanInfo> erenCanInfos;

        IList<string> invalidProductItemInJson;

        string jsonString = "[{json specified above}]";



        // Call the deserializer

        erenCanInfos = JsonHelper.DeserializeToList<ErenCanInfo>(jsonString);

 

// Check for errors

if (JsonHelper.InvalidJsonElements.Count != 0)

{

    invalidProductItemInJson = InvalidJsonElements;

   

    // Here we have invalid items of json now we are rectified with

    // the problematic data from json

}
}
}
