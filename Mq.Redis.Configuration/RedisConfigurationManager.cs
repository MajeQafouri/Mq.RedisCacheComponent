namespace Mq.Redis.Configuration
{
    public class RedisConfigurationManager
    {
        #region Constants

        private const string SectionName = "RedisConfiguration";


        public static RedisConfigurationSection Config
        {
             get
            {
                return new RedisConfigurationSection();

                #region using appSetting to read configs
                // return (RedisConfigurationSection)ConfigurationManager.GetSection(SectionName);
                #endregion
            }
        } 
        #endregion
    }
}