# Deelvraag 4: Welke Spraakservice is het beste om te gebruiken binnen onze applicatie 

## 1. Prijs
Omdat tijdens dit project het budget erg gelimiteerd is zal de prijs van de spraakservice een grootte impact hebben op de keuze. Daarom zal er een field research uitgevoerd worden om te kunnen bepalen welke spraakservice de beste prijs/kwaliteit verhouding heeft.

| Spraakservice               | Prijs                            | Eenmalig |
| --------------------------- | -------------------------------- | -------- |
| Amazon Polly                | Gratis                           | -        |
| Voice Reader Server 15      | €4950,- per taal                 | Ja       |
| Watson                      | Gratis                           | -        |
| Google cloud text-to-speech | Gratis	                          | -        |
| ResponsiveVoice.JS          | $39 per maand	                   | Nee      |
| CloudPronouncer             | $80,- per maand/ $816,- per jaar | Nee      |


## 2. Support & community
Er moet voldoende documentatie online te vinden zijn over de spraakservice. Ook moet de community die werkt met de spraakservice groot genoeg zijn zodat het development team online geholpen kan worden door andere leden van de community.

### 2.1 Amazon Polly
Amazon Polly is een tekst-to-speech API ontwikkeld door Amazon en is een van de meest gebruikte tekst-to-speech API’s. Amazon heeft zelf een “Developer guide” gemaakt waarin uitgebreid staat wat Polly is en hoe het geïmplementeerd moet worden.
Omdat het een van de meest gebruikte tekst-to-speech API’s is zijn er veel mensen die kennis hebben over het gebruik van Polly en ook kunnen helpen in het geval dat dit nodig is via b.v. Stackoverflow.

### 2.2 Voice Reader Server 15
Voice Reader Server 15 is een API ontwikkeld door Linguatec, het is een tekst-to-speech API zonder community. Dit komt waarschijnlijk door de hoge prijs van het product, hierdoor zal er geen hulp buiten Linguatec zelf te vinden zijn. Linguatec levert met het product ook documentatie aan over het implementeren van de API, deze documentatie bevat ook codevoorbeelden. Deze documentatie wordt pas geleverd wanneer het product gekocht wordt en kan daarom niet beoordeeld worden op kwaliteit en/ of kwantiteit. 

### 2.3 Watson
Watson is een tekst-to-speech API ontwikkeld door IBM, ook is het een van de meest populaire tekst-to-speech. IBM heeft zelf een erg uitgebreide documentatie geschreven over Watson waarin uitgelegd wordt hoe het geïmplementeerd moet worden, hoe errors afgehandeld moeten worden en een aantal andere kleinere stukken informatie over het gebruik van Watson.
Watson is net zoals Amazon Polly een van de meest populaire tekst-to-speech API’s, daarom is ook over Watson veel kennis binnen de community, omdat deze community veel kennis heeft over Watson kunnen wij gemakkelijk terecht met onze vragen.
Google Cloud Tekst-To-Speech 
Google Cloud Tekst-To-Speech heeft een uitgebreide documentatie waarin voorbeelden, quickstarts, voorbeelden en referenties worden beschreven. Google heeft ook zijn eigen hulpdesk waar eventuele vragen gesteld kunnen worden over de tekst-to-speech API.
Google Cloud Tekst-To-Speech API heeft een minder actieve community waarin het enkele dagen kan duren om een antwoord te krijgen op een eventuele vraag. Het is wel een product dat al lang bestaat en er zullen al een groot aantal vragen beantwoord zijn die geraadpleegd kunnen worden.

### 2.4 ResponsiveVoice.JS 	
ResponsiveVoice.js is een simpel te implementeren API, deze API wordt geïmplementeerd doormiddel van een script link zoals Bootstrap deze gebruikt. Er staat een kleine hoeveelheid documentatie op de ResponsiveVoice website, verder is er helaas erg weinig informatie te vinden op het gebruik van ResponsiveVoice. 
ResponsiveVoice heeft een kleine community die tevens niet erg actief is, hierdoor zal het lastig zijn om binnen een realistisch tijdsbestek antwoord te krijgen op een eventuele vraag.

### 2.5 CloudPronouncer
CloudPronouncer heeft een gedetailleerde documentatie waarin benodigde informatie gevonden kan worden, ook is er een live-chat op de website waarmee er contact gezocht kan worden met de makers van het product. Via deze live-chat kunnen er vragen gesteld worden indien nodig. 
CloudPronouncer heeft verder geen community om vragen aan te stellen of oplossingen in te kunnen vinden.

