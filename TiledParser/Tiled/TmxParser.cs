using System;
using System.IO;
using System.Xml.Serialization;

namespace AssetImporter.Tiled
{
    public class TmxParser
    {
        /// <summary>
        /// Constructs a new '.tmx' file parser.
        /// </summary>
        public TmxParser()
        {
        }

        /// <summary>
        /// Parses the specified '.tmx' file.
        /// </summary>
        /// <param name="filepath">the location of the file.</param>
        /// <returns>the parsed TmxMap with the data from the specified file.</returns>
        public TmxMap Parse(string filepath)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TmxMap));

                TextReader reader = new StreamReader(filepath);
                TmxMap map = serializer.Deserialize(reader) as TmxMap;
                reader.Close();

                return map;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to parse the \'.tmx\' file! (Due to: " + e.Message + ")\n");
                Console.Error.WriteLine(e);
                Environment.Exit(1);
            }
            return null;
        }
    }
}