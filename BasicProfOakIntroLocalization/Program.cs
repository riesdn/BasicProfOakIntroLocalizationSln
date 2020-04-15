using System;

namespace BasicProfOakIntroLocalization {
    class Program {
        static void Main(string[] args) {

            // want to do a basic version of Professor Oak's opening dialogue in Pokemon Red
            // and also have basic language localization like Greg showed in class 2/14/20
            // (his example repo is downloaded! open InterfaceExample.Sln)

            Console.WriteLine("Language: English / French / Spanish");
            // get user input for which language they want and put it in lang

            //var lang = Console.ReadLine();
            //if(lang == "English") {
            //    var eng = new English();
            //} else if (Console.ReadLine() == "French") {
            //    var frn = new French();
            //} else if (Console.ReadLine() == "Spanish") {
            //    lang = new Spanish();
            //} else {
            //    Console.WriteLine("ERROR: NonOption");
            //}

            // enum for language options??

            var profOakEng = new TextBox(new English());

            var profOakFrn = new TextBox(new French());

            var profOakSpn = new TextBox(new Spanish());

        }
    }
}
