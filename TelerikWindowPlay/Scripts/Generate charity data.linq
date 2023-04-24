<Query Kind="Statements">
  <Output>DataGrids</Output>
  <NuGetReference>Bogus</NuGetReference>
  <NuGetReference>Pixata.Extensions</NuGetReference>
  <Namespace>Bogus</Namespace>
  <Namespace>Pixata.Extensions</Namespace>
  <Namespace>static LanguageExt.Prelude</Namespace>
</Query>

// Using company data as Bogus doesn't generate charity data. Only a prototype, so no problem there
Random r = new();

Enumerable.Range(1, 100).Select(n => new Faker<Charity>()
  .RuleFor(c => c.Id, x => n)
    .RuleFor(u => u.Name, (f, u) => f.Company.CompanyName())
    .RuleFor(u => u.Number, (f, u) => f.Random.Digits(10).Select(n => n.ToString()).JoinStr(""))
    .RuleFor(u => u.Address, (f, u) => f.Address.StreetAddress(true))
    .RuleFor(u => u.City, (f, u) => f.Address.City())
    .RuleFor(u => u.Postcode, (f, u) => f.Address.ZipCode())
    .Generate()
    )
.Select(c => $"new({c.Id}, \"{c.Name}\", \"{c.Number}\", \"{c.Address}\", \"{c.City}\", \"{c.Postcode}\"),").Dump();

class Charity {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Number { get; set; }
  public string Address { get; set; }
  public string City { get; set; }
  public string Postcode { get; set; }
}