### 2.6 Implementatiegemak
Om ervoor te zorgen dat het development team een goed product oplevert, gaat er onderzocht worden hoe makkelijk de spraakservice te implementeren is. Hoe makkelijker de spraakservice voor de developer te implementeren is zal de aanleiding zijn om het implementatiegemak te bepalen.
Meerdere API’s hebben een prijs die niet betaalbaar zijn met het bestaande budget en zullen ook niet getest worden op implementatiegemak. Twee gratis spraakservices vereisen een creditcard die wij niet in ons bezit hebben, daardoor kunnen deze niet getest worden op implementatiegemak.
Watson
Om een werkend audiobestand te kunnen genereren met Watson moet de gebruiker een valide API-key hebben en een valide url hebben die verbonden staat aan het account van de gebruiker, deze informatie is te vinden op het account van deze gebruiker. Om een audiobestand te genereren wordt een POST request gestuurd met de API-key, content-type, audio type, tekst die naar spraak wordt geconverteerd, de naam van het bestand wat gegenereerd wordt en de url. Deze informatie wordt ingediend in een opdrachtenprompt waarna het bestand wordt gegenereerd, deze wordt dan vervolgens opgeslagen op de pc waarna dit audiobestand afgespeeld kan worden. De stem/ taal van het audiobestand kan gemakkelijk aangepast worden doormiddel van /voice/{Voicetype} achter de url te typen binnen de code in de onderstaande implementatieresultaten. Dit gehele proces kan binnen een half uur geïmplementeerd worden en is erg gemakkelijk om uit te voeren, het programma is wel erg foutgevoelig en heeft een limiet aan tekst die het in een keer kan converteren, wanneer deze hoeveelheid te groot wordt zal het audiobestand breken. Daarom moet er bij de daadwerkelijke implementatie een limiet worden ingesteld op de grootte van het bestand dat per keer geconverteerd kan worden. 


#### 2.6.1 Implementatieresultaten 
![helloworldwav](https://github.com/TimMaasGeesteranus/AangevuldeRealiteit/blob/master/docs/onderzoek/media/helloworldWav.png) 
<br><sub> Figuur 1  Hello World.wav </sub>


![helloworldogg](https://github.com/TimMaasGeesteranus/AangevuldeRealiteit/blob/master/docs/onderzoek/media/helloworldOgg.png)  
<br><sub> Figuur 2 Hello World.ogg </sub>

![helloworldopus](https://github.com/TimMaasGeesteranus/AangevuldeRealiteit/blob/master/docs/onderzoek/media/helloworldOpus.png) 
<br><sub> Figuur 3 Hello World.opus </sub>

![helloworldresult](https://github.com/TimMaasGeesteranus/AangevuldeRealiteit/blob/master/docs/onderzoek/media/helloworldResult.png)
<br><sub> Figuur 4 Gegenereerde audiobestanden </sub>

## 3. Conclusie
Uit het onderzoek naar prijzen van verschillende spraakservices is gekomen dat Amazon Polly, Watson en Google Cloud text-to-speech bruikbare opties waren tijdens dit project. Later bleek tijdens het implementatieonderzoek dat alleen Watson te implementeren was, dit is omdat Amazon Polly en Google Cloud text-to-speech een creditcard vereisen om gebruik te maken van de services. Omdat wij geen bruikbare creditcard hebben of kunnen regelen is ervoor gekozen om geen gebruik te maken van deze services. Hierdoor is Watson als enige bruikbare tekst-to-speech service overgebleven en wij zullen deze ook daarom gebruiken voor de applicatie.

## Bronnen
* Fearn, N., & Turner, B. (2019, 19 juni). Best text to speech software of 2019. Geraadpleegd op 29 oktober 2019, van https://www.techradar.com/news/best-text-to-speech-software

* Voice Reader Home 15 - Linguatec. (z.d.). Geraadpleegd op 29 oktober 2019, van https://www.linguatec.de/en/text-to-speech/voice-reader-home-15/

* IBM. (z.d.). Watson Text to Speech. Geraadpleegd op 29 oktober 2019, van https://www.ibm.com/watson/services/text-to-speech/

* Google. (z.d.). Cloud Text-to-Speech - Spraaksynthese | Cloud Text-to-Speech API | Google Cloud. Geraadpleegd op 29 oktober 2019, van https://cloud.google.com/text-to-speech/?hl=nl

* ResponsiveVoice. (2019, 18 augustus). ResponsiveVoice Text To Speech - ResponsiveVoice.JS Text to Speech. Geraadpleegd op 29 oktober 2019, van https://responsivevoice.org/

* De-Vis-Software. (z.d.). Text To Speech API and APP. Geraadpleegd op 29 oktober 2019, van https://www.de-vis-software.ro/text-to-speech-api.aspx





