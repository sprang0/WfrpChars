using System.ComponentModel;

namespace WfrpChars.Data
{
    enum SpeciesType
    {
        Human,
        Halfling,
        Dwarf,
        [Description("High Elf")]
        HighElf,
        [Description("Wood Elf")]
        WoodElf
    }
}