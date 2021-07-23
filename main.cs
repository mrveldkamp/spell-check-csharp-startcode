using System;
using System.IO;
using System.Text.RegularExpressions;

class MainClass {
    public static void Main (string[] args) {
        // Load Dictionary and Alice in Wonderland into arrays
        string[] dictionary = loadDictionary();
        string[] aliceWords = loadAlice();
    }

   // Load & Verify Dictionary
   public static string[] loadDictionary() {
        // Load Dictionary from File line by line
        string[] localDictionary = File.ReadAllLines("data-files/dictionary.txt");

        // Verify dictionary array
        for (int i = 0; i < 20; i++) {
          Console.WriteLine(localDictionary[i]);
        }
        Console.WriteLine(localDictionary.Length);

        // Return dictionary array
        return localDictionary;
   }

   // Load & Verify Alice in Wonderland 
   public static string[] loadAlice() {
        // Load Alice in Wonderland from File as a single string 
        string aliceText = File.ReadAllText("data-files/AliceInWonderLand.txt");

        // Split Alice Text by matching word patterns  
        MatchCollection matches = Regex.Matches(aliceText, @"[\w]+");

        // Create array of Alice words from value of all matches
        string[] localAliceWords = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++) {
          localAliceWords[i] = matches[i].Value;
        }  
        
        // Verify aliceWords array
        for (int i = 0; i < 20; i++) {
          Console.WriteLine(localAliceWords[i]);
        } 
        Console.WriteLine(localAliceWords.Length);

        // Return Array of Alice Words 
        return localAliceWords;
   }
}