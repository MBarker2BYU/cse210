using System.Text.Json;
using System.Text.Json.Serialization;
using Journal.Interfaces;

namespace Journal.Converters;

public class JournalEntryConverter : JsonConverter<IJournalEntry>
{
    public override IJournalEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Deserialize the JSON into the concrete type (e.g., JournalEntry)
        var journalEntry = JsonSerializer.Deserialize<JournalEntry>(ref reader, options);
        return journalEntry;
    }
    public override void Write(Utf8JsonWriter writer, IJournalEntry value, JsonSerializerOptions options)
    {
        // Serialize the concrete type
        JsonSerializer.Serialize(writer, (JournalEntry)value, options);
    }
}