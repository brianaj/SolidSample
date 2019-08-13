using System;
using System.IO;
using System.Net;

namespace ArdalisRating
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}