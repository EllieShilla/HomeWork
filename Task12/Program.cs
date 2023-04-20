using System;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name = "John Doe", Platform = "PC" };

            BInarySerialization bInarySerialization = new BInarySerialization();
            bInarySerialization.ObjectSerialization(user);
            workWithDeserializedObj("Binary", bInarySerialization.ObjectDeserialization());

            XML_Serializer xmlSerializer = new XML_Serializer();
            xmlSerializer.XMLSerialization(user);
            workWithDeserializedObj("XML", xmlSerializer.XMLDeserialization());

            JSONSerializer jsonSerializer = new JSONSerializer();
            jsonSerializer.JSONSerialization(user);
            workWithDeserializedObj("JSON", jsonSerializer.JSONDeserialization());

            Console.ReadLine();
        }

        private static void workWithDeserializedObj(string type, User user)
        {
            if (user == null)
                Console.WriteLine("File not exist.");
            else
                showDeserializedString(type, user.Name, user.Platform);
        }
        private static void showDeserializedString(string serializeType, string name, string platform)
        {
            Console.WriteLine("{0}\nName: {1}   Platform: {2}", serializeType, name, platform);
        }
    }
}
