namespace Abstract_Factory_App
{
    public class OracleCommand : Command
    {
        public override string Query
        {
            get
            {
                return Query;
            }
            set
            {
                Query = value;
            }
        }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}
