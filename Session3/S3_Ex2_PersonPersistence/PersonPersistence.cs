using System.Text.Json;
using S3_Ex1_SerializePersons;

namespace S3_Ex2_PersonPersistence;

public class PersonPersistence
{
    public void StorePersons(List<Person> list)
    {
        string json = JsonSerializer.Serialize(list);
        File.WriteAllText("file.json", json);
    }

    public List<Person> LoadPersons()
    {
        string json = File.ReadAllText("file.json");
        List<Person> list = JsonSerializer.Deserialize<List<Person>>(json)!;
        return list;
    }
}