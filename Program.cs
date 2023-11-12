using System.Xml.Serialization;

namespace NetexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current working directory: {Environment.CurrentDirectory}");

            // read the netex directory from netex_dir.txt
            String netexDir;
            try
            {
                netexDir = File.ReadAllText("netex_dir.txt").Trim();
            }
            catch (Exception e)
            {
                Console.Write("Could not read netex_dir.txt: ");
                Console.WriteLine(e.Message);
                return;
            }
            
            // find all files in there
            var files = Directory.GetFiles(netexDir, "*.xml");
            Console.WriteLine($"Number of files: {files.Length}");
            
            var parser = new Parser();
            
            // loop through
            foreach (var file in files)
            {
                parser.ParseFile(file);
            }
        }
    }

    class Parser
    {
        readonly XmlSerializer _mySerializer = new XmlSerializer(typeof(Netex.PublicationDeliveryStructure));

        public void ParseFile(String path)
        {
            Console.WriteLine($"Loading file {path}");

            using var myFileStream = new FileStream(path, FileMode.Open);

            var myObject = (Netex.PublicationDeliveryStructure)_mySerializer.Deserialize(myFileStream)!;
            foreach (var compositeFrame in myObject.DataObjects.CompositeFrame)
            {
                Console.WriteLine("CompositeFrame");
                foreach (var serviceFrame in compositeFrame.Frames.ServiceFrame)
                {
                    // for shared_data.xml,
                    // Lines, Routes and JourneyPatterns do not exist
                    
                    Console.WriteLine("- ServiceFrame");
                    if (serviceFrame.Lines != null)
                        foreach (var line in serviceFrame.Lines.Line)
                        {
                            var name = line.Name.Value;
                            Console.WriteLine($"  - Line {name} (ID {line.Id})");
                        }
                    
                    
                    if (serviceFrame.Routes != null)
                        foreach (var route in serviceFrame.Routes.Route)
                        {
                            var points = route.PointsInSequence.PointOnRoute;
                            var name = route.Name.Value;
                            var directionType = route.DirectionType.ToString();

                            Console.WriteLine(
                                $"  - Route {name} ({directionType}), {points.Count} stops (part of line {route.LineRef.Ref})");
                        }

                    if (serviceFrame.JourneyPatterns != null)
                        foreach (var journeyPattern in serviceFrame.JourneyPatterns.JourneyPattern)
                        {
                            var stops = journeyPattern.PointsInSequence.StopPointInJourneyPattern;
                            Console.WriteLine($"  - JourneyPattern: {stops.Count} stop points (ID: {journeyPattern.Id})");
                        }
                }

                foreach (var timetableFrame in compositeFrame.Frames.TimetableFrame)
                {
                    Console.WriteLine("- TimetableFrame");

                    var serviceJourneys = timetableFrame.VehicleJourneys.ServiceJourney;
                    Console.WriteLine($"  - Number of ServiceJourneys: {serviceJourneys.Count}");
                    foreach (var serviceJourney in serviceJourneys)
                    {
                        // Console.WriteLine("  - ServiceJourney");
                    }
                }
            }
        }
    }
}