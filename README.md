# RobotaNearMe
Tento projekt je závěrečným projektem na předmět programování. Projekt jsou vlastně dvě aplikace - Api (RobotaNearMe) a klient (RobotaNearMe.Client) - Api je udělaná v ASP.NET a klient je dělán pomocí Blazoru ♥♥♥♥

Je ještě library RobotaNearMe.Lib - ale ta by měla být pro běžného uživatele, který neplánuje přidat další tabulky do databáze nebo upravovat endpointy nezajímavá.

Tato aplikace umožňuje registraci a login pouze přes Google, protože je to nejpřívětivější a nejrozšířenější možnost registrace.

## Postup instalace projektu
1) Naklonovat repositář
2) Spustit terminál ve složce RobotaNearMe - API
3) Do terminálu napsat: docker compose up -d
dotnet ef migrations add -nazev
dotnet ef database update
4) Do databáze zapsat tři role:
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/9535a2a6-3e48-40fd-91bb-df2bd475738e)
6) Zaregistrovat se za admina na API - na API je možnost pouze jednoho admina - jakmile je v databázi někdo registrovaný jako admin, nepůjde vám vytvořit nový admin účet.
7) Přidat JobFieldy jaké chcete - např. Developer atd.
8) V tento moment už by vše mělo fungovat bez problému - nyní se můžete registrovat na klientovi, vytvářet firmy, job offery prostě co jen chcete vyžadujete.

###Export dat do PDF a Excelu 
Všechny věci by se měly ukládat do Downloads. Nevím jak to funguje na Macu, ale na Windows by s tím neměl být žádný problém a nikde by se žádná cesta neměla upravovat.



- neautorizovaný přístup
![admin-theme](./ReadMeFiles/admin-not-authentificated.png)

## Diagram databáze
![admin-theme](./ReadMeFiles/db-diagram.png)


## Návod
V této sekci bych se rád zaměřil na **základní obsluhu** mojí aplikace. Aplikace se vlastně dělí na dvě aplikace - API - ve které by měl mít možné změny provádět pouze někdo s Admin účtem a poté Client - kdokoli bude mít přístup k receptáři a fóru -> ve fóru bude moci postovat příspěvky a komentáře pouze jako Anynom - pro využití hlavní náplně aplikace, tedy jakéhosi vylepšeného deníčku je potřeba se zaregistrovat a potvrdit svůj mail.

### API
Tato aplikace slouží jednak pro správu admin funkcí, ale také jako API na kterou posílá requesty client, když chce něco z databáze
![admin-theme](./ReadMeFiles/admin-admin-theme.png)
#### Úprava informací o uživatelích 
- jméno, přijmení, mail, bio, nebo pokud někdo přestane mít o stránku zájem a bude chtít být odebrán z newsletteru
![admin-theme](./ReadMeFiles/admin-users.png)
![admin-theme](./ReadMeFiles/admin-update-user.png)
#### Přidání kategorie do fóra
- po vyplnění formy se přidá nová kategorie kterou může kdokoli při vytváření nového topicu zvolit
![admin-theme](./ReadMeFiles/admin-add-category.png)
#### Správa fóra
- opravdu jednoduchá záležitost, stačí vybrat topic který chcete smazat, nebo ve kterém chcete smazat odpověď a nesplést si tlačítka která jsou různě barevná
![admin-theme](./ReadMeFiles/admin-forum.png)
![admin-theme](./ReadMeFiles/admin-specific-topic.png)
#### Správa kategorií
- pokud uvážíte, že je nějaká kategorie zbytečná, stačí ji smazat - nedivte se ale potom, pokud smažete i některé topics.
![admin-theme](./ReadMeFiles/admin-manage-categories.png)
#### Newsletter
- jednoduše stačí najít uživatele, kterému chcete newsletter poslat, napsat jaký má být předmět zprávy a zpráva samotná, a mail poslat - offtopic - podpis v mailu je stejný jako jak se jmenuje Váš admin účet, proto je dobré ho před posíláním mailů zkontrolovat a popřípadě poupravit
![admin-theme](./ReadMeFiles/admin-newsletter.png)
#### Newsletter všichni
- pokud jste si mysleli, že jsou předchozí funkce jednoduché na pochopení, tak věřte, že tato je ještě jednodušší - stačí totiž vyplnit předmět a zprávu, a mail se odešle všem kteří jsou přihlášení k newsletteru
![admin-theme](./ReadMeFiles/admin-newsletter-everyone.png)
#### Export dat do PDF
- stačí kliknout na tlačítko, a vyexportují se informace z tabulky Users do pdf souboru, nic složitého na pochopení
#### Export dat do Excelu
- opět stačí kliknout na tlačítko, a pokud jsme změnili cestu kam se má soubor ukládat, vše by mělo proběhnout bez problémů

### Client
![admin-theme](./ReadMeFiles/user-logged-in-main.png)
#### Meals
- externí API pro receptář
![admin-theme](./ReadMeFiles/user-meals.png)
![admin-theme](./ReadMeFiles/user-meals-more-specific.png)
![admin-theme](./ReadMeFiles/user-meals-most-specific.png)
#### Overview
- přihlášený uživatel si vybere den, který chce zapsat - buďto přes select, nebo pomocí postraních tlačítek a následně zapíše svůj den
![admin-theme](./ReadMeFiles/client-overview.png)
![admin-theme](./ReadMeFiles/client-overview-overview.png)
#### Forum
- uživatel může přidat nový topic, pokud je přihlášený může dát topicu upvote nebo downvote, může přejít na komentáře a přidat další komentář, a pokud je opět přihlášený, může dát upvote nebo downvote i komentáři
![admin-theme](./ReadMeFiles/client-forum.png)
![admin-theme](./ReadMeFiles/client-add-topic.png)
![admin-theme](./ReadMeFiles/client-replies.png)
![admin-theme](./ReadMeFiles/client-add-comment.png)
#### UserProfile
- uživatel může upravit svůj profil - jméno, username, přijmení, mail, nebo přestat odebírat newsletter
![admin-theme](./ReadMeFiles/client-update-profile.png)

