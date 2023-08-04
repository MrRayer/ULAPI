namespace ULAPI.Utils
{
    public class UDBConnM : IUDBConnM
    {
        public string ConnStrUDB { get; set; }
        public UDBConnM(IConfiguration config)
        {
            ConnStrUDB = config.GetValue<String>("ConnectionStrings:UserDB");
        }
    }
}
