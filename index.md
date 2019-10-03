# Inleiding

In dit document wordt het projectplan beschreven voor de nieuwe Augmented
Reality(AR) toepassing die zal worden gerealiseerd tijdens het NOTS project.

Gedurende het NOTS-project dient elke projectgroep een toepassing te
realiseren aan de hand van de nieuwste technologieën zoals Machine learning,
Artificial intelligence etc.

Onze keuze is uitgegaan naar Augmented reality. Dit is een techniek waarbij er
door middel van een camera/bril digitale elementen aan de fysieke omgeving kunnen
worden toegevoegd. Een technologie die op dit moment vol aan het ontwikkelen is
door het opkomen van verschillende nieuwe frameworks waarmee het eenvoudig is
om een toepassing met deze technologie te realiseren.

Echter is de usecase tijdens het project nog niet definitief, wegens het feit
dat de projectgroep nog met meerdere organisaties zoals het Vrijheidsmuseum in
Groesbeek en iXperium in Nijmegen in gesprek is over een mogelijke
samenwerking.

Overigens is er wel een concrete usecase achter de hand, waar de rest van
dit projectplan op gebaseerd zal zijn.

Deze usecase betreft een platform waarbij toeristen door middel van AR worden
voorzien van informatie over verschillende bezienswaardigheden. Er is namelijk
bij veel bezienswaardigheden ter plekke vaak geen of beperkte informatie
beschikbaar. Zo valt er bij veel beelden/monumenten geen informatie te vinden en
is de taal vaak een probleem bij bezienswaardigheden in het buitenland.

Vandaar dat er een prototype van een location-based platform zal worden
opgeleverd. Hierbij wordt bij de verschillende bezienswaardigheden informatie in de
gewenste taal getoond. Daarnaast zal het ook de mogelijkheid hebben op
informatie voor te lezen door middel van een spraak assistent.

In dit document zal de aanpak van het benodigde onderzoek van deze toepassing
worden vastgelegd. Dit kan als leidraad worden gebruikt voor het projectteam. Ook kunnen alle betrokken partijen dit bestand gebruiken als referentie.

Dit zal nader toegelicht worden aan de hand van de volgende hoofdstukken:

2. [Probleemstelling](./2.%20probleemstelling.md)

3. [Doelstelling](./3.%20doelstelling.md)

4. [Vraagstelling(en)](<./4%20vraagstelling(en).md>)

5. [Randvoorwaarden](./5%20Randvoorwaarden.md)

6. [Op te leveren producten & kwaliteitseisen](./6.%20Op%20te%20leveren%20producten%20en%20kwaliteitseisen.md)

7. [Projectgrenzen](./7.%20Projectgrenzen.md)

8. [Ontwikkelmethode](./8.%20Ontwikkelmethode.md)

9. [Projectorganisatie](./9.%20Projectorganisatie.md)

10. [Planning](./10.%20Planning.md)

11. [Risico's](./11%20Risico's.md)

# Probleemstelling

## Huidige situatie

Toeristen bezoeken vaak plaatsen met als doel om bezienswaardigheden te bezichtigen. Bij deze bezienswaardigheden is vaak informatie beschikbaar die toeristen kunnen lezen. Echter is deze informatie niet altijd volledig of in een andere taal geschreven.

## Gewenste situatie

De te realiseren applicatie geeft toeristen de mogelijkheid om deze onvolledige informatie aan te vullen met beschikbare informatie van het internet.

Bij het openen van de applicatie kan de toerist markers op zijn scherm zien met afstanden waar bezienswaardigheden zich bevinden. Wanneer de camera van een mobiel apparaat gericht wordt op de bezienswaardigheid, kan de toerist deze marker aanklikken. Daarna wordt er een Augmented Reality weergave getoond waar informatie over de bezienswaardigheid op te zien is. Deze weergave lijkt er in de echte wereld te zijn, maar wordt alleen toegevoegd door de applicatie. Wanneer de toerist om deze weergave heen loopt, zal deze meedraaien zodat de tekst altijd leesbaar is, onafhankelijk van de locatie van de toerist.

Ook is het mogelijk om de aanvullende informatie automatisch te vertalen naar een voorkeurtaal die de toerist kan instellen in de applicatie. De toerist kan vervolgens deze informatie ook nog beluisteren.

# Doelstelling

Het doel van dit project is om voor 18 april 2020 een prototype applicatie te realiseren die toeristen een rijkere ervaring aanbiedt bij historische monumenten.
Door het gebruik van de camera op een mobiel apparaat zal er door middel van Augmented Reality digitale elementen worden toegevoegd aan de realiteit om de
gebruiker een betere beleving te geven. Door middel van deze digitale elementen kan de gebruiker meer ervaren en meer te weten te komen over het monument waar
hij zijn camera op richt. Daarnaast kan de gebruiker ervoor kiezen de informatie in zijn eigen spreektaal te laten voorlezen.

Om het doel te bereiken zullen er een aantal onderzoeken worden gedaan die in het hoofdstuk vraagstellingen zullen worden toegelicht.

