using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string adjective, string name, string number, string color, string place, string adjectiveTwo, string famousPerson, string noun, string song, string verb, string abstractNoun, string adjectiveThree, string pluralNoun)
    {
      MadLibsVariable myMadLibVariable = new MadLibsVariable();
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Name = name;
      myMadLibVariable.Number = number;
      myMadLibVariable.Color = color;
      myMadLibVariable.Place = place;
      myMadLibVariable.AdjectiveTwo = adjectiveTwo;
      myMadLibVariable.FamousPerson = famousPerson;
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Song = song;
      myMadLibVariable.Verb = verb;
      myMadLibVariable.AbstractNoun = abstractNoun;
      myMadLibVariable.AdjectiveThree = adjectiveThree;
      myMadLibVariable.PluralNoun = pluralNoun;
      return View(myMadLibVariable);
    }
  }
}