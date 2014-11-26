namespace VIPLocator
{
  class AthleteInfo
  {
    public string Name { get; set; }
    public string BirthPlace { get; set; }
    public string Position { get; set; }

    public AthleteInfo(string name, string birthplace, string position)
    {
      Name = name;
      BirthPlace = birthplace;
      Position = position;
    }
  }
}