# Deelvraag 1: Wat is Augmented Reality? <a name="deelvraag1"></a>

## Motivatie & relevantie

Voordat het team een Augmented Reality applicatie kan gaan realiseren, moet duidelijk zijn wat AR eigenlijk is en wat het precies inhoudt. Dit onderzoek zal een beter beeld scheppen van wat AR is, wat de mogelijkheden zijn en waarom je juist wel of niet AR wilt gebruiken. Dit zal het team helpen bij het maken van design keuzes en technische keuzes in de loop van het project.

## Relatie tot probleemstelling & doelstelling

Om het probleem op te lossen is het team van plan een Augmented Reality applicatie te maken. Om dit mogelijk te maken moet het team verstand hebben van Augmented Reality. Dit is ook meteen het doel: een applicatie die door middel van Augmented Reality de gebruiker een betere beleving kan bieden bij historische monumenten.

## Relatie tot andere deelvragen

Deze vraag heeft een direct verband met de andere deelvragen omdat alle onderzoeken te maken hebben met Augmented Reality. Dit onderzoek vormt als het ware ‘de backbone’ van alle onderzoeken.

## Met welke onderzoeksmethode ga je de vraag beantwoorden?

Deze deelvraag gaat beantwoord worden door middel van de BIEB-onderzoeksmethode. Elke deelvraag zal beantwoordn worden aan de hand van de BIEB-onderzoeksmethode.

## Toetscriteria aan de hand waarvan je het antwoord kunt toetsen

Toetscriteria zijn niet relevant bij deze vraag. Daarom worden er subvragen gebruikt in plaats van toetscriteria. De subvragen die beantwoord zullen worden tijdens het onderzoek zijn:

- Wat zijn de toepassingen van Augmented Reality?
- Wat zijn de verschillen tussen Virtual Reality en Augmented Reality?
- Wat zijn de voordelen en nadelen van Augmented Reality?
- Wat is de toekomst van Augmented Reality?

## Uitvoering

Twee leden van het development team zullen dit onderzoek gaan uitvoeren. Deze twee leden zijn nog niet bepaald en zullen nader in het PvA worden opgenomen.

# Deelvraag 2: Welke app/web framework is het meest geschikt om onze applicatie mee te realiseren? <a name="deelvraag2"></a>

## Motivatie

Om ervoor te zorgen dat het developmentteam de doelstelling kan waarmaken, is het van belang dat er gekozen wordt voor een geschikt framework om de applicatie mee te bouwen. Dit zal het proces gemakkelijker maken waardoor het developmentteam meer kan realiseren in de beschikbare werktijd.

## Relevantie

Om erachter te komen welk app/web framework het meest geschikt is voor ons project, gaat er onderzoek gedaan worden naar verschillende frameworks. Deze frameworks zullen worden getest op verschillende vlakken. Dit wordt gedaan om ervoor te zorgen dat het development team de applicatie kan realiseren en zodat de gebruiker een goede gebruikservaring heeft. De antwoorden die uit de onderzoeken blijken worden in een diagram vergeleken met elkaar en zo wordt het meest geschikte framework gekozen voor ons project.

## Relatie tot probleemstelling

Om de probleemstelling op te lossen gaat er een applicatie gemaakt worden die toeristen van informatie voorziet bij monumenten. De relatie tussen dit onderzoek en de probleemoplossing is dat het resultaat van dit onderzoek gebruikt zal worden om het probleem op te lossen.

## Relatie tot doelstelling

De relatie tussen dit onderzoek en de doelstelling is dat het resultaat van dit onderzoek (een van de getest frameworks) gebruikt zal worden door het development team om de applicatie te realiseren.

## Met welke onderzoeksmethode ga je de vraag beantwoorden?

Tijdens dit onderzoek wordt er gebruik gemaakt van de volgende onderzoeksmethoden. Er zal een Bieb onderzoek uitgevoerd worden om de verschillende frameworks te verzamelen, kijken wat voor platvormen deze ondersteunen, de voor en nadelen van het framework en hoe veel documentatie er bestaat voor de frameworks.
Hierna zal er een lab onderzoek uitgevoerd worden om de frameworks te testen doormiddel van een experiment waarbij een kleine testapplicatie ontwikkeld wordt.

### Toetscriteria aan de hand waarvan je het antwoord kunt toetsen?

De vlakken waarop we de verschillende frameworks gaan beoordelen zijn gebruiksvriendelijkheid en ondersteunde platvormen. Hieronder wordt per vlak uitgelegd waarom er op het vlek onderzoek wordt gedaan.
De vlakken waarop we de verschillende frameworks gaan beoordelen zijn implementatiegemak, ondersteunde platvormen, performance, functionaliteit en support & community en ondersteunde platvormen. Hieronder wordt per vlak uitgelegd waarom er op het vlek onderzoek wordt gedaan.

### Gebruiksvriendelijkheid

Om ervoor te zorgen dat het developmentteam een goed product oplevert, gaat er onderzocht worden hoe gebruiksvriendelijk de verschillende frameworks zijn. Hoe makkelijker het framework voor de developer te gebruiken zal de aanleiding zijn om de gebruiksvriendelijkheid te bepalen.

