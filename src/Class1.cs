using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgnParser.src
{
    internal class FileReader

    {
        private string _filepath { get; set; }
        public FileReader(string filepath)
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
