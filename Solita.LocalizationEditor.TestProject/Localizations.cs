using Solita.LocalizationEditor.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solita.LocalizationEditor.TestProject
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

        [LocalizationCategory("Days", 110)]
        public static class Days
        {
            [Localization(Description = "Monday", DefaultValue = "Maanantai")]
            public const string Monday = "/common/day/Monday";

            [Localization(Description = "Tuesday", DefaultValue = "Tiistai")]
            public const string Tuesday = "/common/day/Tuesday";

            [Localization(Description = "Wednesday", DefaultValue = "Keskiviikko")]
            public const string Wednesday = "/common/day/Wednesday";

            [Localization(Description = "Thursday", DefaultValue = "Torstai")]
            public const string Thursday = "/common/day/Thursday";

            [Localization(Description = "Friday", DefaultValue = "Perjantai")]
            public const string Friday = "/common/day/Friday";

            [Localization(Description = "Saturday", DefaultValue = "Lauantai")]
            public const string Saturday = "/common/day/Saturday";

            [Localization(Description = "Sunday", DefaultValue = "Sunnuntai")]
            public const string Sunday = "/common/day/Sunday";

            public static string DayOfWeek(DayOfWeek dayOfWeek)
            {
                return "/common/day/" + dayOfWeek;
            }
        }

        [LocalizationCategory("Forms", 200)]
        public static class Forms
        {
            [Localization(Description = "Required field", DefaultValue = "Kenttä on pakollinen")]
            public const string Required = "/forms/required";

            [Localization(Description = "Form is invalid.", DefaultValue = "Lomakkeella on virheitä.")]
            public const string FormHasErrors = "/forms/formhaserrors";

            [Localization(Description = "The file format is not permitted", DefaultValue = "Tiedostomuoto ei sallittu")]
            public const string UnallowedFileExtension = "/forms/unallowedfileextension";

            [Localization(Description = "Attachment file", DefaultValue = "Liitetiedosto (PDF, JPG, TXT)")]
            public const string Attachment = "/forms/attachment";

            [Localization(Description = "Browse", DefaultValue = "Selaa")]
            public const string Browse = "/forms/browse";

            [Localization(Description = "Choose file", DefaultValue = "Valitse tiedosto")]
            public const string ChooseFile = "/forms/choosefile";

            [Localization(Description = "Maximum attachment file size", DefaultValue = "Suurin sallittu tiedostokoko on 4 MB.")]
            public const string AllowedAttachmentSize = "/forms/attachmentsize";

            [Localization(Description = "Check field", DefaultValue = "Tarkista kenttä")]
            public const string CheckField = "/forms/checkfield";
        }

        [LocalizationCategory("Location (content type)", 300)]
        public static class Location
        {
            [Localization(Description = "Contact information", DefaultValue = "Yhteystiedot")]
            public const string ContactInformation = "/location/contactinformation";

            [Localization(Description = "Opening hours", DefaultValue = "Aukioloajat")]
            public const string OpeningHours = "/location/openinghours";

            [Localization(Description = "Mon - Fri (opening hours)", DefaultValue = "maanantai - perjantai")]
            public const string OpeningHoursMondayToFriday = "/location/openinghoursmondaytofriday";

            [Localization(Description = "Saturday (opening hours)", DefaultValue = "lauantai")]
            public const string OpeningHoursSaturday = "/location/openinghourssaturday";

            [Localization(Description = "Sunday (opening hours)", DefaultValue = "sunnuntai")]
            public const string OpeningHoursSunday = "/location/openinghourssunday";

            [Localization(Description = "Services", DefaultValue = "Palvelut")]
            public const string Services = "/location/services";

            [Localization(Description = "Show on map", DefaultValue = "Näytä kartalla")]
            public const string ShowOnMap = "/location/showonmap";

            [Localization(Description = "Close map", DefaultValue = "Sulje kartta")]
            public const string CloseMap = "/location/closemap";

            [Localization(Description = "Restaurants not found", DefaultValue = "Läheltäsi ei löytynyt ravintoloita.")]
            public const string NoLocationsFound = "/location/nolocationsfound";

            [Localization(Description = "All (selection)", DefaultValue = "Kaikki")]
            public const string AllLocations = "/locationlistblock/alllocations";

            [Localization(Description = "My restaurants", DefaultValue = "Ravintolani")]
            public const string MyRestaurants = "/locationlistgadget/myrestaurants";

            [Localization(Description = "Choose a city (selection)", DefaultValue = "Valitse kaupunki")]
            public const string ChooseCity = "/locationlistblock/choosecity";

            [Localization(Description = "Route to restaurant", DefaultValue = "Reitti myymälään")]
            public const string RouteToLocation = "/locationlistblock/routetolocation";
        }

        [LocalizationCategory("Search", 500)]
        public static class Search
        {
            [Localization(Description = "Search", DefaultValue = "Hae")]
            public const string DoSearch = "/search/search";

            [Localization(Description = "Search products", DefaultValue = "Hae tuotteista")]
            public const string SearchProducts = "/search/searchproducts";

            [Localization(Description = "Search site", DefaultValue = "Hae sivustolta")]
            public const string SearchSite = "/search/searchsite";

            [Localization(Description = "Found", DefaultValue = "Löytyi ")]
            public const string Found = "/search/found";

            [Localization(Description = "results", DefaultValue = "osumaa")]
            public const string results = "/search/results";

            [Localization(Description = "Search results", DefaultValue = "Hakutulokset")]
            public const string SearchResults = "/search/searchresults";

            [Localization(Description = "No results", DefaultValue = "Ei hakutuloksia")]
            public const string NoResults = "/search/noresults";

            [Localization(Description = "Limit search", DefaultValue = "Rajaa hakua")]
            public const string LimitSearch = "/search/limitsearch";

            [Localization(Description = "Show more", DefaultValue = "Näytä lisää")]
            public const string ShowMore = "/search/showmore";

            [Localization(Description = "Show all", DefaultValue = "Näytä kaikki")]
            public const string ShowAll = "/search/showall";

            [Localization(Description = "Navigate to selection", DefaultValue = "Siirry sivulle...")]
            public const string NavigateTo = "/search/navigateto";

            [Localization(Description = "Free text search", DefaultValue = "Vapaa tekstihaku")]
            public const string FreeText = "/search/freetext";

            [Localization(Description = "Use text search or filter results", DefaultValue = "Käytä tekstihakua tai rajaa hakutuloksia")]
            public const string HelpText = "/search/helptext";

            [Localization(Description = "Choose categories", DefaultValue = "Valitse kategoriat")]
            public const string ChooseProductCategories = "/search/choosecategories";

            [Localization(Description = "Choose methods", DefaultValue = "Valitse käyttötapa")]
            public const string ChooseProductUsage = "/search/choosemethods";

            [Localization(Description = "Choose diets", DefaultValue = "Valitse erityisruokavaliot")]
            public const string ChooseDiets = "/search/choosediets";

            [Localization(Description = "Frozen goods", DefaultValue = "Pakasteet")]
            public const string FrozenGoods = "/search/frozengoods";

            [Localization(Description = "Fresh goods", DefaultValue = "Tuoretuotteet")]
            public const string FreshGoods = "/search/freshgoods";

            [Localization(Description = "Clear search filters", DefaultValue = "Tyhjennä valinnat")]
            public const string ClearFilters = "/search/clearfilters";

            [Localization(Description = "Show all tags", DefaultValue = "Lisää...")]
            public const string MoreTags = "/search/moretags";
        }

        [LocalizationCategory("Navigation", 510)]
        public static class Navigation
        {
            [Localization(Description = "Select section", DefaultValue = "Valitse osio")]
            public const string SelectSection = "/navigation/selectsection";

            [Localization(Description = "Frontpage", DefaultValue = "Etusivu")]
            public const string Frontpage = "/navigation/frontpage";

            [Localization(Description = "Contact", DefaultValue = "Ota yhteyttä")]
            public const string Contact = "/navigation/contact";

            [Localization(Description = "myCompanyReplace", DefaultValue = "Tili")]
            public const string myCompanyReplace = "/navigation/myCompanyreplace";
        }

        [LocalizationCategory("Wayfinder - myCompany.com", 650)]
        public static class WayFinder
        {
            [Localization(Description = "Wayfinder text ", DefaultValue = "You are currently browsing the international site. Would you like to change location?")]
            public const string WayFinderText = "/wayfinder/wayfindertext";

            [Localization(Description = "Wayfinder link text", DefaultValue = "Click here!")]
            public const string WayFinderLinkText = "/wayfinder/wayfinderlinktext";

            [Localization(Description = "Dismiss wayfinder-notification", DefaultValue = "Dismiss")]
            public const string DismissWayfinderNotification = "/wayfinder/dismiss";
        }

        [LocalizationCategory("Recipe", 700)]
        public static class Recipe
        {
            [Localization(Description = "Show recipe", DefaultValue = "Näytä resepti")]
            public const string ShowRecipe = "/recipe/showrecipe";

            [Localization(Description = "Ingredients", DefaultValue = "Ainekset")]
            public const string Ingredients = "/recipe/ingredients";

            [Localization(Description = "Instructions", DefaultValue = "Tee näin")]
            public const string Instructions = "/recipe/instructions";
        }

        [LocalizationCategory("User", 800)]
        public static class User
        {
            [Localization(Description = "Log in", DefaultValue = "Kirjaudu")]
            public const string Login = "/user/login";

            [Localization(Description = "Log in here", DefaultValue = "Kirjaudu sisään tästä")]
            public const string LoginHere = "/user/loginhere";

            [Localization(Description = "Log out", DefaultValue = "Kirjaudu ulos")]
            public const string LogOff = "/user/logoff";

            [Localization(Description = "Log out (lower case)", DefaultValue = "kirjaudu ulos")]
            public const string LogOffLowerCase = "/user/logofflowercase";

            [Localization(Description = "Logon header", DefaultValue = "Kirjaudu")]
            public const string LogOnHeader = "/user/logonheader";

            [Localization(Description = "My information", DefaultValue = "Omat tietoni")]
            public const string MyInformation = "/user/myinformation";

            [Localization(Description = "Company or community name", DefaultValue = "Yrityksen tai yhteisön nimi")]
            public const string CompanyOrCommunityName = "/user/companyorcommunityname";

            [Localization(Description = "Name", DefaultValue = "Nimi")]
            public const string Name = "/user/name";

            [Localization(Description = "First name", DefaultValue = "Etunimi")]
            public const string FirstName = "/user/firstname";

            [Localization(Description = "Last name", DefaultValue = "Sukunimi")]
            public const string LastName = "/user/lastname";

            [Localization(Description = "Street address", DefaultValue = "Katuosoite")]
            public const string Address = "/user/address";

            [Localization(Description = "Postal code", DefaultValue = "Postinumero")]
            public const string PostCode = "/user/postcode";

            [Localization(Description = "Post office", DefaultValue = "Postitoimipaikka")]
            public const string PostOffice = "/user/postoffice";

            [Localization(Description = "City", DefaultValue = "Kaupunki")]
            public const string City = "/user/city";

            [Localization(Description = "Country", DefaultValue = "Maa")]
            public const string Country = "/user/country";

            [Localization(Description = "Company", DefaultValue = "Yritys")]
            public const string Company = "/user/company";

            [Localization(Description = "Email", DefaultValue = "Sähköpostiosoite")]
            public const string Email = "/user/email";

            [Localization(Description = "Phone", DefaultValue = "Puhelinnumero")]
            public const string Phone = "/user/phone";

            [Localization(Description = "Password", DefaultValue = "Salasana")]
            public const string Password = "/user/password";

            [Localization(Description = "Confirm password", DefaultValue = "Salasana uudestaan")]
            public const string ConfirmPassword = "/user/confirmpassword";

            [Localization(Description = "Change password", DefaultValue = "Vaihda salasana")]
            public const string ChangePassword = "/user/changepassword";

            [Localization(Description = "Password too short", DefaultValue = "Salasana liian lyhyt")]
            public const string PasswordTooShort = "/user/passwordtooshort";

            [Localization(Description = "Passwords do not match", DefaultValue = "Salasanat eivät täsmää")]
            public const string PasswordsDoNotMatch = "/user/passwordsdonotmatch";

            [Localization(Description = "Password must be at least {0} characters long", DefaultValue = "Salasanan tulee olla vähintään {0} merkkiä pitkä")]
            public const string PasswordMinLengthTemplate = "/user/passwordminlength";

            [Localization(Description = "Remember me", DefaultValue = "Muista minut")]
            public const string RememberMe = "/user/rememberme";

            [Localization(Description = "Terms and conditions", DefaultValue = "Käyttöehdot")]
            public const string TermsAndConditions = "/user/termsandconditions";

            [Localization(Description = "Marketing", DefaultValue = "Markkinointilupa")]
            public const string Marketing = "/user/marketing";

            [Localization(Description = "Accept terms and conditions", DefaultValue = "Olen lukenut ja hyväksynyt palvelun ehdot")]
            public const string AcceptTermsAndConditions = "/user/accepttermsandconditions";

            [Localization(Description = "Accept marketing", DefaultValue = "Minulle saa lähettää markkinointiviestejä")]
            public const string AcceptMarketing = "/user/acceptmarketing";

            [Localization(Description = "Signup link", DefaultValue = "Rekisteröidy")]
            public const string SignUpLink = "/user/signuplink";

            [Localization(Description = "Reset password link", DefaultValue = "Unohtuiko salasana?")]
            public const string ResetPasswordLink = "/user/resetpasswordlink";

            [Localization(Description = "Password reset email sent", DefaultValue = "Sähköposti salasanan vaihtoon lähetetty")]
            public const string PasswordResetEmailSent = "/user/passwordresetemailsent";

            [Localization(Description = "Password reset successfully", DefaultValue = "Salasana vaihdettu onnistuneesti")]
            public const string PasswordResetSuccessfully = "/user/passwordresetsuccessfully";

            [Localization(Description = "Sign up", DefaultValue = "Rekisteröidy")]
            public const string SignUp = "/user/signup";

            [Localization(Description = "Sign out link", DefaultValue = "Kirjaudu ulos")]
            public const string SignOutLink = "/user/signoutlink";

            [Localization(Description = "Signup confirm header", DefaultValue = "Rekisteröitymisen vahvistus")]
            public const string SignUpConfirmHeader = "/user/signupconfirmheader";

            [Localization(Description = "Incorrect username or password", DefaultValue = "Virheellinen käyttäjätunnus tai salasana")]
            public const string LoginError = "/user/loginerror";

            [Localization(Description = "Username already in use", DefaultValue = "Käyttäjätunnus on jo käytössä")]
            public const string UsernameIsAlreadyInUse = "/user/usernamealreadyinuse";

            [Localization(Description = "Email already in use", DefaultValue = "Sähköpostiosoite on jo käytössä")]
            public const string EmailIsAlreadyInUse = "/user/emailalreadyinuse";

            [Localization(Description = "Email not found", DefaultValue = "Sähköpostiosoitetta ei löydy")]
            public const string EmailNotFound = "/user/emailnotfound";

            [Localization(Description = "Have you already registered?", DefaultValue = "Oletko jo rekisteröitynyt?")]
            public const string HaveYouAlreadyRegistered = "/user/haveyoualreadyregistered";

            [Localization(Description = "I have already registered", DefaultValue = "Olen jo rekisteröitynyt")]
            public const string IHaveAlreadyRegistered = "/user/ihavealreadyregistered";

            [Localization(Description = "I haven't registered yet", DefaultValue = "Minulla ei ole vielä käyttäjätunnuksia")]
            public const string IHaventRegisteredYet = "/user/ihaventregisteredyet";

            [Localization(Description = "Service terms not accepted", DefaultValue = "Palvelun ehtoja ei ole hyväksytty")]
            public const string TermsNotAccepted = "/user/termsnotaccepted";

            [Localization(Description = "Incorrect email verification code", DefaultValue = "Virheellinen varmistuskoodi")]
            public const string IncorrectEmailVerificationCode = "/user/incorrectemailverificationcode";

            [Localization(Description = "Incorrect email", DefaultValue = "Virheellinen sähköpostiosoite")]
            public const string IncorrectEmail = "/user/incorrectemail";

            [Localization(Description = "Incorrect phone number", DefaultValue = "Virheellinen puhelinnumero")]
            public const string IncorrectPhonenumber = "/user/incorrectphonenumber";

            [Localization(Description = "Incorrect postal code", DefaultValue = "Virheellinen postinumero")]
            public const string IncorrectPostalCode = "/user/incorrectpostalcode";

        }

        // keep product attributes at the bottom.. they take a lot of space
        [LocalizationCategory("Product", 10000)]
        public static class Product
        {
            [Localization(Description = "Ingredients", DefaultValue = "Sisältö")]
            public const string Ingredients = "/product/ingredients";

            [Localization(Description = "Product code", DefaultValue = "Tuotenumero")]
            public const string ProductCode = "/product/productcode";

            [Localization(Description = "CN code", DefaultValue = "CN-koodi")]
            public const string CNCode = "/product/cncode";

            [Localization(Description = "Weight", DefaultValue = "Paino")]
            public const string Weight = "/product/weight";

            [Localization(Description = "Country of origin", DefaultValue = "Valmistusmaa")]
            public const string CountryOfOrigin = "/product/countryoforigin";

            [Localization(Description = "Quality certificates", DefaultValue = "Laatusertifikaatit")]
            public const string QualityCertificates = "/product/qualitycertificates";

            [Localization(Description = "EAN code", DefaultValue = "EAN-tunnus")]
            public const string EANCode = "/product/eancode";

            [Localization(Description = "Pick up location", DefaultValue = "Noutosijainti")]
            public const string PickUpLocation = "/product/pickuplocation";

            [Localization(Description = "Pralines", DefaultValue = "Konvehdit")]
            public const string Pralines = "/product/pralines";

            [Localization(Description = "Show pralines", DefaultValue = "Näytä konvehdit")]
            public const string ShowPralines = "/product/showpralines";

            [Localization(Description = "Hide pralines", DefaultValue = "Piilota konvehdit")]
            public const string HidePralines = "/product/hidepralines";

            [Localization(Description = "Select product group", DefaultValue = "Valitse tuoteryhmä")]
            public const string SelectProductGroup = "/product/selectproductgroup";

            [Localization(Description = "Select product group", DefaultValue = "Näytä tuotetiedot")]
            public const string ShowProductDetails = "/product/showproductdetails";

            [Localization(Description = "Select product group", DefaultValue = "Piilota tuotetiedot")]
            public const string HideProductDetails = "/product/hideproductdetails";

            [Localization(Description = "Baking instructions", DefaultValue = "Paisto-ohje")]
            public const string BakingInstructions = "/product/bakinginstructions";

            [Localization(Description = "Product information", DefaultValue = "Tuotetiedot")]
            public const string ProductInformation = "/product/productinformation";

            [Localization(Description = "Sales unit", DefaultValue = "Myyntiyksikkö")]
            public const string SalesUnit = "/product/salesunit";

            [Localization(Description = "Pieces", DefaultValue = "Myyntierän koko")]
            public const string Pieces = "/product/pieces";

            [Localization(Description = "Pieces per case", DefaultValue = "Kpl per myyntierä")]
            public const string PiecesPerCase = "/product/piecespercase";

            [Localization(Description = "Net weight", DefaultValue = "Nettopaino")]
            public const string NetWeight = "/product/netweight";

            [Localization(Description = "Gross weight", DefaultValue = "Bruttopaino")]
            public const string GrossWeight = "/product/grossweight";

            [Localization(Description = "Case dimensions", DefaultValue = "Myyntierän mitat")]
            public const string CaseDimensions = "/product/casedimensions";

            [Localization(Description = "EUR-pallet", DefaultValue = "EUR-lava")]
            public const string EURPallet = "/product/eurpallet";

            [Localization(Description = "Cases per EUR-pallet", DefaultValue = "Myyntierää per EUR-lava")]
            public const string CasesPerEURPallet = "/product/casespereurpallet";

            [Localization(Description = "Including pallet", DefaultValue = "(sis. lava)")]
            public const string IncludingPallet = "/product/includingPallet";

            [Localization(Description = "Pallet height", DefaultValue = "Lavan korkeus")]
            public const string PalletHeight = "/product/palletheight";

            [Localization(Description = "Products", DefaultValue = "Tuotteet")]
            public const string ProductsText = "/product/productstext";

            [Localization(Description = "Show all", DefaultValue = "Näytä kaikki")]
            public const string ShowAllText = "/product/showalltext";

            [Localization(Description = "Show", DefaultValue = "Näytä")]
            public const string ShowText = "/product/showtext";

            [Localization(Description = "All", DefaultValue = "Kaikki")]
            public const string AllText = "/product/alltext";

            [Localization(Description = "Hello", DefaultValue = "Hei")]
            public const string Hello = "/product/hello";

            [Localization(Description = "Your previous order contained these", DefaultValue = "Näitä tilasit viimeksi")]
            public const string YourPreviousOrderContainedThese = "/product/yourpreviousordercontainedthese";

        }

        [LocalizationCategory("Diets", 10100)]
        public static class Diets
        {
            [Localization(Description = "Check nutritional values", DefaultValue = "Tarkista tuotetiedot aina myös pakkauksesta.")]
            public const string CheckNutritionalValues = "/product/diet/checknutritionalvalues";

            [Localization(Description = "Diets (title)", DefaultValue = "Eritysruokavaliot")]
            public const string DietsHeading = "/product/diet/dietsheading";

            [Localization(Description = "Milkless", DefaultValue = "Maidoton")]
            public const string NoMilk = "/product/diet/nomilk";

            [Localization(Description = "Milkless (short)", DefaultValue = "Maidoton")]
            public const string NoMilkShort = "/product/diet/short/nomilk";

            [Localization(Description = "Lactose free", DefaultValue = "Laktoositon (laktoosia < 0,01 g / 100 g)")]
            public const string NoLactose = "/product/diet/nolactose";

            [Localization(Description = "Low lactose", DefaultValue = "Vähälaktoosinen (laktoosia < 1 g / 100 g)")]
            public const string LowLactose = "/product/diet/lowlactose";

            [Localization(Description = "Low lactose (short)", DefaultValue = "Vähälaktoosinen")]
            public const string LowLactoseShort = "/product/diet/short/lowlactose";

            [Localization(Description = "Gluten free", DefaultValue = "Gluteeniton")]
            public const string NoGluten = "/product/diet/nogluten";

            [Localization(Description = "Wheat", DefaultValue = "Vehnää")]
            public const string Wheat = "/product/diet/wheat";

            [Localization(Description = "Nuts / almond", DefaultValue = "Pähkinää / mantelia")]
            public const string Nuts = "/product/diet/nuts";

            [Localization(Description = "Nuts / almond (short)", DefaultValue = "Sis. pähkinää")]
            public const string NutsShort = "/product/diet/short/nuts";

            [Localization(Description = "Soy", DefaultValue = "Soijaa")]
            public const string Soy = "/product/diet/soy";

            [Localization(Description = "Soy lecithin", DefaultValue = "Soijalesitiiniä")]
            public const string SoyLecithin = "/product/diet/soylecithin";

            [Localization(Description = "Gelatine (pork)", DefaultValue = "Liivatetta (sikaperäistä)")]
            public const string GelatinePork = "/product/diet/gelatinepork";

            [Localization(Description = "Gelatine (bovine)", DefaultValue = "Liivatetta (nautaperäistä)")]
            public const string GelatineBovine = "/product/diet/gelatinebovine";

            [Localization(Description = "Celery", DefaultValue = "Selleriä")]
            public const string Celery = "/product/diet/celery";

            [Localization(Description = "Celery (short)", DefaultValue = "Sis. selleriä")]
            public const string CeleryShort = "/product/diet/short/celery";

            [Localization(Description = "Sesame seed", DefaultValue = "Seesaminsiemeniä")]
            public const string Sesame = "/product/diet/sesame";

            [Localization(Description = "Egg", DefaultValue = "Kananmunaa")]
            public const string Egg = "/product/diet/egg";

            [Localization(Description = "High fiber", DefaultValue = "Runsaskuituinen")]
            public const string HighFiber = "/product/diet/highfiber";


            [Localization(Description = "No additives", DefaultValue = "Lisäaineeton")]
            public const string NoAdditives = "/product/diet/noadditives";

            [Localization(Description = "No preservatives", DefaultValue = "Säilöntäaineeton")]
            public const string NoPreservatives = "/product/diet/nopreservatives";

            [Localization(Description = "Less salt", DefaultValue = "Vähemmän suolaa")]
            public const string LessSalt = "/product/diet/lesssalt";

            [Localization(Description = "Less salt", DefaultValue = "Ei lisättyä sokeria, sisältää luontaista sokeria")]
            public const string NoAddedSugar = "/product/diet/noaddedsugar";


            [Localization(Description = "Vegetarian", DefaultValue = "Soveltuu kasvisruokavalioon")]
            public const string Vegetarian = "/product/diet/vegetarian";

            [Localization(Description = "Vegetarian (short)", DefaultValue = "Kasvisruokavalio")]
            public const string VegetarianShort = "/product/diet/short/vegetarian";

            [Localization(Description = "Contains beef", DefaultValue = "Sisältää nautaa")]
            public const string Beef = "/product/diet/beef";

            [Localization(Description = "Contains beef (short)", DefaultValue = "Sis. nautaa")]
            public const string BeefShort = "/product/diet/short/beef";

            [Localization(Description = "Contains pork", DefaultValue = "Sisältää sikaa")]
            public const string Pork = "/product/diet/pork";

            [Localization(Description = "Contains pork (short)", DefaultValue = "Sis. sikaa")]
            public const string PorkShort = "/product/diet/short/pork";

            [Localization(Description = "Contains fish", DefaultValue = "Sisältää kalaa")]
            public const string Fish = "/product/diet/fish";

            [Localization(Description = "Contains fish (short)", DefaultValue = "Sis. kalaa")]
            public const string FishShort = "/product/diet/short/fish";

            [Localization(Description = "Contains garlic", DefaultValue = "Sisältää tuoretta valkosipulia")]
            public const string Garlic = "/product/diet/garlic";

            [Localization(Description = "Contains garlic (short)", DefaultValue = "Sis. tuoretta valkosipulia")]
            public const string GarlicShort = "/product/diet/short/garlic";

            [Localization(Description = "Gluten free", DefaultValue = "Gluteeniton")]
            public const string GlutenFree = "/product/diet/glutenfree";

            [Localization(Description = "Gluten free (short)", DefaultValue = "Gluteeniton")]
            public const string GlutenFreShort = "/product/diet/short/glutenfree";

            [Localization(Description = "Lactose free", DefaultValue = "Laktoositon (laktoosia < 0,01 g / 100 g)")]
            public const string LactoseFree = "/product/diet/lactosefree";

            [Localization(Description = "Lactose free (short)", DefaultValue = "Laktoositon")]
            public const string LactoseFreeShort = "/product/diet/short/lactosefree";

            [Localization(Description = "Contains allergens", DefaultValue = "Sisältää allergeeneja")]
            public const string Allergens = "/product/diet/allergens";

            [Localization(Description = "Contains allergens (short)", DefaultValue = "Sis. allergeeneja")]
            public const string AllergensShort = "/product/diet/short/allergens";

            [Localization(Description = "Healthy", DefaultValue = "Voi hyvin")]
            public const string Healthy = "/product/diet/healthy";

            [Localization(Description = "Healthy (short)", DefaultValue = "Voi hyvin")]
            public const string HealthyShort = "/product/diet/short/healthy";

            [Localization(Description = "Yes (contains)", DefaultValue = "Kyllä")]
            public const string ExistenceTrue = "/product/diet/contains/true";

            [Localization(Description = "No (contains)", DefaultValue = "Ei")]
            public const string ExistenceFalse = "/product/diet/contains/false";

            [Localization(Description = "Maybe (contains)", DefaultValue = "Saattaa sisältää")]
            public const string ExistenceMaybe = "/product/diet/contains/maybe";

            public static string TranslateDiet(string diet, bool useShort = false)
            {
                return (useShort) ? "/product/diet/short/" + diet.ToLower() : "/product/diet/" + diet.ToLower();
            }
        }

        [LocalizationCategory("Nutrients", 10200)]
        public static class Nutrients
        {
            [Localization(Description = "Nutrients (title)", DefaultValue = "Ravintosisältö")]
            public const string NutrientsHeading = "/product/nutrients/nutrientsheading";

            [Localization(Description = "Energy kJ", DefaultValue = "Energia kJ")]
            public const string EnergyKj = "/product/nutrient/energykJ";

            [Localization(Description = "Energy kcal", DefaultValue = "Energia kcal")]
            public const string EnergyKcal = "/product/nutrient/energykcal";

            [Localization(Description = "Fat", DefaultValue = "Rasva")]
            public const string Fat = "/product/nutrient/fat";

            [Localization(Description = "of which saturated fat", DefaultValue = "josta tyydyttynyttä")]
            public const string OfWhichFatSaturated = "/product/nutrient/ofwhichfatsaturated";

            [Localization(Description = "Carbohydrates", DefaultValue = "Hiilihydraatit")]
            public const string Carbohydrates = "/product/nutrient/carbohydrates";

            [Localization(Description = "of which sugar", DefaultValue = "josta sokeria")]
            public const string OfWhichSugar = "/product/nutrient/ofwhichsugar";

            [Localization(Description = "Protein", DefaultValue = "Proteiini")]
            public const string Protein = "/product/nutrient/protein";

            [Localization(Description = "Fiber", DefaultValue = "Ravintokuitu")]
            public const string Fiber = "/product/nutrient/fiber";

            [Localization(Description = "Salt", DefaultValue = "Suola")]
            public const string Salt = "/product/nutrient/salt";

            [Localization(Description = "GDA for adult", DefaultValue = "* Aikuisen viitteellisestä päiväsaannista (2 000 kcal ruokavalio)")]
            public const string GdaForAdult = "/product/nutrient/gdaforadult";

            [Localization(Description = "GDA disclaimer", DefaultValue = "Viitteellinen päiväsaanti (GDA) voi olla alhaisempi tai korkeampi. Yksilölliset ravitsemukselliset tarpeet vaihtelevat sukupuolesta, iästä, painosta ja liikunnan määrästä")]
            public const string GdaDisclaimer = "/product/nutrient/gdadisclaimer";

            [Localization(Description = "(GDA) per {0} grams", DefaultValue = "{0} g tuotetta sisältää")]
            public const string GdaPerGivenGramsTemplate = "/product/nutrient/gdaperxgrams";

            [Localization(Description = "(GDA) per {0} piece ({1} grams)", DefaultValue = "{0} kpl ({1} g) tuotetta sisältää")]
            public const string GdaPerPieceTemplate = "/product/nutrient/gdaperpiece";

            [Localization(Description = "Gda per hundred grams - row heading", DefaultValue = "per 100g")]
            public const string GdaPerGramsRowHeading = "/product/nutrient/gdapergramsrowheading";

            [Localization(Description = "Gda - row heading", DefaultValue = "GDA")]
            public const string GdaRowHeading = "/product/nutrient/gdarowheading";
        }

        [LocalizationCategory("Restaurant Page", 20000)]
        public static class RestaurantPage
        {
            [Localization(Description = "Add to favorites", DefaultValue = "Lisää suosikiksi")]
            public const string AddToFavorites = "/restaurantpage/addtofavorites";

            [Localization(Description = "Remove from favorites", DefaultValue = "Poista suosikeista")]
            public const string RemoveFromFavorites = "/restaurantpage/removefromfavorites";

            [Localization(Description = "Feedback", DefaultValue = "Anna palautetta")]
            public const string Feedback = "/restaurantpage/feedback";

            [Localization(Description = "Restaurant articles", DefaultValue = "Ravintolakohtaista")]
            public const string RestaurantArticles = "/restaurantpage/restaurantarticles";

            [Localization(Description = "Feedback content", DefaultValue = "Palaute")]
            public const string FeedbackContent = "/restaurantpage/feedbackcontent";

            [Localization(Description = "Name", DefaultValue = "Nimi")]
            public const string Name = "/restaurantpage/name";

            [Localization(Description = "Email", DefaultValue = "Sähköposti")]
            public const string Email = "/restaurantpage/email";

            [Localization(Description = "Telephone costs: lan-line", DefaultValue = "Lankapuhelimesta 8,21 snt/puhelu + 1,47 snt/min")]
            public const string TelephoneCostsLanLine = "/restaurantpage/telephonecostslanline";

            [Localization(Description = "Telephone costs: mobile", DefaultValue = "Matkapuhelimesta 8,21 snt/puhelu + 16,42 snt/min")]
            public const string TelephoneCostsMobile = "/restaurantpage/telephonecostsmobile";

            [Localization(Description = "Submit feedback", DefaultValue = "Lähetä palaute")]
            public const string SubmitFeedback = "/restaurantpage/submitfeedback";

            [Localization(Description = "Thank you for your feedback", DefaultValue = "Kiitos palautteestasi")]
            public const string ThankYouForYourFeedback = "/restaurantpage/thankyouforyourfeedback";

            [Localization(Description = "Your feedback  is important to us", DefaultValue = "Saamamme palaute on meille ensiarvoisen tärkeää.")]
            public const string YourFeedbackIsImportant = "/restaurantpage/yourfeedbackisimportant";

            [Localization(Description = "Return to the restaurants page", DefaultValue = "Palaa takaisin ravintolan sivulle")]
            public const string ReturnToRestaurant = "/restaurantpage/returntorestaurant";

            [Localization(Description = "Search restaurants", DefaultValue = "Hae ravintoloita")]
            public const string SearchRestaurants = "/restaurantpage/searchrestaurants";
        }

        [LocalizationCategory("Restaurant Menu", 30000)]
        public static class RestaurantMenu
        {
            [Localization(Description = "Restaurant menus", DefaultValue = "Ruokalistat")]
            public const string RestaurantMenus = "/restaurantmenu/restaurantmenus";

            [Localization(Description = "Favorite", DefaultValue = "Suosikki")]
            public const string Favorite = "/restaurantmenu/favorite";

            [Localization(Description = "Location", DefaultValue = "Sijantisi")]
            public const string Location = "/restaurantmenu/location";

            [Localization(Description = "Change address", DefaultValue = "Vaihda osoitetta")]
            public const string ChangeAddress = "/restaurantmenu/changeaddress";

            [Localization(Description = "Favorite restaurants", DefaultValue = "Suosikki-ravintolasi")]
            public const string FavoriteRestaurants = "/restaurantmenu/favoriterestaurants";

            [Localization(Description = "Restaurants nearby", DefaultValue = "Ravintolat lähelläsi")]
            public const string RestaurantsNearby = "/restaurantmenu/restaurantsnearby";

            [Localization(Description = "No restaurants", DefaultValue = "Ei ravintoloita")]
            public const string NoRestaurants = "/restaurantmenu/norestaurants";

            [Localization(Description = "Unable to locate", DefaultValue = "Paikannus epäonnistui")]
            public const string UnableToLocate = "/restaurantmenu/unabletolocate";

            [Localization(Description = "View restaurant's page", DefaultValue = "Siirry ravintolan sivulle")]
            public const string ViewRestaurantsPage = "/restaurantmenu/viewrestaurantspage";

            [Localization(Description = "Available today", DefaultValue = "Tarjolla tänään")]
            public const string AvailableToday = "/restaurantmenu/availabletoday";

            [Localization(Description = "Available for week", DefaultValue = "Tarjolla viikolla")]
            public const string AvailableForWeek = "/restaurantmenu/availableforweek";

            [Localization(Description = "Filter according to diet", DefaultValue = "Rajaa ruokavaliosi mukaan")]
            public const string FilterAccordingToDiet = "/restaurantmenu/filteraccordingtodiet";

            [Localization(Description = "Subscribe menu", DefaultValue = "Tilaa lista")]
            public const string SubscribeMenu = "/restaurantmenu/subscribemenu";

            [Localization(Description = "Subscribe lunch menu", DefaultValue = "Tilaa lounaslista")]
            public const string SubscribeLunchMenu = "/restaurantmenu/subscribelunchmenu";

            [Localization(Description = "Print menu", DefaultValue = "Tulosta lista")]
            public const string PrintMenu = "/restaurantmenu/printmenu";

            [Localization(Description = "Show only", DefaultValue = "Näytä vain")]
            public const string ShowOnly = "/restaurantmenu/showonly";

            [Localization(Description = "Hide", DefaultValue = "Älä näytä")]
            public const string Hide = "/restaurantmenu/hide";

            [Localization(Description = "Show entire week", DefaultValue = "Näytä koko viikko")]
            public const string ShowEntireWeek = "/restaurantmenu/showentireweek";

            [Localization(Description = "Show only today", DefaultValue = "Näytä vain tämä päivä")]
            public const string ShowOnlyToday = "/restaurantmenu/showonlytoday";

            [Localization(Description = "Show next week", DefaultValue = "Näytä seuraava viikko")]
            public const string ShowNextWeek = "/restaurantmenu/shownextweek";

            [Localization(Description = "Previous week", DefaultValue = "Edellinen viikko")]
            public const string PreviousWeek = "/restaurantmenu/previousweek";

            [Localization(Description = "Next week", DefaultValue = "Seuraava viikko")]
            public const string NextWeek = "/restaurantmenu/nextweek";

            [Localization(Description = "Print lunchlist for week", DefaultValue = "Tulosta viikon lounaslista")]
            public const string PrintLunchlistForWeek = "/restaurantmenu/printlunchlistforweek";

            [Localization(Description = "Print lunchlist for today", DefaultValue = "Tulosta päivän lounaslista")]
            public const string PrintLunchlistForToday = "/restaurantmenu/printlunchlistfortoday";

            [Localization(Description = "Download menu with product data sheet", DefaultValue = "Lataa ruokalista tuoteselosteilla")]
            public const string MenuWithProductDataSheet = "/restaurantmenu/menuwithproductdatasheet";

            [Localization(Description = "See order selection", DefaultValue = "Siirry tilausvalikoimaan")]
            public const string OrderSelectionLinkText = "/restaurantmenu/orderselectionlinktext";

            [Localization(Description = "No menu available", DefaultValue = "Ei ruokalistaa saatavilla")]
            public const string NoMenuAvailable = "/restaurantmenu/nomenuavailable";

            [Localization(Description = "No lunch-service", DefaultValue = "Ei lounas-palvelua")]
            public const string NoLunchService = "/restaurantmenu/nolunchservice";

        }

        [LocalizationCategory("Order Page", 40000)]
        public static class OrderPage
        {
            [Localization(Description = "Order forms", DefaultValue = "Tilauslomakkeet")]
            public const string OrderForms = "/orderpage/orderforms";

            [Localization(Description = "Products", DefaultValue = "Tuotteet")]
            public const string Products = "/orderpage/products";

            [Localization(Description = "pc", DefaultValue = "kpl")]
            public const string Pc = "/orderpage/pc";

            [Localization(Description = "Buy", DefaultValue = "Osta")]
            public const string Buy = "/orderpage/buy";

            [Localization(Description = "Add products to your shopping cart", DefaultValue = "Lisää tuotteita ostoskoriisi")]
            public const string ProductsToShoppingCart = "/orderpage/productstoshoppingcart";

            [Localization(Description = "See product data sheet", DefaultValue = "Katso tarkemmat tuotetiedot")]
            public const string SeeProductDataSheet = "/orderpage/seeproductdatasheet";

            [Localization(Description = "Added to shopping cart", DefaultValue = "Lisätty ostoskoriin")]
            public const string AddedToShoppingCart = "/orderpage/addedtoshoppingcart";

            [Localization(Description = "Shopping cart", DefaultValue = "Ostoskori")]
            public const string ShoppingCart = "/orderpage/shoppingcart";

            [Localization(Description = "Select product quantities", DefaultValue = "Valitse tuotteiden tilausmäärä")]
            public const string SelectProductQuantities = "/orderpage/selectproductquantities";

            [Localization(Description = "Product", DefaultValue = "Tuote")]
            public const string Product = "/orderpage/product";

            [Localization(Description = "Quantity", DefaultValue = "Lukumäärä")]
            public const string Quantity = "/orderpage/quantity";

            [Localization(Description = "Price", DefaultValue = "Hinta")]
            public const string Price = "/orderpage/price";

            [Localization(Description = "Sum", DefaultValue = "Summa")]
            public const string Sum = "/orderpage/sum";

            [Localization(Description = "Total", DefaultValue = "Yhteensä")]
            public const string Total = "/orderpage/total";

            [Localization(Description = "Prices incl. VAT", DefaultValue = "Hinnat sisältävät ALV:n")]
            public const string PricesIncludeVat = "/orderpage/pricesincludevat";

            [Localization(Description = "Customer information", DefaultValue = "Tilaajan tiedot")]
            public const string CustomerInformation = "/orderpage/customerinformation";

            [Localization(Description = "Additional information", DefaultValue = "Lisätietoja")]
            public const string AdditionalInformation = "/orderpage/additionalinformation";

            [Localization(Description = "Write your message", DefaultValue = "Kirjoita viestisi")]
            public const string WriteYourMessage = "/orderpage/writeyourmessage";

            [Localization(Description = "Pickup date", DefaultValue = "Noutopäivämäärä")]
            public const string PickupDate = "/orderpage/pickupdate";

            [Localization(Description = "I accept", DefaultValue = "Hyväksyn")]
            public const string IAccept = "/orderpage/iaccept";

            [Localization(Description = "the terms and conditions", DefaultValue = "tilaus- ja toimitusehdot")]
            public const string TheTermsAndConditions = "/orderpage/thetermsandconditions";

            [Localization(Description = "Order summary", DefaultValue = "Tilaustiedot")]
            public const string OrderSummary = "/orderpage/ordersummary";

            [Localization(Description = "Please check your order", DefaultValue = "Tarkista vielä tilauksesi")]
            public const string PleaseCheckYourOrder = "/orderpage/pleasecheckyourorder";

            [Localization(Description = "Order", DefaultValue = "Tilaa")]
            public const string Order = "/orderpage/order";

            [Localization(Description = "Thank you for your order", DefaultValue = "Kiitos tilauksestasi")]
            public const string OrderThankYou = "/orderpage/orderthankyou";

            [Localization(Description = "Order has been sent", DefaultValue = "Tilauksesi on lähetetty onnistuneesti, saat pian vahvistuksen sähköpostiisi.")]
            public const string OrderHasBeenSent = "/orderpage/orderhasbeensent";
        }

        [LocalizationCategory("Order Acknowledgement Email", 50000)]
        public static class OrderAcknowledgementEmail
        {
            [Localization(Description = "Order summary", DefaultValue = "Tilauskooste")]
            public const string OrderSummary = "/orderacknowledgementemail/ordersummary";

            [Localization(Description = "Ordered products", DefaultValue = "Tilatut tuotteet")]
            public const string OrderedProducts = "/orderacknowledgementemail/orderedproducts";

            [Localization(Description = "Order pickup date is", DefaultValue = "Tilauksen noutopäivä on")]
            public const string OrderPickupDate = "/orderacknowledgementemail/orderpickupdate";

        }

        [LocalizationCategory("Event", 60000)]
        public static class Event
        {

            [Localization(Description = "Event", DefaultValue = "Tapahtuma")]
            public const string EventText = "/event/event";

            [Localization(Description = "Move to event-calendar", DefaultValue = "Siirry tapahtumakalenteriin")]
            public const string MoveToEventCalendar = "/event/movetoeventcalendar";

            [Localization(Description = "Year", DefaultValue = "Vuosi")]
            public const string Year = "/event/year";

            [Localization(Description = "Month", DefaultValue = "Kuukausi")]
            public const string Month = "/event/month";

            [Localization(Description = "Event type", DefaultValue = "Tapahtumatyyppi")]
            public const string EventType = "/event/eventtype";

            [Localization(Description = "Move to event-page", DefaultValue = "Siirry tapahtuman sivulle")]
            public const string MoveToEventPage = "/event/movetoeventpage";

            [Localization(Description = "Event dates title", DefaultValue = "Tapahtuma-aika")]
            public const string EventDatesTitle = "/event/eventdatestitle";

            [Localization(Description = "Starts", DefaultValue = "Alkaa")]
            public const string Starts = "/event/starts";

            [Localization(Description = "Ends", DefaultValue = "Päättyy")]
            public const string Ends = "/event/ends";
        }

        [LocalizationCategory("Commerce Admin Tool", 70000)]
        public static class CommerceAdminTool
        {
            [Localization(Description = "Warehouse", DefaultValue = "Varasto")]
            public const string Warehouse = "/commerceadmintool/warehouse";

            [Localization(Description = "Status", DefaultValue = "Tila")]
            public const string Status = "/commerceadmintool/status";

            [Localization(Description = "Created from", DefaultValue = "Luotu alkaen")]
            public const string CreatedFrom = "/commerceadmintool/createdfrom";

            [Localization(Description = "Created to", DefaultValue = "Luotu viimeistään")]
            public const string CreatedTo = "/commerceadmintool/createdto";

            [Localization(Description = "Search shipments", DefaultValue = "Hae tilauksia")]
            public const string SearchShipments = "/commerceadmintool/searchshipments";

            [Localization(Description = "Download", DefaultValue = "Lataa")]
            public const string Download = "/commerceadmintool/download";

            [Localization(Description = "Mark as shipped", DefaultValue = "Merkkaa lähetetyksi")]
            public const string MarkAsShipped = "/commerceadmintool/markasshipped";

            [Localization(Description = "Order processing", DefaultValue = "Tilausten käsittely")]
            public const string OrderProcessing = "/commerceadmintool/orderprocessing";

            [Localization(Description = "Mark as shipped confirmation", DefaultValue = "Haluatko varmasti merkata tilaukset lähetetyksi?")]
            public const string MarkAsShippedConfirmation = "/commerceadmintool/markasshippedconfirmation";

            [Localization(Description = "Mark", DefaultValue = "Merkkaa")]
            public const string Mark = "/commerceadmintool/mark";

            [Localization(Description = "Do not mark", DefaultValue = "Älä merkkaa")]
            public const string DoNotMark = "/commerceadmintool/donotmark";
        }

        [LocalizationCategory("Shop products", 75000)]
        public static class ShopProducts
        {
            [Localization(Description = "Currently unavailable", DefaultValue = "Tilapäisesti loppu")]
            public const string CurrentlyUnavailable = "/shopproducts/currentlyunavailable";
        }

        [LocalizationCategory("Shopping cart", 80000)]
        public static class CommerceShoppingCart
        {
            [Localization(Description = "Shopping cart", DefaultValue = "Ostoskori")]
            public const string ShoppingCartText = "/commerceshoppingcart/shoppingcarttext";

            [Localization(Description = "Shopping cart is empty", DefaultValue = "Ostoskori on tyhjä")]
            public const string ShoppingCartIsEmpty = "/commerceshoppingcart/shoppingcartisempty";

            [Localization(Description = "Add to cart", DefaultValue = "Lisää koriin")]
            public const string AddToCart = "/commerceshoppingcart/addtocart";

            [Localization(Description = "Adding", DefaultValue = "Lisätään")]
            public const string Adding = "/commerceshoppingcart/adding";

            [Localization(Description = "Added to cart", DefaultValue = "lisätty koriin")]
            public const string AddedToCart = "/commerceshoppingcart/addedtocart";

            [Localization(Description = "Product added to cart", DefaultValue = "Tuote lisätty koriin")]
            public const string ProductAddedToCart = "/commerceshoppingcart/productaddedtocart";

            [Localization(Description = "Productnum", DefaultValue = "Tuotenro")]
            public const string ProductNumber = "/commerceshoppingcart/productnum";

            [Localization(Description = "Remove", DefaultValue = "Poista")]
            public const string Remove = "/commerceshoppingcart/remove";

            [Localization(Description = "Incl. VAT", DefaultValue = "sis. ALV")]
            public const string InclVat = "/commerceshoppingcart/inclvat";

            [Localization(Description = "VAT", DefaultValue = "ALV")]
            public const string Vat = "/commerceshoppingcart/vat";

            [Localization(Description = "Total", DefaultValue = "Yhteensä")]
            public const string Total = "/commerceshoppingcart/total";

            [Localization(Description = "Products total", DefaultValue = "Tuotteet yhteensä")]
            public const string ProductsTotal = "/commerceshoppingcart/productstotal";

            [Localization(Description = "Products VAT total", DefaultValue = "Tuotteiden ALV yhteensä")]
            public const string ProductsVatTotal = "/commerceshoppingcart/productsvattotal";

            [Localization(Description = "Shipping costs are added to the total price of the order", DefaultValue = "Toimituskulut lisätään tilauksen hintaan")]
            public const string ShippingCostsAreAdded = "/commerceshoppingcart/shippingcostsareadded";

            [Localization(Description = "Choose more products", DefaultValue = "Valitse lisää tuotteita")]
            public const string ChooseMoreProducts = "/commerceshoppingcart/choosemoreproducts";

            [Localization(Description = "Empty shopping cart", DefaultValue = "Tyhjennä ostoskori")]
            public const string EmptyShoppingCart = "/commerceshoppingcart/emptyshoppingcart";

            [Localization(Description = "Move to checkout", DefaultValue = "Siirry kassalle")]
            public const string MoveToCheckout = "/commerceshoppingcart/movetocheckout";

            [Localization(Description = "Gift added to cart", DefaultValue = "Lahja lisätty koriin")]
            public const string GiftAddedToCart = "/commerceshoppingcart/giftaddedtocart";

            [Localization(Description = "You can choose multiple gifts and send them to multiple recipients at once", DefaultValue = "Halutessasi voit valita useita lahjoja ja lähettää ne eri vastaanottajille kerralla.")]
            public const string ChooseMultipleGifts = "/commerceshoppingcart/choosemultiplegifts";

            [Localization(Description = "Choose more gifts", DefaultValue = "Valitse lisää lahjoja")]
            public const string ChooseMoreGifts = "/commerceshoppingcart/choosemooregifts";

            [Localization(Description = "Send gift now", DefaultValue = "Lähetä lahja nyt")]
            public const string SendGiftNow = "/commerceshoppingcart/sendgiftnow";

        }

        [LocalizationCategory("Checkout page", 90000)]
        public static class ShopCheckout
        {
            [Localization(Description = "Shopping cart summary", DefaultValue = "Ostoskorin yhteenveto")]
            public const string ShoppingCartSummary = "/shopcheckout/shoppingcartsummary";

            [Localization(Description = "Shopping cart merged title", DefaultValue = "Keskeneräinen ostoskori löytynyt")]
            public const string ShoppingCartMergedTitle = "/shopcheckout/shoppingcartmergedtitle";

            [Localization(Description = "Shopping cart merged text", DefaultValue = "Tunnuksellasi on löytynyt keskeneräinen ostoskori ja tämä on yhdistetty nykyiseen ostoskoriisi.")]
            public const string ShoppingCartMergedText = "/shopcheckout/shoppingcartmergedtext";

            [Localization(Description = "Customer information and shipping", DefaultValue = "Asiakastiedot ja toimitustapa")]
            public const string CustomerInformationAndShipping = "/shopcheckout/customerinformationandshipping";

            [Localization(Description = "Confirm order", DefaultValue = "Vahvista tilaus")]
            public const string ConfirmOrder = "/shopcheckout/confirmorder";

            [Localization(Description = "Customer information", DefaultValue = "Asiakastiedot")]
            public const string CustomerInformation = "/shopcheckout/customerinformation";

            [Localization(Description = "Please check marked fields", DefaultValue = "Ole hyvä ja tarkista merkityt kentät")]
            public const string PleaseCheckMarkedFields = "/shopcheckout/pleasecheckmarkedfields";

            [Localization(Description = "Check field", DefaultValue = "Tarkista kenttä")]
            public const string CheckField = "/shopcheckout/checkfield";

            [Localization(Description = "Continue to customer information", DefaultValue = "Jatka asiakastietoihin")]
            public const string ContinueToCustomerInformation = "/shopcheckout/continuetocustomerinformation";

            [Localization(Description = "Do you already have an account?", DefaultValue = "Onko sinulla jo myCompany tunnus?")]
            public const string DoYouAlreadyHaveAnAccount = "/shopcheckout/doyoualreadyhaveanaccount";

            [Localization(Description = "Log in to use your account", DefaultValue = "Kirjaudu sisään käyttääksesi tunnukseesi tallennettuja yhteystietoja")]
            public const string LogInToUseYourAccount = "/shopcheckout/logintouseyouraccount";

            [Localization(Description = "No account? Please fill in the information", DefaultValue = "Ei tunnusta? Ole hyvä ja täytä tiedot")]
            public const string NoAccountFillInInformation = "/shopcheckout/noaccountfillininformation";

            [Localization(Description = "Fill in information footnote", DefaultValue = "Samalla luot myCompany-tunnuksen. Sillä käytät kätevästi kaikkia myCompanyin verkkopalveluja.")]
            public const string FillInInformationFootnote = "/shopcheckout/fillininformationfootnote";

            [Localization(Description = "Check customer information", DefaultValue = "Tarkista asiakastiedot")]
            public const string CheckCustomerInformation = "/shopcheckout/checkcustomerinformation";

            [Localization(Description = "Check customer information footnote", DefaultValue = "Tiedot on täytetty myCompany-tunnuksesi tiedoista. Tarkistathan, että ne ovat ajan tasalla.")]
            public const string CheckCustomerInformationFootnote = "/shopcheckout/checkcustomerinformationfootnote";

            [Localization(Description = "Own information", DefaultValue = "Omat tiedot")]
            public const string OwnInformation = "/shopcheckout/owninformation";

            [Localization(Description = "Subscriber information", DefaultValue = "Tilaajan tiedot")]
            public const string SubscriberInformation = "/shopcheckout/subscriberinformation";

            [Localization(Description = "Email as username notification", DefaultValue = "Sähköpostiosoite toimii käyttäjätunnuksenasi myCompanyin verkkopalveluissa")]
            public const string EmailAsUsernameNotification = "/shopcheckout/emailasusernamenotification";

            [Localization(Description = "Customer type", DefaultValue = "Asiakkuustyyppi")]
            public const string CustomerType = "/shopcheckout/customertype";

            [Localization(Description = "Shipping address is same as billing address", DefaultValue = "Tilauksen toimitusosoite on sama kuin tilaajan osoite")]
            public const string ShippingAddressIsSameAsBillingAddress = "/shopcheckout/shippingaddressissameasbillingaddress";

            [Localization(Description = "Billing address", DefaultValue = "Laskutusosoite")]
            public const string BillingAddress = "/shopcheckout/billingaddress";

            [Localization(Description = "Shipping address", DefaultValue = "Toimitusosoite")]
            public const string ShippingAddress = "/shopcheckout/shippingaddress";

            [Localization(Description = "Choose delivery method", DefaultValue = "Valitse toimitustapa")]
            public const string ChooseDeliveryMethod = "/shopcheckout/choosedeliverymethod";

            [Localization(Description = "Search pickup point with postal code", DefaultValue = "Hae pakettiautomaatti postinumerolla")]
            public const string SearchPickupPointWithPostalCode = "/shopcheckout/searchpickuppointwithpostalcode";

            [Localization(Description = "Choose pickup point", DefaultValue = "Ole hyvä ja valitse noutopiste")]
            public const string ChoosePickupPoint = "/shopcheckout/choosepickuppoint";

            [Localization(Description = "Pickup point", DefaultValue = "Noutopiste")]
            public const string PickupPoint = "/shopcheckout/pickuppoint";

            [Localization(Description = "Proceed with order", DefaultValue = "Jatka tilausta")]
            public const string ProceedWithOrder = "/shopcheckout/proceedwithorder";

            [Localization(Description = "Account creation footnote", DefaultValue = "Tilauksen yhteydessä sinulle luodaan myCompany-tunnus. Jatkamalla vahvistat, että hyväksyt")]
            public const string AccountCreationFootnote = "/shopcheckout/accountcreationfootnote";

            [Localization(Description = "Terms of use (lower case)", DefaultValue = "palvelun käyttöehdot")]
            public const string TermsOfUseLowerCase = "/shopcheckout/termsofuselowercase";

            [Localization(Description = "Product", DefaultValue = "Tuote")]
            public const string Product = "/shopcheckout/product";

            [Localization(Description = "Quantity", DefaultValue = "Määrä")]
            public const string Quantity = "/shopcheckout/quantity";

            [Localization(Description = "Product and quantity", DefaultValue = "Tuote ja määrä")]
            public const string ProductAndQuantity = "/shopcheckout/productandquantity";

            [Localization(Description = "Price (lower case)", DefaultValue = "hinta")]
            public const string PriceLowerCase = "/shopcheckout/pricelowercase";

            [Localization(Description = "pc", DefaultValue = "kpl")]
            public const string Pc = "/shopcheckout/pc";

            [Localization(Description = "Shipping costs", DefaultValue = "Toimituskulut")]
            public const string ShippingCosts = "/shopcheckout/shippingcosts";

            [Localization(Description = "Additional information", DefaultValue = "Tilauksen lisätiedot / viesti")]
            public const string AdditionalInformation = "/shopcheckout/additionalInformation";

            [Localization(Description = "Additional information invoice addition", DefaultValue = "(esim. laskutusosoite, yhteyshenkilö, kustannuspaikka)")]
            public const string AdditionalInformationInvoiceAddition = "/shopcheckout/additionalInformationinvoiceaddition";

            [Localization(Description = "Payment method", DefaultValue = "Maksutapa")]
            public const string PaymentMethod = "/shopcheckout/paymentmethod";

            [Localization(Description = "Choose payment method", DefaultValue = "Valitse maksutapa")]
            public const string ChoosePaymentMethod = "/shopcheckout/choosepaymentmethod";

            [Localization(Description = "Ovt-identifier", DefaultValue = "Ovt-tunnus")]
            public const string OvtIdentifier = "/shopcheckout/ovtidentifier";

            [Localization(Description = "Invoice payment notification", DefaultValue = "Ole hyvä ja täytä lisätietokenttään laskutustiedot (esim. laskutusosoite, yhteyshenkilö, kustannuspaikka)")]
            public const string InvoicePaymentNotification = "/shopcheckout/invoicepaymentnotification";

            [Localization(Description = "Confirm and pay order", DefaultValue = "Vahvista ja maksa tilaus")]
            public const string ConfirmAndPayOrder = "/shopcheckout/confirmandpayorder";

            [Localization(Description = "Confirm and send order", DefaultValue = "Vahvista ja lähetä tilaus")]
            public const string ConfirmAndSendOrder = "/shopcheckout/confirmandsendorder";

            [Localization(Description = "By continuing you accept", DefaultValue = "Jatkamalla tilausta vahvistat, että hyväksyt")]
            public const string ByContinuingYouAccept = "/shopcheckout/bycontinuingyouaccept";

            [Localization(Description = "The terms and conditions (lower case)", DefaultValue = "toimitusehdot sekä palvelun käyttöehdot")]
            public const string TheTermsAndConditions = "/shopcheckout/thetermsandconditions";

            [Localization(Description = "Thank you for your order", DefaultValue = "Kiitos tilauksestasi!")]
            public const string ThankYouForYourOrder = "/shopcheckout/thankyouforyourorder";

            [Localization(Description = "Order number", DefaultValue = "Tilausnumero")]
            public const string OrderNumber = "/shopcheckout/ordernumber";

            [Localization(Description = "Print receipt", DefaultValue = "Tulosta kuitti")]
            public const string PrintReceipt = "/shopcheckout/printreceipt";

            [Localization(Description = "Order confirmation", DefaultValue = "Tilausvahvistus")]
            public const string OrderConfirmation = "/shopcheckout/orderconfirmation";

            [Localization(Description = "Order has been cancelled", DefaultValue = "Tilaus on peruutettu")]
            public const string OrderHasBeenCancelled = "/shopcheckout/orderhasbeencancelled";

            [Localization(Description = "Your order has been cancelled", DefaultValue = "Tilauksesi on peruutettu")]
            public const string YourOrderHasBeenCancelled = "/shopcheckout/yourorderhasbeencancelled";

            [Localization(Description = "Ordering from users country not available", DefaultValue = "Tilaaminen ei valitettavasti ole mahdollista tietoihisi määritetystä maasta.")]
            public const string OrderCountryNotAvailable = "/shopcheckout/ordercountrynotavailable";

            [Localization(Description = "Error creating order", DefaultValue = "Virhe tilauksen luonnissa, tarkista tiedot ja yritä uudelleen")]
            public const string ErrorCreatingOrder = "/shopcheckout/errorcreatingorder";

            [Localization(Description = "Move to MyPage", DefaultValue = "Siirry omiin tietoihin")]
            public const string MoveToMyPage = "/shopcheckout/movetomypage";

            [Localization(Description = "Ordering not available from current account", DefaultValue = "Et ole kirjautunut myCompany-tunnuksilla, tilaaminen on estetty.")]
            public const string OrderingNotAvailableFromCurrentAccount = "/shopcheckout/orderingnotavailablefromcurrentaccount";

            [Localization(Description = "Incl. VAT", DefaultValue = "sis. ALV")]
            public const string InclVat = "/shopcheckout/inclvat";

            [Localization(Description = "Products total", DefaultValue = "Tuotteet yhteensä")]
            public const string ProductsTotal = "/shopcheckout/productstotal";

            [Localization(Description = "Order total excl. VAT", DefaultValue = "Kokonaishinta ilman ALV")]
            public const string OrderTotalExclVat = "/shopcheckout/ordertotalexclvat";

            [Localization(Description = "Products VAT total", DefaultValue = "Tuotteiden ALV yhteensä")]
            public const string ProductsVatTotal = "/shopcheckout/productsvattotal";

            [Localization(Description = "Order total", DefaultValue = "Tilauksen kokonaishinta")]
            public const string OrderTotal = "/shopcheckout/ordertotal";

            [Localization(Description = "Total", DefaultValue = "Yhteensä")]
            public const string Total = "/shopcheckout/total";

            [Localization(Description = "Shipping-method and date and recipient", DefaultValue = "Toimitustapa ja -päivämäärä sekä vastaanottaja")]
            public const string ShippingMethodAndDateAndRecipient = "/shopcheckout/shippingmethodanddateandrecipient";

            [Localization(Description = "Incl VAT and shipping costs", DefaultValue = "sis. ALV ja toimituskulut")]
            public const string InclVatAndShippingCosts = "/shopcheckout/inclvatandshippingcosts";

            [Localization(Description = "Confirm order notification", DefaultValue = "Huom! Vahvistuksen jälkeen tilausta ei voi enää muokata!")]
            public const string ConfirmOrderNotification = "/shopcheckout/confirmordernotification";

            [Localization(Description = "Eligible for free dispenser checkbox text", DefaultValue = "Kyllä! Olen tilannut vähintään 10 kg ksylitolipastilleja tai purukumia ja saan annostelijan veloituksetta (1 annostelija/tilaus)")]
            public const string EligibleForFreeDispenserCheckboxText = "/shopcheckout/eligibleforfreedispensercheckboxtext";

        }

        [LocalizationCategory("Gifting: Checkout page", 90001)]
        public static class GiftingShopCheckout
        {
            [Localization(Description = "Choose a gift", DefaultValue = "Valitse lahja")]
            public const string ChooseAGift = "/giftingshopcheckout/chooseagift";

            [Localization(Description = "Packaging", DefaultValue = "Paketointi")]
            public const string Packaging = "/giftingshopcheckout/packaging";

            [Localization(Description = "Gift", DefaultValue = "Lahja")]
            public const string Gift = "/giftingshopcheckout/gift";

            [Localization(Description = "Own information", DefaultValue = "Omat tiedot")]
            public const string OwnInformation = "/giftingshopcheckout/owninformation";

            [Localization(Description = "Show product details & allergenes", DefaultValue = "Näytä tuote- ja allergiatiedot")]
            public const string ShowProductAndAllergyDetails = "/giftingshopcheckout/showproductandallergydetails";

            [Localization(Description = "Selectable cards", DefaultValue = "Korttivaihtoehdot")]
            public const string SelectableCards = "/giftingshopcheckout/selectablecards";

            [Localization(Description = "Write a greeting", DefaultValue = "Kirjoita tervehdys")]
            public const string WriteGreeting = "/giftingshopcheckout/writeagreeting";

            [Localization(Description = "Greeting text for the card", DefaultValue = "Tervehdysteksti korttiin")]
            public const string GreetingTextCard = "/giftingshopcheckout/greetingtextforcard";

            [Localization(Description = "Empty greeting text confirmation", DefaultValue = "Haluatko varmasti jättää tervehdystekstin tyhjäksi?")]
            public const string EmptyGreetingTextConfirmation = "/giftingshopcheckout/emptygreetingtextconfirmation";

            [Localization(Description = "Desired delivery date", DefaultValue = "Toivottu toimitusajankohta")]
            public const string DesiredDeliveryDate = "/giftingshopcheckout/desireddeliverydate";

            [Localization(Description = "As soon as possible", DefaultValue = "Mahdollisimman pian")]
            public const string AsSoonAsPossible = "/giftingshopcheckout/assoonaspossible";

            [Localization(Description = "Please choose desired delivery date", DefaultValue = "Ole hyvä ja valitse päivämäärä")]
            public const string ChooseDeliveryDate = "/giftingshopcheckout/choosedeliverydate";

            [Localization(Description = "Certain date", DefaultValue = "Tiettynä päivänä")]
            public const string CertainDate = "/giftingshopcheckout/certaindate";

            [Localization(Description = "Address of a person receiving the gift", DefaultValue = "Lahjan saajan tiedot")]
            public const string PersonAddressReceivingGift = "/giftingshopcheckout/personaddressreceivinggift";

            [Localization(Description = "Additional information", DefaultValue = "Toimituksen lisätiedot (esim. ovikoodi)")]
            public const string AdditionalInformation = "/giftingshopcheckout/additionalInformation";

            [Localization(Description = "Continue to next gift", DefaultValue = "Jatka seuraavaan lahjaan")]
            public const string ContinueToNextGift = "/giftingshopcheckout/continuetonextgift";

            [Localization(Description = "Continue to own information", DefaultValue = "Jatka omiin tietoihin")]
            public const string ContinueToOwnInformation = "/giftingshopcheckout/continuetoowninformation";

            [Localization(Description = "Continue to payment", DefaultValue = "Jatka maksuun")]
            public const string ContinueToPayment = "/giftingshopcheckout/continuetopayment";

            [Localization(Description = "Send same gift to another person", DefaultValue = "Lähetä samanlainen jollekulle toiselle")]
            public const string SendSameGiftAnotherPerson = "/giftingshopcheckout/sendsamegiftanotherperson";

            [Localization(Description = "Create myCompany account", DefaultValue = "Luo tiedoillani myCompany-tunnus")]
            public const string CreatemyCompanyAccount = "/giftingshopcheckout/createmyCompanyaccount";

            [Localization(Description = "Account speeds up entering information in the future", DefaultValue = "Tunnus nopeuttaa tietojen syöttöä jatkossa")]
            public const string AccountSpeedsUpEnteringInformationInTheFuture = "/giftingshopcheckout/accountspeedsupenteringinformationinthefuture";

            [Localization(Description = "We will deliver the gift on closest weekday", DefaultValue = "Toimitamme tuotteen lähimpänä arkipäivänä.")]
            public const string WeekendSelected = "/giftingshopcheckout/weekendselected";

            [Localization(Description = "Greeting title", DefaultValue = "Otsikko")]
            public const string GreetingTitle = "/giftingshopcheckout/greetingtitle";

            [Localization(Description = "Remove gift confirmation", DefaultValue = "Haluatko varmasti poistaa lahjan?")]
            public const string RemoveGiftConfirmation = "/giftingshopcheckout/removegiftconfirmation";

            [Localization(Description = "Fill information or", DefaultValue = "Täytä tiedot tai")]
            public const string FillInformationOr = "/giftingshopcheckout/fillininformationor";

            [Localization(Description = "Login with myCompany-account (lower case)", DefaultValue = "kirjaudu myCompany-tunnuksella")]
            public const string LoginWithmyCompanyAccountLowerCase = "/giftingshopcheckout/loginwithmyCompanyaccountlowercase";

            [Localization(Description = "Product is not currently available", DefaultValue = "Tuote ei valitettavasti ole tällä hetkellä saatavilla")]
            public const string ProductIsNotCurrentlyAvailable = "/giftingshopcheckout/productisnotcurrentlyavailable";

            [Localization(Description = "Remove product from shopping-cart", DefaultValue = "Poista tuote ostoskorista")]
            public const string RemoveProductFromShoppingCart = "/giftingshopcheckout/removeproductfromshoppingcart";

            [Localization(Description = "Error creating order", DefaultValue = "Virhe tilauksen luonnissa, tarkista tiedot ja yritä uudelleen")]
            public const string ErrorCreatingOrder = "/giftingshopcheckout/errorcreatingorder";

            [Localization(Description = "Thank you for your order", DefaultValue = "Kiitos tilauksestasi!")]
            public const string ThankYouForYourOrder = "/giftingshopcheckout/thankyouforyourorder";
        }

        [LocalizationCategory("My page", 90000)]
        public static class MyPage
        {
            [Localization(Description = "Account management", DefaultValue = "myCompany-tilinhallinta")]
            public const string AccountManagement = "/mypage/accountmanagement";

            [Localization(Description = "Hello", DefaultValue = "Hei")]
            public const string Hello = "/mypage/hello";

            [Localization(Description = "Account management information", DefaultValue = "Täällä voit hallita myCompany-tiliisi ja tekemiisi tilauksiin liittyviä asioita")]
            public const string AccountManagementInformation = "/mypage/accountmanagementinformation";

            [Localization(Description = "Own information", DefaultValue = "Omat tiedot")]
            public const string OwnInformation = "/mypage/owninformation";

            [Localization(Description = "Save information", DefaultValue = "Tallenna tiedot")]
            public const string SaveInformation = "/mypage/saveinformation";

            [Localization(Description = "Information updated", DefaultValue = "Tiedot päivitetty")]
            public const string InformationUpdated = "/mypage/informationupdated";

            [Localization(Description = "Error saving information", DefaultValue = "Virhe tietojen tallennuksessa")]
            public const string ErrorSavingInformation = "/mypage/errorsavinginformation";

            [Localization(Description = "Not logged in with myCompany-account", DefaultValue = "Et ole kirjautunut myCompany-tunnuksilla, omien tietojen muokkaaminen on estetty.")]
            public const string NotLoggedInWithmyCompanyAccount = "/mypage/notloggedinwithmyCompanyaccount";

            [Localization(Description = "Email footnote", DefaultValue = "Voit käyttää kaikkia myCompanyin palveluja samalla myCompany-tunnuksella. Tähän osoitteeseen lähetetään myös tiedotteet ja tilausvahvistukset.")]
            public const string EmailFootnote = "/mypage/emailfootnote";

            [Localization(Description = "Password footnote", DefaultValue = "Käytäthän sellaista salasanaa, jota et käytä toisessa verkkopalvelussa.")]
            public const string PasswordFootnote = "/mypage/passwordfootnote";

            [Localization(Description = "Order history", DefaultValue = "Tilaushistoria")]
            public const string OrderHistory = "/mypage/orderhistory";

            [Localization(Description = "No orders", DefaultValue = "Ei tilauksia")]
            public const string NoOrders = "/mypage/noorders";

            [Localization(Description = "Incl VAT and shipping costs", DefaultValue = "sis. ALV ja toimituskulut")]
            public const string InclVatAndShippingCosts = "/mypage/inclvatandshippingcosts";

            [Localization(Description = "pc", DefaultValue = "kpl")]
            public const string Pc = "/mypage/pc";

            [Localization(Description = "Incl VAT", DefaultValue = "sis. ALV")]
            public const string InclVat = "/mypage/inclvat";

            [Localization(Description = "Productnum", DefaultValue = "Tuotenro")]
            public const string ProductNum = "/mypage/productnum";

            [Localization(Description = "Shipping", DefaultValue = "Toimitus")]
            public const string Shipping = "/mypage/shipping";

            [Localization(Description = "Billing address", DefaultValue = "Laskutusosoite")]
            public const string BillingAddress = "/mypage/billingaddress";

            [Localization(Description = "Shipping address", DefaultValue = "Toimitusosoite")]
            public const string ShippingAddress = "/mypage/shippingaddress";

            [Localization(Description = "Additional information", DefaultValue = "Viesti / tilauksen lisätiedot")]
            public const string AdditionalInformation = "/mypage/additionalInformation";

            [Localization(Description = "Show content", DefaultValue = "Näytä sisältö")]
            public const string ShowContent = "/mypage/showcontent";

            [Localization(Description = "Hide content", DefaultValue = "Piilota sisältö")]
            public const string HideContent = "/mypage/hidecontent";

            [Localization(Description = "Order status: InProgress", DefaultValue = "Käsiteltävänä")]
            public const string OrderStatusInProgress = "/mypage/orderstatus/inprogress";

            [Localization(Description = "Order status: OnHold", DefaultValue = "Odottaa")]
            public const string OrderStatusOnHold = "/mypage/orderstatus/onhold";

            [Localization(Description = "Order status: Shipped", DefaultValue = "Lähetetty")]
            public const string OrderStatusShipped = "/mypage/orderstatus/shipped";

            [Localization(Description = "Order status: Cancelled", DefaultValue = "Peruutettu")]
            public const string OrderStatusCancelled = "/mypage/orderstatus/cancelled";

            public static string OrderStatus(string status)
            {
                return "/mypage/orderstatus/" + status.ToLower();
            }

            [Localization(Description = "Product information not available", DefaultValue = "Tuotetietoja ei saatavilla")]
            public const string ProductInformationNotAvailable = "/mypage/productinformationnotavailable";

            [Localization(Description = "Shipping method not available", DefaultValue = "Toimitustavan tietoja ei saatavilla")]
            public const string ShippingMethodNotAvailable = "/mypage/shippingmethodnotavailable";

            [Localization(Description = "Customer service contact information", DefaultValue = "myCompanyin asiakaspalvelun yhteystiedot")]
            public const string CustomerServiceContactInformation = "/mypage/customerservicecontactinformation";

        }

        [LocalizationCategory("Meetings", 100000)]
        public static class Meetings
        {
            [Localization(Description = "Location search block title", DefaultValue = "Kokous- ja juhlatilat")]
            public const string LocationSearchBlockTitle = "/meetings/locationblocktitle";

            [Localization(Description = "City", DefaultValue = "Kaupunki")]
            public const string City = "/meetings/city";

            [Localization(Description = "Location", DefaultValue = "Sijainti")]
            public const string Location = "/meetings/location";

            [Localization(Description = "All", DefaultValue = "Kaikki")]
            public const string All = "/meetings/all";

            [Localization(Description = "Participants", DefaultValue = "Osallistujia")]
            public const string Participants = "/meetings/participants";

            [Localization(Description = "More search terms", DefaultValue = "Lisää hakuehtoja")]
            public const string MoreSearchTerms = "/meetings/moresearchterms";

            [Localization(Description = "Date", DefaultValue = "Päivämäärä")]
            public const string Date = "/meetings/date";

            [Localization(Description = "Start time", DefaultValue = "Alkamisaika")]
            public const string StartTime = "/meetings/starttime";

            [Localization(Description = "End time", DefaultValue = "Loppumisaika")]
            public const string EndTime = "/meetings/endtime";

            [Localization(Description = "Show locations", DefaultValue = "Näytä tilat")]
            public const string ShowLocations = "/meetings/showlocations";

            [Localization(Description = "Area", DefaultValue = "Pinta-ala")]
            public const string Area = "/meetings/area";

            [Localization(Description = "Features", DefaultValue = "Varustelu")]
            public const string Features = "/meetings/features";

            [Localization(Description = "Room type", DefaultValue = "Huonetyyppi")]
            public const string RoomType = "/meetings/roomtype";

            [Localization(Description = "Suitable rooms (singular)", DefaultValue = "sopiva tila")]
            public const string SuitableRoom = "/meetings/suitableroom";

            [Localization(Description = "Suitable rooms (plural)", DefaultValue = "sopivaa tilaa")]
            public const string SuitableRooms = "/meetings/suitablerooms";

            [Localization(Description = "Back to location search results", DefaultValue = "Takaisin listaukseen")]
            public const string BackToLocationResults = "/meetings/backtolocationresults";

            [Localization(Description = "No location search results", DefaultValue = "Ei hakutuloksia")]
            public const string NoLocationSearchResults = "/meetings/nolocationsearchresults";

            [Localization(Description = "Max. n persons", DefaultValue = "Max. {0} hlöä")]
            public const string MaxNPersons = "/meetings/maxnpersons";

            [Localization(Description = "Restaurant home page", DefaultValue = "Ravintolan kotisivu")]
            public const string RestaurantHomePage = "/meetings/restauranthomepage";

            [Localization(Description = "Restaurant lunch menu page", DefaultValue = "Lounaslista")]
            public const string RestaurantLunchMenu = "/meetings/restaurantlunchmenu";

            [Localization(Description = "Rooms title", DefaultValue = "Tilat")]
            public const string RoomsTitle = "/meetings/roomstitle";

            [Localization(Description = "Directions title", DefaultValue = "Sijainti ja yhteydet")]
            public const string DirectionsTitle = "/meetings/directionstitle";

            [Localization(Description = "Calendar title", DefaultValue = "Kalenteri")]
            public const string CalendarTitle = "/meetings/calendartitle";

            [Localization(Description = "Calendar day title", DefaultValue = "Päivä")]
            public const string CalendarDayTitle = "/meetings/calendardaytitle";

            [Localization(Description = "Calendar week", DefaultValue = "Viikko")]
            public const string CalendarWeekTitle = "/meetings/calendarweektitle";

            [Localization(Description = "Varaa", DefaultValue = "Varaa")]
            public const string Book = "/meetings/book";

            [Localization(Description = "Tee varauspyyntö", DefaultValue = "Tee varauspyyntö")]
            public const string CreateBookingRequest = "/meetings/createbookingrequest";

            [Localization(Description = "Parkkipaikat", DefaultValue = "Parkkipaikat")]
            public const string ParkingSlots = "/meetings/parkingslots";

            [Localization(Description = "Company", DefaultValue = "Yritys")]
            public const string Company = "/meetings/company";

            [Localization(Description = "Account", DefaultValue = "Asiakas")]
            public const string Account = "/meetings/account";

            [Localization(Description = "Customer Name", DefaultValue = "Tilaajan nimi")]
            public const string CustomerName = "/meetings/CustomerName";

            [Localization(Description = "Orderer email", DefaultValue = "Tilaajan sähköposti")]
            public const string OrdererEmail = "/meetings/ordererEmail";

            [Localization(Description = "Orderer phone", DefaultValue = "Tilaajan puhelinnumero")]
            public const string OrdererPhone = "/meetings/ordererPhone";

            [Localization(Description = "Host of the event", DefaultValue = "Tilaisuuden isäntä")]
            public const string HostOfTheEvent = "/meetings/HostOfTheEvent";

            [Localization(Description = "Host phone number", DefaultValue = "Isännän puhelinnumero")]
            public const string HostPhone = "/meetings/HostPhone";

            [Localization(Description = "Additional wishes", DefaultValue = "Lisätoiveet")]
            public const string AdditionalWishes = "/meetings/AdditionalWishes";

            [Localization(Description = "Cost Center", DefaultValue = "Kustannuspaikka")]
            public const string CostCenter = "/meetings/CostCenter";

            [Localization(Description = "Customer Number", DefaultValue = "Asiakasnumero")]
            public const string CustomerNumber = "/meetings/CustomerNumber";

            [Localization(Description = "Invoicing Information", DefaultValue = "Laskutustiedot")]
            public const string InvoicingInformation = "/meetings/invoicinginformation";

            [Localization(Description = "Invoicing Reference", DefaultValue = "Laskun viite")]
            public const string InvoicingReference = "/meetings/InvoicingReference";

            [Localization(Description = "Payment Method", DefaultValue = "Maksutapa")]
            public const string PaymentMethod = "/meetings/PaymentMethod";

            [Localization(Description = "Invoice", DefaultValue = "Laskulla")]
            public const string Invoice = "/meetings/Invoice";

            [Localization(Description = "Pay In Restaurant", DefaultValue = "Maksu ravintolassa")]
            public const string PayInRestaurant = "/meetings/PayInRestaurant";

            [Localization(Description = "Booker Email Marketing Allowed", DefaultValue = "Minulle saa lähettää markkinointimateriaalia sähköpostitse")]
            public const string BookerEmailMarketingAllowed2 = "/meetings/BookerEmailMarketingAllowed2";

            [Localization(Description = "Booker Email Marketing Allowed (email)", DefaultValue = "Sähköpostimarkkinointi sallittu")]
            public const string BookerEmailMarketingAllowed = "/meetings/BookerEmailMarketingAllowed";

            [Localization(Description = "Yes", DefaultValue = "Kyllä")]
            public const string Yes = "/meetings/Yes";

            [Localization(Description = "No", DefaultValue = "Ei")]
            public const string No = "/meetings/No";

            [Localization(Description = "Own Notes", DefaultValue = "Omat muistiinpanot")]
            public const string OwnNotes = "/meetings/OwnNotes";

            [Localization(Description = "Own Notes Example", DefaultValue = "(esim. osallistujien nimet)")]
            public const string OwnNotesExample = "/meetings/ownnotesexample";

            [Localization(Description = "Event schedule", DefaultValue = "Tilaisuuden aikataulu")]
            public const string EventSchedule = "/meetings/eventschedule";

            [Localization(Description = "All total", DefaultValue = "Kaikki yhteensä")]
            public const string AllTotal = "/meetings/alltotal";

            [Localization(Description = "All total net", DefaultValue = "Yhteensä netto")]
            public const string AllTotalNet = "/meetings/alltotalnet";

            [Localization(Description = "Billing address", DefaultValue = "Laskutusosoite")]
            public const string BillingAddress = "/meetings/billingaddress";

            [Localization(Description = "E-invoice address", DefaultValue = "Verkkolaskuosoite")]
            public const string EInvoiceAddress = "/meetings/einvoiceaddress";

            [Localization(Description = "Reservation date", DefaultValue = "Varauspäivä")]
            public const string ReservationDate = "/meetings/reservationdate";

            [Localization(Description = "Alternative delivery location", DefaultValue = "Muu toimituspaikka")]
            public const string AlternativeDeliveryLocation = "/meetings/alternativedeliverylocation";

            [Localization(Description = "Takeout", DefaultValue = "Noudan ravintolasta")]
            public const string Takeout = "/meetings/takeout";

            [Localization(Description = "Reservation was successful", DefaultValue = "Varaus onnistui")]
            public const string ReservationSuccessful = "/meetings/reservationsuccessful";

            [Localization(Description = "Reservation request was successful", DefaultValue = "Varauspyyntö lähetetty")]
            public const string ReservationRequestSuccessful = "/meetings/reservationrequestsuccessful";

            [Localization(Description = "Reservation changed to request", DefaultValue = "Varausta ei voitu vahvistaa, varauksesi on lähetetty varauspyyntönä. Myyntipalvelumme on teihin yhteydessä.")]
            public const string ReservationChangedToRequest = "/meetings/reservationchangedtorequest";

            [Localization(Description = "You can see and update your reservation", DefaultValue = "Näet varauksesi tiedot ja voit muokata sitä")]
            public const string UpdateReservation = "/meetings/updatereservation";

            [Localization(Description = "in own reservations", DefaultValue = "omissa varauksissa")]
            public const string InOwnReservations = "/meetings/inownreservations";

            [Localization(Description = "Back to calendar", DefaultValue = "Takaisin varauskalenteriin")]
            public const string BackToCalendar = "/meetings/backtocalendar";
        }

        [LocalizationCategory("Meetings: Room reservation", 100001)]
        public static class MeetingsRoomReservation
        {
            [Localization(Description = "Do you already have an account?", DefaultValue = "Onko sinulla jo tunnukset?")]
            public const string DoYouAlreadyHaveAnAccount = "/meetings/roomreservation/doyoualreadyhaveanaccount";

            [Localization(Description = "You are logged in with a non-{0}-account", DefaultValue = "Olet kirjautunut sisään muulla kuin {0}-tunnuksella.")]
            public const string LoggedInWithANonServiceAccount = "/meetings/roomreservation/loggedinwithanonservice-account";

            [Localization(Description = "If you have a {0}-account", DefaultValue = "Mikäli sinulla on {0}-tunnukset")]
            public const string IfYouHaveAnAccount = "/meetings/roomreservation/ifyouhaveanaccount";

            [Localization(Description = "Cannot update reservation", DefaultValue = "Jos haluat tehdä muutoksia varaukseesi, ota yhteyttä myyntipalveluun")]
            public const string CannotUpdateReservation = "/meetings/roomreservation/cannotupdatereservation";

            [Localization(Description = "Cannot create reservation", DefaultValue = "Varausta ei voi enää tehdä verkkopalvelun kautta, ota yhteyttä myyntipalveluun")]
            public const string CannotCreateReservation = "/meetings/roomreservation/cannotcreatereservation";

            [Localization(Description = "Sending as reservation request", DefaultValue = "Valitsemaasi tilaa tai aikaväliä ei voi varata verkkopalvelun kautta, varauksesi lähetetään varauspyyntönä")]
            public const string SendingAsReservationRequest = "/meetings/roomreservation/sendingasreservationrequest";

            [Localization(Description = "Reservation is editable until {0}", DefaultValue = "Varausta voi muokata klo {0} asti")]
            public const string ReservationEditableUntil = "/meetings/roomreservation/reservationeditableuntil";

            [Localization(Description = "Event name", DefaultValue = "Tilaisuuden nimi")]
            public const string EventName = "/meetings/roomreservation/eventname";

            [Localization(Description = "Location", DefaultValue = "Sijainti")]
            public const string Location = "/meetings/roomreservation/location";

            [Localization(Description = "Room", DefaultValue = "Tila")]
            public const string Room = "/meetings/roomreservation/room";

            [Localization(Description = "Time", DefaultValue = "Ajankohta")]
            public const string Time = "/meetings/roomreservation/time";

            [Localization(Description = "Is the event a multi-day event?", DefaultValue = "Tilaisuus on monipäiväinen?")]
            public const string IsTheEventAMultiDayEvent = "/meetings/roomreservation/istheeventamultidayevent";

            [Localization(Description = "Multi-day event -tooltip: logged in", DefaultValue = "Vahvista ensin varauksesi ja kopioi se uudeksi varaukseksi \"Omat varaukset\"-osiossa. Tai soita alla olevaan myyntipalvelun numeroon.")]
            public const string MultiDayEventTooltipLoggedIn = "/meetings/roomreservation/multidayeventtooltiploggedin";

            [Localization(Description = "Multi-day event -tooltip: not logged in", DefaultValue = "Soita alla olevaan myyntipalvelun numeroon.")]
            public const string MultiDayEventTooltipNotLoggedIn = "/meetings/roomreservation/multidayeventtooltipnotloggedin";

            [Localization(Description = "Select time from calendar", DefaultValue = "Valitse ajankohta kalenterista")]
            public const string SelectTimeFromCalendar = "/meetings/roomreservation/selecttimefromcalendar";

            [Localization(Description = "Original time", DefaultValue = "Alkuperäinen ajankohta")]
            public const string OriginalTime = "/meetings/roomreservation/originalTime";

            [Localization(Description = "Cancel time selection", DefaultValue = "Peru muokkaus")]
            public const string CancelTimeSelection = "/meetings/roomreservation/canceltimeselection";

            [Localization(Description = "Participant count", DefaultValue = "Osallistujamäärä")]
            public const string ParticipantCount = "/meetings/roomreservation/participantcount";

            [Localization(Description = "Persons (lower case)", DefaultValue = "henkilöä")]
            public const string PersonsLowerCase = "/meetings/roomreservation/personslowercase";

            [Localization(Description = "Room price", DefaultValue = "Tilan hinta")]
            public const string RoomPrice = "/meetings/roomreservation/roomprice";

            [Localization(Description = "Contains VAT (lower case)", DefaultValue = "sis. alv")]
            public const string ContainsVatLowerCase = "/meetings/roomreservation/containsvatlowercase";

            [Localization(Description = "Room not available", DefaultValue = "Valitsemasi tila ei valitettavasti ole vapaa valitulla aikavälillä")]
            public const string RoomNotAvailable = "/meetings/roomreservation/roomnotavailable";

            [Localization(Description = "Catering not available", DefaultValue = "Valitsemastasi sijainnista ei voi tilata tarjoiluja haluamanasi päivänä")]
            public const string CateringNotAvailable = "/meetings/roomreservation/cateringnotavailable";

            [Localization(Description = "Move reservation-calendar", DefaultValue = "Siirry varauskalenteriin")]
            public const string MoveToReservationCalendar = "/meetings/roomreservation/movetoreservationcalendar";

            [Localization(Description = "Catering", DefaultValue = "Tarjoilut")]
            public const string Catering = "/meetings/roomreservation/catering";

            [Localization(Description = "Add catering services", DefaultValue = "Lisää tarjoiluja")]
            public const string AddCateringServices = "/meetings/roomreservation/addcateringservices";

            [Localization(Description = "Check catering services", DefaultValue = "Muista tarkastaa tarjoiluajat valitsemalla \"Lisää ja muokkaa tarjoiluja\"")]
            public const string CheckCateringServices = "/meetings/roomreservation/checkcateringservices";

            [Localization(Description = "No catering services", DefaultValue = "Ei tarjoiluja")]
            public const string NoCateringServices = "/meetings/roomreservation/nocateringservices";

            [Localization(Description = "Catering service", DefaultValue = "Tarjoilu")]
            public const string CateringService = "/meetings/roomreservation/cateringservice";

            [Localization(Description = "pc", DefaultValue = "kpl")]
            public const string Pc = "/meetings/roomreservation/pc";

            [Localization(Description = "Total", DefaultValue = "Yhteensä")]
            public const string Total = "/meetings/roomreservation/total";

            [Localization(Description = "Add and edit catering services", DefaultValue = "Lisää, muokkaa ja poista tarjoiluja")]
            public const string AddAndEditCateringServices = "/meetings/roomreservation/addandeditcateringservices";

            [Localization(Description = "Remove all catering services", DefaultValue = "Poista kaikki tarjoilut")]
            public const string RemoveAllCateringServices = "/meetings/roomreservation/removeallcateringservices";

            [Localization(Description = "Special diets and other specifications", DefaultValue = "Erikoisruokavaliot ja muut tarkennukset")]
            public const string SpecialDietsAndOtherSpecifications = "/meetings/roomreservation/specialdietsandotherspecifications";

            [Localization(Description = "Price total", DefaultValue = "Hinta yhteensä")]
            public const string PriceTotal = "/meetings/roomreservation/pricetotal";

            [Localization(Description = "Room rent (email)", DefaultValue = "Tilavuokra")]
            public const string RoomRent = "/meetings/roomreservation/roomrent";

            [Localization(Description = "Reservation time (email)", DefaultValue = "Kellonaika")]
            public const string ReservationTime = "/meetings/roomreservation/reservationtime";
        }

        [LocalizationCategory("Meetings: Catering", 100002)]
        public static class MeetingsCatering
        {
            [Localization(Description = "All products", DefaultValue = "Kaikki tuotteet")]
            public const string AllProducts = "/meetings/catering/allproducts";

            [Localization(Description = "Persons abbr.", DefaultValue = "hlöä")]
            public const string PersonsAbbr = "/meetings/catering/personsabbr";

            [Localization(Description = "Choose", DefaultValue = "Valitse")]
            public const string Choose = "/meetings/catering/choose";

            [Localization(Description = "Chosen caterings", DefaultValue = "Valitut tarjoilut")]
            public const string ChosenCaterings = "/meetings/catering/chosencaterings";

            [Localization(Description = "Qty", DefaultValue = "kpl")]
            public const string Qty = "/meetings/catering/qty";

            [Localization(Description = "Catering total", DefaultValue = "Tarjoilut yhteensä (sis. ALV)")]
            public const string CateringTotal = "/meetings/catering/cateringtotal";

            [Localization(Description = "Catering VAT", DefaultValue = "ALV osuus {0} %")]
            public const string CateringVat = "/meetings/catering/cateringvat";

            [Localization(Description = "Room total", DefaultValue = "Tila yhteensä")]
            public const string RoomTotal = "/meetings/catering/roomtotal";

            [Localization(Description = "Unavailable products", DefaultValue = "Seuraavia tuotteita ei ole saatavilla haluamallasi päivällä")]
            public const string UnavailableProducts = "/meetings/catering/unavailableproducts";

            [Localization(Description = "Back to room reservation", DefaultValue = "Takaisin tilavaraukseen")]
            public const string BackToRoomReservation = "/meetings/catering/backtoroomreservation";

            [Localization(Description = "Catering min. modify time", DefaultValue = "Tähän tuotteeseen voi tehdä muutoksia {0} asti.")]
            public const string CateringMinModifyTime = "/meetings/catering/cateringminmodifytime";

            [Localization(Description = "Catering price / participant", DefaultValue = "Hinta {0} € / osallistuja")]
            public const string PricePerParticipant = "/meetings/catering/priceperparticipant";

            [Localization(Description = "Add to catering", DefaultValue = "Lisää tarjoiluun")]
            public const string AddToCatering = "/meetings/catering/addtocatering";

            [Localization(Description = "Add allergy options in next step", DefaultValue = "Voit lisätä tiedon erityisruokavaliosta seuraavassa vaiheessa")]
            public const string AddAllergyOptionsInNextStep = "/meetings/catering/addallergyoptionsinnextstep";

            [Localization(Description = "Morning delivery", DefaultValue = "Aamiainen")]
            public const string MorningDelivery = "/meetings/catering/morningdelivery";

            [Localization(Description = "Lunch delivery", DefaultValue = "Lounas")]
            public const string LunchDelivery = "/meetings/catering/lunchdelivery";

            [Localization(Description = "Afternoon delivery", DefaultValue = "Välipala")]
            public const string AfternoonDelivery = "/meetings/catering/afternoondelivery";

            [Localization(Description = "Delivery time", DefaultValue = "Toimitusaika")]
            public const string DeliveryTime = "/meetings/catering/deliverytime";

            [Localization(Description = "Confim remove catering", DefaultValue = "Haluatko varmasti poistaa tarjoilun?")]
            public const string ConfirmRemoveCatering = "/meetings/catering/confirmremovecatering";

            [Localization(Description = "Recommended products", DefaultValue = "Suosituimmat tuotteet")]
            public const string RecommendedProducts = "/meetings/catering/recommendedproducts";

            [Localization(Description = "Added catering item", DefaultValue = "Lisätty")]
            public const string AddedCateringItem = "/meetings/catering/addedcateringitem";

            [Localization(Description = "Catering not bookable", DefaultValue = "Et voi enää lisätä tarjoiluja näin lähellä tapahtuman alkua. Ota yhteyttä myyntipalveluun!")]
            public const string CateringNotBookable = "/meetings/catering/cateringnotbookable";

            [Localization(Description = "Products (email)", DefaultValue = "Tuotteet")]
            public const string Products = "/meetings/catering/products";

            [Localization(Description = "Time (email)", DefaultValue = "Aika")]
            public const string Time = "/meetings/catering/time";

            [Localization(Description = "Quantity (email)", DefaultValue = "Määrä")]
            public const string Quantity = "/meetings/catering/quantity";

            [Localization(Description = "Item price (email)", DefaultValue = "á hinta")]
            public const string ItemPrice = "/meetings/catering/Itemprice";

            [Localization(Description = "Catering item total (email)", DefaultValue = "Yhteensä")]
            public const string ItemTotal = "/meetings/catering/itemtotal";

            [Localization(Description = "Caterings total (email)", DefaultValue = "Tuotteet yhteensä")]
            public const string ItemsTotal = "/meetings/catering/itemstotal";

            [Localization(Description = "Service Additional Info (email)", DefaultValue = "Tarjoilutilauksen lisätiedot")]
            public const string ServiceAdditionalInfo = "/meetings/catering/serviceadditionalinfo";

        }

        [LocalizationCategory("Meetings: Own reservations", 100003)]
        public static class MeetingsOwnReservations
        {
            [Localization(Description = "Own reservations", DefaultValue = "Omat varaukset")]
            public const string OwnReservations = "/meetings/ownreservations/ownreservations";

            [Localization(Description = "New reservation", DefaultValue = "Uusi tilavaraus")]
            public const string NewReservation = "/meetings/ownreservations/newreservation";

            [Localization(Description = "New catering order", DefaultValue = "Uusi tarjoilutilaus")]
            public const string NewCateringOrder = "/meetings/ownreservations/newcateringorder";

            [Localization(Description = "Upcoming reservations", DefaultValue = "Tulevat")]
            public const string UpcomingReservations = "/meetings/ownreservations/upcomingreservations";

            [Localization(Description = "Past reservations", DefaultValue = "Menneet")]
            public const string PastReservations = "/meetings/ownreservations/pastreservations";

            [Localization(Description = "Cancelled reservations", DefaultValue = "Perutut")]
            public const string CancelledReservations = "/meetings/ownreservations/cancelledreservations";

            [Localization(Description = "No reservations", DefaultValue = "Ei varauksia")]
            public const string NoReservations = "/meetings/ownreservations/noreservations";

            [Localization(Description = "Date", DefaultValue = "Pvm")]
            public const string Date = "/meetings/ownreservations/date";

            [Localization(Description = "Time", DefaultValue = "Klo")]
            public const string Time = "/meetings/ownreservations/time";

            [Localization(Description = "Location", DefaultValue = "Sijainti / tila")]
            public const string Location = "/meetings/ownreservations/location";

            [Localization(Description = "Participants", DefaultValue = "Osallistujia")]
            public const string Participants = "/meetings/ownreservations/participants";

            [Localization(Description = "Catering", DefaultValue = "Tarjoilut")]
            public const string Catering = "/meetings/ownreservations/catering";

            [Localization(Description = "Event name", DefaultValue = "Tilaisuuden nimi")]
            public const string EventName = "/meetings/ownreservations/eventname";

            [Localization(Description = "Event without name title", DefaultValue = "Tilaisuuden tiedot")]
            public const string EventWithoutNameTitle = "/meetings/ownreservations/eventwithoutnametitle";

            [Localization(Description = "Catering order", DefaultValue = "tarjoilutilaus")]
            public const string CateringOrder = "/meetings/ownreservations/cateringorder";

            [Localization(Description = "Yes", DefaultValue = "Kyllä")]
            public const string Yes = "/meetings/ownreservations/yes";

            [Localization(Description = "No", DefaultValue = "Ei")]
            public const string No = "/meetings/ownreservations/no";

            [Localization(Description = "Add catering", DefaultValue = "Ei, lisää")]
            public const string AddCatering = "/meetings/ownreservations/addcatering";

            [Localization(Description = "Cancel", DefaultValue = "Peru")]
            public const string Cancel = "/meetings/ownreservations/cancel";

            [Localization(Description = "Copy", DefaultValue = "Kopioi")]
            public const string Copy = "/meetings/ownreservations/copy";

            [Localization(Description = "Confirm cancel", DefaultValue = "Haluatko varmasti perua varauksen?")]
            public const string ConfirmCancel = "/meetings/ownreservations/confirmcancel";
        }

        [LocalizationCategory("Meetings: Email", 100004)]
        public static class MeetingsEmail
        {
            [Localization(Description = "Customer information title", DefaultValue = "Asiakkaan tiedot")]
            public const string CustomerInformation = "/meetings/email/customerinformation";

            [Localization(Description = "Reservation information title", DefaultValue = "{0}")]
            public const string ReservationInformation = "/meetings/email/reservationinformation";

            [Localization(Description = "Reservation information fallback title", DefaultValue = "Varauksen tiedot")]
            public const string ReservationInformationFallback = "/meetings/email/reservationinformationfallback";

            [Localization(Description = "Contact information title", DefaultValue = "Yhteystiedot")]
            public const string ContactInformation = "/meetings/email/contactinformation";

            [Localization(Description = "Reservation breakdown title", DefaultValue = "{0} - {1} Erittely")]
            public const string ReservationBreakdown = "/meetings/email/reservationbreakdown";

            [Localization(Description = "Reservation breakdown fallback title", DefaultValue = "Tilauksen erittely")]
            public const string ReservationBreakdownFallback = "/meetings/email/reservationbreakdownfallback";

            [Localization(Description = "Other information", DefaultValue = "Muuta sovittua")]
            public const string OtherInformation = "/meetings/email/otherinformation";

        }

        [LocalizationCategory("Meetings: Receptionist view", 100005)]
        public static class MeetingsReceptionistView
        {
            [Localization(Description = "Event name", DefaultValue = "Tilaisuuden nimi")]
            public const string EventName = "/meetings/receptionistview/eventname";

            [Localization(Description = "Customer name", DefaultValue = "Tilaajan nimi")]
            public const string CustomerName = "/meetings/receptionistview/customername";

            [Localization(Description = "Company name", DefaultValue = "Yrityksen nimi")]
            public const string CompanyName = "/meetings/receptionistview/companyname";

            [Localization(Description = "Host name", DefaultValue = "Isännän nimi")]
            public const string HostName = "/meetings/receptionistview/hostname";

            [Localization(Description = "Host phone", DefaultValue = "Isännän puhelinnro")]
            public const string HostPhone = "/meetings/receptionistview/hostphone";
        }
    }
}