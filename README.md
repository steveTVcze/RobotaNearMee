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

## Diagram databáze
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/96889483-7b34-4a28-bcc1-8de688cea5a9)



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
##### Nepřihlášený uživatel
-stránka home - ("/") - využívá 3 externí API :D
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b7c9ccde-5960-4367-a67b-fc904ffa3ce1)

#### Registrace
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/cd01f45d-8e89-414b-96bd-08a877b41603)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/89c9215b-648e-4757-83be-56ab9cb6c1f4)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b649d968-f68d-4c1e-a282-983ee2e72141)

po kliknutí a potvrzení odkazu následuje možnost přihlášení

#### Přihlášení

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ec9fb9a5-6593-4ce0-9cd0-e9a10c467143)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/099e1db2-deca-40ca-be2f-f4b58b44f62c)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ec48f400-fce6-49e2-aef9-b8ac2b3c8183)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/76c03f98-63aa-4c94-9353-4ae96a6dd083)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/60da0515-b9a6-464f-b890-c478c446e4e3)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/70743490-862a-4163-9b4b-354d0f5e2341)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/1f10cbec-72ac-4191-a66d-eb38c01c81d5)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b8d1699a-1d8f-4e89-bc70-142988643fa8)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/103c41d9-e559-43cc-b1bd-13468e178604)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/3c9e54bb-5441-4081-9a4e-2b47e818d3ee)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/10a60db1-c5b6-442e-a09b-aa5719f5bbf6)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/46abbb71-1c2b-41b3-9d0f-a8fb005f02dc)
-ukládá se do složky s projektem

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c8ac7e35-670d-4c2c-aae7-e05208088c35)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ca40cb96-d450-4ac4-8707-67ac5fa74799)
-po odpovězení na nabídku práce jste přesměrováni na home stránku a po opětovném navštívení stránky s danou nabídkou práce tlačítko pro odpověď na nabídku zmizí

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/da2b48f7-6666-4046-af1f-b72b48d8eaac)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/418f9c71-8323-43ca-80ba-f4d69db379c8)

-přihlášení za firmu - jako admin

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/bcaeca30-f57f-4b7e-8c7f-d33007bc2042)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/2521c674-8a63-4b3f-971d-1c3d780c9e86)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/d4a9fa35-2d57-4dbc-aca6-8fa55750df03)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/8012a0a3-08e9-487f-ad35-e1670ddfdef7)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/5fa7e22f-38c5-4045-8abd-bf7b91d339af)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c7d549f3-cb8e-4284-a97e-84d33de9f2ab)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/edc668b9-f6c7-49ca-81bd-f6009f4d7a35)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/66211e0a-10a3-44b3-aa5f-5c4780df65f2)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/a85ed455-61a0-4f14-8690-e0b1fb08c654)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/5202a2a1-5e6f-4b57-a5c1-09d62f202ff0)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/3db91323-826a-4b2c-86a3-8e4a0809cf94)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/01655fbe-c237-4470-bbba-cd14f725387b)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/d5534e82-cdae-48a6-b3d8-d5dcbef749b8)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/428c327a-5df8-4433-a07f-52f0559859b0)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ff0ef858-cfb2-4d66-b523-bbd4184f1093)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/9b0dcdeb-0902-44c6-adad-04b64667f269)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/a3afaa6c-d4c0-4333-823d-b318bc6a53e5)


#### User
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

