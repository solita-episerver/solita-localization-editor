using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solita.LocalizationEditor.Definitions;
using Solita.LocalizationEditor.UI.Common;

namespace Solita.LocalizationEditor.Tests
{
    public class Localizations
    {
        [LocalizationCategory("Common", 100)]
        public static class Common
        {
            [Localization(Description = "myCompany", DefaultValue = "myCompany")]
            public const string Sitename = "/common/sitename";

            [Localization(Description = "Finnish (lang)", DefaultValue = "Suomi")]
            public const string LanguageMenuFi = "/common/languagemenufi";

            [Localization(Description = "Swedish (lang)", DefaultValue = "Svenska")]
            public const string LanguageMenuSv = "/common/languagemenusv";

            [Localization(Description = "English (lang)", DefaultValue = "English")]
            public const string LanguageMenuEn = "/common/languagemenuen";

            [Localization(Description = "Russian (lang)", DefaultValue = "Russian")]
            public const string LanguageMenuRu = "/common/languagemenuru";

            [Localization(Description = "Danish (lang)", DefaultValue = "Danish")]
            public const string LanguageMenuDa = "/common/languagemenuda";

            [Localization(Description = "German (lang)", DefaultValue = "German")]
            public const string LanguageMenuDe = "/common/languagemenude";

            [Localization(Description = "Polish (lang)", DefaultValue = "Polish")]
            public const string LanguageMenuPl = "/common/languagemenupl";

            [Localization(Description = "Czech (lang)", DefaultValue = "Czech")]
            public const string LanguageMenuCs = "/common/languagemenucs";

            [Localization(Description = "Chinese (lang)", DefaultValue = "Chinese")]
            public const string LanguageMenuZh = "/common/languagemenuzh";

            [Localization(Description = "Norwegian no (lang)", DefaultValue = "Norwegian")]
            public const string LanguageMenuNo = "/common/languagemenuno";

            [Localization(Description = "Norwegian nb (lang)", DefaultValue = "Norwegian")]
            public const string LanguageMenuNb = "/common/languagemenunb";

            public static string LanguageMenu(string langauge)
            {
                return "/common/languagemenu" + langauge.ToLower();
            }

            [Localization(Description = "Share", DefaultValue = "JAA")]
            public const string Share = "/social/share";

            [Localization(Description = "Vote", DefaultValue = "Vastaa")]
            public const string Vote = "/common/vote";

            [Localization(Description = "Show more", DefaultValue = "Näytä lisää")]
            public const string ShowMore = "/common/showmore";

            [Localization(Description = "Show less", DefaultValue = "Näytä vähemmän")]
            public const string ShowLess = "/common/showless";

            [Localization(Description = "IE8 notification - header text", DefaultValue = "Internetselaimesi ei ole ajantasalla.")]
            public const string IE8NotificationHeader = "/common/ie8notificationheader";

            [Localization(Description = "IE8 notification - introduction text", DefaultValue = "myCompany.fi-palvelu ei toimi käyttämälläsi Internet Explorer 8 -selaimella. Lataa vaihtoehtoinen selain tai päivitä IE8 uudempaan.")]
            public const string IE8IntroductionText = "/common/ie8notificationintroductiontext";

            [Localization(Description = "IE8 notification - close button", DefaultValue = "Sulje ikkuna")]
            public const string IE8CloseWindow = "/common/ie8notificationclosewindow";

            [Localization(Description = "IE8 notification - bottom text", DefaultValue = "Sulkemalla tämän ikkunan tiedostat, että kokemuksesi sivustosta ei välttämättä ole paras mahdollinen")]
            public const string IE8BottomText = "/common/ie8notificationbottomtext";

            [Localization(Description = "Recipient information", DefaultValue = "Vastaanottajan yhteystiedot")]
            public const string RecipientInformation = "/common/recipientinformation";

            [Localization(Description = "Required field message", DefaultValue = "Kenttä on pakollinen")]
            public const string RequiredField = "/common/requiredfield";

            [Localization(Description = "Fill required fields", DefaultValue = "Syötä puuttuvat tiedot")]
            public const string FillRequiredFields = "/common/fillrequiredfields";

            [Localization(Description = "Next", DefaultValue = "Seuraava")]
            public const string Next = "/common/next";

            [Localization(Description = "Previous", DefaultValue = "Edellinen")]
            public const string Previous = "/common/previous";

            [Localization(Description = "View", DefaultValue = "Katso")]
            public const string View = "/common/view";

            [Localization(Description = "Choose", DefaultValue = "Valitse")]
            public const string Choose = "/common/choose";

            [Localization(Description = "Save", DefaultValue = "Tallenna")]
            public const string Save = "/common/save";

            [Localization(Description = "Saving", DefaultValue = "Tallennetaan")]
            public const string Saving = "/common/saving";

            [Localization(Description = "Continue", DefaultValue = "Jatka")]
            public const string Continue = "/common/continue";

            [Localization(Description = "Cancel", DefaultValue = "Peruuta")]
            public const string Cancel = "/common/cancel";

            [Localization(Description = "Cancel editing", DefaultValue = "Peruuta muokkaus")]
            public const string CancelEditing = "/common/cancelediting";

            [Localization(Description = "Close", DefaultValue = "Sulje")]
            public const string Close = "/common/close";

            [Localization(Description = "Clear", DefaultValue = "Tyhjennä")]
            public const string Clear = "/common/clear";

            [Localization(Description = "Back", DefaultValue = "Takaisin")]
            public const string Back = "/common/back";

            [Localization(Description = "Change", DefaultValue = "Vaihda")]
            public const string Change = "/common/change";

            [Localization(Description = "Update", DefaultValue = "Päivitä")]
            public const string Update = "/common/update";

