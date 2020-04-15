using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProfOakIntroLocalization {
    public abstract class GeneralLanguage: ILocalization {

        Dictionary<string, string> Phrases = new Dictionary<string, string> { ["err"] = "ERROR: Phrase Not Found"};

        public abstract void InitDictionary();

        public string GetPhrase(int phraseNum) {
            return "";
        }

        public GeneralLanguage() {
            InitDictionary();
        }
    }
}
