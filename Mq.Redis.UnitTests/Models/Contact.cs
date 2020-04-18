namespace Mq.Redis.UnitTests.Models
{
    public class Contact
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public Contact(string type, string value)
        {
            this.Type = type;
            this.Value = value;
        }
    }
}
