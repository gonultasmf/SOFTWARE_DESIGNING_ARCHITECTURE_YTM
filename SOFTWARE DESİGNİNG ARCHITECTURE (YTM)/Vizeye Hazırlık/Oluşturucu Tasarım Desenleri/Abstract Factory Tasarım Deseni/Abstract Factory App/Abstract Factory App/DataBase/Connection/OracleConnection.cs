namespace Abstract_Factory_App
{
    public class OracleConnection : Connection
    {
        public override string ConnString
        {
            get
            {
                return ConnString;
            }
            set
            {

            }
        }

        public override void Connect()
        {
            throw new System.NotImplementedException();
        }
    }
}
