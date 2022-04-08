using System;

namespace Adapter_Tasarım_Alistirma_1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            /*
            Compound unknown = new Compound();
            unknown.Display();
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            Console.ReadKey();*/

            /*
            Target target = new Customer();
            target.Request();
            Console.ReadKey();
            */
            ISorgula sorgula = new Adapter("","");
            sorgula.ParametreliSorgula("fhf");

        }

    }


    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDatabank bank;
        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }
        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);
            Console.WriteLine("\nCompound: {0} ------ ", chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);
        }
    }
    public class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }
        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }


    /*
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    public class Manager : Target
    {
        public override void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    public class Customer : Target
    {
        public override void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest("aaa");
        }
    }
    
    public class Adaptee
    {
        public void SpecificRequest(string aa)
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }*/

    interface ISorgula
    {
        void ParametreliSorgula(string a);
        void ParametresizSorgula();

    }
    class Orracle : ISorgula
    {
        public void ParametreliSorgula(string a)
        {
            throw new NotImplementedException();
        }

        public void ParametresizSorgula()
        {
            throw new NotImplementedException();
        }
    }
    class Sql : ISorgula
    {
        public void ParametreliSorgula(string a)
        {
            throw new NotImplementedException();
        }

        public void ParametresizSorgula()
        {
            throw new NotImplementedException();
        }
    }
    class NoSql
    {

        public void ikiparametreli(string a, string b)
        {

        }
    }
    class Adapter : ISorgula
    {
        NoSql noSql = new NoSql();
        string a, b;
        public Adapter(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public void ParametreliSorgula(string a)
        {
            noSql.ikiparametreli(a, b);
        }

        public void ParametresizSorgula()
        {
            noSql.ikiparametreli(this.a, b);
        }
    }

}
