namespace WfrpChars.Data
{
    class Character
    {
        public Character(ISpecies species)
        {
            Species = species;
        }

        public ISpecies Species { get; set; } = new Human();
        public Characteristics Characteristics { get; set; } = new Characteristics();
    }
}
