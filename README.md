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
