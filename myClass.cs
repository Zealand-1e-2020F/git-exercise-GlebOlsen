namespace GitExercise
{
    class myClass
    {
        private string _name;
        private string _adresse;
        private string _postNB;

        public myClass(string name, string adresse, string postNB)
        {
            _name = name;
            _adresse = adresse;
            _postNB = postNB;
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
        public override string ToString()
        {
            return $"His name is {Name} and he lives in {Adresse} and his postal code is {PostNB}!";
        }
    }
}