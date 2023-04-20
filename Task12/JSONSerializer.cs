using System.IO;
using System.Runtime.Serialization.Json;

namespace Task12
{
    internal class JSONSerializer
    {
        DataContractJsonSerializer serializer;
        public JSONSerializer()
        {
            serializer = new DataContractJsonSerializer(typeof(User));
        }

        public void JSONSerialization(User user)
        {
            Stream file = new FileStream("User.json", FileMode.Create);
            serializer.WriteObject(file, user);
            file.Close();
        }

        public User JSONDeserialization()
        {
            if (File.Exists("User.json"))
            {
                Stream file = new FileStream("User.json", FileMode.Open);
                User user = (User)serializer.ReadObject(file);
                file.Close();
                return user;
            }
            return null;
        }
    }
}