### Implementatiegemak

Om ervoor te zorgen dat het development team een goed product oplevert, gaat er onderzocht worden hoe makkelijk de verschillende frameworks te leren en te gebruiken zijn. Hoe makkelijker het framework voor de developer te gebruiken zal de aanleiding zijn om de gebruiksvriendelijkheid te bepalen.

### Ondersteunende platvormen

Om ervoor te zorgen dat de applicatie door een zo groot mogelijk publiek gebruikt kan worden, gaat er onderzoek gedaan worden naar welke platvormen ieder framework ondersteund. Hoe meer platvormen er ondersteund worden, hoe meer potentiële gebruikers de applicatie kunnen gebruiken.

### Performance

De applicatie moet goed kunnen performen. Dit wil zeggen dat de gebruiker niet wordt gehinderd door lange wachttijden, lag en vasthangende frames.

### Functionaliteit

Het framework moet voldoende nuttige functionaliteiten hebben en location-based AR ondersteunen.

### Support & community

Er moet voldoende documentatie online te vinden zijn over het framework. Ook moet de community die werkt met het framework groot genoeg zijn zodat het development team online geholpen kan worden door andere leden van de communitie.
Er moet voldoende documentatie online te vinden zijn over het framework. Ook moet de community die werkt met het framework groot genoeg zijn zodat het development team online geholpen kan worden door andere leden van de community.

## Geef aan wie dit gaan uitvoeren?

Twee mensen uit het team gaan dit onderzoek uitvoeren. Wie deze twee mensen worden nader bepaald. Zodra dit bepaald is wordt het ge-updated in het Plan van Aanpak.

# Deelvraag 3: Welke bron (API) is het meest geschikt om informatie te geven over de verschillende bezienswaardigheden? <a name="deelvraag3"></a>

## Motivatie

Om de applicatie te voorzien van informatie over de bezienswaardigheden. Is het noodzakelijk dat er onderzocht wordt welke API het beste gebruikt kan worden om deze informatie te leveren.

## Relevantie

Alle informatie die gebruikt gaat worden om informatie te tonen bij bezienswaardigheden, zal geleverd worden door een API. Omdat er meerdere API's beschikbaar zijn om dit doel te bereiken, is het noodzakelijk dat deze worden vergeleken. Hierdoor kunnen toeristen van de meest up-to-date informatie worden voorzien.

## Relatie tot probleemstelling

Het probleem omvat onder andere dat bezienswaardigheden niet altijd informatie tonen die toeristen kunnen lezen omdat het in een andere taal geschreven is. Tevens is deze informatie vaak onvolledig. Deze informatie moet dan vervolgens aangevuld/vertaald worden.

## Relatie tot doelstelling

Het doel is om de toeristen te voorzien van volledige en begrijpelijke informatie. Hiervoor is een API nodig die deze informatie zal leveren.

## Met welke onderzoeksmethode ga je de vraag beantwoorden?

Deze deelvraag zal onderzocht worden met gebruik van Bieb-, Lab- en Werkplaatsonderzoek. Allereerst zal er gezocht worden naar verschillende API's die de applicatie kunnen voorzien van informatie over de bezienswaardigheden. Vervolgens kunnen deze API's worden getest doormiddel van het ontwikkelen van een prototype om de voor- en nadelen te vinden per API. Aan de hand van prototypes zal er een API gekozen worden die gebruikt gaat worden in de applicatie.

## Toetscriteria aan de hand waarvan je het antwoord kunt toetsen?

Iedere gevonden API zal getoetst worden aan de hand van een aantal toetscriteria. Deze worden hieronder nader uitgelegd.

### Implementatie gemak

Voor elke API zal een poging gedaan worden om deze te implementeren in een bestaand prototype. Vervolgens is het afhankelijk hiervan mogelijk om te bepalen wat het implementatie gemak is.

### Hoeveelheid informatie beschikbaar

De hoeveelheid data die een API beschikbaar stelt speelt een grote rol. De API moet voor zoveel mogelijk bezienswaardigheden informatie bevatten. Bij te weinig beschikbare data, zal deze API niet meer verder getest worden.

### Verschillende talen

Het is wenselijk als de API-vertalingen van de beschikbare informatie bevat. Echter omdat er nog andere manieren zijn om de informatie te vertalen is het geen vereiste, maar het zal wel een voordeel opleveren.

### Geef aan wie dit gaan uitvoeren?

Wie dit onderzoek zal uitvoeren is nog niet bekend. Zodra dit bepaald is zal het Plan van Aanpak aangepast worden.

# Deelvraag 4: Welke Spraakservice is het beste om te gebruiken binnen onze applicatie <a name="deelvraag4"></a>

## Motivatie

Om ervoor te zorgen dat de informatie in de applicatie op een juiste manier verteld kan worden aan de gebruiker is het belangrijk om een spraakservice te kiezen die goed past bij de applicatie.
De kosten van deze spraakservice zijn ook van belang door een gelimiteerd budget.

## Relevantie

