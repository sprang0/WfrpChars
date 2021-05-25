using System.ComponentModel;

namespace WfrpChars.Data.Types
{
    enum SpeciesTypes
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