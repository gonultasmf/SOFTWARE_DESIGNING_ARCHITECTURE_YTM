namespace Lab_Ders_2
{
    interface IDosyaSikistirma
    {
        string compString(string file);
    }

    class Zip : IDosyaSikistirma
    {
        string _uzanti;
        public Zip(string uzanti)
        {
            this._uzanti = uzanti;
        }
        public string compString(string file)
        {
            // gerekli işlemler yapıldı...
            return file + _uzanti;
        }
    }
    class Rar : IDosyaSikistirma
    {
        string yol;
        public Rar(string yol)
        {
            this.yol = yol;
        }
        public string compString(string file)
        {
            // gerekli işlemler yapıldı...
            return yol + file;
        }
    }
    class Factory
    {
        public IDosyaSikistirma SikistirmaTipi(string type)
        {
            switch (type)
            {
                case "rar":
                    return new Rar("Rar/");
                case "zip":
                    return new Zip(".zip");
                default:
                    return null;
            }
        }
    }
}