Er wordt binnen de applicatie gebruik gemaakt van een spraakservice, deze wordt gebruikt om de informatie die bij een bezienswaardigheid staat voor te lezen aan de gebruiker. Het is van belang dat de spraakservice gebruikt kan worden binnen de applicatie en dat de spraakservice binnen het budget valt.

## Relatie tot probleemstelling

Om de probleemstelling op te lossen gaat er een applicatie gemaakt worden die toeristen van informatie voorziet bij monumenten. De relatie tussen dit onderzoek en de probleemoplossing is dat het resultaat van dit onderzoek gebruikt zal worden om het probleem op te lossen.

## Relatie tot doelstelling

De relatie tussen dit onderzoek en de doelstelling is dat het resultaat van dit onderzoek (een van de spraakservices die onderzocht wordt) gebruikt zal worden door het development team om de applicatie te realiseren.

## Met welke onderzoeksmethode ga je de vraag beantwoorden

Tijdens dit onderzoek wordt er gebruik gemaakt van de volgende onderzoeksmethoden. Er zal een Bieb onderzoek uitgevoerd worden om de verschillende spraakservices te verzamelen, kijken hoe deze geïmplementeerd moeten worden, de voor en nadelen van de spraakservice, de kosten en hoe veel documentatie er bestaat voor deze spraakservices.
Hierna zal er een lab onderzoek uitgevoerd worden om de spraakservices te testen doormiddel van een experiment waarbij een kleine testapplicatie ontwikkeld wordt.

## Toetscriteria aan de hand waarvan je het antwoord kunt toetsen

De vlakken waarop de verschillende spraakservices beoordeeld worden zijn:

#### Implementatiegemak

Om ervoor te zorgen dat het development team een goed product oplevert, gaat er onderzocht worden hoe makkelijk de spraakservice te implementeren is. Hoe makkelijker de spraakservice voor de developer te implementeren is zal de aanleiding zijn om het implementatiegemak te bepalen.

#### Prijs

Omdat tijdens dit project het budget erg gelimiteerd is zal de prijs van de spraakservice een grootte impact hebben op de keuze. Daarom zal er een field research uitgevoerd worden om te kunnen bepalen welke spraakservice de beste prijs/kwaliteit verhouding heeft.

#### Support & community

Er moet voldoende documentatie online te vinden zijn over de spraakservice. Ook moet de community die werkt met de spraakservice groot genoeg zijn zodat het development team online geholpen kan worden door andere leden van de community.

## Geef aan wie dit gaat uitvoeren

Twee mensen uit het team gaan dit onderzoek uitvoeren. Wie deze twee mensen worden nader bepaald. Zodra dit bepaald is wordt het ge-update in het Plan van Aanpak.

# Randvoorwaarden

Hieronder zijn de randvoorwaarden van dit project opgesteld. Randvoorwaarden zijn de voorwaarden waaraan voldaan dient te worden om zo het project tot een goed einde te laten komen. Mocht er aan één of meerdere voorwaarden niet voldaan worden, dan zal dit negatieve gevolgen hebben voor het verloop van het project. Alle meetingen zullen plaatsvinden op de geselecteerde werkplaats (De werkplaats van de projectgroep staat niet vast en kan dus veranderen tijdens het project.)

- De projectbegeleider reageert binnen twee werkdagen op vragen door middel van mail of een meeting zodat de projectgroep niet vast komt te zitten op een probleem voor een lange periode.
- De projectbegeleider is minimaal eens per twee weken beschikbaar voor feedback door middel van een meeting om de kwaliteit van het proces te bewaken, deze meeting heeft geen vaste tijd of dag.
- De projectbegeleider is minimaal eens per drie weken beschikbaar voor een retrospective door middel van een meeting om de kwaliteit van het proces te bewaken. Deze vergaderingen zullen de eerste dinsdag na een sprint plaatsvinden.
- Er dient altijd een werkende internetverbinding beschikbaar te zijn in de gereserveerde werkplaats zodat de projectgroep (effectief) aan het project kan werken.

# Op te leveren producten en kwaliteitseisen

In dit hoofdstuk wordt beschreven welke producten we aan het eind van het project zullen opleveren

