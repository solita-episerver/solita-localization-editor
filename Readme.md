# Localization Editor

LocalizationEditorin tarkoituksena on tarjota k�ytt�liittym� kielik��nn�sten hallintaan. Editori otetaan k�ytt��n projekteissa includaamalla LocalizationEditor Nugetin kautta: https://www.myget.org/feed/solita-episerver/package/nuget/Solita.LocalizationEditor.UI .

Kategorioiden/kielik��nn�sten m��ritys:

    ```C#
        public class Localizations
        {
			[LocalizationCategory("Common", 100)]
			public static class Common
			{
				[Localization(Description = "myCompany", DefaultValue = "myCompany")]
				public const string Sitename = "/common/sitename";
			}
		}
    ```
LocalizationCategoryt ja Localization stringit n�kyv�t editorin vasemmassa reunassa, kuten kuvassa:

![Image of Yaktocat](documentationResources/editorUI.png)

Itse kielik��nn�kset(kuvassa *English* ja *Swedish* alla) luetaan xml tiedostosta, k�yt�ss� olevaa FileAccessStrategya hy�dynt�en(oletuksena Blob strategy)
VPP-tekniikkaa hy�dynt�v�t providerit eiv�t ole yhteensopivia Episerver >= 9 kanssa. VPP-tekniikkaa hy�dynt�v� accessStrategy on kuitenkin saatavilla tiedostossa(**VppFileAccessStrategy.cs**)

K��nn�ksen hakeminen k�ytt�liittym�ss�(*.cshtml)

    ```html
        <p>Localization editor Blob storage test: @Html.Translate("/common/languagemenufi")</p>
    ```

**Solita.LocalizationEditor.TestProject** Up&Running:(haettu k��nn�s /common/languagemenufi)

![Image of Yaktocat](documentationResources/exampleproj.png)


## Toimintamalli:
- Ladataan kaikki k��nn�skategoriat ja k��nn�ssanat App domainiin ladatuista assemblyista, kuten esimerkiss�
    - Laajempi esimerkki k��nn�kategorioiden rekister�imisest�: **Solita.LocalizationEditor.TestEpiProject\Localizations.cs**
    - Kategoria rekister�idaan attribuutilla **[LocalizationCategory("Kategorian nimi", "<int>")]**, jossa <int> = j�rjestysnumero
    - K��nn�s rekister�id��n attribuutilla **[Localization(Description="xxx" DefaultValue = "xxx")]**
- Ladataan k��nn�kset sis�lt�v� xml hydynt�en annettua **FileAccessStrategy** toteutusta(m��ritetty controllerissa **LocalizationEditorController.cs**)
    - FileAccessStrategyt m��ritetty DAL kansiossa.
- Render�id��n xml: st� luetut k��nn�kset k��nn�staulukkoon k��nn�st� vastaavan kielen alle
- Kun kielik��nn�ksi� on muokattu taulukossa ja painettu **Save**, syntyy uusi xml tiedosto blob storageen.

## Jatkokehitys
- Buildaa solution konfiguraatiolla **DevDeploy**
    - DevDeploy konfiguraatio paketoi *Solita.LocalizationEditor.UI* projektin 
    - Kopioi tarvittavat build artifaktit *Solita.LocalizationEditor.TestEpiProject* k�ytett�v�ksi
    - Lokalisaatio editoriin teht�v�t muutokset ovat v�litt�m�sti k�ytett�viss� Epi testiprojektissa
# Testit
Kaikki yksikk�testit kuuluvat olla vihre�ll�. Muuten jokin keskeinen toiminnallisuus on rikki.

## Build targetit
Custom build targetit on m��ritetty **Solita.LocalizationEditor.UI.csproj** tiedostossa(tiedoston lopussa), aktivoituvat vain mik�li konfiguraatioksi valittu "DevDeploy"

## Huomioitavaa

Kun Episerver.Framework paketin p�ivitt�� versioon >= 9, epi saitin lataaminen aiheuttaa "NullReference" Exceptionin mik�li web.config: ssa on VPP m��rityksi� lokalisaatioita varten.
Huomioitavaa on my�s, ett� reposta ei ole poistettu mit��n VPP-pohjaista lokalisointitekniikkaa, LocalizationPersister luokkaa on vain refaktoroitu niin, ett� k�ytett�v� Data-access tekniikka
initialisoidaan luokan ulkopuolella. Alkuper�inen VPP-moduuli l�ytyy kansiosta **DAL\VppFileAccessStrategy.cs**(aiheuttaa build-errorin mik�li yritt�� buildata episerverin versiolla >= 9).

### Suorituskyky
K�ytt�liittym�n p�ivitys tehd��n t�ll� hetkell� JQueryn avulla domia manipuloiden. Isojen k��nn�stiedostojen kohdalla t�m� tarkoittaa k�ytt�liittym�n "j��tymist�".
Jatkossa voisikin mietti� render�innin hoitamista data-binding tekniikoiden(esim. knockout tai reactjs), jotta editorista saataisiin k�ytett�v�mpi.
