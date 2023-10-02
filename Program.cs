using System.Xml.Serialization;

var path = "path/to/skane/line_12_802_9011012080200000.xml";

Console.WriteLine($"Loading file {path}");

var mySerializer = new XmlSerializer(typeof(Netex.PublicationDeliveryStructure));

using var myFileStream = new FileStream(path, FileMode.Open);

var myObject = (Netex.PublicationDeliveryStructure)mySerializer.Deserialize(myFileStream)!;
foreach (var compositeFrame in myObject.DataObjects.CompositeFrame)
{
    Console.WriteLine("CompositeFrame");
    foreach (var serviceFrame in compositeFrame.Frames.ServiceFrame)
    {
        Console.WriteLine("- ServiceFrame");
        foreach (var line in serviceFrame.Lines.Line)
        {
            var name = line.Name.Value;
            Console.WriteLine($"  - Line {name} (ID {line.Id})");
        }

        foreach (var route in serviceFrame.Routes.Route)
        {
            var points = route.PointsInSequence.PointOnRoute;
            var name = route.Name.Value;
            var directionType = route.DirectionType.ToString();
        
            Console.WriteLine($"  - Route {name} ({directionType}), {points.Count} stops (part of line {route.LineRef.Ref})");
        }

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


