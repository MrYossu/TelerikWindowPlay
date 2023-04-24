<Query Kind="Statements">
  <Output>DataGrids</Output>
  <NuGetReference>Bogus</NuGetReference>
  <Namespace>static LanguageExt.Prelude</Namespace>
  <Namespace>Bogus</Namespace>
</Query>

var customers = Enumerable.Range(1, 100).Select(n => new Faker<Customer>()
  .RuleFor(c => c.Id, x => n)
    .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
    .RuleFor(u => u.Surname, (f, u) => f.Name.LastName())
    .RuleFor(u => u.Email, (f, u) => f.Internet.Email())
    .RuleFor(u => u.Address, (f, u) => f.Address.StreetAddress(true))
    .RuleFor(u => u.City, (f, u) => f.Address.City())
    .RuleFor(u => u.Postcode, (f, u) => f.Address.ZipCode())
    .Generate()
    )
.Select(c => $"new({c.Id}, \"{c.FirstName}\", \"{c.Surname}\", \"{c.Email}\", \"{c.Address}\", \"{c.City}\", \"{c.Postcode}\"),").Dump();

class Customer {
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string Surname { get; set; }
  public string Email { get; set; }
  public string Address { get; set; }
  public string City { get; set; }
  public string Postcode { get; set; }
}