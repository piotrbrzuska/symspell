using System.Linq;
using NUnit.Framework;

namespace symspell.Tests
{
    [TestFixture()]
    public class SymSpellTests
    {
        [TestCase("kóbek","kubek")]
        public void CorrectTest(string input, string correct)
        {
            var spelling = new SymSpell();
            spelling.LoadDirectoryFromFile(@"./../../../dict/Polski.dic");
            var suggests = spelling.Suggest(input);
            var corrected = suggests.Any(a => a.term.Equals(correct));
            Assert.True(corrected);
        }
        [TestCase("kubek")]
        public void IsCorrect(string input)
        {
            var spelling = new SymSpell();
            spelling.AddToDictionary(input);//LoadDirectoryFromFile(@"./../../../dict/Polski.dic");
            Assert.True(spelling.Spell(input));
        }
    }
}