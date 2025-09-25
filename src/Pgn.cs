using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgnParser.src
{
    internal class Pgn

    {
        private string _filepath { get; set; }
        public string Event { get; set; }

        public Pgn(string filepath)
        {
            _filepath = filepath;
            readFile();
        }


        private void readFile()
        {

            try
            {
                if (File.Exists(_filepath)) {
                    using (StreamReader sr = new StreamReader(_filepath))
                    {
                        string line;
                    
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("Event"))
                            {
                                Event = line.Substring(6, line.Length - 7);
                                Console.WriteLine(Event);
                            }
                            Console.WriteLine(line);
                        }
                    }
                }

                else
                {
                    Console.WriteLine($"File not found at: {_filepath}");
                }

            } catch (Exception ex)
            {
                Console.WriteLine("Error occured while reading file: " + ex.Message);
            }
        }

    }
}
