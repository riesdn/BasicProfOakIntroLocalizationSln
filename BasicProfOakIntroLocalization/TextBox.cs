using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProfOakIntroLocalization {
    public class TextBox {

        // this will act like Hello.cs in greg's example
        // this is the object that will create instance of whatever I want Oak to say

        ILocalization Language;

        public void WelcomeSpeech() {
            Console.WriteLine();
        }

        public TextBox(ILocalization language) {
            Language = language;
        }
    }
}
