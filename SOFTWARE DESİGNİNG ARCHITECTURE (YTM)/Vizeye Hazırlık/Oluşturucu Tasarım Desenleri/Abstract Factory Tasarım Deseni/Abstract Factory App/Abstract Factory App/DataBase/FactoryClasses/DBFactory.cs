namespace Abstract_Factory_App
{
    public abstract class DBFactory
    {
        public abstract Connection CreateConn();
        public abstract Command CreateComm();
    }
}
