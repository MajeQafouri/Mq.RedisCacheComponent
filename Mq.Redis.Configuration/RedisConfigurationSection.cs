
namespace Mq.Redis.Configuration
{
    public class RedisConfigurationSection 
    {
        #region Constants

        private const string HostAttributeName = "localhost";
        private const string PortAttributeName = "6379";
        private const string PasswordAttributeName = "";
        private const string DatabaseIDAttributeName = "";

        #endregion

        #region Properties

        public string Host
        {
            get { return HostAttributeName.ToString(); }
        }

        public int Port
        {
            get { return int.Parse(PortAttributeName); }
        }

        public string Password
        {
            get { return PasswordAttributeName.ToString(); }
        }

        public long DatabaseID
        {
            get { return long.Parse(DatabaseIDAttributeName.ToString()); }
        }

        #endregion

        #region you can either use appsetting file to read the configs
        //[ConfigurationProperty(HostAttributeName, IsRequired = true)]
        //public string Host
        //{
        //    get { return this[HostAttributeName].ToString(); }
        //}

        //[ConfigurationProperty(PortAttributeName, IsRequired = true)]
        //public int Port
        //{
        //    get { return (int)this[PortAttributeName]; }
        //}

        //[ConfigurationProperty(PasswordAttributeName, IsRequired = false)]
        //public string Password
        //{
        //    get { return this[PasswordAttributeName].ToString(); }
        //}

        //[ConfigurationProperty(DatabaseIDAttributeName, IsRequired = false)]
        //public long DatabaseID
        //{
        //    get { return (long)this[DatabaseIDAttributeName]; }
        //}
        #endregion
    }
}