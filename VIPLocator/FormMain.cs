using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace VIPLocator
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private static List<string> GetNamesFromSite(string p)
    {
      return new List<string>();
    }

    private static List<string> GenerateWikiUrlsFromNames(List<string> names)
    {
      return new List<string>();
    }

    private static Collection<AthleteInfo> GetPlayerData(List<string> wikipediaURLs)
    {
      return new Collection<AthleteInfo>();
    }

    private void FormMain_Load(object sender, System.EventArgs e)
    {
      List<string> names = GetNamesFromSite("http://...");
      List<string> wikipediaURLs = GenerateWikiUrlsFromNames(names);
      Collection<AthleteInfo> _playerData = GetPlayerData(wikipediaURLs);
    }
  }
}