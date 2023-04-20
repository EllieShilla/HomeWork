using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class BInarySerialization
    {
        IFormatter formatter;

        public BInarySerialization()
        {
            formatter = new BinaryFormatter();
        }

        public void ObjectSerialization(User user)
        {
            Stream stream = new FileStream("Person.bin",
                                            FileMode.Create,
                                            FileAccess.Write,
                                            FileShare.None);

            formatter.Serialize(stream, user);
            stream.Close();
        }

        public User ObjectDeserialization()
        {
            if (File.Exists("Person.bin"))
            {
                Stream stream = new FileStream("Person.bin",
                                FileMode.Open,
                                FileAccess.Read,
                                FileShare.Read);

                User user = (User)formatter.Deserialize(stream);
                stream.Close();
                return user;
            }
            return null;
        }
    }
}
