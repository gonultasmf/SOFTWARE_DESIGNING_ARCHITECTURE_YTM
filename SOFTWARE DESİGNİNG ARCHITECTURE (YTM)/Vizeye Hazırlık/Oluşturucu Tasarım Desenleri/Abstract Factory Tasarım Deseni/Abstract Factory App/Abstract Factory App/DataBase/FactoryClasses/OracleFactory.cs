namespace Abstract_Factory_App
{
    public class OracleFactory : DBFactory
    {
        public override Command CreateComm()
        {
            throw new System.NotImplementedException();
        }

        public override Connection CreateConn()
        {
            throw new System.NotImplementedException();
        }
    }
}
