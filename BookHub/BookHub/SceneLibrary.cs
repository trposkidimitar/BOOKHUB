using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    public class SceneLibrary
    {
        public List<Book> ModernLiterature { get; set; }
        public List<Book> Classics { get; set; }
        public List<Book> Drama { get; set; }
        public List<Book> CrimeThriller { get; set; }
        public List<Book> AdventureAction { get; set; }
        public List<Book> Romance { get; set; }
        public List<Book> Horror { get; set; }
        public List<Book> Comedy { get; set; }
        public List<Book> ScienceFictionFantasy { get; set; }
        public List<Book> HistoricFiction { get; set; }
        public List<Book> MacedonianPoetry { get; set; }
        public List<Book> ForeignPoetry { get; set; }
        public List<Book> Travel { get; set; }
        public List<Book> SportFitness { get; set; }
        public List<Book> Cookbooks { get; set; }
        public List<Book> Economy { get; set; }
        public List<Book> SocialOther { get; set; }
        public List<Book> Medicine { get; set; }
        public List<Book> ScienceOther { get; set; }
        public List<Book> Music { get; set; }
        public List<Book> FilmStagecraft { get; set; }
        public List<Book> Architecture { get; set; }
        public List<Book> EncyclopediaLexicon { get; set; }
        public List<Book> JournalMagazine { get; set; }

        public SceneLibrary()
        {
            ModernLiterature = new List<Book>();
            Classics = new List<Book>();
            Drama = new List<Book>();
            CrimeThriller = new List<Book>();
            AdventureAction = new List<Book>();
            Romance = new List<Book>();
            Horror = new List<Book>();
            Comedy = new List<Book>();
            ScienceFictionFantasy = new List<Book>();
            HistoricFiction = new List<Book>();
            MacedonianPoetry = new List<Book>();
            ForeignPoetry = new List<Book>();
            Travel = new List<Book>();
            SportFitness = new List<Book>();
            Cookbooks = new List<Book>();
            Economy = new List<Book>();
            SocialOther = new List<Book>();
            Medicine = new List<Book>();
            ScienceOther = new List<Book>();
            Music = new List<Book>();
            FilmStagecraft = new List<Book>();
            EncyclopediaLexicon = new List<Book>();
            JournalMagazine = new List<Book>();
        }
    }
}
