# ASP.NET-Inl-mningsuppgift1


• För Asp.Net förklaringen är det fokus på det som sker i Startup.cs, wwwroot och Razor språket.
• För Razor Pages så handlar det bara att beskriva de två filerna. Content Page och Page Model.


ASP.NET CORE & DESS ANVÄNDNINGSOMRÅDEN:
ASP.NET Core är ett cross-platform, högpresterande open-source framework som används för att 
bygga moderna cloud/internet appar. Med ASP.NET Core kan du bygga webbappar och services, IoT appar och mobila backends.

STARTUP:
I startup.cs så jobbar vi mest med att registrera services och "injecta" moduler i HTTP pipeline.
Startup.cs innehåller klassen "Startup" som är hjärtat i varje ASP.NET Core projekt. Den tillåter oss att konfigurera vår app. 
Vi kan ladda configurations, registrera dependencies och bestämma ordningen på vår ASP.NET request-pipeline.
Startup-klassen är obligatorisk för att din ASP.NET app ska kunna köras. 
I Startup.cs så hittar vi två stycken metoder, "ConfigureServices och "Configure"
I "ConfigureServices"-metoden placerar du dina services som ska kallas på och köras (tex "services.AddRazorPages").
"Configure"-metoden används för att specificera hur din app svarar på HTTP-requests med hjälp av middleware-komponenter som adderas till en IApplicationBuilder instans. 

WWWROOT:
I "wwwroot" hittas alla statiska filer i ditt projekt. All HTML,CSS,bilder och JS som skickas till användarens browser bör ligga i wwwroot.
Wwwroot är alltså en samlingsplats för projektets statiska filer, detta bidrar till att du har ett "rent" projekt där du separerar dina kodfiler (C#/Razor) ifrån dina statiska filer (välorganiserat). 

RAZORSPRÅKET:
Razor är en kombination av programspråk för programmering av webbsidor/appar.
Razor ger programmerare möjligheten att lägga in programkod i C# och Visual Basic i webbsidans kod som annars är skiven i HTML. 
Det är alltså ett sätt att blanda de två programspråken med HTML på ett körbart sätt. 
När en webbsida kallas på så exekveras razor-koden av servern och omvandlar sedan programkoden till HTML innan den skickas till användaren.

RAZOR-PAGES:
Razor Pages Appar är nyare och simplare web-applikations programmeringsmodell som har en fil-baserad routing approach till skillnad ifrån ASP.NET MVC.
Varje Razor-Page består av en HTML-sida (Index.html.cs) där du bygger upp sidan som användaren ser och interagerar med och en "PageModel" (Index.cshtml.cs) sida där du kodar funktionalitet och styr din Razor-HTML-sida (med C#).
Här jobbar vi med GET och POST för att hämta/skicka data och reagera på användaren.  


MVC:
MVC står för "Model-View-Controller" och är ett designmönster för appar som har ett grafisk användargränssnitt. Genom att använda MVC kan man separara användargränssnittet från affärslogiken. De tre typer man arbetar med i MVC är model, view och controllerobjekt. Dessa tre typer är separerade från varandra och kan arbeta självständigt samtidigt som de kommunicerar med varann. Man kan dra nytta av MVC-designmönstret på många sätt då objekten blir återanvändbara och gränssnittet blir bättre definierat. MVC bidrar till man minskar komplexiteten eftersom det blir enklare att programmera, felsöka och testa saker i programmet. 

Model: 
Här definierar man regler, data och instruktioner som applikationen ska följa. 
Modellen tar emot förfrågningar om information från view och svarar på instruktioner som kommer ifrån controllern. All data som ligger lagrad i en databas till exempel bör ligga i model när data har laddats in i applikationen. 

View: 
Detta är vad som visas för användaren. View ska ge en korrekt representation av model och kan även låta användaren redigera datan från model. 

Controller: 
Controllern är delen som tar emot instruktioner ifrån användaren och gör om instruktionerna till något som appen kan hantera. Controllern känner av input ifrån användaren så som musklick och kommandon från tangentbordet samt informerar model eller view om vad som ska utföras eller visas. Conntrollern fungerar som en mellanhand mellan view och model. 

Nackdelar med MVC: 
Tidskrävande, det tar tid att göra även mindre uppgifter då det krävs omfattande planering för att dela upp koden och dess separation. 

Tar mycket plats, ska man ha ett minimalistiskt tänk och inte för mycket clutter i sitt projekt så rekommenderas inte MVC. MVC kräcker mycket plats på servern och är oftast tänkt att använda för större appar. 

Komplicerat, som tidigare nämnt så är MVC inte så smidigt att använda för mindre appar då MVC ökar komplexiteten saker. 