| Product                           | Kwaliteitseisen (SMART)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | Benodigde activiteiten om te komen tot het product                                                                                                                       | Proceskwaliteit                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| --------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Plan van aanpak                   | <ul><li>Moet voldoen aan de ICA-controlekaart.</li><li>Alle hoofdstukken moeten door alle groepsleden minimaal één keer gereviewed zijn.</li><li>Het Plan van Aanpak moet alle hoofdstukken bevatten uit het bestand [Toelichting op het PvA 3.0](https://onderwijsonline.han.nl/elearning/lessonfile/4ymRvp5D/eyJpdiI6IjRWNERzRjRpXC9Cd2hjc3lHTVlcL1ZLUT09IiwidmFsdWUiOiIyOUNCMkZnZGZqVzZJcGZyc2FFRUxuamFjZUNOOFh2U3hUbWxtd3dJaEI3bmlGWFZ4RXZZTklXaktLakRVaTk5IiwibWFjIjoiYjAyYmQwZDQzOTUwNDJjMTliNTUwY2UzNTg0YWQxMjQxZTlhMjY5M2IzOTc4MmM3Y2RiYjA0NmRhMjJlZjdiMSJ9).</li></ul> | <ul><li>Eventueel feedback vragen van projectbegeleider</li></ul>                                                                                                        | <ul><li>Alle groepsleden reviewen op vooraf bepaalde tijden de hoofdstukken die op dat moment zijn aangepast en verbeteren deze indien nodig.</li><li>Voorafgaand aan inleverdeadlines wordt het Plan van Aanpak nogmaals compleet nagelezen door alle groepsleden.</li></ul>                                                                                                                                                                                                                                                                                                                                     |
| Onderzoeksverslag                 | <ul><li>Moet voldoen aan de ICA-controlekaart.</li><li> Het onderzoek moet aansluiten bij het project en de techniek augmented reality.</li><li>De tekst in het verslag is vrij van spellings- en grammaticafouten</li><li> De resultaten van het onderzoek moeten gebruikt worden in het project.</li><li>Het verslag moet een bronnenlijst bevatten in APA-stijl</li><li>Elke bron moet door minstens twee andere bronnen bevestigd worden om als bron opgenomen te mogen worden</li>                                                                                         | <ul><li>Er moet gewerkt worden met de research methods van de site van HBO-I</li></ul>                                                                                   | <ul><li>Tijdens het schrijven van het onderzoeksverslag moet telkens gecontroleerd worden of het verslag nog wel relevant is voor het project. </li><li> Het onderzoek moet in de eerste sprint afgerond worden.</li></ul>                                                                                                                                                                                                                                                                                                                                                                                        |
| InterestAR (prototype) applicatie | <ul><li>De unittests dienen 80% code coverage op te leveren en te slagen </li><li>Er dient aan de afgesproken code conventies te worden voldaan</li><li>Er dient documentatie te worden opgesteld bij het maken van belangrijke designkeuzes betreft de structuur van de applicatie </li></ul>                                                                                                                                                                                                                                                                                  | <ul><li> Programmeren aan de hand van de codeconventies</li><li>Reviewen van code</li><li>Schrijven van unittests</li><li>Het documenteren van gemaakte keuzes</li></ul> | Om de kwaliteit te waarborgen zal er door door één ander teamlid een codereview worden gehouden op aangemaakte pull-requests. Ook maakt ieder teamlid een feature branch aan wanneer hij start met werken aan een nieuwe functionaliteit. Er zal documentatie worden bijgehouden wanneer er structurele designkeuzes worden gedaan. Hieronder vallen zaken zoals: <ul><li>Het opstellen van een lagenstructuur</li><li>Opstellen van databaseschema’s</li><li>Afwijkende oplossingen voor standaardstructuren</li><li>Fundamentele keuzes die effect hebben voor het team gedurende het ontwikkelproces</li></ul> |
| Eindpresentatie                   | <ul><li>De presentatie wordt gepresenteerd aan de hand van een powerpoint</li><li>Uit de presentatie wordt het volgende duidelijk: <ul><li>Alle opgeleverde producten</li><li>Het verloop van het groepsproces</li></ul></li>                                                                                                                                                                                                                                                                                                                                                   | <ul><li>Overleg over de inhoud van de presentatie</li><li>Overleg over de inhoud van de powerpointslides</li></ul>                                                       | <ul><li>Ieder groepslid zorgt ervoor dat hij zijn te presenteren deel goed heeft voorbereid</li><li>De powerpoint wordt 5 dagen van tevoren gemaakt zodat iedereen genoeg tijd heeft om hiermee te oefenen</li></ul>                                                                                                                                                                                                                                                                                                                                                                                              |

## Definition of Done

### Code

- Vóór het samenvoegen van code wordt de werking van de nieuwe code gereviewed. door minimaal één groepslid door middel van een pull-request.
- De code van een afgeronde taak (feature branch) is samengevoegd met de development branch.
- Alle geschreven code voldoet aan de opgestelde kwaliteitseisen.

### Documenten

- Het document moet voldoen aan de opgestelde kwaliteitseisen.
- Het document is samengevoegd met de development branch.
- Minimaal één teamlid hebben het document gereviewed op inhoud en grammatica.

### Tests

- De geschreven tests worden eerst gereviewed en uitgevoerd door minimaal één groepslid.
- De code van de geschreven tests is samengevoegd met de development branch.

### Ontwerpkeuzes

- De meerderheid van het team stemt in met de ontwerpkeuze.
- Het volledige team is op de hoogte van een gemaakte ontwerpkeuze.
- De gemaakte ontwerpkeuze is vastgelegd in een document.

### Projectgrenzen

In dit hoofdstuk zullen de projectgrenzen van het project worden bepaald, waardoor er voor alle betrokken partijen een goed beeld onstaat, wat er precies zal opgeleverd/uitgevoerd gedurende het project.

Voor dit project zijn de volgende projectgrenzen opgesteld:

- In de projectperiode vallen twee vakantieperiodes waarin niet zal worden gewerkt aan het project.
  - Herfstvakantie (14-10-2019 t/m 20-10-2019)
  - Kerstvakantie (23-12-2019 t/m 05-01-2020)
- Er zullen geen 3D modellen worden ontwikkeld.
- Er zal geen productieklare applicatie worden opgeleverd.
- Na afloop van de projectperiode zullen er geen werkzaamheden aan de projectproducten worden uitgevoerd.
- Het product betreft een AR applicatie, waardoor mogelijke andere gevraagde functionaliteiten niet kunnen worden opgeleverd.

# Ontwikkelmethode

## Selectie ontwikkelmethode

Het project is als volgt:

> Gedurende de eerste twee weken zal er van start worden gegaan met een prototype applicatie waarmee toeristen op verschillende wijze voorzien worden van informatie. Zoals door het tonen van een Augmented reality weergave per bezienswaardigheid en het voorlezen van de informatie.
>
> Echter kan het voorkomen dat het project in de eerste weken nog veranderd, aangezien er nog contact gaande is met verschillende externe organisaties, waarmee mogelijk nog in samenwerking een ander product uit voort zal komen.
>
> Mocht dit het geval zijn, dan zal dit voor de [usecase deadline](./10.%20planning.md) worden besloten.

Het is dus gewenst dat de projectmethode rekening houdt met de veranderingen van de use case en het onderzoek doen naar de voor ons nieuwe techniek van Augmented reality. Waarbij een iteratieve projectmethodiek het beste aansluit op ons project, gezien de mogelijke veranderingen in de use case en onze ervaring met betrekking tot Augmented reality.

Hiervoor is er onderzoek gedaan naar verschillende project/ontwikkelmethodes. Zoals onder meer Prince2, Lean, Kanban, Waterfall en XP.

In de onderstaande tabel kunnen de resultaten van het onderzoek worden bekeken. Hierbij zal vermeld worden welke onderdelen van de project/ontwikkelmethode ingezet zullen worden voor het project.

| Planning/ontwikkelmethode | Wat gaat er gebruikt worden                                                                                            | Toelichting                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| ------------------------- | ---------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Scrum                     | <ul><li>De sprintplanning </li><li>De rol Scrummaster</li><li>[De meetings](#meeting)</li><li>Het scrum bord</li></ul> | Van scrum zal de sprintplanning, meetings en rollen worden ingezet tijdens het project. Om zo een vaste iteratieve projectstructuur op te zetten. Waarbij er vaste meetings zijn waar gepland en geëvalueerd kan worden en er een scrum bord is voor transparantie tijdens het project. Tot slot zal ook de rol scrummaster worden ingezet om de planning van meetings op te stellen en het team te coachen op de verschillende aspecten van scrum |
| Waterfall                 | N.v.T                                                                                                                  | Bij Waterval wordt er uitgegaan van een vaste planning waar niet vanaf geweken mag worden. Zoals voorgaand al gezegd kan de usecase van dit project mogelijk nog wijzigen, wat betekent dat het projectplan aangepast moet worden. Daarom is voor dit project waterval geen goede keus om te gebruiken.                                                                                                                                            |
| Prince2                   | N.v.T                                                                                                                  | De projectmethode Prince2 zal niet worden ingezet tijdens het project, vanwege het feit dat de projectstructuur te algemeen is en het volledig gebaseerd is op 7 principles. Daarnaast is Prince2 een algemene managementmethode en geen ontwikkelmethode.                                                                                                                                                                                         |
| Kanban                    | N.v.T                                                                                                                  | Wij kiezen er in ons project voor om het scrumbord in te zetten i.p.v. het kanban bord, omdat het team de voorkeur geeft aan het voorafgaand plannen van taken en het de kanban bord teveel vrijheden geeft.                                                                                                                                                                                                                                       |
| Lean                      | <ul><li>Zero defects</li></ul>                                                                                         | Met het gebruik van Zero defects wordt er gestreefd naar het oplossen van problemen voordat er verder zal gewerkt worden aan nieuwe taken.                                                                                                                                                                                                                                                                                                         |
| XP (Extreme programming)  | <ul><li>Pair programming</li><li>Refactoring</li></ul>                                                                 | Van XP zullen we de pair programming inzetten om complexe zaken te tackelen en refactors waarbij we in de 3e sprintweek de codekwaliteit zullen verbeteren voor oplevering.                                                                                                                                                                                                                                                                        |

Het project zal worden opgedeeld in 3 fases:

- De pregame (4 weken)

  - Het bepalen van de usecase

  - Het uitvoeren van voorbereidend onderzoek

  - Het opstellen van het storyboard

- De sprints (4 sprints van 3 weken)

  - Het uitvoeren van onderzoek

  - Het realiseren van de applicatie

  - Het opstellen van applicatietests

  - Het opstellen en bijwerken van documentatie

- De postgame (10 dagen)

  - Het opstellen van opleverdocumentatie

  - Het uitvoeren van de laatste verbeteracties

  - De presentatie van het eindresultaat

_Meer informatie over de scrumplanning kan worden teruggevonden in het hoofdstuk [planning](./10.%20planning.md)_

#### Rollen

Binnen ons project zal er één scrumrol worden toegekend. Namelijk die van
Scrummaster.  
Wat deze rol precies zal inhouden kan worden teruggevonden in het onderdeel
projectrollen van het hoofdstuk [projectorganisatie](./9.%20Projectorganisatie.md).

#### Meetings

Binnen het project zullen er ook een aantal scrummeetings plaatsvinden.  
Namelijk de:

- Daily standup

- Sprint planning

- Retrospective meeting

- Sprint review

Wat deze meetings precies zullen inhouden, kan worden teruggevonden in het
onderdeel contactmomenten van het hoofdstuk [projectorganisatie](./9.%20Projectorganisatie.md).

# Projectorganisatie

## Contact

### Contactmomenten

Binnen het project zullen er de volgende contactmomenten plaatsvinden:

| Meetings              | aanwezigen                   | Doel                                                                                                                           |
| --------------------- | ---------------------------- | ------------------------------------------------------------------------------------------------------------------------------ |
| Daily standup         | Het projectteam              | \-Inventariseren individuele voortgang <br> -Projectvoortgang inventariseren en eventueel bijsturen <br> -Problemen aankaarten |
| Sprint planning       | Het projectteam & Begeleider | \-Het bepalen van de taken per sprint                                                                                          |
| Retrospective meeting | Het projectteam & Begeleider | \-Tussentijds evalueren op de verloop van de sprint. <br>-Het geven van onderlinge feedback.                                   |
| Sprint review         | Het projectteam & Begeleider | \-Het opleveren van de deelproducten en evalueren van de sprint                                                                |

### Contactgegevens

#### Team

Gedurende het project kan er contact worden opgenomen met het team middels de
onderstaande contactgegevens.

**Emailadres team:** _ica.ar2019\@gmail.com_

| Naam                 | Studentnummer | Emailadres                          | Telefoonnummer  |
| -------------------- | ------------- | ----------------------------------- | --------------- |
| Kevin van Schaijk    | 601152        | KFG.vanSchaijk\@student.han.nl      | \+31 681072279  |
| Jim van de Ligt      | 603359        | J.vandeLigt\@student.han.nl         | \+31 653688678  |
| Randy Grouls         | 596183        | R.grouls\@student.han.nl            | \+31 643920846  |
| Kay Verhaegh         | 601055        | K.L.J.Verhaegh\@student.han.nl      | \+31 630701475  |
| Reno Rovers          | 595524        | RMJ.Rovers\@student.han.nl          | \+31 6 12362659 |
| Tim Maas Geesteranus | 597842        | TME.MaasGeesteranus\@student.han.nl | \+31 622337484  |

_Wanneer het contact de hele groep betreft, gelieve contact op te nemen met het
emailadres van het team._

## Projectrollen

Binnen het projectteam zij er ook een aantal projectrollen gedefinieerd. Deze
kunnen worden teruggevonden in het onderstaande overzicht.

| Personen | Rollen                    |
| -------- | ------------------------- |
| Jim      | Planning                  |
| Randy    | Scrummaster, Klantcontact |
| Kay      | Lokaalreservering         |
| Reno     | Notulist                  |
| Tim      | Klantcontact              |
| Kevin    | Planning                  |

Verantwoordelijkheden rollen:

- Planning:

  - Het controleren of het project op schema ligt aan de hand van de planning

  - Het inschatten van deadlines en het mogelijk bijstellen van de planning
  - Het bijwerken van het scrumbord

- Scrummaster

  - Het bewaken van het scrumproces

  - Het voorbereiden van meetings

  - Het voorzitten van meetings

- Klantcontact

  - Het contact met begeleiders/externe partijen
  - Verantwoordelijk voor het onderhouden van al het contact dat via de groepsmail gaat

- Lokaalreservering

  - Het tijdig reserveren van werkruimtes

- Notulist

  - Het notuleren tijdens de verschillende meetings/contactmomenten

# Planning

Dit project zal worden uitgevoerd door middel van de Scrum methode. Dit betekent dat het project meerdere sprints zal bevatten.
Deze sprints zullen steeds 3 weken duren. Er is gekozen voor sprints van drie weken zodat er binnen de projectperiode vier gelijke sprints gehouden kunnen worden.
De derde week van de sprint wordt gereserveerd voor het testen van de applicatie en het schrijven van de documentatie. Hier is in vorige projecten te weinig tijd
voor ingepland, vandaar de reden dat er gekozen is voor sprints van 3 weken. De planning van de meetings kan indien nodig veranderen wanneer de usecase wijzigt door
eventueel contact met Ixpirium of Het Vrijheidsmuseum in Groesbeek.

## Evaluatie projectrollen

De projectrollen zullen elke retrospective geëvalueerd worden. Er zal bij de evaluatie ook beslist worden of de rollen binnen het project team moeten veranderen.
De verschillende rollen zullen geëvalueerd worden op de punten die staan bescheven in [projectorganisatie](9.%20Projectorganisatie.md).

## Overzicht belangrijke data

| Datum      | Tijd  | Beschrijving                          |
| ---------- | ----- | ------------------------------------- |
| 20-09-2019 | 16:00 | **Inlevermoment Plan van Aanpak**     |
| 20-09-2019 | 16:00 | **Inlevermoment Storyboard**          |
| 07-10-2019 | 17:00 | **Deadline Usecase vaststellen**      |
| 08-10-2019 | 17:00 | **Deelvraag 1 afgerond**              |
| 22-10-2019 | 17:00 | **Deelvraag 3 afgerond**              |
| 26-10-2019 | 17:00 | **Deelvraag 4 afgerond**              |
| 28-10-2019 | 17:00 | **Deelvraag 2 afgerond**              |
| 31-10-2019 | 16:00 | **Inlevermoment Onderzoeksverslag**   |
| 31-10-2019 | 16:00 | **Inlevermoment Tussentijds product** |
| 23-01-2020 | 16:00 | **Inlevermoment Eindproduct**         |

## Overzicht Sprints

| Datum van  | Datum tot  | Sprintnummer |
| ---------- | ---------- | ------------ |
| 01-09-2019 | 29-09-2019 | Pregame      |
| 30-09-2019 | 27-10-2019 | Sprint 1\*   |
| 28-10-2019 | 17-11-2019 | Sprint 2     |
| 18-11-2019 | 08-12-2019 | Sprint 3     |
| 09-12-2019 | 12-01-2020 | Sprint 4\*   |
| 13-01-2020 | 23-01-2020 | Postgame     |

\*Deze sprints worden onderbroken door een vakantieperiode. Onderstaande tabel geeft deze weer.

## Overzicht vakanties

| Datum van  | Datum tot  | Vakantie      |
| ---------- | ---------- | ------------- |
| 14-10-2019 | 20-10-2019 | Herstvakantie |
| 23-12-2019 | 05-01-2020 | Kerstvakantie |

## Overzicht meetings

| Datum      | Tijd  | Beschrijving          |
| ---------- | ----- | --------------------- |
| 17-09-2019 | 15:30 | Retrospective meeting |
| 30-09-2019 | 09:15 | Sprint 1 planning     |
| 01-10-2019 | 15:30 | Retrospective meeting |
| 28-09-2019 | 09:15 | Sprint 2 planning     |
| 29-10-2019 | 15:30 | Retrospective meeting |
| 12-11-2019 | 15:30 | Retrospective meeting |
| 18-11-2019 | 09:15 | Sprint 3 planning     |
| 26-11-2019 | 15:30 | Retrospective meeting |
| 12-01-2019 | 09:15 | Sprint 4 planning     |
| 10-12-2019 | 15:30 | Retrospective meeting |
| 07-01-2020 | 15:30 | Retrospective meeting |

## Gantt chart

In de onderstaande Gantt chart geeft een beeld van de verschillende projectfasen.<br>
![Gantt Chart](https://raw.githubusercontent.com/TimMaasGeesteranus/AangevuldeRealiteit/master/docs/plan%20van%20aanpak/Afbeeldingen/Gantt-chart.PNG)

# 10. Risico's

Dit hoofdstuk gaat over de risico’s die mogelijk de voortgang van het project kunnen beïnvloeden. In de onderstaande tabel zijn de verschillende risico’s opgenomen met daarbij de kans, de impact en tegenmaatregelen die dan genomen worden. Door deze risico’s te erkennen en tegenmaatregelen te bedenken, wordt de impact op de voortgang van het project verlaagd.

| Risico                                                                   | Kans   | Impact | Tegenmaatregel                                                                                                               |
| ------------------------------------------------------------------------ | ------ | ------ | ---------------------------------------------------------------------------------------------------------------------------- |
| De projectbegeleider is langtijdig onbereikbaar.                         | Klein  | Klein  | Het team neemt contact op met de HAN om een plaatsvervangende projectbegeleider toe te wijzen aan het project.               |
| Schoolvoorzieningen zijn langtijdig onbruikbaar (ISAS, OnderwijsOnline). | Klein  | Middel | Het team neemt contact op met de HAN om een alternatieve inlevermethode af te spreken.                                       |
| Gebruikte libraries functioneren niet langer of zijn niet beschikbaar.   | Klein  | Groot  | Alternatieve libraries gebruiken / zelf de code herschrijven.                                                                |
| Er is geen werkplek beschikbaar.                                         | Klein  | Klein  | Het team werkt vanuit thuis.                                                                                                 |
| De use case verandert.                                                   | Middel | Klein  | Het team past het Plan van Aanpak aan en realiseert een nieuw storyboard.                                                    |
| NotS Win deadlines hebben een hogere prioriteit.                         | Groot  | Middel | De NotS Win deadlines aan zien komen en de taken en planning hierop aanpassen                                                |
| Het team kan niet naar meetups                                           | Klein  | Klein  | Wanneer er een meetup gepland is maakt het team daar de nummer 1 prioriteit van en gaat hoe dan ook naar de geplande meetup. |
