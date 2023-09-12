// See https://aka.ms/new-console-template for more information

using S3_Ex1_SerializePersons;
using S3_Ex2_PersonPersistence;

Person p1 = new Person()
{
    Age = 42,
    Height = 184.23,
    Hobbies = new []{"soccer", "swimming"},
    Sex = 'M',
    FirstName = "Simon",
    IsMarried = true,
    LastName = "Simonsen"
};

Person p2 = new Person()
{
    Age = 22,
    Height = 174,
    Hobbies = new []{"ballet", "rock-climing", "painting"},
    Sex = 'F',
    FirstName = "Anna",
    IsMarried = false,
    LastName = "Smith"
};

Person p3 = new Person()
{
    Age = 27,
    Height = 217,
    Hobbies = new []{"basketball", "head-against-ceiling-hitting"},
    Sex = 'M',
    FirstName = "James",
    IsMarried = false,
    LastName = "Tallson"
};

List<Person> persons = new() { p1, p2, p3 };

PersonPersistence persPers = new();
persPers.StorePersons(persons);

List<Person> retrieved = persPers.LoadPersons();
int stopDebugHere = 0;