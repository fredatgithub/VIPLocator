namespace VIPLocator
{
  class MusicianInfo
  {
    public string Name { get; set; }
    public string BirthPlace { get; set; }
    public string Instrument { get; set; }

    public MusicianInfo(string name, string birthplace, string instrument)
    {
      Name = name;
      BirthPlace = birthplace;
      Instrument = instrument;
    }
  }
}