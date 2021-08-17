using System;
using System.Collections.Generic;
using System.IO;
using ServiceStack.Redis;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            IRedisClient redisClient = new RedisClient("106.14.249.170",6379,"3edcVFRS",0);
            var s = redisClient.GetHashKeys("0054514f-2e4d-47ff-84b7-32c5355e73c4");
            string s1 = "123";
            Console.WriteLine(s1);
        }
    }
}
