# Deelvraag 3: Welke bron (API) is het meest geschikt om informatie te geven over de verschillende bezienswaardigheden?

## Wikipedia API MediaWiki:

[Documentatie API](https://www.mediawiki.org/wiki/API:Main_page/nl)

#### Implementatie Gemak:

De implementatie van de Wikipedia API is niet gecompliceerd. Voor het gebruik van de API is geen API-key nodig wat het implementatie gemak bevorderd. Om de juiste informatie op te halen zijn er twee HTTP-requests nodig. Met het eerste request wordt er een lijst met artikelen opgehaald die gerelateerd zijn aan de opgegeven zoekterm. Nadat dit request voltooid is wordt er een tweede HTTP-request gemaakt. In de URL wordt de naam van het gewenste artikel meegegeven. Met dit request wordt alle informatie uit het desbetreffende artikel opgehaald.

#### Hoeveelheid beschikbare informatie

De beschikbare informatie bestaat uit alle Wikipedia pagina's.

#### Beschikbare Talen

De informatie is beschikbaar in het Nederlands en het Engels.

Aangezien er geen vergelijkbare API gevonden kan worden wordt ervoor gekozen om de Wikipedia API te gebruiken

MediaWiki. (z.d.). API:Hoofdpagina - MediaWiki. Geraadpleegd op 22 oktober 2019, van https://www.mediawiki.org/wiki/API:Main_page/nl
