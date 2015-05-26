using System.Collections.Generic;

namespace symspell
{
    public interface ISpell
    {
        string DefaultLanguage { get; set; }
        List<SuggestItem> Suggest(string input, string language = "");
        bool Spell(string input, string language = "");
        void LoadDirectoryFromFile(string dictFilePath, string language = "");
        void AddToDictionary(string key, string language);
    }
}