            [Localization(Description = "Edit", DefaultValue = "Muokkaa")]
            public const string Edit = "/common/edit";

            [Localization(Description = "Remove", DefaultValue = "Poista")]
            public const string Remove = "/common/remove";

            [Localization(Description = "Send", DefaultValue = "Lähetä")]
            public const string Send = "/common/send";

            [Localization(Description = "Sending", DefaultValue = "Lähetetään")]
            public const string Sending = "/common/sending";

            [Localization(Description = "Try again", DefaultValue = "Yritä uudelleen")]
            public const string TryAgain = "/common/tryagain";

            [Localization(Description = "Loading", DefaultValue = "Ladataan")]
            public const string Loading = "/common/loading";

            [Localization(Description = "Disclaimer", DefaultValue = "Käyttöehdot")]
            public const string Disclaimer = "/common/disclaimer";

            [Localization(Description = "Current issues", DefaultValue = "Ajankohtaista")]
            public const string CurrentIssues = "/common/currentissues";

            [Localization(Description = "Read more", DefaultValue = "Lue lisää")]
            public const string ReadMore = "/common/readmore";

            [Localization(Description = "Participate in customer survey", DefaultValue = "Osallistu")]
            public const string ParticipateInCustomerSurvey = "/common/participateincustomersurvey";

            [Localization(Description = "Decline customer survey", DefaultValue = "Ei kiitos")]
            public const string DeclineCustomerSurvey = "/common/declinecustomersurvey";

            [Localization(Description = "Print", DefaultValue = "Tulosta")]
            public const string Print = "/common/print";

            [Localization(Description = "Print all", DefaultValue = "Tulosta kaikki")]
            public const string PrintAll = "/common/printall";

            [Localization(Description = "RSS feed", DefaultValue = "RSS")]
            public const string RssFeed = "/common/rssfeed";

            [Localization(Description = "Lunch list page save guide", DefaultValue = "Muutettuasi päivämääriä, muista tallentaa sivu oikeasta yläkulmasta")]
            public const string LunchListPageSaveGuide = "/common/lunchlistpagesaveguide";

            [Localization(Description = "Information about cookies", DefaultValue = "Tietoa evästeistä")]
            public const string InformationAboutCookies = "/common/informationaboutcookies";

            [Localization(Description = "Move to frontpage (upper case)", DefaultValue = "Siirry etusivulle")]
            public const string MoveToFrontpage = "/common/movetofrontpageuppercase";

            [Localization(Description = "Return to frontpage (lower case)", DefaultValue = "palaa etusivulle")]
            public const string ReturnToFrontpage = "/common/returntofrontpage";

            [Localization(Description = "Today (lower case)", DefaultValue = "tänään")]
            public const string TodayLowerCase = "/common/todaylowercase";

            [Localization(Description = "Week (lower case)", DefaultValue = "viikko")]
            public const string WeekLowerCase = "/common/weeklowercase";

            [Localization(Description = "VAT", DefaultValue = "ALV")]
            public const string Vat = "/common/vat";

            [Localization(Description = "Copy link by selecting the text", DefaultValue = "Kopioi linkki valitsemalla teksti")]
            public const string CopyLinkBySelectingTheText = "/common/copylinkbyselectingthetext";

            [Localization(Description = "Copy link", DefaultValue = "Kopioi linkki")]
            public const string CopyLink = "/common/copylink";

            [Localization(Description = "The link has been copied", DefaultValue = "Linkki kopioitu")]
            public const string TheLinkHasBeenCopied = "/common/thelinkhasbeencopied";

            [Localization(Description = "Characters left (lower case)", DefaultValue = "merkkiä jäljellä")]
            public const string CharactersLeftLowerCase = "/common/charactersleftlowercase";

            [Localization(Description = "Rows (lower case)", DefaultValue = "riviä")]
            public const string RowsLowerCase = "/common/rowslowercase";

            [Localization(Description = "Show comments", DefaultValue = "Näytä kommentit")]
            public const string ShowComments = "/common/showcomments";

            [Localization(Description = "Hide comments", DefaultValue = "Piilota kommentit")]
            public const string HideComments = "/common/hidecomments";
        }

        [LocalizationCategory("Common: social", 105)]
        public static class CommonSocial
        {
            [Localization(Description = "Reply", DefaultValue = "Vastaa")]
            public const string Reply = "/common/social/reply";

            [Localization(Description = "Retweet", DefaultValue = "Retweettaa")]
            public const string Retweet = "/common/social/retweet";

            [Localization(Description = "Favorite", DefaultValue = "Lisää suosikiksi")]
            public const string Favorite = "/common/social/favorite";

            [Localization(Description = "Share address", DefaultValue = "Jaa osoite")]
            public const string ShareAddress = "/common/social/shareaddress";

            [Localization(Description = "Share on Facebook", DefaultValue = "Jaa Facebookissa")]
            public const string ShareOnFacebook = "/common/social/shareonfacebook";

            [Localization(Description = "Share on Twitter", DefaultValue = "Jaa Twitterissä")]
            public const string ShareOnTwitter = "/common/social/shareontwitter";

            [Localization(Description = "Send your greetings and participate", DefaultValue = "Lähetä omat terveisesi ja osallistu!")]
            public const string SendYourGreetingsAndParticipate = "/common/social/sendyourgreetingsandparticipate";

            [Localization(Description = "Like this page", DefaultValue = "Tykkää tästä sivusta")]
            public const string LikeThisPage = "/common/social/likethispage";

            [Localization(Description = "Tell a friend", DefaultValue = "Kerro kaverille")]
            public const string TellAFriend = "/common/social/tellafriend";
        }
    }
}
