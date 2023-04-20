using System.IO;
using System.Xml.Serialization;

namespace Task12
{
    internal class XML_Serializer
    {
        XmlSerializer serializer;
        public XML_Serializer()
        {
            serializer = new XmlSerializer(typeof(User));
        }

        public void XMLSerialization(User user)
        {
            Stream stream = new FileStream("User.xml", FileMode.Create);
            serializer.Serialize(stream, user);
            stream.Close();
        }

        public User XMLDeserialization()
        {
            if (File.Exists("User.xml"))
            {
                Stream stream = new FileStream("User.xml", FileMode.Open);
                User user = serializer.Deserialize(stream) as User;
                stream.Close();
                return user;
            }
            return null;
        }
    }
}
