using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace COM426_Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("@CompGlyndŵr_AllTweets.json"))
            {
                string json = r.ReadToEnd();
                List<Tweet> tweets = JsonConvert.DeserializeObject<List<Tweet>>(json, new IsoDateTimeConverter { DateTimeFormat = "ddd MMM dd HH:mm:ss zz00 yyyy" });

                Console.WriteLine("The latest tweet says:");
                Console.WriteLine(tweets[0].text);
                Console.WriteLine();
            }

            using (StreamReader r = new StreamReader("@CompGlyndŵr_Followers.json"))
            {
                string json = r.ReadToEnd();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json, new IsoDateTimeConverter { DateTimeFormat = "ddd MMM dd HH:mm:ss zz00 yyyy" });

                Console.WriteLine("The first follower in the list is:");
                Console.WriteLine(users[0].name);
                Console.WriteLine();
            }

            using (StreamReader r = new StreamReader("@CompGlyndŵr_User.json"))
            {
                string json = r.ReadToEnd();
                User user = JsonConvert.DeserializeObject<User>(json, new IsoDateTimeConverter { DateTimeFormat = "ddd MMM dd HH:mm:ss zz00 yyyy" });

                Console.WriteLine($"{user.screen_name} signed up at:");
                Console.WriteLine(user.created_at);
            }

            Console.ReadKey();
        }
    }
}
