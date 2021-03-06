# Code conventies
## Duidelijke naamgeving en code
- methode/classes/variable namen hebben een duidelijke naamgeving die de functionaliteit/het gebruik verduidelijken.
- Alle code krijgt een engelse naamgeving.
- Afhankelijk van de taal word camelcasing & pascalcasing bepaalt.
- Alle private variabelen worden bovenaan gezet vóór alle andere variabelen.
- Alle constante variabelen worden geschreven in volledig hoofdletters.
- Eventuele interfaces woden begonnen met een I.
- Commentaar word geplaatst waar nodig, echter dient de code in de meeste gevallen al duidelijk genoeg te zijn zonder.
- Er word gestreeft om deep nesting te voorkomen om dat de functionaliteit slecht duidelijk word.
- Gebruik autoformating van de IDE voor het uitlijnen van code.

### feature branches
- De feature branches dienen de {feature/userstory-nummer/featurenaam} naamgeving te hebben.

## Efficiëntie
- Bij het schrijven van code word het DRY (Don't repeat yourself) principle toegepast.
- Er zal worden gestreeft om programmeer taal specifieke best practices toe te passen.
- Exception handling dient in het geval van meerdere soorten exceptions, specifiek per error plaats te vinden. 


## Functionaliteit opdelen
- Het Separation of Concern principle zal worden aangehouden, waarbij de functionaliteit word opgedeeld tussen verschillende methodes/klassen. 
- Er zal information hiding worden toegepast als een methode als een bepaalde functionaliteit enkel onderdeel is van de hoofdfunctionaliteit die zichtbaar is voor andere klassen.
- In het project zal worden gestreeft naar lage mate van koppeling en hoge functionaliteitsspecificatie(cohesion).
- Het Single responsibility principle zal worden aangehouden.

