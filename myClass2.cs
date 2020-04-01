namespace GitExercise
{
    class myClass2
    {
        private string _name;
        private string _adresse;
        private string _postNB;
        private string _by;

        public myClass2(string name, string adresse, string postNB, string by)
        {
            _name = name;
            _adresse = adresse;
            _postNB = postNB;
            _by = by;
        }

        public string Adresse 
        { 
            get 
            {
                return _adresse; 
            }
        }
        public string Name 
        { 
            get 
            {
                return _name; 
            }
        }
        public string PostNB 
        { 
            get 
            {
                return _postNB; 
            }
        }

        public string By 
        { 
            get 
            {
                return _by;
            }
        }

        public override string ToString()
        {
            return $"His name is {Name} and he lives in {Adresse} and his postal code is {PostNB}! He lives in city {By}";
        }
    }
}