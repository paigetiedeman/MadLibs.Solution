using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {return View();}

    [Route("/shortform")]
    public ActionResult ShortForm() {return View();}

    [Route("/shortstory")]
    public ActionResult ShortStory(string adjective, string pluralNoun, string noun, string verb)
    {
      MadLibsVariable myMadLibVariable = new MadLibsVariable();
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.PluralNoun = pluralNoun;
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Verb = verb;
      return View(myMadLibVariable);
    }

    [Route("/form")]
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