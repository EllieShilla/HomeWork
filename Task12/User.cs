using System;
using Task8;

namespace Task12
{
    [Serializable]
    public class User : Person
    {
        public User(string name) : base(name)
        {
        }

        public User()
        {
        }

        public new string Name { get; set; }

        private string platform;
        public string Platform
        {
            get { return platform; }
            set { platform = value; }
        }
    }
}
